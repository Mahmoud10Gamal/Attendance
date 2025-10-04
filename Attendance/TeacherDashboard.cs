using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Attendance.DataAcess;

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

            // Default filter: current month
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void btnShowAttendance_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (!int.TryParse(txtClassId.Text.Trim(), out int classId))
            {
                MessageBox.Show("Please enter a valid Class ID.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void txtClassId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
