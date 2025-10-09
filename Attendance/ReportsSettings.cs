using Attendance.DataAcess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Attendance
{
    public partial class ReportsSettings : Form
    {
        private readonly int _userId;
        private readonly string _role;

        public ReportsSettings(int userId, string role, string v)
        {
            InitializeComponent();
            _userId = userId;
            _role = role;
        }

        private void ReportsSettings_Load(object sender, EventArgs e)
        {
            LoadDropdownData();
        }

        private void LoadDropdownData()
        {
            using (var db = new ApplicationDbContext())
            {
                // Load Classes
                var classes = db.Classes
                                .Select(c => new { c.ClassId, c.Name })
                                .ToList();

                cmbClasses.DataSource = classes;
                cmbClasses.DisplayMember = "Name";
                cmbClasses.ValueMember = "ClassId";
                cmbClasses.SelectedIndex = -1;

                // Load Teachers
                var teachers = db.Teachers
                                 .Include(t => t.User)
                                 .Select(t => new { t.TeacherId, Name = t.User.FullName })
                                 .ToList();

                cmbTeachers.DataSource = teachers;
                cmbTeachers.DisplayMember = "Name";
                cmbTeachers.ValueMember = "TeacherId";
                cmbTeachers.SelectedIndex = -1;

                // Load Students
                var students = db.Students
                                 .Include(s => s.User)
                                 .Select(s => new { s.StudentId, Name = s.User.FullName })
                                 .ToList();

                cmbStudents.DataSource = students;
                cmbStudents.DisplayMember = "Name";
                cmbStudents.ValueMember = "StudentId";
                cmbStudents.SelectedIndex = -1;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            using (var db = new ApplicationDbContext())
            {
                var attendanceQuery = db.AttendanceRecords
                    .Include(a => a.Student).ThenInclude(s => s.User)
                    .Include(a => a.Class).ThenInclude(c => c.Teacher).ThenInclude(t => t.User)
                    .Where(a => a.AttendanceDate >= dtpStartDate.Value &&
                                a.AttendanceDate <= dtpEndDate.Value);

                if (_role == "Student")
                {
                    var student = db.Students.FirstOrDefault(s => s.UserId == _userId);
                    if (student != null)
                        attendanceQuery = attendanceQuery.Where(a => a.StudentId == student.StudentId);
                }
                else if (_role == "Teacher")
                {
                    var teacher = db.Teachers.FirstOrDefault(t => t.UserId == _userId);
                    if (teacher != null)
                        attendanceQuery = attendanceQuery.Where(a => a.Class.TeacherId == teacher.TeacherId);
                }
                else
                {
                    lblMessage.ForeColor = Color.DodgerBlue;
                    lblMessage.Text = "Admin Mode - Viewing all records.";
                }


                if (cmbClasses.SelectedValue != null)
                {
                    int selectedClassId = Convert.ToInt32(cmbClasses.SelectedValue);
                    attendanceQuery = attendanceQuery.Where(a => a.ClassId == selectedClassId);
                }

                if (cmbStudents.SelectedValue != null)
                {
                    int selectedStudentId = Convert.ToInt32(cmbStudents.SelectedValue);
                    attendanceQuery = attendanceQuery.Where(a => a.StudentId == selectedStudentId);
                }

                if (cmbTeachers.SelectedValue != null)
                {
                    int selectedTeacherId = Convert.ToInt32(cmbTeachers.SelectedValue);
                    attendanceQuery = attendanceQuery.Where(a => a.Class.TeacherId == selectedTeacherId);
                }

                var attendanceRecords = attendanceQuery
                    .Select(a => new
                    {
                        a.AttendanceDate,
                        Student = a.Student.User.FullName,
                        Class = a.Class.Name,
                        Teacher = a.Class.Teacher.User.FullName,
                        a.Status,
                        a.Remarks
                    })
                    .OrderBy(a => a.AttendanceDate)
                    .ToList()
                    .Select(a => new
                    {
                        Date = a.AttendanceDate.ToString("yyyy-MM-dd"),
                        a.Student,
                        a.Class,
                        a.Teacher,
                        Status = a.Status.ToString(),
                        a.Remarks
                    })
                    .ToList();

                dgvReport.DataSource = attendanceRecords;

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = $"{attendanceRecords.Count} records loaded successfully.";
            }
        }


        // ====================== EXPORT TO PDF ======================
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource == null)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Export to PDF"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = new FileStream(saveDialog.FileName, FileMode.Create))
                    {
                        var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 30, 30);
                        iTextSharp.text.pdf.PdfWriter.GetInstance(doc, stream);
                        doc.Open();

                        // Title
                        var titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                        doc.Add(new iTextSharp.text.Paragraph("Attendance Report", titleFont)
                        {
                            Alignment = iTextSharp.text.Element.ALIGN_CENTER,
                            SpacingAfter = 20
                        });

                        // Table setup
                        var table = new iTextSharp.text.pdf.PdfPTable(dgvReport.Columns.Count)
                        {
                            WidthPercentage = 100
                        };


                        foreach (DataGridViewColumn column in dgvReport.Columns)
                        {
                            var cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText))
                            {
                                BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 230)
                            };
                            table.AddCell(cell);
                        }


                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                    }

                    MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // ====================== EXPORT TO EXCEL ======================
        private void btnExportExcel_Click(object sender, EventArgs e)
        {


            if (dgvReport.DataSource == null)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Export to Excel"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Workbooks.Add();
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelApp.ActiveSheet;


                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgvReport.Columns[i].HeaderText;
                    }

                    // Rows
                    for (int i = 0; i < dgvReport.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvReport.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvReport.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    worksheet.SaveAs(saveDialog.FileName);
                    excelApp.Quit();

                    MessageBox.Show("Excel exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
