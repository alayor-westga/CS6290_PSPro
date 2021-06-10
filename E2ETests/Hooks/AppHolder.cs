using FlaUI.UIA2;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using E2ETests.Hooks.Windows;

namespace E2ETests.Hooks
{
    public class AppHolder
    {
        public Application app { get; set; }
        public UIA2Automation automation { get; set; }
        public Window window { get; set; }

        public LoginWindow loginWindow { get; set; }
    }
}
