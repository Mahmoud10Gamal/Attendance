using Attendance.DataAcess;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Attendance
{
    public partial class ClassSetting : Form
    {
        private ApplicationDbContext _context;

        public ClassSetting()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        // View All Classes
        private void BTNViewAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Classes
                                               .Select(c => new { c.ClassId, c.Name, c.Year, Teacher = c.Teacher.Name })
                                               .ToList();
        }

        // View a specific Class by ID
        private void BTNViewClass_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TBClassID.Text, out int classId))
            {
                var cls = _context.Classes
                                  .Where(c => c.ClassId == classId)
                                  .Select(c => new { c.ClassId, c.Name, c.Year, Teacher = c.Teacher.Name })
                                  .ToList();

                if (cls.Any())
                    dataGridView1.DataSource = cls;
                else
                    MessageBox.Show("Class not found.");
            }
            else
            {
                MessageBox.Show("Please enter a valid Class ID.");
            }
        }

        // Delete a Class
        private void BTNDeleteClass_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TBClassID.Text, out int classId))
            {
                var cls = _context.Classes.FirstOrDefault(c => c.ClassId == classId);
                if (cls != null)
                {
                    _context.Classes.Remove(cls);
                    _context.SaveChanges();
                    MessageBox.Show("Class deleted successfully.");
                    BTNViewAll_Click(sender, e); // Refresh
                }
                else
                {
                    MessageBox.Show("Class not found.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Class ID.");
            }
        }

        // Edit Class (using textBox1 for Name, textBox2 for Year)
        private void BTNEditClass_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TBClassID.Text, out int classId))
            {
                var cls = _context.Classes.FirstOrDefault(c => c.ClassId == classId);
                if (cls != null)
                {
                    cls.Name = textBox1.Text;
                    cls.Year = textBox2.Text;

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
                MessageBox.Show("Enter a valid Class ID.");
            }
        }
    }
}
