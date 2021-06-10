using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Hooks.Windows
{
    public class LoginWindow
    {
        private readonly AppHolder appHolder;
        public LoginWindow(AppHolder appHolder) 
        {
            this.appHolder = appHolder;
        }

        public void SetUserName(string username) 
        {
            appHolder.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("userNameTextBox"))
                .AsTextBox()
                .Enter(username);
        }

        public void SetPassword(string password) 
        {
            appHolder.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("passwordTextBox"))
                .AsTextBox()
                .Enter(password);
        }

        public void Login() 
        {
            appHolder.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("loginButton"))
                .AsButton()
                .Click();
            Thread.Sleep(2000);
            appHolder.mustChangeWindow = true;
        }

        public string GetErrorMessageLabel() 
        {
            return appHolder.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("errorMessageLabel"))
                .AsLabel()
                .Text;
        }
    }
}
