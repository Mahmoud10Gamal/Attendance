namespace Attendance
{
    partial class Teacher_attentance
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;

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
            lblClass = new Label();
            cmbClasses = new ComboBox();
            dtpAttendanceDate = new DateTimePicker();
            btnLoadStudents = new Button();
            dgvStudents = new DataGridView();
            btnSaveAttendance = new Button();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
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
            btnReports.Click += btnReports_Click;
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
            lblWelcome.Size = new Size(900, 40);
            lblWelcome.TabIndex = 1;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.Controls.Add(lblClass);
            mainPanel.Controls.Add(cmbClasses);
            mainPanel.Controls.Add(dtpAttendanceDate);
            mainPanel.Controls.Add(btnLoadStudents);
            mainPanel.Controls.Add(dgvStudents);
            mainPanel.Controls.Add(btnSaveAttendance);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 560);
            mainPanel.TabIndex = 0;
            // 
            // lblClass
            // 
            lblClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClass.Location = new Point(40, 50);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(100, 23);
            lblClass.TabIndex = 0;
            lblClass.Text = "Select Class:";
            // 
            // cmbClasses
            // 
            cmbClasses.Location = new Point(160, 48);
            cmbClasses.Name = "cmbClasses";
            cmbClasses.Size = new Size(180, 28);
            cmbClasses.TabIndex = 1;
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Format = DateTimePickerFormat.Short;
            dtpAttendanceDate.Location = new Point(360, 48);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(150, 27);
            dtpAttendanceDate.TabIndex = 2;
            // 
            // btnLoadStudents
            // 
            btnLoadStudents.BackColor = Color.FromArgb(41, 128, 185);
            btnLoadStudents.FlatStyle = FlatStyle.Flat;
            btnLoadStudents.ForeColor = Color.White;
            btnLoadStudents.Location = new Point(530, 45);
            btnLoadStudents.Name = "btnLoadStudents";
            btnLoadStudents.Size = new Size(140, 30);
            btnLoadStudents.TabIndex = 3;
            btnLoadStudents.Text = "Load Students";
            btnLoadStudents.UseVisualStyleBackColor = false;
            btnLoadStudents.Click += btnLoadStudents_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersHeight = 29;
            dgvStudents.Location = new Point(40, 100);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(850, 350);
            dgvStudents.TabIndex = 4;
            // 
            // btnSaveAttendance
            // 
            btnSaveAttendance.BackColor = Color.FromArgb(39, 174, 96);
            btnSaveAttendance.FlatStyle = FlatStyle.Flat;
            btnSaveAttendance.ForeColor = Color.White;
            btnSaveAttendance.Location = new Point(380, 470);
            btnSaveAttendance.Name = "btnSaveAttendance";
            btnSaveAttendance.Size = new Size(200, 40);
            btnSaveAttendance.TabIndex = 5;
            btnSaveAttendance.Text = "Save Attendance";
            btnSaveAttendance.UseVisualStyleBackColor = false;
            btnSaveAttendance.Click += btnSaveAttendance_Click;
            // 
            // Teacher_attentance
            // 
            ClientSize = new Size(1100, 600);
            Controls.Add(mainPanel);
            Controls.Add(lblWelcome);
            Controls.Add(sidebar);
            Name = "Teacher_attentance";
            Text = "Teacher Attendance";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }
    }
}
