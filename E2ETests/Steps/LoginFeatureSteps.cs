using TechTalk.SpecFlow;
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
            context.loginWindow.EnterUserName("");
        }

        [Given(@"username is ""(.*)""")]
        public void GivenUsernameIs(string username)
        {
            context.loginWindow.EnterUserName(username);
        }

        [Given(@"password is empty")]
        public void GivenPasswordIsEmpty()
        {
            context.loginWindow.EnterPassword("");
        }

        [Given(@"password is ""(.*)""")]
        public void GivenPasswordIs(string password)
        {
            context.loginWindow.EnterPassword(password);
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

        [Then(@"the user full name ""(.*)"" is shown in the new complaint window")]
        public void ThenUserFullNameIsShownInTheNewComplaintWindow(string message)
        {
            var userFullName = context.newComplaintWindow.GetUserFullName();
            Assert.AreEqual(message, userFullName);
        }

        [Then(@"the user full name ""(.*)"" is shown in the investigator dashboard window")]
        public void ThenUserFullNameIsShownInTheInvestigatorDashboardWindow(string message)
        {
            var userFullName = context.investigatorDashboardWindow.GetUserFullName();
            Assert.AreEqual(message, userFullName);
        }

        [Then(@"the user full name ""(.*)"" is shown in the administrator dashboard window")]
        public void ThenUserFullNameIsShownInTheAdministratorDashboardWindow(string message)
        {
            var userFullName = context.administratorDashboardWindow.GetUserFullName();
            Assert.AreEqual(message, userFullName);
        }

        [Given(@"supervisor ""(.*)"" logs in with password ""(.*)""")]
        public void SupervisorLogsIn(string username, string password)
        {
            context.loginWindow.EnterUserName(username);
            context.loginWindow.EnterPassword(password);
            context.loginWindow.Login();
        }

        [When(@"investigator ""(.*)"" logs in with password ""(.*)""")]
        public void WhenInvestigatorLogsInWithPassword(string username, string password)
        {
            context.loginWindow.EnterUserName(username);
            context.loginWindow.EnterPassword(password);
            context.loginWindow.Login();
        }

        [Given(@"investigator ""(.*)"" logs in with password ""(.*)""")]
        public void GivenInvestigatorLogsInWithPassword(string username, string password)
        {
            context.loginWindow.EnterUserName(username);
            context.loginWindow.EnterPassword(password);
            context.loginWindow.Login();
        }


        [When(@"administrator ""(.*)"" logs in with password ""(.*)""")]
        public void WhenAdministratorLogsInWithPassword(string username, string password)
        {
            context.loginWindow.EnterUserName(username);
            context.loginWindow.EnterPassword(password);
            context.loginWindow.Login();
        }
    }
}
