using System.Collections.Generic;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System.Threading;

namespace E2ETests.Windows
{
    public class InvestigatorDashboardWindow
    {
        private readonly Context context;
        public InvestigatorDashboardWindow(Context context)
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

        public string GetComplaintStatus()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("statusLabelValue"))
                .AsLabel()
                .Text;
        }

        public void SelectDisposition(string disposition)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("dispositionComboBox"))
                .AsComboBox()
                .Select(disposition);
        }

        public void ClickOnSave()
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("saveButton"))
                .AsButton()
                .Click();
            Thread.Sleep(2000);
            Keyboard.Press(VirtualKeyShort.ENTER);
        }

        public void ClickOnSeeNotes()
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
