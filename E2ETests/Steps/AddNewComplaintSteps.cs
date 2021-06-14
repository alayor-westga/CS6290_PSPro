using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Data.SqlClient;
using E2ETests.Drivers;

namespace E2ETests.Steps
{
    [Binding]
    public class AddNewComplaintSteps
    {
        private readonly Context context;

        public AddNewComplaintSteps(Context context)
        {
            this.context = context;
        }

        [When(@"click on save")]
        public void WhenClickOnSave()
        {
            context.newComplaintWindow.ClickOnSave();
        }

        [Then(@"the first name field is labeled as required")]
        public void TheFirstNameFieldIsLabeledAsRequired()
        {
            var errorLabel = context.newComplaintWindow.GetFirstNameErrorLabel();
            Assert.AreEqual(errorLabel, "Required Field");
        }

        [Then(@"the officer field is labeled as required")]
        public void TheOfficerFieldIsLabeledAsRequired()
        {
            var errorLabel = context.newComplaintWindow.GetOfficerErrorLabel();
            Assert.AreEqual(errorLabel, "Select a Name From the Dropdown");
        }

        [Then(@"the allegation field is labeled as required")]
        public void TheAllegatiorFieldIsLabeledAsRequired()
        {
            var errorLabel = context.newComplaintWindow.GetAllegationErrorLabel();
            Assert.AreEqual(errorLabel, "Required Field");
        }

        [Then(@"the complaint summary field is labeled as required")]
        public void TheComplaintSummaryFieldIsLabeledAsRequired()
        {
            var errorLabel = context.newComplaintWindow.GetComplaintSummaryErrorLabel();
            Assert.AreEqual(errorLabel, "Required Field");
        }

        [Given(@"this citizen info is entered")]
        public void GivenThisCitizenInfoIsEntered(Table table)
        {
            var citizenRaw = table.Rows[0];
            context.newComplaintWindow.EnterCitizenFirstName(citizenRaw[0]);
            context.newComplaintWindow.EnterCitizenLastName(citizenRaw[1]);
            context.newComplaintWindow.EnterCitizenAddress1(citizenRaw[2]);
            context.newComplaintWindow.EnterCitizenAddress2(citizenRaw[3]);
            context.newComplaintWindow.EnterCitizenCity(citizenRaw[4]);
            context.newComplaintWindow.SelectCitizenState(citizenRaw[5]);
            context.newComplaintWindow.EnterCitizenZipCode(citizenRaw[6]);
            context.newComplaintWindow.EnterCitizenPhoneNumber(citizenRaw[7]);
            context.newComplaintWindow.EnterCitizenEmailAddress(citizenRaw[8]);
        }

        [Given(@"the officer ""(.*)"" is selected")]
        public void GivenTheOfficerIsSelected(string officer)
        {
            context.newComplaintWindow.SelectOfficer(officer);
        }

        [Given(@"the allegation ""(.*)"" is selected")]
        public void GivenTheAllegationIsSelected(string allegation)
        {
            context.newComplaintWindow.SelectAllegation(allegation);
        }

        [Given(@"the complaint summary is ""(.*)""")]
        public void GivenTheComplaintSummaryIs(string complaintSummary)
        {
            context.newComplaintWindow.EnterComplaintSummary(complaintSummary);
        }

        [Then(@"the complaint should be saved with this content")]
        public void ThenTheComplaintShouldBeSavedWithThisContent(Table table)
        {
            var expectedComplaint = table.Rows[0];
            Dictionary<string, string> complaint = GetComplaint();
            Assert.AreEqual(expectedComplaint[0], complaint.GetValueOrDefault("supervisor_name"));
            Assert.AreEqual(expectedComplaint[1], complaint.GetValueOrDefault("citizen_name"));
            Assert.AreEqual(expectedComplaint[2], complaint.GetValueOrDefault("officer_name"));
            Assert.AreEqual(expectedComplaint[3], complaint.GetValueOrDefault("allegation_type"));
            Assert.True(complaint.GetValueOrDefault("complaint_notes").Contains(expectedComplaint[4]));
        }

        private Dictionary<string, string> GetComplaint()
        {
            Dictionary<string, string> complaint = new Dictionary<string, string>();
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                var query = "" +
                " SELECT " +
                "   CONCAT(s.first_name, ' ', s.last_name) AS supervisor_name, " +
                "   CONCAT(ci.first_name, ' ', ci.last_name) AS citizen_name, " +
                "   CONCAT(o.first_name, ' ', o.last_name) AS officer_name, " +
                "   co.allegation_type, " +
                "   co.complaint_notes " +
                " FROM Complaints co" +
                "   INNER JOIN Personnel s ON (s.personnel_id = co.supervisors_personnel_id)" +
                "   INNER JOIN Citizens ci ON (ci.citizen_id = co.citizen_id)" +
                "   INNER JOIN Personnel o ON (o.personnel_id = co.officers_personnel_id);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            complaint.Add("supervisor_name", reader["supervisor_name"].ToString());
                            complaint.Add("citizen_name", reader["citizen_name"].ToString());
                            complaint.Add("officer_name", reader["officer_name"].ToString());
                            complaint.Add("allegation_type", reader["allegation_type"].ToString());
                            complaint.Add("complaint_notes", reader["complaint_notes"].ToString());
                        }
                    }
                }
            }
            return complaint;
        }

        [Given(@"a complaint with this info is created")]
        public void GivenAComplaintWithThisInfoIsCreated(Table table)
        {
            var complaintToAdd = table.Rows[0];
            context.newComplaintWindow.EnterCitizenFirstName(complaintToAdd[0]);
            context.newComplaintWindow.EnterCitizenLastName(complaintToAdd[1]);
            context.newComplaintWindow.EnterCitizenAddress1(complaintToAdd[2]);
            context.newComplaintWindow.EnterCitizenAddress2(complaintToAdd[3]);
            context.newComplaintWindow.EnterCitizenCity(complaintToAdd[4]);
            context.newComplaintWindow.SelectCitizenState(complaintToAdd[5]);
            context.newComplaintWindow.EnterCitizenZipCode(complaintToAdd[6]);
            context.newComplaintWindow.EnterCitizenPhoneNumber(complaintToAdd[7]);
            context.newComplaintWindow.EnterCitizenEmailAddress(complaintToAdd[8]);
            context.newComplaintWindow.SelectOfficer(complaintToAdd[9]);
            context.newComplaintWindow.SelectAllegation(complaintToAdd[10]);
            context.newComplaintWindow.EnterComplaintSummary(complaintToAdd[11]);
            context.newComplaintWindow.ClickOnSave();
        }

        [Given(@"the user logs out")]
        public void GivenTheUserLogsOut()
        {
            context.newComplaintWindow.ClickOnLogout();
        }


    }
}
