using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;

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

        [When(@"administrator clicks on Manage Complaint")]
        public void WhenAdministratorClicksOnManageComplaint()
        {
             context.investigatorDashboardWindow.ClicksOnManageComplaint();
        }
    }
}
