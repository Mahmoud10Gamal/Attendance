namespace Attendance
{
    partial class BackupForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbBackupType;
        private System.Windows.Forms.Label lblBackupType;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbBackupType = new System.Windows.Forms.ComboBox();
            this.lblBackupType = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Database Backup";

            // txtBackupPath
            this.txtBackupPath.Location = new System.Drawing.Point(25, 60);
            this.txtBackupPath.Size = new System.Drawing.Size(300, 27);

            // btnBrowse
            this.btnBrowse.Location = new System.Drawing.Point(340, 60);
            this.btnBrowse.Size = new System.Drawing.Size(90, 28);
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // lblBackupType
            this.lblBackupType.AutoSize = true;
            this.lblBackupType.Location = new System.Drawing.Point(25, 110);
            this.lblBackupType.Text = "Backup Type:";

            // cmbBackupType
            this.cmbBackupType.Location = new System.Drawing.Point(120, 106);
            this.cmbBackupType.Size = new System.Drawing.Size(150, 28);
            this.cmbBackupType.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnBackup
            this.btnBackup.Location = new System.Drawing.Point(25, 160);
            this.btnBackup.Size = new System.Drawing.Size(150, 40);
            this.btnBackup.Text = "Start Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);

            // progressBar
            this.progressBar.Location = new System.Drawing.Point(25, 220);
            this.progressBar.Size = new System.Drawing.Size(405, 20);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(25, 250);
            this.lblStatus.Text = "";

            // BackupForm
            this.ClientSize = new System.Drawing.Size(460, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblBackupType);
            this.Controls.Add(this.cmbBackupType);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Backup Database";
            this.Load += new System.EventHandler(this.BackupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
