using System;
using System.IO;
using FlaUI.UIA2;

namespace E2ETests
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "PSPro.exe";
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\PSPro\bin\Debug\", fileName);
            var app = FlaUI.Core.Application.Launch(path);
            using (var automation = new UIA2Automation())
            {
                var window = app.GetMainWindow(automation);
                var loginButton = window.FindFirstDescendant(cf => cf.ByText("Login"));
                loginButton?.Click();
            }
            app.Close();
        }
    }
}
