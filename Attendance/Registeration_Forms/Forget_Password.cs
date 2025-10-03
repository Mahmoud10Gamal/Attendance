using Attendance.DataAcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance.Registeration_Forms
{
    public partial class Forget_Password : Form
    {
        private Form Form1;

        public Forget_Password()
        {
            InitializeComponent();
        }

        private void rest_password(object sender, EventArgs e)
        {
            string username = TBRestUN.Text.Trim();
            string newPassword = TBRestPas.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Username and new password are required.");
                return;
            }

            using (var db = new ApplicationDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                // Hash the new password
                using var hmac = new HMACSHA512();
                user.PasswordSalt = hmac.Key;
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(newPassword));

                db.Users.Update(user);
                db.SaveChanges();
            }

            MessageBox.Show("Password reset successfully.");
            this.Close();            // close Register form
            Form1.Show();
        }
    }
}
