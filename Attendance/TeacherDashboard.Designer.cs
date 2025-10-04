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
            SuspendLayout();

            // Sidebar
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(btnReports);
            sidebar.Controls.Add(btnAttendance);
            sidebar.Dock = DockStyle.Left;
            sidebar.Size = new Size(200, 600);

            // Buttons
            btnAttendance.Dock = DockStyle.Top;
            btnAttendance.Text = "Attendance";
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Height = 50;

            btnReports.Dock = DockStyle.Top;
            btnReports.Text = "Reports";
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Height = 50;

            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Text = "Logout";
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Height = 50;
            btnLogout.Click += btnLogout_Click;

            // Header
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Height = 40;

            // Main panel
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.Dock = DockStyle.Fill;

            // Grid
            dgvAttendance.Dock = DockStyle.Right;
            dgvAttendance.Width = 550;
            dgvAttendance.BackgroundColor = Color.White;

            // Filters
            lblStudent.Text = "Student:";
            lblStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudent.Location = new Point(30, 40);
            cmbStudents.Location = new Point(150, 38);
            cmbStudents.Width = 150;

            lblStartDate.Text = "Start Date:";
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.Location = new Point(30, 90);
            dtpStartDate.Location = new Point(150, 88);
            dtpStartDate.Width = 150;

            lblEndDate.Text = "End Date:";
            lblEndDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEndDate.Location = new Point(30, 140);
            dtpEndDate.Location = new Point(150, 138);
            dtpEndDate.Width = 150;

            btnShowAttendance.Text = "Filter by Student";
            btnShowAttendance.BackColor = Color.FromArgb(41, 128, 185);
            btnShowAttendance.ForeColor = Color.White;
            btnShowAttendance.FlatStyle = FlatStyle.Flat;
            btnShowAttendance.Location = new Point(70, 190);
            btnShowAttendance.Size = new Size(180, 35);
            btnShowAttendance.Click += btnShowAttendance_Click;

            lblClass.Text = "Class:";
            lblClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClass.Location = new Point(30, 270);
            cmbClasses.Location = new Point(150, 268);
            cmbClasses.Width = 150;

            btnFilterByClass.Text = "Filter by Class";
            btnFilterByClass.BackColor = Color.FromArgb(41, 128, 185);
            btnFilterByClass.ForeColor = Color.White;
            btnFilterByClass.FlatStyle = FlatStyle.Flat;
            btnFilterByClass.Location = new Point(70, 320);
            btnFilterByClass.Size = new Size(180, 35);
            btnFilterByClass.Click += btnFilterByClass_Click;

            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.BackColor = Color.FromArgb(39, 174, 96);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Location = new Point(70, 380);
            btnExportPdf.Size = new Size(180, 35);
            btnExportPdf.Click += btnExportPdf_Click;

            // Add to main panel
            mainPanel.Controls.AddRange(new Control[] {
                dgvAttendance, lblStudent, cmbStudents,
                lblStartDate, dtpStartDate, lblEndDate, dtpEndDate,
                btnShowAttendance, lblClass, cmbClasses,
                btnFilterByClass, btnExportPdf
            });

            // Form
            ClientSize = new Size(1000, 600);
            Controls.Add(mainPanel);
            Controls.Add(lblWelcome);
            Controls.Add(sidebar);
            Text = "Teacher Dashboard";
            WindowState = FormWindowState.Maximized;

            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }
    }
}
