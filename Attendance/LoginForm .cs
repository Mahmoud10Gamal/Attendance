using Attendance.DataAcess;
using Attendance.Model;
using Attendance.Registeration_Forms;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Attendance
{
    public partial class login : Form
    {
        // Color constants for modern design
        private readonly Color primaryColor = Color.FromArgb(41, 128, 185);
        private readonly Color hoverColor = Color.FromArgb(52, 152, 219);
        private readonly Color focusColor = Color.FromArgb(41, 128, 185);
        private readonly Color errorColor = Color.Crimson;
        private readonly Color successColor = Color.FromArgb(39, 174, 96);

        public login()
        {
            InitializeComponent();
            InitializeLogoPlaceholder();
        }

        private void InitializeLogoPlaceholder()
        {
            picLogo.BackColor = Color.White;
            picLogo.Paint += (s, e) =>
            {
                using (Font font = new Font("Segoe UI", 24, FontStyle.Bold))
                {
                    string text = "AS";
                    SizeF textSize = e.Graphics.MeasureString(text, font);
                    PointF position = new PointF(
                        (picLogo.Width - textSize.Width) / 2,
                        (picLogo.Height - textSize.Height) / 2
                    );
                    e.Graphics.DrawString(text, font, new SolidBrush(primaryColor), position);
                }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                ShowMessage("Please enter email", errorColor);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowMessage("Please enter password", errorColor);
                txtPassword.Focus();
                return;
            }

            if (!IsValidEmail(email))
            {
                ShowMessage("Please enter a valid email address", errorColor);
                txtEmail.Focus();
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Authenticating...";
            Cursor = Cursors.WaitCursor;

            try
            {
                if (AuthenticateUser(email, password, out string role, out int userId))
                {
                    ShowMessage("Login successful!", successColor);

                    LogAuditEntry(userId, "Login", "Users", userId);

                    System.Threading.Thread.Sleep(500);
                    OpenRoleSpecificForm(role, userId, email);

                    this.Hide();
                }
                else
                {
                    ShowMessage("Invalid email or password!", errorColor);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Error: " + ex.Message, errorColor);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "LOGIN";
                Cursor = Cursors.Default;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // UI Focus Effects
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            panelEmailUnderline.BackColor = focusColor;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            panelEmailUnderline.BackColor = Color.Gainsboro;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            panelPasswordUnderline.BackColor = focusColor;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            panelPasswordUnderline.BackColor = Color.Gainsboro;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = hoverColor;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = primaryColor;
        }

        // Toggle password visibility
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private bool AuthenticateUser(string email, string password, out string role, out int userId)
        {
            role = null;
            userId = 0;

            using var context = new ApplicationDbContext();

            var user = context.Users.FirstOrDefault(u => u.Email == email && u.IsActive);

            if (user != null && VerifyPassword(password, user.PasswordHash, user.PasswordSalt))
            {
                userId = user.UserId;
                role = MapRole((byte)user.Role);
                return true;
            }

            return false;
        }

        private bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using var hmac = new HMACSHA512(storedSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return CryptographicOperations.FixedTimeEquals(computedHash, storedHash);
        }

        private string MapRole(byte roleValue) =>
            roleValue switch
            {
                1 => "Admin",
                2 => "Teacher",
                3 => "Student",
                _ => "Unknown"
            };

        private void OpenRoleSpecificForm(string role, int userId, string email)
        {
            Form dashboard = null;

            switch (role)
            {
                case "Admin":
                    dashboard = new AdminDashboard(userId, email);
                    break;

                case "Teacher":
                    dashboard = new TeacherDashboard(userId, email);
                    break;

                case "Student":
                    dashboard = new StudentDashboard(userId, email);
                    break;

                default:
                    MessageBox.Show("Unknown role", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (dashboard != null)
            {
                this.Hide();

                dashboard.ShowDialog();

                this.Show();

            }
        }


        private void LogAuditEntry(int userId, string action, string entity, int entityId)
        {
            try
            {
                using var context = new ApplicationDbContext();

                var log = new AuditLog
                {
                    UserId = userId,
                    Action = action,
                    Entity = entity,
                    EntityId = entityId,
                    Details = $"User logged in from {Environment.MachineName}",
                    Timestamp = DateTime.Now
                };

                context.AuditLogs.Add(log);
                context.SaveChanges();
            }
            catch
            {
                // Don't block login if logging fails
            }
        }

        private void ShowMessage(string message, Color color)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = color;
        }

        // Helper for seeding a password
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            //registerForm.ShowDialog();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();

        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Forget_Password forgetForm = new Forget_Password();
            this.Hide();
            forgetForm.ShowDialog();
            this.Show();
        }

    }
}