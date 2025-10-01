//using Attendance.DataAcess;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Security.Cryptography;

//namespace Attendance.Model
//{
//    public static class SeedData
//    {
//        public static void Initialize()
//        {
//            using (var db = new ApplicationDbContext())
//            {
//                if (db.Users.Any()) return; // لو فيه بيانات بالفعل ما يكررش

//                // ========== 1. Admin User ==========
//                PasswordHelper.CreatePasswordHash("Admin@123", out var adminHash, out var adminSalt);
//                var adminUser = new User
//                {
//                    Username = "admin1",
//                    PasswordHash = adminHash,
//                    PasswordSalt = adminSalt,
//                    FullName = "System Admin",
//                    Email = "admin1@system.com",
//                    Role = UserRole.Admin,
//                    IsActive = true,
//                    CreatedAt = DateTime.UtcNow
//                };
//                db.Users.Add(adminUser);

//                // ========== 2. Teacher User + Teacher ==========
//                PasswordHelper.CreatePasswordHash("Teacher@123", out var teacherHash, out var teacherSalt);
//                var teacherUser = new User
//                {
//                    Username = "teacher1",
//                    PasswordHash = teacherHash,
//                    PasswordSalt = teacherSalt,
//                    FullName = "System Teacher",
//                    Email = "teacher1@school.com",
//                    Role = UserRole.Teacher,
//                    IsActive = true,
//                    CreatedAt = DateTime.UtcNow
//                };
//                db.Users.Add(teacherUser);
//                db.SaveChanges(); // نحفظ عشان ناخد UserId

//                var teacher = new Teacher
//                {
//                    UserId = teacherUser.UserId,
//                    EmployeeNumber = "T-001"
//                };
//                db.Teachers.Add(teacher);

//                // ========== 3. Student User + Student ==========
//                PasswordHelper.CreatePasswordHash("Student@123", out var studentHash, out var studentSalt);
//                var studentUser = new User
//                {
//                    Username = "student1",
//                    PasswordHash = studentHash,
//                    PasswordSalt = studentSalt,
//                    FullName = "System Student",
//                    Email = "student1@student.com",
//                    Role = UserRole.Student,
//                    IsActive = true,
//                    CreatedAt = DateTime.UtcNow
//                };
//                db.Users.Add(studentUser);
//                db.SaveChanges();

//                var student = new Student
//                {
//                    UserId = studentUser.UserId,
//                    StudentNumber = "S-001",
//                    DOB = new DateTime(2005, 5, 20)
//                };
//                db.Students.Add(student);
//                db.SaveChanges();

//                // ========== 4. Class ==========
//                var mathClass = new Class
//                {
//                    Name = "Math Class A",
//                    Year = "2025",
//                    TeacherId = teacher.TeacherId
//                };
//                db.Classes.Add(mathClass);
//                db.SaveChanges();

//                // ========== 5. Enrollment ==========
//                var enrollment = new Enrollment
//                {
//                    StudentId = student.StudentId,
//                    ClassId = mathClass.ClassId,
//                    EnrolledAt = DateTime.UtcNow
//                };
//                db.Enrollments.Add(enrollment);
//                db.SaveChanges();

//                // ========== 6. Attendance Record ==========
//                var attendance = new AttendanceRecord
//                {
//                    StudentId = student.StudentId,
//                    ClassId = mathClass.ClassId,
//                    AttendanceDate = DateTime.Today,
//                    Status = AttendanceStatus.Present,
//                    Remarks = "On time",
//                    MarkedBy = teacherUser.UserId,
//                    MarkedAt = DateTime.UtcNow
//                };
//                db.AttendanceRecords.Add(attendance);

//                db.SaveChanges();
//            }
//        }
//    }
//}
