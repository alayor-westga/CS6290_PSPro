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

         [Given(@"administrator clicks the See Notes button")]
        public void GivenAdministratorClicksTheSeeNotesButton()
        {
            context.administratorDashboardWindow.ClickOnSeeNotes();
        }

        //[Then(@"the current notes should contain ""(.*)""")]
        //public void ThenTheCurrentNotesShouldContain(string expectedNotes)
        //{
           // string actualNotes = context.complaintNotesWindow.GetNotes();
            //Assert.True(actualNotes.Contains(expectedNotes));
        //}

        [When(@"administrator adds the comment ""(.*)""")]
        public void WhenAdministratorAddsTheComment(string note)
        {
            context.complaintNotesWindow.AddNote(note);
        }

        [When(@"administrator saves the comment")]
        public void WhenAdministratorSavesTheComment()
        {
            context.complaintNotesWindow.ClickOnSave();
        }

        [When(@"admin selects officer ""(.*)""")]
        public void WhenAdminSelectsOfficer(string officer)
        {
            context.administratorDashboardWindow.SelectOfficer(officer);
        }

        [Then(@"administrator should see (.*) complaints")]
        public void ThenAdministratorShouldSeeComplaints(int complaintsNumber)
        {
            List<Dictionary<string, string>> complaintList = context.administratorDashboardWindow.GetComplaintsList();
            Assert.AreEqual(complaintsNumber, complaintList.Count);
        }

        [Then(@"administrator should see one complaint with this info")]
        public void ThenAdministratorShouldSeeOneComplaintWithThisInfo(Table table)
        {
            List<Dictionary<string, string>> complaintList = context.administratorDashboardWindow.GetComplaintsList();
            Assert.AreEqual(1, complaintList.Count);
            var expectedComplaint = table.Rows[0];
            Dictionary<string, string> actualComplaint = complaintList[0];
            Assert.AreEqual(expectedComplaint[0], actualComplaint.GetValueOrDefault("Officer"));
            Assert.AreEqual(expectedComplaint[1], actualComplaint.GetValueOrDefault("Allegation"));
        }
    }
}
