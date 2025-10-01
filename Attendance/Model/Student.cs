using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public string StudentNumber { get; set; } = null!;
        public DateTime? DOB { get; set; }

        public User User { get; set; } = null!;
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
    }
}
