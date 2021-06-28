using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Data.SqlClient;
using E2ETests.Drivers;

namespace E2ETests.Steps
{
    [Binding]
    public class ManageComplaintAsAdministratorSteps
    {
        private readonly Context context;

        public ManageComplaintAsAdministratorSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"administrator should see a complaint with this info")]
        public void ThenAdministratorShouldSeeAComplaintWithThisInfo(Table table)
        {
            List<Dictionary<string, string>> complaints = context.administratorDashboardWindow.GetComplaintsList();
            Assert.AreEqual(1, complaints.Count);
            var expectedComplaint = table.Rows[0];
            var actualComplaint = complaints[0];
            Assert.AreEqual(expectedComplaint[0], actualComplaint.GetValueOrDefault("Officer"));
            Assert.AreEqual(expectedComplaint[1], actualComplaint.GetValueOrDefault("Citizen"));
        }

        [When(@"administrator clicks on Manage Complaint")]
        public void WhenAdministratorClicksOnManageComplaint()
        {
            context.administratorDashboardWindow.ClicksOnManageComplaint();
        }

        [Given(@"administrator clicks on Manage Complaint")]
        public void GivenAdministratorClicksOnManageComplaint()
        {
            context.administratorDashboardWindow.ClicksOnManageComplaint();
        }

        [Given(@"administrator selects the discipline ""(.*)""")]
        public void GivenAdministratorSelectsTheDiscipline(string discipline)
        {
            context.administratorDashboardWindow.SelectDiscipline (discipline);
        }

        [When(@"administrator saves the complaint changes")]
        public void WhenInvestigatorSavesTheComplaintChanges()
        {
            context.administratorDashboardWindow.ClickOnSave();
        }

        [Then(@"the complaint discipline should be updated to ""(.*)"" in the DB")]
        public void ThenTheComplaintDisciplineShouldBeUpdatedToInTheDB(string expectedDiscipline)
        {
            Dictionary<string, string> complaint = GetComplaintFromDB();
            Assert.AreEqual(expectedDiscipline, complaint.GetValueOrDefault("discipline"));
        }

        private Dictionary<string, string> GetComplaintFromDB()
        {
            Dictionary<string, string> discipline = new Dictionary<string, string>();
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                var query = "SELECT discipline, complaint_notes from Complaints;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            discipline.Add("discipline", reader["discipline"].ToString());
                            discipline.Add("complaint_notes", reader["complaint_notes"].ToString());
                        }
                    }
                }
            }
            return discipline;
        }
    }
}
