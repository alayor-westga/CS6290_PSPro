﻿using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Hooks.Windows
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
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("userNameTextBox"))
                .AsTextBox()
                .Enter(username);
        }

        public void EnterPassword(string password) 
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("passwordTextBox"))
                .AsTextBox()
                .Enter(password);
        }

        public void Login() 
        {
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
