using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int UserId { get; set; }
        public string EmployeeNumber { get; set; } = null!;

        public User User { get; set; } = null!;
        public ICollection<Class> Classes { get; set; } = new List<Class>();
    }
}
