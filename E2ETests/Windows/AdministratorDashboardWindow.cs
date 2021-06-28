using System.Collections.Generic;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System.Threading;

namespace E2ETests.Windows
{
    public class AdministratorDashboardWindow
    {
        private readonly Context context;
        public AdministratorDashboardWindow(Context context)
        {
            this.context = context;
        }

        public string GetUserFullName()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("userFullNameLabel"))
                .AsLabel()
                .Text;
        }

        public List<Dictionary<string, string>> GetComplaintsList()
        {
            List<Dictionary<string, string>> complaints = new List<Dictionary<string, string>>();
            DataGridViewRow[] rows = context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("complaintsDataGridView"))
                .AsDataGridView()
                .Rows;
            foreach (DataGridViewRow row in rows)
            {
                Dictionary<string, string> complaint = new Dictionary<string, string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    var nameRaw = cell.Name;
                    var name = nameRaw.Remove(nameRaw.IndexOf(row.Name) - 1);
                    complaint.Add(name, cell.Value);
                }
                complaints.Add(complaint);
            }
            return complaints;
        }

        public void ClicksOnManageComplaint()
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("manageComplaintButton"))
                .AsButton()
                .Click();
        }

        internal void SelectDiscipline(string discipline)
        {
            context.GetWindow()
               .FindFirstDescendant(cf => cf.ByAutomationId("disciplineComboBox"))
               .AsComboBox()
               .Select(discipline);
        }

        internal void ClickOnSave()
        {
            context.GetWindow()
               .FindFirstDescendant(cf => cf.ByAutomationId("saveButton"))
               .AsButton()
               .Click();
            Thread.Sleep(2000);
            Keyboard.Press(VirtualKeyShort.ENTER);
        }

        public string GetComplaintStatus()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("statusLabelValue"))
                .AsLabel()
                .Text;
        }

        internal void ClickOnSeeNotes()
        {
            context.GetWindow()
                           .FindFirstDescendant(cf => cf.ByAutomationId("seeNotesButton"))
                           .AsButton()
                           .Click();
            Thread.Sleep(2000);
            context.mustChangeWindow = true;
        }
    }
}
