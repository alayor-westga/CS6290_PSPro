using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Hooks.Windows
{
    public class LoginWindow
    {
        private readonly Window window;
        public LoginWindow(Window window) 
        {
            this.window = window;
        }

        public void SetUserName(string username) 
        {
            window
                .FindFirstDescendant(cf => cf.ByAutomationId("userNameTextBox"))
                .AsTextBox()
                .Enter(username);
        }

        public void SetPassword(string password) 
        {
            window
                .FindFirstDescendant(cf => cf.ByAutomationId("passwordTextBox"))
                .AsTextBox()
                .Enter(password);
        }

        public void Login() 
        {
            window
                .FindFirstDescendant(cf => cf.ByAutomationId("loginButton"))
                .AsButton()
                .Click();
            Thread.Sleep(2000);
        }

        public string GetErrorMessageLabel() 
        {
            return window
                .FindFirstDescendant(cf => cf.ByAutomationId("errorMessageLabel"))
                .AsLabel()
                .Text;
        }
    }
}
