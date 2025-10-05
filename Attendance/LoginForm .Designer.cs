
namespace Attendance
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            panelLogin = new Panel();
            chkShowPassword = new CheckBox();
            lblMessage = new Label();
            btnLogin = new Button();
            panelPasswordUnderline = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            panelEmailUnderline = new Panel();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblRegister = new Label();
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            picLogo = new PictureBox();
            panelMain.SuspendLayout();
            panelLogin.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelLogin);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(480, 600);
            panelMain.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(chkShowPassword);
            panelLogin.Controls.Add(lblMessage);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(panelPasswordUnderline);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(panelEmailUnderline);
            panelLogin.Controls.Add(txtEmail);
            panelLogin.Controls.Add(lblEmail);
            panelLogin.Controls.Add(lblRegister);
            panelLogin.Location = new Point(60, 240);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(360, 340);
            panelLogin.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(0, 175); // ← Changed X to 0 (left-aligned)
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Bottom;
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.Crimson;
            lblMessage.Location = new Point(0, 300);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(360, 40);
            lblMessage.TabIndex = 8;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkRememberMe
            
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(0, 215);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.BackColor = Color.Gainsboro;
            panelPasswordUnderline.Location = new Point(0, 155);
            panelPasswordUnderline.Name = "panelPasswordUnderline";
            panelPasswordUnderline.Size = new Size(360, 2);
            panelPasswordUnderline.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(0, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 25);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(0, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // panelEmailUnderline
            // 
            panelEmailUnderline.BackColor = Color.Gainsboro;
            panelEmailUnderline.Location = new Point(0, 75);
            panelEmailUnderline.Name = "panelEmailUnderline";
            panelEmailUnderline.Size = new Size(360, 2);
            panelEmailUnderline.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(0, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 25);
            txtEmail.TabIndex = 0;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(0, 20);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblRegister.ForeColor = Color.RoyalBlue;
            lblRegister.Location = new Point(120, 270);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(119, 20);
            lblRegister.TabIndex = 5;
            lblRegister.Text = "Or Register Here";
            lblRegister.Click += lblRegister_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(480, 200);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.WhiteSmoke;
            lblSubtitle.Location = new Point(140, 155);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(188, 23);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to your account";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(85, 110);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Attendance System";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Location = new Point(200, 30);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(80, 80);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 600);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance System - Login";
            panelMain.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panelEmailUnderline;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private Label lblRegister;
    }
}