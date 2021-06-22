using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System;
using System.Threading;

namespace E2ETests.Windows
{
    public class CitizenWindow
    {
        private readonly Context context;
        public CitizenWindow(Context context)
        {
            this.context = context;
        }


        public void EnterCitizenFirstName(string firstName)
        {
            this.setCitizenField("firstNameTextBox",firstName);
            Thread.Sleep(2000);
        }

        public void ClickSearchCitizen()
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("SearchCitizenButton"))
                .AsButton()
                .Click();
            Thread.Sleep(2000);
        }

        public void ClickOnLogout()
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("LogoutLinkLabel"))
                .AsButton()
                .Click();
            Thread.Sleep(2000);
            context.mustChangeWindow = true;
        }

        private void setCitizenField(string fieldName, string value)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId(fieldName))
                .AsTextBox()
                .Enter(value);
        }
    }
}
