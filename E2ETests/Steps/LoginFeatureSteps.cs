using TechTalk.SpecFlow;
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
            appHolder.window
                .FindFirstDescendant(cf => cf.ByAutomationId("userNameTextBox"))
                .AsTextBox()
                .Enter("Hello");
        }
        
        [Given(@"password is empty")]
        public void GivenPasswordIsEmpty()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click on Login")]
        public void WhenClickOnLogin()
        {
            appHolder.window
                .FindFirstDescendant(cf => cf.ByAutomationId("loginButton"))
                .AsButton()
                .Click();
        }
        
        [Then(@"the message ""(.*)"" is shown")]
        public void ThenTheMessageIsShown(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
