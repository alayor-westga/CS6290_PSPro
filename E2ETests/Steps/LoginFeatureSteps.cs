using TechTalk.SpecFlow;
using FlaUI.Core.AutomationElements;
using E2ETests.Hooks;
using NUnit.Framework;

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
                .Enter("");
        }

        [Given(@"username is ""(.*)""")]
        public void GivenUsernameIs(string username)
        {
            appHolder.window
                .FindFirstDescendant(cf => cf.ByAutomationId("userNameTextBox"))
                .AsTextBox()
                .Enter(username);
        }
        
        [Given(@"password is empty")]
        public void GivenPasswordIsEmpty()
        {
            appHolder.window
                .FindFirstDescendant(cf => cf.ByAutomationId("passwordTextBox"))
                .AsTextBox()
                .Enter("");
        }

        [Given(@"password is ""(.*)""")]
        public void GivenPasswordIs(string password)
        {
            appHolder.window
                .FindFirstDescendant(cf => cf.ByAutomationId("passwordTextBox"))
                .AsTextBox()
                .Enter(password);
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
        public void ThenTheMessageIsShown(string message)
        {
            var errorMessage = appHolder.window
                .FindFirstDescendant(cf => cf.ByAutomationId("errorMessageLabel"))
                .AsLabel()
                .Text;
            Assert.AreEqual(message, errorMessage);
        }
    }
}
