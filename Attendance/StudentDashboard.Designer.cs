namespace Attendance
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnViewAttendance;
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Controls.Add(this.btnViewAttendance);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Width = 200;
            // 
            // btnLogout
            // 
            this.btnViewAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.Height = 50;
            this.btnViewAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAttendance.ForeColor = System.Drawing.Color.White;
            // 
            // btnViewAttendance
            // 
            btnViewAttendance.Dock = DockStyle.Top;
            btnViewAttendance.FlatStyle = FlatStyle.Flat;
            btnViewAttendance.ForeColor = Color.White;
            btnViewAttendance.Location = new Point(0, 0);
            btnViewAttendance.Name = "btnViewAttendance";
            btnViewAttendance.Size = new Size(200, 50);
            btnViewAttendance.TabIndex = 1;
            btnViewAttendance.Text = "View Attendance";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Height = 40;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // StudentDashboard
            // 
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.sidebar);
            this.Text = "Student Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private DataGridView dataGridView1;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
    }
}
