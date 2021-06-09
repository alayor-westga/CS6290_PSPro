using TechTalk.SpecFlow;
using FlaUI.UIA2;
using FlaUI.Core.AutomationElements;
using E2ETests.Hooks;

namespace E2ETests.Steps
{
    [Binding]
    public class LoginFeatureSteps
    {
        private readonly AppHolder appHolder;

        public LoginFeatureSteps(AppHolder appHolder)
        {
            this.appHolder = appHolder;
        }

        [Given(@"username is empty")]
        public void GivenUsernameIsEmpty()
        {
            using (var automation = new UIA2Automation())
            {
                var window = appHolder.app.GetMainWindow(automation);
                var userNameTextBox = window.FindFirstDescendant(cf => cf.ByAutomationId("userNameTextBox")).AsTextBox();
                userNameTextBox?.Enter("Hello");
            }
        }
        
        [Given(@"password is empty")]
        public void GivenPasswordIsEmpty()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click on Login")]
        public void WhenClickOnLogin()
        {
            using (var automation = new UIA2Automation())
            {
                var window = appHolder.app.GetMainWindow(automation);
                var userNameTextBox = window.FindFirstDescendant(cf => cf.ByAutomationId("loginButton")).AsButton();
                userNameTextBox?.Click();
            }
        }
        
        [Then(@"the message ""(.*)"" is shown")]
        public void ThenTheMessageIsShown(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
