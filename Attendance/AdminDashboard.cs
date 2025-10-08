namespace Attendance
{
    public partial class AdminDashboard : Form
    {
        private int _userId;
        private string _email;

        public AdminDashboard()
        {
            InitializeComponent();
        }
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
            ClassSetting classSettings = new ClassSetting();
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
            this.Hide();

            // Create and show the TeacherDashboard form again
            TeacherDashboard dashboard = new TeacherDashboard(_userId, _email);
            dashboard.FormClosed += (s, args) => this.Show(); // Show again if needed after dashboard closes
            dashboard.Show();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm();
            backupForm.ShowDialog();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
