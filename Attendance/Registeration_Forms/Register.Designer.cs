namespace Attendance.Registeration_Forms
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            panelRegister = new Panel();
            label1 = new Label();
            TBRegEmail = new TextBox();
            lblMessage = new Label();
            btnRegister = new Button();
            panelPasswordUnderline = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            panelUsernameUnderline = new Panel();
            txtUsername = new TextBox();
            lblUsername = new Label();
            panelRoles = new Panel();
            rbTeacher = new RadioButton();
            rbStudent = new RadioButton();
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            picLogo = new PictureBox();
            label2 = new Label();
            panelMain.SuspendLayout();
            panelRegister.SuspendLayout();
            panelRoles.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelRegister);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(420, 450);
            panelMain.TabIndex = 0;
            panelMain.Paint += panelMain_Paint;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(label1);
            panelRegister.Controls.Add(TBRegEmail);
            panelRegister.Controls.Add(lblMessage);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(panelPasswordUnderline);
            panelRegister.Controls.Add(txtPassword);
            panelRegister.Controls.Add(lblPassword);
            panelRegister.Controls.Add(panelUsernameUnderline);
            panelRegister.Controls.Add(txtUsername);
            panelRegister.Controls.Add(lblUsername);
            panelRegister.Controls.Add(panelRoles);
            panelRegister.Location = new Point(52, 165);
            panelRegister.Margin = new Padding(3, 2, 3, 2);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(315, 270);
            panelRegister.TabIndex = 1;
            panelRegister.Paint += panelRegister_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(3, 42);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // TBRegEmail
            // 
            TBRegEmail.BackColor = Color.White;
            TBRegEmail.BorderStyle = BorderStyle.FixedSingle;
            TBRegEmail.Font = new Font("Segoe UI", 11F);
            TBRegEmail.ForeColor = Color.DimGray;
            TBRegEmail.Location = new Point(3, 68);
            TBRegEmail.Margin = new Padding(3, 2, 3, 2);
            TBRegEmail.Name = "TBRegEmail";
            TBRegEmail.Size = new Size(315, 27);
            TBRegEmail.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Bottom;
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.Crimson;
            lblMessage.Location = new Point(0, 240);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(315, 30);
            lblMessage.TabIndex = 8;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(41, 128, 185);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(0, 195);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(315, 34);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += register_New_User;
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.BackColor = Color.Gainsboro;
            panelPasswordUnderline.Location = new Point(0, 86);
            panelPasswordUnderline.Margin = new Padding(3, 2, 3, 2);
            panelPasswordUnderline.Name = "panelPasswordUnderline";
            panelPasswordUnderline.Size = new Size(315, 2);
            panelPasswordUnderline.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(0, 122);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(3, 122);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // panelUsernameUnderline
            // 
            panelUsernameUnderline.BackColor = Color.Gainsboro;
            panelUsernameUnderline.Location = new Point(0, 38);
            panelUsernameUnderline.Margin = new Padding(3, 2, 3, 2);
            panelUsernameUnderline.Name = "panelUsernameUnderline";
            panelUsernameUnderline.Size = new Size(315, 2);
            panelUsernameUnderline.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(0, 15);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 27);
            txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.Gray;
            lblUsername.Location = new Point(0, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // panelRoles
            // 
            panelRoles.Controls.Add(rbTeacher);
            panelRoles.Controls.Add(rbStudent);
            panelRoles.Location = new Point(3, 146);
            panelRoles.Margin = new Padding(3, 2, 3, 2);
            panelRoles.Name = "panelRoles";
            panelRoles.Size = new Size(315, 45);
            panelRoles.TabIndex = 6;
            // 
            // rbTeacher
            // 
            rbTeacher.AutoSize = true;
            rbTeacher.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rbTeacher.Location = new Point(18, 11);
            rbTeacher.Margin = new Padding(3, 2, 3, 2);
            rbTeacher.Name = "rbTeacher";
            rbTeacher.Size = new Size(79, 23);
            rbTeacher.TabIndex = 5;
            rbTeacher.TabStop = true;
            rbTeacher.Text = "Teacher";
            rbTeacher.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            rbStudent.AutoSize = true;
            rbStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rbStudent.Location = new Point(140, 11);
            rbStudent.Margin = new Padding(3, 2, 3, 2);
            rbStudent.Name = "rbStudent";
            rbStudent.Size = new Size(78, 23);
            rbStudent.TabIndex = 6;
            rbStudent.TabStop = true;
            rbStudent.Text = "Student";
            rbStudent.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(420, 135);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.WhiteSmoke;
            lblSubtitle.Location = new Point(131, 105);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(133, 19);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Create your account";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(74, 71);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(232, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Attendance System";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Location = new Point(175, 15);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(70, 52);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(3, 105);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 9;
            label2.Text = "Pasword";
            // 
            // Register
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance System - Register";
            panelMain.ResumeLayout(false);
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            panelRoles.ResumeLayout(false);
            panelRoles.PerformLayout();
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
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panelUsernameUnderline;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panelRoles;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.RadioButton rbStudent;
        private TextBox TBRegEmail;
        private Label label1;
        private Label label2;
    }
}
