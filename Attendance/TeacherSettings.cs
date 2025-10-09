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

        public TeacherSettings()
        {
            InitializeComponent();
        }

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
                    if (_teacherId == 0)
                    {

                        var allClasses = db.Classes
                            .Select(c => new { c.ClassId, c.Name })
                            .ToList();

                        cmbClasses.DataSource = allClasses;
                        cmbClasses.DisplayMember = "Name";
                        cmbClasses.ValueMember = "ClassId";
                        lblMessage.ForeColor = Color.DodgerBlue;
                        lblMessage.Text = "Admin Mode: viewing all classes.";
                    }
                    else
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
                    var attendanceQuery = db.AttendanceRecords
                        .Include(a => a.Student)
                        .ThenInclude(s => s.User)
                        .Where(a => a.AttendanceDate >= dtpStartDate.Value &&
                                    a.AttendanceDate <= dtpEndDate.Value);

                    if (_teacherId != 0)
                        attendanceQuery = attendanceQuery.Where(a => a.Class.TeacherId == _teacherId);
                    else
                        lblMessage.Text = "Admin Mode - Showing all attendance records.";

                    attendanceQuery = attendanceQuery.Where(a => a.ClassId == selectedClassId);

                    var attendanceRecords = attendanceQuery
                       .Select(a => new
                       {
                           a.AttendanceDate,
                           Student = a.Student.User.FullName,
                           a.Status,
                           a.Remarks
                       })
                       .OrderBy(a => a.AttendanceDate)
                       .ToList()
                       .Select(a => new
                       {
                           Date = a.AttendanceDate.ToString("yyyy-MM-dd"),
                           a.Student,
                           Status = a.Status.ToString(),
                           a.Remarks
                       })
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
