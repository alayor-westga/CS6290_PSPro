using System;
using TechTalk.SpecFlow;
using System.IO;
using FlaUI.Core;
using FlaUI.UIA2;
using E2ETests.Hooks.Windows;

namespace E2ETests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private static string execPath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\PSPro\bin\Debug\", "PSPro.exe");

        [BeforeScenario]
        public static void BeforeTestRun(Context context)
        {
            context.app = Application.Launch(execPath);
            context.automation = new UIA2Automation();
            context.loginWindow = new LoginWindow(context);
            context.newComplaintWindow = new NewComplaintWindow(context);
        }

        [AfterScenario]
        public static void AfterTestRun(Context context)
        {
            context.app.Close();
            context.automation.Dispose();
        }
    }
}
