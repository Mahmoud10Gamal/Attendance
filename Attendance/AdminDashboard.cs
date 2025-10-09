using Attendance.DataAcess;
using Attendance.Model;

namespace Attendance
{
    public partial class AdminDashboard : Form
    {
        private int _userId;
        private string _email;
        private User? _currentUser;

        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email;

            // نجيب المستخدم الحالي من الداتا
            _currentUser = db.Users.FirstOrDefault(u => u.UserId == _userId);
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
            if (_currentUser == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            if (_currentUser.Role == UserRole.Admin)
            {
                // Admin mode: open StudentSettings for all students
                var stdForm = new StudentSettings(0, _email); // 0 = Admin Mode
                stdForm.ShowDialog();
                return;
            }

            var student = db.Students.FirstOrDefault(s => s.UserId == _userId);
            if (student != null)
            {
                var stdForm = new StudentSettings(student.StudentId, _email);
                stdForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Student record not found.");
            }
        }

        private void BTNTeatcherSetting_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            if (_currentUser.Role == UserRole.Admin)
            {
                // Admin mode: open TeacherSettings for all teachers
                var teacherForm = new TeacherSettings(0, _email); // 0 = Admin Mode
                teacherForm.ShowDialog();
                return;
            }

            var teacher = db.Teachers.FirstOrDefault(t => t.UserId == _userId);
            if (teacher != null)
            {
                TeacherSettings teacherForm = new TeacherSettings(teacher.TeacherId, _email);
                teacherForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Teacher record not found.");
            }
        }

        //private void btnReportsSetting_Click(object sender, EventArgs e)
        //{
        //    ReportsSettings reportForm = new ReportsSettings();
        //    reportForm.ShowDialog();
        //}

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm(_userId);
            backupForm.ShowDialog();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
           
        }
    }
}