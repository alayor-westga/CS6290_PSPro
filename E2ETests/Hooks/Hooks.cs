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
        public static void BeforeTestRun(AppHolder appHolder)
        {
            appHolder.app = Application.Launch(execPath);
            appHolder.automation = new UIA2Automation();
            appHolder.window = appHolder.app.GetMainWindow(appHolder.automation);
            appHolder.loginWindow = new LoginWindow(appHolder.window);
        }

        [AfterScenario]
        public static void AfterTestRun(AppHolder appHolder)
        {
            appHolder.app.Close();
            appHolder.automation.Dispose();
        }
    }
}
