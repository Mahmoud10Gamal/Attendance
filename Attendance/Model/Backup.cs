using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Model
{
    public enum BackupType
    {
        Full,
        Differential,
        Log
    }

    public class Backup
    {
        public int BackupId { get; set; }
        public DateTime BackupDate { get; set; }
        public string FilePath { get; set; } = null!;    // مكان الباك أب على السيرفر/الهارد
        public BackupType BackupType { get; set; }      // نوع الباك أب
        public long? SizeBytes { get; set; }            // حجم الباك أب بالبايت

        public int? PerformedBy { get; set; }           // مين عمل الباك أب
        public User? User { get; set; }
    }
}
