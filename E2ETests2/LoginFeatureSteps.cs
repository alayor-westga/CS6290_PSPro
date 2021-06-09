using System;
using TechTalk.SpecFlow;

namespace E2ETests2
{
    [Binding]
    public class LoginFeatureSteps
    {
        [Given(@"username is empty")]
        public void GivenUsernameIsEmpty()
        {
            ScenarioContext.Current.Pending();
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
