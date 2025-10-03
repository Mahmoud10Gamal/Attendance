namespace Attendance
{
    partial class TeacherDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            sidebar = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnAttendance = new Button();
            lblWelcome = new Label();
            mainPanel = new Panel();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(btnReports);
            sidebar.Controls.Add(btnAttendance);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 486);
            sidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 436);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 50);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 50);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";
            // 
            // btnAttendance
            // 
            btnAttendance.Dock = DockStyle.Top;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(0, 0);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(200, 50);
            btnAttendance.TabIndex = 2;
            btnAttendance.Text = "Attendance";
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWelcome.Location = new Point(200, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(570, 40);
            lblWelcome.TabIndex = 1;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(570, 446);
            mainPanel.TabIndex = 0;
            // 
            // TeacherDashboard
            // 
            ClientSize = new Size(770, 486);
            Controls.Add(mainPanel);
            Controls.Add(lblWelcome);
            Controls.Add(sidebar);
            Name = "TeacherDashboard";
            Text = "Teacher Dashboard";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
