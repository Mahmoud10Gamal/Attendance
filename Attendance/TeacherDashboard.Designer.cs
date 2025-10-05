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
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnShowAttendance;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.Button btnFilterByClass;
        private System.Windows.Forms.Button btnExportPdf;

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
            filterPanel = new Panel();
            lblStudent = new Label();
            cmbStudents = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            btnShowAttendance = new Button();
            lblClass = new Label();
            cmbClasses = new ComboBox();
            btnFilterByClass = new Button();
            btnExportPdf = new Button();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            filterPanel.SuspendLayout();
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
            btnAttendance.Click += btnAttendance_Click;
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
            mainPanel.Controls.Add(filterPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 560);
            mainPanel.TabIndex = 0;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.ColumnHeadersHeight = 29;
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.Location = new Point(300, 0);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(500, 560);
            dgvAttendance.TabIndex = 0;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.WhiteSmoke;
            filterPanel.Controls.Add(lblStudent);
            filterPanel.Controls.Add(cmbStudents);
            filterPanel.Controls.Add(lblStartDate);
            filterPanel.Controls.Add(dtpStartDate);
            filterPanel.Controls.Add(lblEndDate);
            filterPanel.Controls.Add(dtpEndDate);
            filterPanel.Controls.Add(btnShowAttendance);
            filterPanel.Controls.Add(lblClass);
            filterPanel.Controls.Add(cmbClasses);
            filterPanel.Controls.Add(btnFilterByClass);
            filterPanel.Controls.Add(btnExportPdf);
            filterPanel.Dock = DockStyle.Left;
            filterPanel.Location = new Point(0, 0);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(300, 560);
            filterPanel.TabIndex = 1;
            // 
            // lblStudent
            // 
            lblStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudent.Location = new Point(30, 40);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(100, 23);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Student:";
            // 
            // cmbStudents
            // 
            cmbStudents.Location = new Point(150, 38);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(120, 28);
            cmbStudents.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.Location = new Point(30, 90);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 23);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(150, 88);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(120, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            lblEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEndDate.Location = new Point(30, 140);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(100, 23);
            lblEndDate.TabIndex = 4;
            lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(150, 138);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(120, 27);
            dtpEndDate.TabIndex = 5;
            // 
            // btnShowAttendance
            // 
            btnShowAttendance.BackColor = Color.FromArgb(41, 128, 185);
            btnShowAttendance.FlatStyle = FlatStyle.Flat;
            btnShowAttendance.ForeColor = Color.White;
            btnShowAttendance.Location = new Point(60, 190);
            btnShowAttendance.Name = "btnShowAttendance";
            btnShowAttendance.Size = new Size(180, 35);
            btnShowAttendance.TabIndex = 6;
            btnShowAttendance.Text = "Filter by Student";
            btnShowAttendance.UseVisualStyleBackColor = false;
            btnShowAttendance.Click += btnShowAttendance_Click;
            // 
            // lblClass
            // 
            lblClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClass.Location = new Point(30, 270);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(100, 23);
            lblClass.TabIndex = 7;
            lblClass.Text = "Class:";
            // 
            // cmbClasses
            // 
            cmbClasses.Location = new Point(150, 268);
            cmbClasses.Name = "cmbClasses";
            cmbClasses.Size = new Size(120, 28);
            cmbClasses.TabIndex = 8;
            // 
            // btnFilterByClass
            // 
            btnFilterByClass.BackColor = Color.FromArgb(41, 128, 185);
            btnFilterByClass.FlatStyle = FlatStyle.Flat;
            btnFilterByClass.ForeColor = Color.White;
            btnFilterByClass.Location = new Point(60, 320);
            btnFilterByClass.Name = "btnFilterByClass";
            btnFilterByClass.Size = new Size(180, 35);
            btnFilterByClass.TabIndex = 9;
            btnFilterByClass.Text = "Filter by Class";
            btnFilterByClass.UseVisualStyleBackColor = false;
            btnFilterByClass.Click += btnFilterByClass_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.FromArgb(39, 174, 96);
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(60, 380);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(180, 35);
            btnExportPdf.TabIndex = 10;
            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
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
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            filterPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel filterPanel;
    }
}
