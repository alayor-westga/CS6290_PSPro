using FlaUI.Core.AutomationElements;

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
        public void EnterCitizenFirstName(string firstName)
        {
            setCitizenField("firstNameTextBox", firstName);
        }

        public void EnterCitizenLastName(string lastName)
        {
            setCitizenField("lastNameTextBox", lastName);
        }
        public void EnterCitizenAddress1(string address1)
        {
            setCitizenField("address1TextBox", address1);
        }
        public void EnterCitizenAddress2(string address2)
        {
            setCitizenField("address2TextBox", address2);
        }
        public void EnterCitizenCity(string city)
        {
            setCitizenField("cityTextBox", city);
        }
        public void SelectCitizenState(string state)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("stateComboBox"))
                .AsComboBox()
                .Select(state);
        }

        public void EnterCitizenZipCode(string zipCode)
        {
            setCitizenField("zipCodeTextBox", zipCode);
        }

        public void EnterCitizenPhoneNumber(string phoneNumber)
        {
            setCitizenField("phoneNumberTextBox", phoneNumber);
        }
        public void EnterCitizenEmailAddress(string email)
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

        public void SelectOfficer(string officer)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("officerComboBox"))
                .AsComboBox()
                .Select(officer);
        }

        public void SelectAllegation(string allegation)
        {
            context.GetWindow()
                .FindFirstDescendant(cf => cf.ByAutomationId("allegationComboBox"))
                .AsComboBox()
                .Select(allegation);
        }
    }
}
