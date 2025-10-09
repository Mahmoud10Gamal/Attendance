using Attendance.DataAcess;
using Attendance.Model;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Attendance.Registeration_Forms
{
    public partial class Register : Form
    {
        private readonly Color errorColor = Color.Crimson;
        private readonly Color successColor = Color.FromArgb(39, 174, 96);

        public Register()
        {
            InitializeComponent();
        }

        private void register_New_User(object sender, EventArgs e)
        {
             lblMessage.Text = "";

            string username = txtUsername.Text.Trim();
            string email = TBRegEmail.Text.Trim();
            string password = txtPassword.Text;
            UserRole role;

            if (rbTeacher.Checked)
                role = UserRole.Teacher;
            else if (rbStudent.Checked)
                role = UserRole.Student;
            else
            {
                ShowMessage("Please select a role.", errorColor);
                return;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ShowMessage("Username and password are required.", errorColor);
                return;
            }


            using var hmac = new HMACSHA512();
            byte[] passwordSalt = hmac.Key;
            byte[] passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            var user = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FullName = username,
                Email = email,

                Role = role,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            if (role== UserRole.Teacher)
            {
                user.Teacher = new Teacher
                {
                    EmployeeNumber = username
     
                };
            }
            else if (role == UserRole.Student)
            {
                user.Student = new Student
                {
                    StudentNumber = username
                };
            }
            using (var db = new ApplicationDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();

                ShowMessage("User registered successfully.", successColor);

                System.Threading.Thread.Sleep(500);


                Form dashboard = null;

                if (role == UserRole.Teacher)
                    dashboard = new TeacherDashboard(user.UserId, user.Email);
                else if (role == UserRole.Student)
                    dashboard = new StudentDashboard(user.UserId, user.Email);

                this.Hide();
                dashboard.ShowDialog();
                this.Close();

            }
        }

        private void ShowMessage(string message, Color color)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = color;
        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
