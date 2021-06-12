using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Hooks.Windows
{
    public class NewComplaintWindow
    {
        private readonly Context context;
        public NewComplaintWindow(Context context) 
        {
            this.context = context;
        }

        public string GetUserFullName() 
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("SupervisorLabel"))
                .AsLabel()
                .Text;
        }
        public string GetFirstNameErrorLabel() 
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("firstNameErrorLabel"))
                .AsLabel()
                .Text;
        }
        public string GetOfficerErrorLabel() 
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("officerErrorLabel"))
                .AsLabel()
                .Text;
        }
        public string GetAllegationErrorLabel() 
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("allegationErrorLabel"))
                .AsLabel()
                .Text;
        }
        public string GetComplaintSummaryErrorLabel() 
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("complaintSummaryErrorLabel"))
                .AsLabel()
                .Text;
        }
        public void SetCitizenFirstName(string firstName) 
        {
               context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("firstNameTextBox"))
                .AsTextBox()
                .Enter(firstName);
        }
        public void Save() 
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("SaveButton"))
                .AsButton()
                .Click();
        }
    }
}
