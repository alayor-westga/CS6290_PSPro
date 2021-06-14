using System;
using TechTalk.SpecFlow;
using System.IO;
using FlaUI.Core;
using FlaUI.UIA2;
using E2ETests.Model;
using E2ETests.Drivers;
using System.Data.SqlClient;

namespace E2ETests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private static string execPath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\PSPro\bin\Debug\", "PSPro.exe");

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            cleanUpDB();
        }

        [BeforeScenario]
        public static void BeforeScenario(Context context)
        {
            context.app = Application.Launch(execPath, "e2e_tests");
            context.automation = new UIA2Automation();
            context.loginWindow = new LoginWindow(context);
            context.newComplaintWindow = new NewComplaintWindow(context);
            context.investigatorDashboardWindow = new InvestigatorDashboardWindow(context);
            context.administratorDashboardWindow = new AdministratorDashboardWindow(context);
        }

        [AfterScenario]
        public static void AfterScenario(Context context)
        {
            context.app.Close();
            context.automation.Dispose();
            cleanUpDB();
        }

        private static void cleanUpDB()
        {
             using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                var query = "" + 
                "DELETE FROM Complaints;  DBCC CHECKIDENT ('Complaints', RESEED, 1);" +
                "DELETE FROM Supervisors; " +
                "DELETE FROM Investigators; " +
                "DELETE FROM Administrators; " +
                "DELETE FROM Officers; " +
                "DELETE FROM Personnel; DBCC CHECKIDENT ('Personnel', RESEED, 1);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
