using FlaUI.UIA2;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using E2ETests.Model;

namespace E2ETests
{
    public class Context
    {
        public bool mustChangeWindow { get; set; }
        public Application app { get; set; }
        public UIA2Automation automation { get; set; }
        private Window window { get; set; }

        public LoginWindow loginWindow { get; set; }
        public NewComplaintWindow newComplaintWindow { get; set; }
        public InvestigatorDashboardWindow investigatorDashboardWindow { get; set; }
        public AdministratorDashboardWindow administratorDashboardWindow { get; set; }

        public Window GetWindow()
        {
            if (window == null) {
                window = app.GetMainWindow(automation);
            }
            if (mustChangeWindow) 
            {
                window = automation.GetDesktop()
                    .FindFirstChild(cf => cf.ByProcessId(app.ProcessId))
                    .AsWindow();
                mustChangeWindow = false;
            }
            return window;
        }
    }
}
