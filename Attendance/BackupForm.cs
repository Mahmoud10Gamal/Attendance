using Attendance.DataAcess;
using Attendance.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;



using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class BackupForm : Form
    {
        private readonly int _userId;

        public BackupForm()
        {
            InitializeComponent();
        }
        public BackupForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            cmbBackupType.DataSource = Enum.GetValues(typeof(BackupType));
            cmbBackupType.SelectedItem = BackupType.Full;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBackupPath.Text))
            {
                MessageBox.Show("Please select a folder to save the backup.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var backupType = (BackupType)cmbBackupType.SelectedItem;
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupFile = Path.Combine(txtBackupPath.Text,
                $"AttendanceSystem_{backupType}_{timestamp}.bak");

            string connectionString = "Data Source=.;Initial Catalog=AttendanceSystem;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                btnBackup.Enabled = false;
                progressBar.Value = 20;
                lblStatus.Text = "Starting backup...";

                string sql = backupType switch
                {
                    BackupType.Full => $"BACKUP DATABASE [AttendanceSystem] TO DISK = '{backupFile}' WITH FORMAT, INIT",
                    BackupType.Differential => $"BACKUP DATABASE [AttendanceSystem] TO DISK = '{backupFile}' WITH DIFFERENTIAL, INIT",
                    BackupType.Log => $"BACKUP LOG [AttendanceSystem] TO DISK = '{backupFile}' WITH INIT",
                    _ => throw new InvalidOperationException("Unsupported backup type")
                };

                await using var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);
                await conn.OpenAsync();

                await using var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);
                await cmd.ExecuteNonQueryAsync();


                progressBar.Value = 80;
                long sizeBytes = new FileInfo(backupFile).Length;

                await SaveBackupRecord(backupFile, backupType, sizeBytes);

                progressBar.Value = 100;
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "✅ Backup completed successfully!";
                MessageBox.Show("Backup completed and logged successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Crimson;
                lblStatus.Text = "❌ Backup failed!";
                MessageBox.Show($"Backup failed:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnBackup.Enabled = true;
                progressBar.Value = 0;
            }
        }

        private async Task SaveBackupRecord(string filePath, BackupType type, long sizeBytes)
        {
            using (var db = new ApplicationDbContext())
            {
                var backup = new Backup
                {
                    FilePath = filePath,
                    BackupDate = DateTime.Now,
                    BackupType = type,
                    SizeBytes = sizeBytes,
                    PerformedBy = _userId
                };

                db.Backups.Add(backup);
                await db.SaveChangesAsync();
            }
        }
    }
}
