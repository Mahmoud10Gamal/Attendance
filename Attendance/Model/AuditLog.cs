using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    public class AuditLog
    {
        [Key]
        public int LogId { get; set; }
        public int? UserId { get; set; }

        public string Action { get; set; } = null!;
        public string Entity { get; set; } = null!;
        public int? EntityId { get; set; }
        public Guid? EntityGuid { get; set; }
        public string? Details { get; set; }

        public DateTime Timestamp { get; set; }
        public User? User { get; set; }
    }

}
