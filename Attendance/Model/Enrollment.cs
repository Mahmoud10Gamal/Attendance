using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime EnrolledAt { get; set; }

        public Student Student { get; set; } = null!;
        public Class Class { get; set; } = null!;
    }
}
