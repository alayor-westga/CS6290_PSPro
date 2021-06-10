using TechTalk.SpecFlow;
using FlaUI.Core.AutomationElements;
using E2ETests.Hooks;
using NUnit.Framework;
using System.Threading;

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
            appHolder.loginWindow.setUserName("");
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
            Thread.Sleep(2000);
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

        [Then(@"the title emessage ""(.*)"" is shown")]
        public void ThenTheTitleMessageIsShown(string message)
        {
            var window = appHolder.automation.GetDesktop()
                .FindFirstChild(cf => cf.ByProcessId(appHolder.app.ProcessId))
                .AsWindow();
            var titleMessage = window
                .FindFirstDescendant(cf => cf.ByAutomationId("SupervisorLabel"))
                .AsLabel()
                .Text;
            Assert.AreEqual(message, titleMessage);
        }
    }
}
