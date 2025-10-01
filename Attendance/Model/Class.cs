using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    public class Class
    {
        public int ClassId { get; set; }
        public string Name { get; set; } = null!;
        public string Year { get; set; } = null!;
        public int? TeacherId { get; set; }

        public Teacher? Teacher { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
    }
}
