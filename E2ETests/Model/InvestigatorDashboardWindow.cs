using System.Collections.Generic;
using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Model
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
    }
}
