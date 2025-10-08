namespace Attendance
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnClassSetting;
        private System.Windows.Forms.Button btnReportsSetting;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnLogout;
        private Button BTNTeatcherSetting;
        private Button BTNStdSetting;

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
            BTNTeatcherSetting = new Button();
            BTNStdSetting = new Button();
            btnLogout = new Button();
            btnBackup = new Button();
            btnReportsSetting = new Button();
            btnClassSetting = new Button();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(BTNTeatcherSetting);
            sidebar.Controls.Add(BTNStdSetting);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(btnBackup);
            sidebar.Controls.Add(btnReportsSetting);
            sidebar.Controls.Add(btnClassSetting);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 375);
            sidebar.TabIndex = 2;
            // 
            // BTNTeatcherSetting
            // 
            BTNTeatcherSetting.Dock = DockStyle.Top;
            BTNTeatcherSetting.FlatStyle = FlatStyle.Flat;
            BTNTeatcherSetting.ForeColor = Color.White;
            BTNTeatcherSetting.Location = new Point(0, 200);
            BTNTeatcherSetting.Name = "BTNTeatcherSetting";
            BTNTeatcherSetting.Size = new Size(200, 50);
            BTNTeatcherSetting.TabIndex = 5;
            BTNTeatcherSetting.Text = "Teachers  Setting";
            BTNTeatcherSetting.Click += BTNTeatcherSetting_Click;
            // 
            // BTNStdSetting
            // 
            BTNStdSetting.Dock = DockStyle.Top;
            BTNStdSetting.FlatStyle = FlatStyle.Flat;
            BTNStdSetting.ForeColor = Color.White;
            BTNStdSetting.Location = new Point(0, 150);
            BTNStdSetting.Name = "BTNStdSetting";
            BTNStdSetting.Size = new Size(200, 50);
            BTNStdSetting.TabIndex = 4;
            BTNStdSetting.Text = "Students  Setting";
            BTNStdSetting.Click += BTNStdSetting_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 325);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBackup
            // 
            btnBackup.Dock = DockStyle.Top;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(0, 100);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(200, 50);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Backup";
            btnBackup.Click += btnBackup_Click;
            // 
            // btnReportsSetting
            // 
            btnReportsSetting.Dock = DockStyle.Top;
            btnReportsSetting.FlatStyle = FlatStyle.Flat;
            btnReportsSetting.ForeColor = Color.White;
            btnReportsSetting.Location = new Point(0, 50);
            btnReportsSetting.Name = "btnReportsSetting";
            btnReportsSetting.Size = new Size(200, 50);
            btnReportsSetting.TabIndex = 2;
            btnReportsSetting.Text = "Generate Reports";
            btnReportsSetting.Click += btnReportsSetting_Click;
            // 
            // btnClassSetting
            // 
            btnClassSetting.Dock = DockStyle.Top;
            btnClassSetting.FlatStyle = FlatStyle.Flat;
            btnClassSetting.ForeColor = Color.White;
            btnClassSetting.Location = new Point(0, 0);
            btnClassSetting.Name = "btnClassSetting";
            btnClassSetting.Size = new Size(200, 50);
            btnClassSetting.TabIndex = 3;
            btnClassSetting.Text = "Classes  Setting";
            btnClassSetting.Click += btnClassSetting_Click;
            // 
            // AdminDashboard
            // 
            ClientSize = new Size(919, 375);
            Controls.Add(sidebar);
            MaximumSize = new Size(935, 414);
            MinimumSize = new Size(935, 414);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboard_Load;
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}