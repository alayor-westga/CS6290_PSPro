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
            appHolder.loginWindow.SetUserName("");
        }

        [Given(@"username is ""(.*)""")]
        public void GivenUsernameIs(string username)
        {
            appHolder.loginWindow.SetUserName(username);
        }
        
        [Given(@"password is empty")]
        public void GivenPasswordIsEmpty()
        {
            appHolder.loginWindow.SetPassword("");
        }

        [Given(@"password is ""(.*)""")]
        public void GivenPasswordIs(string password)
        {
            appHolder.loginWindow.SetPassword(password);
        }
        
        [When(@"click on Login")]
        public void WhenClickOnLogin()
        {
            appHolder.loginWindow.Login();
        }
        
        [Then(@"the message ""(.*)"" is shown")]
        public void ThenTheMessageIsShown(string message)
        {
            var errorMessage = appHolder.loginWindow.GetErrorMessageLabel();
            Assert.AreEqual(message, errorMessage);
        }

        [Then(@"the user full name ""(.*)"" is shown")]
        public void ThenTheTitleMessageIsShown(string message)
        {
            var userFullName = appHolder.newComplaintWindow.GetUserFullName();
            Assert.AreEqual(message, userFullName);
        }
    }
}
