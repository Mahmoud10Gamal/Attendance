using Attendance.DataAcess;
using Attendance.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Attendance
{
    public partial class Teacher_attentance : Form
    {
        private int _userId;
        private string _email;

        public Teacher_attentance(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email;
            lblWelcome.Text = $"Welcome, Teacher {_email}";
            LoadClasses();
        }

        private void LoadClasses()
        {
            using var context = new ApplicationDbContext();
            var classes = context.Classes
                .Select(c => new { c.ClassId, c.Name })
                .ToList();

            cmbClasses.DataSource = classes;
            cmbClasses.DisplayMember = "Name";
            cmbClasses.ValueMember = "ClassId";
            cmbClasses.SelectedIndex = -1;
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            if (cmbClasses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int classId = (int)cmbClasses.SelectedValue;

            using var context = new ApplicationDbContext();
            var students = context.Enrollments
                .Where(e => e.ClassId == classId)
                .Select(e => new
                {
                    e.Student.StudentId,
                    StudentName = e.Student.User.Username
                })
                .ToList();

            dgvStudents.DataSource = null;
            dgvStudents.Columns.Clear();

            dgvStudents.DataSource = students;
            dgvStudents.Columns["StudentId"].Visible = false; // hide ID column

            dgvStudents.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Present",
                Name = "PresentColumn"
            });
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            if (cmbClasses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime date = dtpAttendanceDate.Value.Date;
            int classId = (int)cmbClasses.SelectedValue;

            using var context = new ApplicationDbContext();

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.IsNewRow) continue;

                int studentId = (int)row.Cells["StudentId"].Value;
                bool isPresent = Convert.ToBoolean(row.Cells["PresentColumn"].Value ?? false);

                // Check if attendance already exists
                var existing = context.AttendanceRecords
                    .FirstOrDefault(a => a.StudentId == studentId && a.AttendanceDate == date);

                if (existing == null)
                {
                    context.AttendanceRecords.Add(new AttendanceRecord
                    {
                        StudentId = studentId,
                        ClassId = classId,
                        AttendanceDate = date,
                        Status = isPresent ? AttendanceStatus.Present : AttendanceStatus.Absent,
                        MarkedBy = _userId,
                        MarkedAt = DateTime.Now
                    });
                }
                else
                {
                    existing.Status = isPresent ? AttendanceStatus.Present : AttendanceStatus.Absent;
                    existing.MarkedBy = _userId;
                    existing.MarkedAt = DateTime.Now;
                }
            }



            context.SaveChanges();

            MessageBox.Show("Attendance saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void Teacher_attentance_Load(object sender, EventArgs e)
        {
            // optional load logic
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // Hide the current form (Teacher_attentance)
            this.Hide();

            // Create and show the TeacherDashboard form again
            TeacherDashboard dashboard = new TeacherDashboard(_userId, _email);
            dashboard.FormClosed += (s, args) => this.Show(); // Show again if needed after dashboard closes
            dashboard.Show();
        }
    }
}
