using System;
using System.Windows.Forms;

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
            lblWelcome.Text = $"Welcome, Teacher {email}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
