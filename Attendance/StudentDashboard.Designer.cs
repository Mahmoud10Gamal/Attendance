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
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Label lblAttendanceRate;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Label lblFilterInfo;

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
            btnViewAttendance = new Button();
            lblWelcome = new Label();
            mainPanel = new Panel();
            btnExportPdf = new Button();
            lblAttendanceRate = new Label();
            dgvAttendance = new DataGridView();
            lblFilterInfo = new Label();
            dtEnd = new DateTimePicker();
            lblEnd = new Label();
            dtStart = new DateTimePicker();
            lblStart = new Label();
            cmbClasses = new ComboBox();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(btnViewAttendance);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(180, 525);
            sidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 480);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 45);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewAttendance
            // 
            btnViewAttendance.Dock = DockStyle.Top;
            btnViewAttendance.FlatStyle = FlatStyle.Flat;
            btnViewAttendance.ForeColor = Color.White;
            btnViewAttendance.Location = new Point(0, 0);
            btnViewAttendance.Name = "btnViewAttendance";
            btnViewAttendance.Size = new Size(180, 45);
            btnViewAttendance.TabIndex = 1;
            btnViewAttendance.Text = "View Attendance";
            btnViewAttendance.Click += btnViewAttendance_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.Location = new Point(180, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(786, 40);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Student";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(btnExportPdf);
            mainPanel.Controls.Add(lblAttendanceRate);
            mainPanel.Controls.Add(dgvAttendance);
            mainPanel.Controls.Add(lblFilterInfo);
            mainPanel.Controls.Add(dtEnd);
            mainPanel.Controls.Add(lblEnd);
            mainPanel.Controls.Add(dtStart);
            mainPanel.Controls.Add(lblStart);
            mainPanel.Controls.Add(cmbClasses);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(180, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(786, 485);
            mainPanel.TabIndex = 0;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportPdf.Location = new Point(643, 362);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(120, 30);
            btnExportPdf.TabIndex = 0;
            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // lblAttendanceRate
            // 
            lblAttendanceRate.AutoSize = true;
            lblAttendanceRate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAttendanceRate.ForeColor = Color.FromArgb(41, 128, 185);
            lblAttendanceRate.Location = new Point(20, 365);
            lblAttendanceRate.Name = "lblAttendanceRate";
            lblAttendanceRate.Size = new Size(0, 23);
            lblAttendanceRate.TabIndex = 1;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.WhiteSmoke;
            dgvAttendance.ColumnHeadersHeight = 29;
            dgvAttendance.Location = new Point(20, 75);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(743, 280);
            dgvAttendance.TabIndex = 2;
            // 
            // lblFilterInfo
            // 
            lblFilterInfo.AutoSize = true;
            lblFilterInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblFilterInfo.ForeColor = Color.DimGray;
            lblFilterInfo.Location = new Point(20, 55);
            lblFilterInfo.Name = "lblFilterInfo";
            lblFilterInfo.Size = new Size(0, 20);
            lblFilterInfo.TabIndex = 3;
            // 
            // dtEnd
            // 
            dtEnd.Font = new Font("Segoe UI", 9F);
            dtEnd.Location = new Point(591, 24);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(172, 27);
            dtEnd.TabIndex = 4;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEnd.Location = new Point(509, 28);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(76, 20);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "End Date:";
            // 
            // dtStart
            // 
            dtStart.Font = new Font("Segoe UI", 9F);
            dtStart.Location = new Point(327, 23);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(176, 27);
            dtStart.TabIndex = 6;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStart.Location = new Point(246, 25);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(84, 20);
            lblStart.TabIndex = 7;
            lblStart.Text = "Start Date:";
            // 
            // cmbClasses
            // 
            cmbClasses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClasses.Font = new Font("Segoe UI", 10F);
            cmbClasses.Location = new Point(20, 20);
            cmbClasses.Name = "cmbClasses";
            cmbClasses.Size = new Size(220, 31);
            cmbClasses.TabIndex = 8;
            // 
            // StudentDashboard
            // 
            ClientSize = new Size(966, 525);
            Controls.Add(mainPanel);
            Controls.Add(lblWelcome);
            Controls.Add(sidebar);
            Name = "StudentDashboard";
            Text = "Student Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += StudentDashboard_Load;
            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }
    }
}
