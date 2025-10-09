using Attendance.DataAcess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Attendance
{
    public partial class TeacherSettings : Form
    {
        private readonly int _teacherId;
        private readonly string _email;

        public TeacherSettings(int teacherId, string email)
        {
            InitializeComponent();
            _teacherId = teacherId;
            _email = email;
        }

        private void TeacherSettings_Load(object sender, EventArgs e)
        {
            lblMessage.Text = $"Welcome, {_email}";
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;

            LoadTeacherClasses();
        }

        private void LoadTeacherClasses()
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var teacherClasses = db.Classes
                        .Where(c => c.TeacherId == _teacherId)
                        .Select(c => new { c.ClassId, c.Name })
                        .ToList();

                    cmbClasses.DataSource = teacherClasses;
                    cmbClasses.DisplayMember = "Name";
                    cmbClasses.ValueMember = "ClassId";
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = Color.Crimson;
                lblMessage.Text = $"❌ Error loading classes: {ex.Message}";
            }
        }

        private void btnLoadAttendance_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                lblMessage.ForeColor = Color.Crimson;
                lblMessage.Text = "⚠️ End Date cannot be earlier than Start Date!";
                return;
            }

            if (cmbClasses.SelectedValue == null)
            {
                lblMessage.ForeColor = Color.Crimson;
                lblMessage.Text = "⚠️ Please select a class!";
                return;
            }

            LoadAttendance();
        }

        private void LoadAttendance()
        {
            try
            {
                int selectedClassId = (int)cmbClasses.SelectedValue;

                using (var db = new ApplicationDbContext())
                {
                    var attendanceRecords = db.AttendanceRecords
                        .Include(a=>a.Student)
                        .ThenInclude(s=>s.User)
                        .Where(a => a.ClassId == selectedClassId &&
                                    a.AttendanceDate >= dtpStartDate.Value &&
                                    a.AttendanceDate <= dtpEndDate.Value)
                        .Select(a => new
                        {
                            Student = a.Student.User.FullName,
                            Date = a.AttendanceDate.ToString("yyyy-MM-dd"),
                            Status = a.Status.ToString(),
                            Remarks = a.Remarks
                        })
                        .OrderBy(a => a.Date)
                        .ToList();

                    dgvAttendance.DataSource = attendanceRecords;
                    lblCount.Text = $"Total Records: {attendanceRecords.Count}";
                    lblMessage.ForeColor = Color.FromArgb(39, 174, 96);
                    lblMessage.Text = attendanceRecords.Count > 0
                        ? "Attendance loaded successfully."
                        : "No attendance records found for this range.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = Color.Crimson;
                lblMessage.Text = $"Error: {ex.Message}";
            }
        }
    }
}
