using Attendance.DataAcess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Attendance
{
    public partial class ClassSetting : Form
    {
        private readonly ApplicationDbContext _context;

        public ClassSetting()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        // Load form
        private void ClassSetting_Load(object sender, EventArgs e)
        {
            BTNViewAll_Click(sender, e);
        }

        // === VIEW ALL CLASSES ===
        private void BTNViewAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Classes
                .Select(c => new
                {
                    c.ClassId,
                    c.Name,
                    c.Year,
                    TeacherID = c.TeacherId
                })
                .ToList();
        }

        // === VIEW CLASS BY ID ===
        private void BTNViewClass_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TBClassID.Text, out int classId))
            {
                var cls = _context.Classes.FirstOrDefault(c => c.ClassId == classId);
                if (cls != null)
                {
                    // Show in grid
                    dataGridView1.DataSource = new[]
                    {
                        new { cls.ClassId, cls.Name, cls.Year, cls.TeacherId }
                    }.ToList();

                    // Fill textboxes for editing
                    textBox1.Text = cls.Name;
                    textBox2.Text = cls.TeacherId.ToString();
                }
                else
                {
                    MessageBox.Show("Class not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Class ID.");
            }
        }

        // === DELETE CLASS ===
        private void BTNDeleteClass_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(TBClassID.Text, out int classId))
            {
                var cls = _context.Classes.FirstOrDefault(c => c.ClassId == classId);
                if (cls != null)
                {
                    _context.Classes.Remove(cls);
                    _context.SaveChanges();
                    MessageBox.Show("Class deleted successfully.");
                    BTNViewAll_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Class not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Class ID.");
            }
        }

        // === EDIT / UPDATE CLASS ===
        private void BTNEditClass_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(TBClassID.Text, out int classId))
            {
                var cls = _context.Classes.FirstOrDefault(c => c.ClassId == classId);
                if (cls != null)
                {
                    cls.Name = textBox1.Text;

                    if (int.TryParse(textBox2.Text, out int teacherId))
                    {
                        cls.TeacherId = teacherId;
                    }

                    _context.SaveChanges();
                    MessageBox.Show("Class updated successfully.");
                    BTNViewAll_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Class not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Class ID.");
            }
        }
    }
}
