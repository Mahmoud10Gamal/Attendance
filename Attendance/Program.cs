using Attendance.Model;

namespace Attendance
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //try
            //{
                //SeedData.Initialize();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Database seeding failed: " + ex.Message);
            //}
            Application.Run(new login());
        }
    }
}