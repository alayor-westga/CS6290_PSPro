using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Data.SqlClient;
using E2ETests.Drivers;
using E2ETests.Windows;

namespace E2ETests.Steps
{
    [Binding]
    public class ManageComplaintAsInvestigatorSteps
    {
        private readonly Context context;

        public ManageComplaintAsInvestigatorSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"investigator should see a complaint with this info")]
        public void ThenInvestigatorShouldSeeAComplaintWithThisInfo(Table table)
        {
            List<Dictionary<string, string>> complaints = context.investigatorDashboardWindow.GetComplaintsList();
            Assert.AreEqual(1, complaints.Count);
            var expectedComplaint = table.Rows[0];
            var actualComplaint = complaints[0];
            Assert.AreEqual(expectedComplaint[0], actualComplaint.GetValueOrDefault("Officer"));
            Assert.AreEqual(expectedComplaint[1], actualComplaint.GetValueOrDefault("Citizen"));
            Assert.AreEqual(expectedComplaint[2], actualComplaint.GetValueOrDefault("Allegation"));
        }

        [When(@"investigator clicks on Manage Complaint")]
        public void WhenInvestigatorClicksOnManageComplaint()
        {
            context.investigatorDashboardWindow.ClicksOnManageComplaint();
        }

        [Given(@"investigator clicks on Manage Complaint")]
        public void GivenInvestigatorClicksOnManageComplaint()
        {
            context.investigatorDashboardWindow.ClicksOnManageComplaint();
        }

        [Given(@"investigator selects the disposition ""(.*)""")]
        public void GivenInvestigatorSelectsTheDisposition(string disposition)
        {
            context.investigatorDashboardWindow.SelectDisposition(disposition);
        }

        [When(@"investigator saves the complaint changes")]
        public void WhenInvestigatorSavesTheComplaintChanges()
        {
            context.investigatorDashboardWindow.ClickOnSave();
        }

        [Given(@"investigator saves the complaint changes")]
        public void GivenInvestigatorSavesTheComplaintChanges()
        {
            context.investigatorDashboardWindow.ClickOnSave();
        }

        [Then(@"the complaint disposition should be updated to ""(.*)"" in the DB")]
        public void ThenTheComplaintDispositionShouldBeUpdatedToInTheDB(string expectedDisposition)
        {
            Dictionary<string, string> complaint = GetComplaintFromDB();
            Assert.AreEqual(expectedDisposition, complaint.GetValueOrDefault("disposition"));
        }

        private Dictionary<string, string> GetComplaintFromDB()
        {
            Dictionary<string, string> disposition = new Dictionary<string, string>();
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                var query = "SELECT disposition, complaint_notes from Complaints;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            disposition.Add("disposition", reader["disposition"].ToString());
                            disposition.Add("complaint_notes", reader["complaint_notes"].ToString());
                        }
                    }
                }
            }
            return disposition;
        }

        [Given(@"investigator clicks the See Notes button")]
        public void GivenInvestigatorClicksTheSeeNotesButton()
        {
            context.investigatorDashboardWindow.ClickOnSeeNotes();
        }

        [Then(@"the current notes should contain ""(.*)""")]
        public void ThenTheCurrentNotesShouldContain(string expectedNotes)
        {
            string actualNotes = context.complaintNotesWindow.GetNotes();
            Assert.True(actualNotes.Contains(expectedNotes));
        }

        [When(@"investigator adds the comment ""(.*)""")]
        public void WhenInvestigatorAddsTheComment(string note)
        {
            context.complaintNotesWindow.AddNote(note);
        }

        [When(@"investigator saves the comment")]
        public void WhenInvestigatorSavesTheComment()
        {
            context.complaintNotesWindow.ClickOnSave();
        }

        [Then(@"the complaint notes should contain ""(.*)"" in the DB")]
        public void ThenTheComplaintNotesShouldContainInTheDB(string expectedNote)
        {
            Dictionary<string, string> complaint = GetComplaintFromDB();
            Assert.True(complaint.GetValueOrDefault("complaint_notes").Contains(expectedNote));
        }

        [Then(@"investigator should see (.*) complaints")]
        public void ThenInvestigatorShouldSeeComplaints(int complaintsNumber)
        {
            List<Dictionary<string, string>> complaintList = context.investigatorDashboardWindow.GetComplaintsList();
            Assert.AreEqual(complaintsNumber, complaintList.Count);
        }

        [When(@"selects officer ""(.*)""")]
        public void WhenSelectsOfficer(string officer)
        {
            context.investigatorDashboardWindow.SelectOfficer(officer);
        }

        [Then(@"investigator should see one complaint with this info")]
        public void ThenInvestigatorShouldSeeOneComplaintWithThisInfo(Table table)
        {
            List<Dictionary<string, string>> complaintList = context.investigatorDashboardWindow.GetComplaintsList();
            Assert.AreEqual(1, complaintList.Count);
            var expectedComplaint = table.Rows[0];
            Dictionary<string, string> actualComplaint = complaintList[0];
            Assert.AreEqual(expectedComplaint[0], actualComplaint.GetValueOrDefault("Officer"));
            Assert.AreEqual(expectedComplaint[1], actualComplaint.GetValueOrDefault("Allegation"));
        }

        [When(@"investigator selects closed complaints")]
        public void WhenInvestigatorSelectsClosedComplaints()
        {
            context.investigatorDashboardWindow.SelectStatus(StatusFilter.Closed);
        }

    }
}
