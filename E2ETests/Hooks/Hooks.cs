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
            appHolder.app = Application.Launch(execPath, "e2e_tests");
            appHolder.automation = new UIA2Automation();
            appHolder.loginWindow = new LoginWindow(appHolder);
            appHolder.newComplaintWindow = new NewComplaintWindow(appHolder);
        }

        [AfterScenario]
        public static void AfterTestRun(AppHolder appHolder)
        {
            appHolder.app.Close();
            appHolder.automation.Dispose();
        }
    }
}
