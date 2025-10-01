using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    public enum UserRole : byte
    {
        Admin = 1,
        Teacher = 2,
        Student = 3
    }
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public Teacher? Teacher { get; set; }
        public Student? Student { get; set; }

        public ICollection<AttendanceRecord> MarkedAttendanceRecords { get; set; } = new List<AttendanceRecord>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
    }
}
