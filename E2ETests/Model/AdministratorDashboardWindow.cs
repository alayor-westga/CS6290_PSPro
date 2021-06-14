using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Model
{
    public class AdministratorDashboardWindow
    {
        private readonly Context context;
        public AdministratorDashboardWindow(Context context)
        {
            this.context = context;
        }

        public string GetUserFullName()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("userFullNameLabel"))
                .AsLabel()
                .Text;
        }
    }
}
