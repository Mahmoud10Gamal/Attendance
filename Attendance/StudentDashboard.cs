using Attendance.DataAcess;
using Attendance.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;

namespace Attendance
{
    public partial class StudentDashboard : Form
    {
        private int _userId;
        private string _email;

        public StudentDashboard(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email;
            lblWelcome.Text = $"Welcome, Student {_email}";
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        // ✅ تحميل الكلاسات الخاصة بالطالب الحالي
        private void LoadClasses()
        {
            using var db = new ApplicationDbContext();

            var student = db.Students.FirstOrDefault(s => s.UserId == _userId);
            if (student == null)
            {
                MessageBox.Show("Student not found!");
                return;
            }

            var classes = db.Enrollments
                .Include(e => e.Class)
                .Where(e => e.StudentId == student.StudentId)
                .Select(e => new
                {
                    e.Class.ClassId,
                    e.Class.Name
                })
                .Distinct()
                .ToList();

            cmbClasses.DisplayMember = "Name";
            cmbClasses.ValueMember = "ClassId";
            cmbClasses.DataSource = classes;
            cmbClasses.SelectedIndex = -1;
        }

        // ✅ عند الضغط على View Attendance
        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            if (cmbClasses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class first.");
                return;
            }

            int classId = (int)cmbClasses.SelectedValue;
            string className = cmbClasses.Text;
            DateTime start = dtStart.Value.Date;
            DateTime end = dtEnd.Value.Date;

            LoadAttendance(classId, start, end);

            lblFilterInfo.Text = $"Showing attendance for {className} ({start:dd-MMM-yyyy} → {end:dd-MMM-yyyy})";
        }

        // ✅ تحميل بيانات الحضور من قاعدة البيانات
        private void LoadAttendance(int classId, DateTime start, DateTime end)
        {
            using var db = new ApplicationDbContext();

            var student = db.Students.FirstOrDefault(s => s.UserId == _userId);
            if (student == null) return;

            var records = db.AttendanceRecords
                .Where(a => a.StudentId == student.StudentId &&
                            a.ClassId == classId &&
                            a.AttendanceDate >= start &&
                            a.AttendanceDate <= end)
                .OrderByDescending(a => a.AttendanceDate)
                .Select(a => new
                {
                    Date = a.AttendanceDate.ToShortDateString(),
                    Status = a.Status.ToString(),
                    Remarks = a.Remarks
                })
                .ToList();

            dgvAttendance.DataSource = records;

            if (records.Count == 0)
            {
                lblAttendanceRate.Text = "No attendance records found.";
                return;
            }

            int total = records.Count;
            int present = records.Count(r => r.Status == AttendanceStatus.Present.ToString());
            double rate = (double)present / total * 100;
            lblAttendanceRate.Text = $"Attendance Rate: {rate:F2}% ({present}/{total})";
        }

        // ✅ تصدير بيانات الحضور إلى PDF
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "Attendance_Report.pdf"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToPdf(sfd.FileName);
                    MessageBox.Show("✅ PDF exported successfully!");
                }
            }
        }

        private void ExportToPdf(string filePath)
        {
            Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // 🔹 العنوان
            Paragraph title = new Paragraph("Student Attendance Report", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph("\n"));

            // 🔹 معلومات إضافية
            doc.Add(new Paragraph(lblFilterInfo.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11, BaseColor.DARK_GRAY)));
            doc.Add(new Paragraph($"\nGenerated for: {_email}", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
            doc.Add(new Paragraph($"\nDate: {DateTime.Now:dd-MMM-yyyy}\n\n"));

            // 🔹 الجدول
            PdfPTable table = new PdfPTable(dgvAttendance.Columns.Count);
            table.WidthPercentage = 100;

            foreach (DataGridViewColumn column in dgvAttendance.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                {
                    BackgroundColor = new BaseColor(230, 230, 250)
                };
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value?.ToString() ?? "");
                }
            }

            doc.Add(table);
            doc.Add(new Paragraph($"\n{lblAttendanceRate.Text}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.BLUE)));
            doc.Close();
        }

        // ✅ زر تسجيل الخروج
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // مش محتاج حالياً، بس ممكن تستخدمه لتحديث مباشر لاحقاً
        }
    }
}
