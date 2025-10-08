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
        private System.Windows.Forms.Panel filterPanel;

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

            // Sidebar
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(btnReports);
            sidebar.Controls.Add(btnAttendance);
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 220;
            sidebar.Padding = new Padding(10, 40, 10, 10);

            // Sidebar Buttons
            btnAttendance.Text = "Attendance";
            btnAttendance.Dock = DockStyle.Top;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Height = 50;
            btnAttendance.Click += btnAttendance_Click;

            btnReports.Text = "Reports";
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Height = 50;
            btnReports.Margin = new Padding(0, 10, 0, 10);
            btnReports.Click += btnReports_Click;

            btnLogout.Text = "Logout";
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Height = 50;
            btnLogout.Click += btnLogout_Click;

            // Header label
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.BackColor = Color.White;
            lblWelcome.Height = 50;
            lblWelcome.Text = "Welcome, Teacher";

            // Main Panel
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Padding = new Padding(20);
            mainPanel.BackColor = Color.FromArgb(245, 247, 250);
            mainPanel.Controls.Add(dgvAttendance);
            mainPanel.Controls.Add(filterPanel);

            // Filter Panel (Left)
            filterPanel.Dock = DockStyle.Left;
            filterPanel.Width = 320;
            filterPanel.BackColor = Color.White;
            filterPanel.Padding = new Padding(20);
            filterPanel.BorderStyle = BorderStyle.FixedSingle;

            // Filter Controls
            lblStudent.Text = "Student:";
            lblStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudent.Location = new Point(20, 30);
            lblStudent.AutoSize = true;

            cmbStudents.Location = new Point(130, 28);
            cmbStudents.Width = 160;

            lblStartDate.Text = "Start Date:";
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.Location = new Point(20, 80);
            lblStartDate.AutoSize = true;

            dtpStartDate.Location = new Point(130, 78);
            dtpStartDate.Width = 160;

            lblEndDate.Text = "End Date:";
            lblEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEndDate.Location = new Point(20, 130);
            lblEndDate.AutoSize = true;

            dtpEndDate.Location = new Point(130, 128);
            dtpEndDate.Width = 160;

            btnShowAttendance.Text = "Filter by Student";
            btnShowAttendance.BackColor = Color.FromArgb(41, 128, 185);
            btnShowAttendance.FlatStyle = FlatStyle.Flat;
            btnShowAttendance.ForeColor = Color.White;
            btnShowAttendance.Location = new Point(70, 180);
            btnShowAttendance.Size = new Size(180, 35);
            btnShowAttendance.Click += btnShowAttendance_Click;

            lblClass.Text = "Class:";
            lblClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClass.Location = new Point(20, 250);
            lblClass.AutoSize = true;

            cmbClasses.Location = new Point(130, 248);
            cmbClasses.Width = 160;

            btnFilterByClass.Text = "Filter by Class";
            btnFilterByClass.BackColor = Color.FromArgb(41, 128, 185);
            btnFilterByClass.FlatStyle = FlatStyle.Flat;
            btnFilterByClass.ForeColor = Color.White;
            btnFilterByClass.Location = new Point(70, 300);
            btnFilterByClass.Size = new Size(180, 35);
            btnFilterByClass.Click += btnFilterByClass_Click;

            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.BackColor = Color.FromArgb(39, 174, 96);
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(70, 360);
            btnExportPdf.Size = new Size(180, 35);
            btnExportPdf.Click += btnExportPdf_Click;

            // Add controls to filter panel
            filterPanel.Controls.AddRange(new Control[]
            {
        lblStudent, cmbStudents,
        lblStartDate, dtpStartDate,
        lblEndDate, dtpEndDate,
        btnShowAttendance,
        lblClass, cmbClasses,
        btnFilterByClass,
        btnExportPdf
            });

            // DataGridView (Right)
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BorderStyle = BorderStyle.FixedSingle;
            dgvAttendance.DefaultCellStyle.BackColor = Color.White;
            dgvAttendance.DefaultCellStyle.ForeColor = Color.Black;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;

            // Form
            ClientSize = new Size(1200, 700);
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
            filterPanel.PerformLayout();
            ResumeLayout(false);
        }

    }
}
