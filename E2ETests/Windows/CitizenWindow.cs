using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System;
using System.Threading;

namespace E2ETests.Windows
{
    public class CitizenWindow
    {
        private readonly Context context;
        public CitizenWindow(Context context)
        {
            this.context = context;
        }


        public void EnterCitizenFirstName(string firstName)
        {
            this.setCitizenField("firstNameTextBox",firstName);
            Thread.Sleep(2000);
        }

        public void ClickSearchCitizen()
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("SearchButton"))
                .AsButton()
                .Click();
            Thread.Sleep(2000);
        }

        public void ClickOnLogout()
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("LogoutLinkLabel"))
                .AsButton()
                .Click();
            Thread.Sleep(2000);
            context.mustChangeWindow = true;
        }

        private void setCitizenField(string fieldName, string value)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId(fieldName))
                .AsTextBox()
                .Enter(value);
        }

        internal void ClickSelectCitizenWindow()
        {
            context.GetWindow()
                 .FindFirstDescendant(cf => cf.ByAutomationId("SelectCitizenButton"))
                 .AsButton()
                 .Click();
            Thread.Sleep(2000);
            context.mustChangeWindow = true; 
        }

        internal object GetDataGridViewData(int columnIndex)
        {
            var searchValue = context.GetWindow().FindFirstDescendant(cf => cf.ByAutomationId("citizenResultDataGridView")).AsDataGridView().Rows[0].Cells[columnIndex];
            Console.WriteLine(searchValue.Value);
            return searchValue.Value;
        }

        internal void EnterCitizenLastName(string lastName)
        {           
            this.setCitizenField("lastNameTextBox", lastName);
            Thread.Sleep(2000);
        }

        internal void EnterCitizenEmail(string email)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("EmailRadioButton"))
                .AsButton()
                .Click();
            this.setCitizenField("emailTextBox", email);
            Thread.Sleep(2000);
        }

        internal void EnterCitizenPhone(string phone)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("PhoneRadioButton"))
                .AsButton()
                .Click();
            this.setCitizenField("phoneTextBox", phone);
            Thread.Sleep(2000);
        }
    }
}
