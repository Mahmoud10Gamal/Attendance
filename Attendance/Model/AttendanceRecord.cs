using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    public enum AttendanceStatus : byte
    {
        Absent = 0,
        Present = 1,
        Late = 2,
        Excused = 3
    }

    public class AttendanceRecord
    {
        [Key]
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public AttendanceStatus Status { get; set; }
        public string? Remarks { get; set; }
        public int? MarkedBy { get; set; }
        public DateTime MarkedAt { get; set; }

        public Student Student { get; set; } = null!;
        public Class Class { get; set; } = null!;
        public User? Marker { get; set; }
    }
}
