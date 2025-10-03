using Attendance.DataAcess;
using Attendance.Model;
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
    public partial class Register : Form
    {
        private Form Form1;

        public Register()
        {
            InitializeComponent();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_New_User(object sender, EventArgs e)
        {
            string username = TBRegUN.Text.Trim();
            string password = TBRegPas.Text;
            UserRole role;

            if (RBTeacher.Checked)
                role = UserRole.Teacher;
            else if (RBStudent.Checked)
                role = UserRole.Student;
            else
            {
                MessageBox.Show("Please select a role (Teacher or Student).");
                return;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            // Hash password
            using var hmac = new HMACSHA512();
            byte[] passwordSalt = hmac.Key;
            byte[] passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            var user = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FullName = username,
                Email = "",
                Role = role,
                IsActive = true,
                CreatedAt = DateTime.Now
            };

            using (var db = new ApplicationDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }

            MessageBox.Show("User registered successfully.");

            this.Close();            // close Register form
            Form1.Show();       // show the previous form again (e.g. Login)
        }

    }
}
