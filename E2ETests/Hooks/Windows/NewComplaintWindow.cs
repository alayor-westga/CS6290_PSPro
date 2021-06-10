using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Hooks.Windows
{
    public class NewComplaintWindow
    {
        private readonly AppHolder appHolder;
        public NewComplaintWindow(AppHolder appHolder) 
        {
            this.appHolder = appHolder;
        }

        public string GetUserFullName() 
        {
            return appHolder.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("SupervisorLabel"))
                .AsLabel()
                .Text;
        }
    }
}
