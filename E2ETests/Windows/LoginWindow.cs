using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Windows
{
    public class LoginWindow
    {
        private readonly Context context;
        public LoginWindow(Context context) 
        {
            this.context = context;
        }

        public void EnterUserName(string username) 
        {
            Thread.Sleep(1000);
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("userNameTextBox"))
                .AsTextBox()
                .Enter(username);
        }

        public void EnterPassword(string password) 
        {
            Thread.Sleep(1000);
            context.GetWindow()
              
                .FindFirstDescendant(cf => cf.ByAutomationId("passwordTextBox"))
                .AsTextBox()
                .Enter(password);
            Thread.Sleep(2000);
        }

        public void Login() 
        {
            Thread.Sleep(1000);
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("loginButton"))
                .AsButton()
                .Click();
            Thread.Sleep(2000);
            context.mustChangeWindow = true;
        }

        public string GetErrorMessageLabel() 
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("errorMessageLabel"))
                .AsLabel()
                .Text;
        }
    }
}
