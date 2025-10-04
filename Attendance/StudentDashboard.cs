using System;
using System.Windows.Forms;

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
            lblWelcome.Text = $"Welcome, Student {email}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
