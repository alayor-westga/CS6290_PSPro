using TechTalk.SpecFlow;
using E2ETests.Hooks;
using NUnit.Framework;

namespace E2ETests.Steps
{
    [Binding]
    public class AddNewComplaintSteps
    {
        private readonly Context context;

        public AddNewComplaintSteps(Context context)
        {
            this.context = context;
        }

        [When(@"click on Save")]
        public void WhenClickOnSave()
        {
            context.newComplaintWindow.Save();
        }

        [Then(@"the first name field is labeled as required")]
        public void TheFirstNameFieldIsLabeledAsRequired()
        {
            var errorLabel = context.newComplaintWindow.GetFirstNameErrorLabel();
            Assert.AreEqual(errorLabel, "Required Field");
        }

        [Then(@"the officer field is labeled as required")]
        public void TheOfficerFieldIsLabeledAsRequired()
        {
            var errorLabel = context.newComplaintWindow.GetOfficerErrorLabel();
            Assert.AreEqual(errorLabel, "Select a Name From the Dropdown");
        }

        [Then(@"the allegation field is labeled as required")]
        public void TheAllegatiorFieldIsLabeledAsRequired()
        {
            var errorLabel = context.newComplaintWindow.GetAllegationErrorLabel();
            Assert.AreEqual(errorLabel, "Required Field");
        }

        [Then(@"the complaint summary field is labeled as required")]
        public void TheComplaintSummaryFieldIsLabeledAsRequired()
        {
            var errorLabel = context.newComplaintWindow.GetComplaintSummaryErrorLabel();
            Assert.AreEqual(errorLabel, "Required Field");
        }

        [Given(@"this citizen info is entered")]
        public void GivenThisCitizenInfoIsEntered(Table table)
        {
            var citizenRaw = table.Rows[0];
            context.newComplaintWindow.SetCitizenFirstName(citizenRaw[0]);
            context.newComplaintWindow.SetCitizenLastName(citizenRaw[1]);
            context.newComplaintWindow.SetCitizenAddress1(citizenRaw[2]);
            context.newComplaintWindow.SetCitizenAddress2(citizenRaw[3]);
            context.newComplaintWindow.SetCitizenCity(citizenRaw[4]);
            context.newComplaintWindow.SetCitizenState(citizenRaw[5]);
            context.newComplaintWindow.SetCitizenZipCode(citizenRaw[6]);
            context.newComplaintWindow.SetCitizenPhoneNumber(citizenRaw[7]);
            context.newComplaintWindow.SetCitizenEmailAddress(citizenRaw[8]);
        }
    }
}
