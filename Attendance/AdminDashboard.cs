using System;
using System.Windows.Forms;

namespace Attendance
{
    public partial class AdminDashboard : Form
    {
        private int _userId;
        private string _email;


        public AdminDashboard(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email;
            lblWelcome.Text = $"Welcome, Admin {email}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
