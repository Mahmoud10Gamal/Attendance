namespace Attendance.Registeration_Forms
{
    partial class Forget_Password
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
            lblTitle = new Label();
            lblUser = new Label();
            TBRestUN = new TextBox();
            lblPass = new Label();
            TBRestPas = new TextBox();
            BTNRest = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reset Your Password";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUser.Location = new Point(40, 100);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(111, 28);
            lblUser.TabIndex = 1;
            lblUser.Text = "Username:";
            // 
            // TBRestUN
            // 
            TBRestUN.Font = new Font("Segoe UI", 12F);
            TBRestUN.Location = new Point(201, 97);
            TBRestUN.Name = "TBRestUN";
            TBRestUN.Size = new Size(237, 34);
            TBRestUN.TabIndex = 2;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPass.Location = new Point(40, 160);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(155, 28);
            lblPass.TabIndex = 3;
            lblPass.Text = "New Password:";
            // 
            // TBRestPas
            // 
            TBRestPas.Font = new Font("Segoe UI", 12F);
            TBRestPas.Location = new Point(201, 154);
            TBRestPas.Name = "TBRestPas";
            TBRestPas.Size = new Size(237, 34);
            TBRestPas.TabIndex = 4;
            TBRestPas.UseSystemPasswordChar = true;
            // 
            // BTNRest
            // 
            BTNRest.BackColor = Color.FromArgb(41, 128, 185);
            BTNRest.FlatStyle = FlatStyle.Flat;
            BTNRest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BTNRest.ForeColor = Color.White;
            BTNRest.Location = new Point(130, 250);
            BTNRest.Name = "BTNRest";
            BTNRest.Size = new Size(180, 40);
            BTNRest.TabIndex = 5;
            BTNRest.Text = "Reset Password";
            BTNRest.UseVisualStyleBackColor = false;
            BTNRest.Click += rest_password;
            // 
            // Forget_Password
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(450, 400);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(TBRestUN);
            Controls.Add(lblPass);
            Controls.Add(TBRestPas);
            Controls.Add(BTNRest);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Forget_Password";
            Text = "Reset Password";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox TBRestUN;
        private Label label1;
        private TextBox TBRestPas;
        private Label label2;
        private Button BTNRest;
        private Label lblTitle;
        private Label lblUser;
        private Label lblPass;
    }
}