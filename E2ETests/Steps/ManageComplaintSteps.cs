using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace E2ETests.Steps
{
    [Binding]
    public class ManageComplaintSteps
    {
        private readonly Context context;

        public ManageComplaintSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"the complaint status should be ""(.*)""")]
        public void ThenTheComplaintStatusShouldBe(string expectedStatus)
        {
            string actualStatus = context.administratorDashboardWindow.GetComplaintStatus();
            Assert.AreEqual(expectedStatus, actualStatus);
        }
    }
}