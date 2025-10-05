using Attendance.DataAcess;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Attendance
{
    public partial class StudentSettings : Form
    {
        private readonly int _studentId;
        private readonly string _email;

        public StudentSettings(int studentId, string email)
        {
            InitializeComponent();
            _studentId = studentId;
            _email = email;
        }

        private void StudentSettings_Load(object sender, EventArgs e)
        {

            lblMessage.Text = $"Welcome, {_email}";
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;
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

            LoadAttendance();
        }

        private void LoadAttendance()
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var attendanceRecords = db.AttendanceRecords
                        .Where(a => a.StudentId == _studentId &&
                                    a.AttendanceDate >= dtpStartDate.Value &&
                                    a.AttendanceDate <= dtpEndDate.Value)
                        .Select(a => new
                        {
                            Date = a.AttendanceDate.ToString("yyyy-MM-dd"),
                            Class = a.Class.Name,
                            Status = a.Status.ToString(),
                            Remarks = a.Remarks
                        })
                        .OrderBy(a => a.Date)
                        .ToList();

                    dgvAttendance.DataSource = attendanceRecords;

                    lblCount.Text = $"Total Records: {attendanceRecords.Count}";
                    lblMessage.ForeColor = Color.FromArgb(39, 174, 96);
                    lblMessage.Text = attendanceRecords.Count > 0
                        ? " Attendance loaded successfully."
                        : " No records found in the selected range.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = Color.Crimson;
                lblMessage.Text = $" Error: {ex.Message}";
            }
        }
    }
}
