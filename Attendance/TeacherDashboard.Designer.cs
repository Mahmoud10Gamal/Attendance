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
        private System.Windows.Forms.Label lblClassId;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Button btnFilterByClass;

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
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            btnShowAttendance = new Button();
            lblClassId = new Label();
            txtClassId = new TextBox();
            btnFilterByClass = new Button();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
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
            sidebar.Size = new Size(200, 600);
            sidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 550);
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
            lblWelcome.Size = new Size(800, 40);
            lblWelcome.TabIndex = 1;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.Controls.Add(dgvAttendance);
            mainPanel.Controls.Add(lblStudentId);
            mainPanel.Controls.Add(txtStudentId);
            mainPanel.Controls.Add(lblStartDate);
            mainPanel.Controls.Add(dtpStartDate);
            mainPanel.Controls.Add(lblEndDate);
            mainPanel.Controls.Add(dtpEndDate);
            mainPanel.Controls.Add(btnShowAttendance);
            mainPanel.Controls.Add(lblClassId);
            mainPanel.Controls.Add(txtClassId);
            mainPanel.Controls.Add(btnFilterByClass);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 560);
            mainPanel.TabIndex = 0;
            // 
            // dgvAttendance
            // 
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Dock = DockStyle.Right;
            dgvAttendance.Location = new Point(250, 0);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(550, 560);
            dgvAttendance.TabIndex = 0;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentId.Location = new Point(30, 40);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(102, 23);
            lblStudentId.TabIndex = 1;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(150, 38);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(150, 27);
            txtStudentId.TabIndex = 2;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.Location = new Point(30, 90);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(98, 23);
            lblStartDate.TabIndex = 3;
            lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(150, 88);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 27);
            dtpStartDate.TabIndex = 4;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEndDate.Location = new Point(30, 140);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(88, 23);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(150, 138);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 27);
            dtpEndDate.TabIndex = 6;
            // 
            // btnShowAttendance
            // 
            btnShowAttendance.BackColor = Color.FromArgb(41, 128, 185);
            btnShowAttendance.FlatStyle = FlatStyle.Flat;
            btnShowAttendance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowAttendance.ForeColor = Color.White;
            btnShowAttendance.Location = new Point(70, 190);
            btnShowAttendance.Name = "btnShowAttendance";
            btnShowAttendance.Size = new Size(180, 35);
            btnShowAttendance.TabIndex = 7;
            btnShowAttendance.Text = "Filter by Student";
            btnShowAttendance.UseVisualStyleBackColor = false;
            btnShowAttendance.Click += btnShowAttendance_Click;
            // 
            // lblClassId
            // 
            lblClassId.AutoSize = true;
            lblClassId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClassId.Location = new Point(30, 270);
            lblClassId.Name = "lblClassId";
            lblClassId.Size = new Size(77, 23);
            lblClassId.TabIndex = 8;
            lblClassId.Text = "Class ID:";
            // 
            // txtClassId
            // 
            txtClassId.Location = new Point(150, 268);
            txtClassId.Name = "txtClassId";
            txtClassId.Size = new Size(150, 27);
            txtClassId.TabIndex = 9;
            txtClassId.TextChanged += txtClassId_TextChanged;
            // 
            // btnFilterByClass
            // 
            btnFilterByClass.BackColor = Color.FromArgb(41, 128, 185);
            btnFilterByClass.FlatStyle = FlatStyle.Flat;
            btnFilterByClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilterByClass.ForeColor = Color.White;
            btnFilterByClass.Location = new Point(70, 320);
            btnFilterByClass.Name = "btnFilterByClass";
            btnFilterByClass.Size = new Size(180, 35);
            btnFilterByClass.TabIndex = 10;
            btnFilterByClass.Text = "Filter by Class";
            btnFilterByClass.UseVisualStyleBackColor = false;
            btnFilterByClass.Click += btnFilterByClass_Click;
            // 
            // TeacherDashboard
            // 
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
