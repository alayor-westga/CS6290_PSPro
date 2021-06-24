using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;

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
            List<Dictionary<string, string>> complaints = context.investigatorDashboardWindow.GetComplaintsList();
            Assert.AreEqual(1, complaints.Count);
            var expectedComplaint = table.Rows[0];
            var actualComplaint = complaints[0];
            Assert.AreEqual(expectedComplaint[0], actualComplaint.GetValueOrDefault("Officer"));
            Assert.AreEqual(expectedComplaint[1], actualComplaint.GetValueOrDefault("Citizen"));
        }

        [When(@"administrator clicks on Manage Complaint")]
        public void WhenAdministratorClicksOnManageComplaint()
        {
            context.investigatorDashboardWindow.ClicksOnManageComplaint();
        }
    }
}
