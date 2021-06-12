using FlaUI.Core.AutomationElements;
using System.Threading;

namespace E2ETests.Hooks.Windows
{
    public class NewComplaintWindow
    {
        private readonly Context context;
        public NewComplaintWindow(Context context)
        {
            this.context = context;
        }

        public string GetUserFullName()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("SupervisorLabel"))
                .AsLabel()
                .Text;
        }
        public string GetFirstNameErrorLabel()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("firstNameErrorLabel"))
                .AsLabel()
                .Text;
        }
        public string GetOfficerErrorLabel()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("officerErrorLabel"))
                .AsLabel()
                .Text;
        }
        public string GetAllegationErrorLabel()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("allegationErrorLabel"))
                .AsLabel()
                .Text;
        }
        public string GetComplaintSummaryErrorLabel()
        {
            return context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("complaintSummaryErrorLabel"))
                .AsLabel()
                .Text;
        }
        public void SetCitizenFirstName(string firstName)
        {
            setCitizenField("firstNameTextBox", firstName);
        }

        public void SetCitizenLastName(string lastName)
        {
            setCitizenField("lastNameTextBox", lastName);
        }
        public void SetCitizenAddress1(string address1)
        {
            setCitizenField("address1TextBox", address1);
        }
        public void SetCitizenAddress2(string address2)
        {
            setCitizenField("address2TextBox", address2);
        }
        public void SetCitizenCity(string city)
        {
            setCitizenField("cityTextBox", city);
        }
        public void SetCitizenState(string state)
        {
            //TODO stateComboBox
        }

        public void SetCitizenZipCode(string zipCode)
        {
            setCitizenField("zipCodeTextBox", zipCode);
        }

        public void SetCitizenPhoneNumber(string phoneNumber)
        {
            setCitizenField("phoneNumberTextBox", phoneNumber);
        }
        public void SetCitizenEmailAddress(string email)
        {
            setCitizenField("emailTextBox", email);
        }

        private void setCitizenField(string fieldName, string value)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId(fieldName))
                .AsTextBox()
                .Enter(value);
        }
        public void Save()
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("SaveButton"))
                .AsButton()
                .Click();
        }
    }
}
