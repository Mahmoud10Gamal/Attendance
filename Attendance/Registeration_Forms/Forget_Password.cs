using Attendance.DataAcess;
using Attendance.Model;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Attendance.Registeration_Forms
{
    public partial class Forget_Password : Form
    {
        public Forget_Password()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void rest_password(object sender, EventArgs e)
        {
            string username = TBRestUN.Text.Trim();
            string newPassword = TBRestPas.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter both username and new password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);

                if (user == null)
                {
                    MessageBox.Show("No user found with that username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hash the new password securely
                using var hmac = new HMACSHA512();
                user.PasswordSalt = hmac.Key;
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(newPassword));

                context.Users.Update(user);
                context.SaveChanges();

                MessageBox.Show("Password has been reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
