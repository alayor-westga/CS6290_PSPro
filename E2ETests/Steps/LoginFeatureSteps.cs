using System;
using TechTalk.SpecFlow;
using FlaUI.UIA2;
using System.IO;

namespace E2ETests.Steps
{
    [Binding]
    public class LoginFeatureSteps
    {
        [Given(@"username is empty")]
        public void GivenUsernameIsEmpty()
        {
            string fileName = "PSPro.exe";
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\PSPro\bin\Debug\", fileName);
            var app = FlaUI.Core.Application.Launch(path);
            using (var automation = new UIA2Automation())
            {
                var window = app.GetMainWindow(automation);
                var loginButton = window.FindFirstDescendant(cf => cf.ByText("Login"));
                loginButton?.Click();
            }
            app.Close();
        }
        
        [Given(@"password is empty")]
        public void GivenPasswordIsEmpty()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click on Login")]
        public void WhenClickOnLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the message ""(.*)"" is shown")]
        public void ThenTheMessageIsShown(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
