using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Attendance.DataAcess;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextFont = iTextSharp.text.Font;


namespace Attendance
{
    public partial class TeacherDashboard : Form
    {
        private int _userId;
        private string _email;

        public TeacherDashboard(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email;
            lblWelcome.Text = $"Welcome, Teacher {_email}";

            LoadDropdowns();

            // Default filter: current month
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;
        }

        private void LoadDropdowns()
        {
            using var context = new ApplicationDbContext();

            // Load students
            var students = context.Students
                .Select(s => new { s.StudentId, s.User.Username })
                .ToList();
            cmbStudents.DataSource = students;
            cmbStudents.DisplayMember = "Username";
            cmbStudents.ValueMember = "StudentId";
            cmbStudents.SelectedIndex = -1;

            // Load classes
            var classes = context.Classes
                .Select(c => new { c.ClassId, c.Name })
                .ToList();
            cmbClasses.DataSource = classes;
            cmbClasses.DisplayMember = "Name";
            cmbClasses.ValueMember = "ClassId";
            cmbClasses.SelectedIndex = -1;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void btnShowAttendance_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = (int)cmbStudents.SelectedValue;
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;

            if (start > end)
            {
                MessageBox.Show("Start Date cannot be after End Date.", "Invalid Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var context = new ApplicationDbContext();

            var attendance = context.AttendanceRecords
                .Where(a => a.StudentId == studentId && a.AttendanceDate >= start && a.AttendanceDate <= end)
                .Select(a => new
                {
                    a.AttendanceId,
                    a.AttendanceDate,
                    a.Status,
                    ClassName = a.Class.Name
                })
                .OrderBy(a => a.AttendanceDate)
                .ToList();

            dgvAttendance.DataSource = attendance;

            if (attendance.Count == 0)
                MessageBox.Show("No attendance records found for this student in the selected range.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFilterByClass_Click(object sender, EventArgs e)
        {
            if (cmbClasses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int classId = (int)cmbClasses.SelectedValue;

            using var context = new ApplicationDbContext();

            var attendance = context.AttendanceRecords
                .Where(a => a.ClassId == classId)
                .Select(a => new
                {
                    a.AttendanceId,
                    a.AttendanceDate,
                    a.Status,
                    StudentName = a.Student.User.Username
                })
                .OrderBy(a => a.AttendanceDate)
                .ToList();

            dgvAttendance.DataSource = attendance;

            if (attendance.Count == 0)
                MessageBox.Show("No attendance records found for this class.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Save Attendance Report",
                FileName = $"AttendanceReport_{DateTime.Now:yyyyMMddHHmmss}.pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Title
                    Paragraph title = new Paragraph("Attendance Report", new iTextFont(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextFont.BOLD));
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    pdfDoc.Add(new Paragraph($"Generated on: {DateTime.Now:dd MMM yyyy HH:mm}", new iTextFont(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextFont.BOLD)));
                    pdfDoc.Add(new Paragraph("\n"));

                    // Table
                    PdfPTable table = new PdfPTable(dgvAttendance.Columns.Count);
                    table.WidthPercentage = 100;

                    // Add headers
                    foreach (DataGridViewColumn column in dgvAttendance.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, new iTextFont(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextFont.BOLD)));
                        cell.BackgroundColor = new BaseColor(230, 230, 250);
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    // Add rows
                    foreach (DataGridViewRow row in dgvAttendance.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF report generated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting PDF: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            // Hide the current dashboard
            this.Hide();

            // Create the attendance form and show it
            Teacher_attentance attendanceForm = new Teacher_attentance(_userId, _email);
            attendanceForm.FormClosed += (s, args) => this.Show(); // Re-show dashboard when attendance form closes
            attendanceForm.Show();
            this.Hide();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            TeacherDashboard dashboard = new TeacherDashboard(_userId, _email);
            dashboard.Show();
            this.Hide();
        }
    }
}
