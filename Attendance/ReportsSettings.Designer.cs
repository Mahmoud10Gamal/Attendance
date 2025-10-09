namespace Attendance
{
    partial class ReportsSettings
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;

        private Label lblClass;
        private Label lblTeacher;
        private Label lblStudent;
        private ComboBox cmbClasses;
        private ComboBox cmbTeachers;
        private ComboBox cmbStudents;

        private Button btnGenerate;
        private Button btnExportExcel;
        private Button btnExportPdf;
        private DataGridView dgvReport;
        private Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblStartDate = new Label();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblClass = new Label();
            lblTeacher = new Label();
            lblStudent = new Label();
            cmbClasses = new ComboBox();
            cmbTeachers = new ComboBox();
            cmbStudents = new ComboBox();
            btnGenerate = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            dgvReport = new DataGridView();
            lblMessage = new Label();
            panelDates = new Panel();
            rowEnd = new Panel();
            rowStart = new Panel();
            panelDropdowns = new Panel();
            rowStudent = new Panel();
            rowTeacher = new Panel();
            rowClass = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            panelDates.SuspendLayout();
            rowEnd.SuspendLayout();
            rowStart.SuspendLayout();
            panelDropdowns.SuspendLayout();
            rowStudent.SuspendLayout();
            rowTeacher.SuspendLayout();
            rowClass.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Dock = DockStyle.Left;
            lblStartDate.Font = new Font("Segoe UI", 10F);
            lblStartDate.Location = new Point(0, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(90, 23);
            lblStartDate.TabIndex = 1;
            lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Dock = DockStyle.Left;
            lblEndDate.Font = new Font("Segoe UI", 10F);
            lblEndDate.Location = new Point(0, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(84, 23);
            lblEndDate.TabIndex = 1;
            lblEndDate.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Dock = DockStyle.Left;
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Location = new Point(90, 0);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(285, 30);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Dock = DockStyle.Left;
            dtpEndDate.Font = new Font("Segoe UI", 10F);
            dtpEndDate.Location = new Point(84, 0);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(285, 30);
            dtpEndDate.TabIndex = 0;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Dock = DockStyle.Left;
            lblClass.Font = new Font("Segoe UI", 10F);
            lblClass.Location = new Point(0, 0);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(52, 23);
            lblClass.TabIndex = 1;
            lblClass.Text = "Class:";
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Dock = DockStyle.Left;
            lblTeacher.Font = new Font("Segoe UI", 10F);
            lblTeacher.Location = new Point(0, 0);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(72, 23);
            lblTeacher.TabIndex = 1;
            lblTeacher.Text = "Teacher:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Dock = DockStyle.Left;
            lblStudent.Font = new Font("Segoe UI", 10F);
            lblStudent.Location = new Point(0, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(73, 23);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student:";
            // 
            // cmbClasses
            // 
            cmbClasses.Dock = DockStyle.Left;
            cmbClasses.Font = new Font("Segoe UI", 10F);
            cmbClasses.Location = new Point(52, 0);
            cmbClasses.Margin = new Padding(3, 4, 3, 4);
            cmbClasses.Name = "cmbClasses";
            cmbClasses.Size = new Size(285, 31);
            cmbClasses.TabIndex = 0;
            // 
            // cmbTeachers
            // 
            cmbTeachers.Dock = DockStyle.Left;
            cmbTeachers.Font = new Font("Segoe UI", 10F);
            cmbTeachers.Location = new Point(72, 0);
            cmbTeachers.Margin = new Padding(3, 4, 3, 4);
            cmbTeachers.Name = "cmbTeachers";
            cmbTeachers.Size = new Size(285, 31);
            cmbTeachers.TabIndex = 0;
            // 
            // cmbStudents
            // 
            cmbStudents.Dock = DockStyle.Left;
            cmbStudents.Font = new Font("Segoe UI", 10F);
            cmbStudents.Location = new Point(73, 0);
            cmbStudents.Margin = new Padding(3, 4, 3, 4);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(285, 31);
            cmbStudents.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(5, 50, 131);
            btnGenerate.Dock = DockStyle.Left;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(0, 0);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(183, 133);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(5, 131, 5);
            btnExportExcel.Dock = DockStyle.Left;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(183, 0);
            btnExportExcel.Margin = new Padding(11, 0, 0, 0);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(160, 133);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.FromArgb(131, 5, 131);
            btnExportPdf.Dock = DockStyle.Left;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(343, 0);
            btnExportPdf.Margin = new Padding(11, 0, 0, 0);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(160, 133);
            btnExportPdf.TabIndex = 0;
            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPDF_Click;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.WhiteSmoke;
            dgvReport.ColumnHeadersHeight = 29;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(0, 0);
            dgvReport.Margin = new Padding(3, 4, 3, 4);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1234, 760);
            dgvReport.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Bottom;
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMessage.ForeColor = Color.DodgerBlue;
            lblMessage.Location = new Point(0, 760);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(1234, 40);
            lblMessage.TabIndex = 4;
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDates
            // 
            panelDates.Controls.Add(rowEnd);
            panelDates.Controls.Add(rowStart);
            panelDates.Location = new Point(0, 0);
            panelDates.Margin = new Padding(3, 4, 3, 4);
            panelDates.Name = "panelDates";
            panelDates.Size = new Size(229, 133);
            panelDates.TabIndex = 3;
            // 
            // rowEnd
            // 
            rowEnd.Controls.Add(dtpEndDate);
            rowEnd.Controls.Add(lblEndDate);
            rowEnd.Location = new Point(0, 0);
            rowEnd.Margin = new Padding(3, 4, 3, 4);
            rowEnd.Name = "rowEnd";
            rowEnd.Size = new Size(229, 133);
            rowEnd.TabIndex = 0;
            // 
            // rowStart
            // 
            rowStart.Controls.Add(dtpStartDate);
            rowStart.Controls.Add(lblStartDate);
            rowStart.Location = new Point(0, 0);
            rowStart.Margin = new Padding(3, 4, 3, 4);
            rowStart.Name = "rowStart";
            rowStart.Size = new Size(229, 133);
            rowStart.TabIndex = 1;
            // 
            // panelDropdowns
            // 
            panelDropdowns.Controls.Add(rowStudent);
            panelDropdowns.Controls.Add(rowTeacher);
            panelDropdowns.Controls.Add(rowClass);
            panelDropdowns.Location = new Point(0, 0);
            panelDropdowns.Margin = new Padding(3, 4, 3, 4);
            panelDropdowns.Name = "panelDropdowns";
            panelDropdowns.Size = new Size(229, 133);
            panelDropdowns.TabIndex = 2;
            // 
            // rowStudent
            // 
            rowStudent.Controls.Add(cmbStudents);
            rowStudent.Controls.Add(lblStudent);
            rowStudent.Location = new Point(0, 0);
            rowStudent.Margin = new Padding(3, 4, 3, 4);
            rowStudent.Name = "rowStudent";
            rowStudent.Size = new Size(229, 133);
            rowStudent.TabIndex = 0;
            // 
            // rowTeacher
            // 
            rowTeacher.Controls.Add(cmbTeachers);
            rowTeacher.Controls.Add(lblTeacher);
            rowTeacher.Location = new Point(0, 0);
            rowTeacher.Margin = new Padding(3, 4, 3, 4);
            rowTeacher.Name = "rowTeacher";
            rowTeacher.Size = new Size(229, 133);
            rowTeacher.TabIndex = 1;
            // 
            // rowClass
            // 
            rowClass.Controls.Add(cmbClasses);
            rowClass.Controls.Add(lblClass);
            rowClass.Location = new Point(0, 0);
            rowClass.Margin = new Padding(3, 4, 3, 4);
            rowClass.Name = "rowClass";
            rowClass.Size = new Size(229, 133);
            rowClass.TabIndex = 2;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnExportPdf);
            panelButtons.Controls.Add(btnExportExcel);
            panelButtons.Controls.Add(btnGenerate);
            panelButtons.Location = new Point(0, 0);
            panelButtons.Margin = new Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(229, 133);
            panelButtons.TabIndex = 1;
            // 
            // ReportsSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1234, 800);
            Controls.Add(dgvReport);
            Controls.Add(panelButtons);
            Controls.Add(panelDropdowns);
            Controls.Add(panelDates);
            Controls.Add(lblMessage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportsSettings";
            Text = "Reports Generating";
            Load += ReportsSettings_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            panelDates.ResumeLayout(false);
            rowEnd.ResumeLayout(false);
            rowEnd.PerformLayout();
            rowStart.ResumeLayout(false);
            rowStart.PerformLayout();
            panelDropdowns.ResumeLayout(false);
            rowStudent.ResumeLayout(false);
            rowStudent.PerformLayout();
            rowTeacher.ResumeLayout(false);
            rowTeacher.PerformLayout();
            rowClass.ResumeLayout(false);
            rowClass.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel panelDates;
        private Panel rowEnd;
        private Panel rowStart;
        private Panel panelDropdowns;
        private Panel rowStudent;
        private Panel rowTeacher;
        private Panel rowClass;
        private Panel panelButtons;
    }
}
