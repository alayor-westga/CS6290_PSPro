    using FlaUI.Core.AutomationElements;

namespace E2ETests.Hooks.Windows
{
    public class LoginWindow
    {
        private readonly Window window;
        public LoginWindow(Window window) 
        {
            this.window = window;
        }

        public void setUserName(string username) 
        {
            window
                .FindFirstDescendant(cf => cf.ByAutomationId("userNameTextBox"))
                .AsTextBox()
                .Enter(username);
        }
    }
}
