using Attendance.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.DataAcess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; } = null!;
        public DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public DbSet<Backup> Backups { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            {
                optionsBuilder.UseSqlServer("Data Source=RuwainyDell\\MSSQLSERVER02;Initial Catalog=AttendanceSystem;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User -> Teacher (1:1)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Teacher)
                .WithOne(t => t.User)
                .HasForeignKey<Teacher>(t => t.UserId);

            // User -> Student (1:1)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Student)
                .WithOne(s => s.User)
                .HasForeignKey<Student>(s => s.UserId);

            // User -> AttendanceRecords (MarkedBy) (1:∞)
            modelBuilder.Entity<User>()
                .HasMany(u => u.MarkedAttendanceRecords)
                .WithOne(a => a.Marker)
                .HasForeignKey(a => a.MarkedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // User -> AuditLogs (1:∞)
            modelBuilder.Entity<User>()
                .HasMany(u => u.AuditLogs)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            // Teacher -> Classes (1:∞)
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Classes)
                .WithOne(c => c.Teacher)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            // Student -> Enrollments (1:∞)
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);

            // Class -> Enrollments (1:∞)
            modelBuilder.Entity<Class>()
                .HasMany(c => c.Enrollments)
                .WithOne(e => e.Class)
                .HasForeignKey(e => e.ClassId);

            // Student -> AttendanceRecords (1:∞)
            modelBuilder.Entity<Student>()
                .HasMany(s => s.AttendanceRecords)
                .WithOne(a => a.Student)
                .HasForeignKey(a => a.StudentId);

            // Class -> AttendanceRecords (1:∞)
            modelBuilder.Entity<Class>()
                .HasMany(c => c.AttendanceRecords)
                .WithOne(a => a.Class)
                .HasForeignKey(a => a.ClassId);

            // Backup -> User (اختياري)
            modelBuilder.Entity<Backup>()
                .HasOne(b => b.User)
                .WithMany()
                .HasForeignKey(b => b.PerformedBy)
                .OnDelete(DeleteBehavior.SetNull);

            // Unique index: طالب مايتسجلش مرتين في نفس الكلاس
            modelBuilder.Entity<Enrollment>()
                .HasIndex(e => new { e.StudentId, e.ClassId })
                .IsUnique();

            // قيود إضافية (طول الحقول)
            modelBuilder.Entity<User>().Property(u => u.Username).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Email).HasMaxLength(100);

            modelBuilder.Entity<Teacher>().Property(t => t.EmployeeNumber).HasMaxLength(50);
            modelBuilder.Entity<Student>().Property(s => s.StudentNumber).HasMaxLength(50);

            modelBuilder.Entity<Class>().Property(c => c.Name).HasMaxLength(50);
            modelBuilder.Entity<Class>().Property(c => c.Year).HasMaxLength(20);

            modelBuilder.Entity<AuditLog>().Property(l => l.Action).HasMaxLength(100);
            modelBuilder.Entity<AuditLog>().Property(l => l.Entity).HasMaxLength(100);

            modelBuilder.Entity<Backup>().Property(b => b.FilePath).HasMaxLength(255);
            modelBuilder.Entity<Backup>().Property(b => b.BackupType).HasMaxLength(50);
        }
    }
}
