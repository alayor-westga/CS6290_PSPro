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
        public void Save() 
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("SaveButton"))
                .AsButton()
                .Click();
        }
    }
}
