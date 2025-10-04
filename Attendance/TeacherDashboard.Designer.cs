namespace Attendance
{
    partial class TeacherDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnShowAttendance;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
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
            dgvAttendance = new DataGridView();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            btnShowAttendance = new Button();
            lblStartDate = new Label();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();

            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();

            // ===== Sidebar =====
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(btnReports);
            sidebar.Controls.Add(btnAttendance);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 600);
            sidebar.TabIndex = 2;

            // ===== Buttons =====
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 550);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;

            btnReports.Dock = DockStyle.Top;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 50);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 50);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";

            btnAttendance.Dock = DockStyle.Top;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(0, 0);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(200, 50);
            btnAttendance.TabIndex = 2;
            btnAttendance.Text = "Attendance";

            // ===== Header Label =====
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWelcome.Location = new Point(200, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(800, 40);
            lblWelcome.TabIndex = 1;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;

            // ===== Main Panel =====
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 560);
            mainPanel.TabIndex = 0;
            mainPanel.BackColor = Color.WhiteSmoke;

            // ===== DataGridView =====
            dgvAttendance.Location = new Point(20, 20);
            dgvAttendance.Size = new Size(450, 500);
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.TabIndex = 10;

            // ===== Label Student ID =====
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentId.Location = new Point(500, 60);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(100, 23);
            lblStudentId.Text = "Student ID:";

            // ===== TextBox Student ID =====
            txtStudentId.Location = new Point(620, 58);
            txtStudentId.Size = new Size(150, 27);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.TabIndex = 11;

            // ===== Start Date =====
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.Location = new Point(500, 110);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(88, 23);
            lblStartDate.Text = "Start Date:";

            dtpStartDate.Location = new Point(620, 108);
            dtpStartDate.Size = new Size(150, 27);
            dtpStartDate.Format = DateTimePickerFormat.Short;

            // ===== End Date =====
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEndDate.Location = new Point(500, 160);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(83, 23);
            lblEndDate.Text = "End Date:";

            dtpEndDate.Location = new Point(620, 158);
            dtpEndDate.Size = new Size(150, 27);
            dtpEndDate.Format = DateTimePickerFormat.Short;

            // ===== Button Show Attendance =====
            btnShowAttendance.BackColor = Color.FromArgb(41, 128, 185);
            btnShowAttendance.ForeColor = Color.White;
            btnShowAttendance.FlatStyle = FlatStyle.Flat;
            btnShowAttendance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowAttendance.Location = new Point(570, 220);
            btnShowAttendance.Name = "btnShowAttendance";
            btnShowAttendance.Size = new Size(150, 35);
            btnShowAttendance.TabIndex = 12;
            btnShowAttendance.Text = "Filter Attendance";
            btnShowAttendance.UseVisualStyleBackColor = false;
            btnShowAttendance.Click += btnShowAttendance_Click;

            // ===== Add controls to main panel =====
            mainPanel.Controls.Add(dgvAttendance);
            mainPanel.Controls.Add(lblStudentId);
            mainPanel.Controls.Add(txtStudentId);
            mainPanel.Controls.Add(lblStartDate);
            mainPanel.Controls.Add(dtpStartDate);
            mainPanel.Controls.Add(lblEndDate);
            mainPanel.Controls.Add(dtpEndDate);
            mainPanel.Controls.Add(btnShowAttendance);

            // ===== Form Settings =====
            ClientSize = new Size(1000, 600);
            Controls.Add(mainPanel);
            Controls.Add(lblWelcome);
            Controls.Add(sidebar);
            Name = "TeacherDashboard";
            Text = "Teacher Dashboard";
            WindowState = FormWindowState.Maximized;

            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }
    }
}
