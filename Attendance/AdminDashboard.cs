namespace Attendance
{
    public partial class AdminDashboard : Form
    {
        private int _userId;
        private string _email;


        public AdminDashboard(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email;
            //lblWelcome.Text = $"Welcome, Admin {email}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
        private void btnClassSetting_Click(object sender, EventArgs e)
        {
            ClassSetting classSettings = new ClassSetting(_userId);
            classSettings.ShowDialog();
        }

        private void BTNStdSetting_Click(object sender, EventArgs e)
        {
            StudentSettings stdForm = new StudentSettings();
            stdForm.ShowDialog();
        }

        private void BTNTeatcherSetting_Click(object sender, EventArgs e)
        {
            TeacherSettings teacherForm = new TeacherSettings();
            teacherForm.ShowDialog();
        }

        private void btnReportsSetting_Click(object sender, EventArgs e)
        {
            ReportsSettings reportForm = new ReportsSettings();
            reportForm.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm();
            backupForm.ShowDialog();
        }

    }
}
