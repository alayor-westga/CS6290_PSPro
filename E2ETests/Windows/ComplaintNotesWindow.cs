using System.Collections.Generic;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System.Threading;

namespace E2ETests.Windows
{
    public class ComplaintNotesWindow
    {
        private readonly Context context;
        public ComplaintNotesWindow(Context context)
        {
            this.context = context;
        }

        public string GetNotes()
        {
         return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("notesTextBox"))
                .AsTextBox()
                .Text;
        }
    }
}