using TechTalk.SpecFlow;
using E2ETests.Hooks;

namespace E2ETests.Steps
{
    [Binding]
    public class AddNewComplaintSteps
    {
        private readonly Context context;

        public AddNewComplaintSteps(Context context)
        {
            this.context = context;
        }

        [When(@"click on Save")]
        public void WhenClickOnSave()
        {
            context.newComplaintWindow.Save();
        }
    }
}
