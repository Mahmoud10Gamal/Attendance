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
            sidebar = new Panel();
            btnLogout = new Button();
            btnViewAttendance = new Button();
            lblWelcome = new Label();
            mainPanel = new Panel();
            dataGridView1 = new DataGridView();
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            sidebar.Size = new Size(200, 411);
            sidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 361);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
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
            btnViewAttendance.Size = new Size(200, 50);
            btnViewAttendance.TabIndex = 1;
            btnViewAttendance.Text = "View Attendance";
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWelcome.Location = new Point(200, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(580, 40);
            lblWelcome.TabIndex = 1;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(dtEnd);
            mainPanel.Controls.Add(dtStart);
            mainPanel.Controls.Add(dataGridView1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(580, 371);
            mainPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(580, 368);
            dataGridView1.TabIndex = 0;
            // 
            // dtStart
            // 
            dtStart.Location = new Point(8, 8);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(250, 27);
            dtStart.TabIndex = 1;
            dtStart.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(264, 8);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(250, 27);
            dtEnd.TabIndex = 2;
            // 
            // StudentDashboard
            // 
            ClientSize = new Size(780, 411);
            Controls.Add(mainPanel);
            Controls.Add(lblWelcome);
            Controls.Add(sidebar);
            Name = "StudentDashboard";
            Text = "Student Dashboard";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
        private DataGridView dataGridView1;
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
    }
}
