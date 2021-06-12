using System;
using TechTalk.SpecFlow;

namespace E2ETests.Steps
{
    [Binding]
    public class DBSupportSteps
    {
        [Given(@"supervisor with username ""(.*)"" and password ""(.*)"" exists on the DB")]
        public void GivenSupervisorWithUsernameAndPasswordExistsOnTheDB(string username, int password)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"investigator with username ""(.*)"" and password ""(.*)"" exists on the DB")]
        public void GivenInvestigatorWithUsernameAndPasswordExistsOnTheDB(string username, int password)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"administrator with username ""(.*)"" and password ""(.*)"" exists on the DB")]
        public void GivenAdministratorWithUsernameAndPasswordExistsOnTheDB(string username, int password)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
