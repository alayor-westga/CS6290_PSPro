using TechTalk.SpecFlow;
using FlaUI.Core.AutomationElements;
using E2ETests.Hooks;
using NUnit.Framework;

namespace E2ETests.Steps
{
    [Binding]
    public class LoginFeatureSteps
    {
        private readonly Context context;

        public LoginFeatureSteps(Context context)
        {
            this.context = context;
        }

        [Given(@"username is empty")]
        public void GivenUsernameIsEmpty()
        {
            context.loginWindow.SetUserName("");
        }

        [Given(@"username is ""(.*)""")]
        public void GivenUsernameIs(string username)
        {
            context.loginWindow.SetUserName(username);
        }
        
        [Given(@"password is empty")]
        public void GivenPasswordIsEmpty()
        {
            context.loginWindow.SetPassword("");
        }

        [Given(@"password is ""(.*)""")]
        public void GivenPasswordIs(string password)
        {
            context.loginWindow.SetPassword(password);
        }
        
        [When(@"click on Login")]
        public void WhenClickOnLogin()
        {
            context.loginWindow.Login();
        }
        
        [Then(@"the message ""(.*)"" is shown")]
        public void ThenTheMessageIsShown(string message)
        {
            var errorMessage = context.loginWindow.GetErrorMessageLabel();
            Assert.AreEqual(message, errorMessage);
        }

        [Then(@"the user full name ""(.*)"" is shown")]
        public void ThenTheTitleMessageIsShown(string message)
        {
            var userFullName = context.newComplaintWindow.GetUserFullName();
            Assert.AreEqual(message, userFullName);
        }

        [Given(@"supervisor ""(.*)"" logs in with password ""(.*)""")]
        public void SupervisorLogsIn(string username, string password)
        {
            context.loginWindow.SetUserName(username);
            context.loginWindow.SetPassword("");
            context.loginWindow.Login();
        }
    }
}
