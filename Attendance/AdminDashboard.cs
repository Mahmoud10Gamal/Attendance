using Attendance.DataAcess;

namespace Attendance
{
    public partial class AdminDashboard : Form
    {
        private int _userId;
        private string _email;

        ApplicationDbContext db = new ApplicationDbContext();

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
            var student= db.Students.FirstOrDefault(s=>s.UserId==_userId);
            if (student != null)
            {
                var stdForm=new StudentSettings(student.StudentId, _email);
                stdForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Student record not found.");
            }

        }

        private void BTNTeatcherSetting_Click(object sender, EventArgs e)
        {
            var teacher = db.Teachers.FirstOrDefault(t => t.UserId == _userId);
            if (teacher != null)
            {
                TeacherSettings teacherForm = new TeacherSettings(teacher.TeacherId,_email);
                teacherForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Teacher record not found.");
            }

        }

        private void btnReportsSetting_Click(object sender, EventArgs e)
        {
            ReportsSettings reportForm = new ReportsSettings();
            reportForm.ShowDialog();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm(_userId);
            backupForm.ShowDialog();
        }

    }
}
