using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.IO;
using FlaUI.Core;

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
        }

        [AfterScenario]
        public static void AfterTestRun(AppHolder appHolder)
        {
            appHolder.app.Close();
        }
    }
}
