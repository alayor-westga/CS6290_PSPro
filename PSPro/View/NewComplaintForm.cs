using PSPro.Controller;
using PSPro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PSPro.View
{
    public partial class NewComplaintForm : Form
    {
        private readonly Form loginForm;
        private readonly LoginController loginController;
        private readonly SupervisorController supervisorController;
        private Complaint complaint;
        private Citizen citizen;
        private User loggedInUser;

        public NewComplaintForm(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.loginController = new LoginController();
            this.supervisorController = new SupervisorController();
            this.complaint = new Complaint();
            this.citizen = new Citizen();
            this.loggedInUser = new User();
            this.phoneNumberErrorLabel.Text = "###-###-####";
            this.zipCodeErrorLabel.Text = "##### or #####-####";
            this.ShowUserName();
            this.PopulateOfficerComboBox();
            this.PopulateStateComboBox(this.stateComboBox);
        }

        private void PopulateStateComboBox(ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(States))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cbo.DisplayMember = "Description";
            cbo.ValueMember = "value";
        }

        /// <summary>
        /// It renders the username.
        /// </summary>
        private void ShowUserName()
        {
            this.loggedInUser = LoginController.GetUser();
            this.SupervisorLabel.Text = this.loggedInUser.FullName + " (" + this.loggedInUser.UserName + ")";
        }

        private void PopulateOfficerComboBox()
        {         
            try
            {
                List<OfficerComboBox> officers = this.supervisorController.GetOfficersForComboBox();      
                this.officerComboBox.DataSource = officers;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.officerComboBox.SelectedIndex = -1;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateFields()) return;
           
            if (string.IsNullOrEmpty(this.citizenIDTextBox.Text))
            {
                this.BindCitizenFieldsToCitizenObject();
                this.BindComplaintFieldsToComplaintObject();

                try
                {
                    this.supervisorController.AddCitizenAndComplaint(this.citizen, this.complaint);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                this.complaint.CitizenID = Int32.Parse(this.citizenIDTextBox.Text); //may not need this - the form may already be populated
                if (this.CheckForChangesMadeToCitizenFields())
                {
                    this.UpdateCitizen(); 
                }
                this.BindComplaintFieldsToComplaintObject();

                try
                {
                    this.supervisorController.AddComplaint(this.complaint);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }           
            }

            this.ClearForm();
            MessageBox.Show("Complaint Successfully\nAdded to Database.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void UpdateCitizen()
        {
            if (!this.ValidateFields()) return;

            Citizen updatedCitizen = new Citizen();
            updatedCitizen.FirstName = this.firstNameTextBox.Text;
            updatedCitizen.LastName = this.lastNameTextBox.Text;
            updatedCitizen.Address1 = this.address1TextBox.Text;
            updatedCitizen.Address2 = this.address2TextBox.Text;
            updatedCitizen.City = this.cityTextBox.Text;
            updatedCitizen.State = this.stateComboBox.SelectedValue.ToString();
            updatedCitizen.ZipCode = this.zipCodeTextBox.Text;
            updatedCitizen.Phone = this.phoneNumberTextBox.Text;
            updatedCitizen.Email = this.emailTextBox.Text;

            try
            {
                if (!this.supervisorController.UpdateCitizen(this.citizen, updatedCitizen))
                {
                    MessageBox.Show("This patient's information has been\nmodified since it has been retrieved."
                    + "\n\nThe form has been updated to reflect those changes.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.GetCitizenFromDB();
                    this.PopulateCitizenFields();
                    return;
                }
                MessageBox.Show("The changes were successfully amended to the database.",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateCitizenFields()
        {
            this.citizenIDTextBox.Text = this.citizen.CitizenID.ToString();
            this.firstNameTextBox.Text = this.citizen.FirstName;
            this.lastNameTextBox.Text = this.citizen.LastName;
            this.address1TextBox.Text = this.citizen.Address1;
            this.address2TextBox.Text = this.citizen.Address2;
            this.cityTextBox.Text = this.citizen.City;
            this.stateComboBox.SelectedValue = Enum.Parse(typeof(States), citizen.State);
            this.zipCodeTextBox.Text = this.citizen.ZipCode;
            this.phoneNumberTextBox.Text = this.citizen.Phone;
            this.emailTextBox.Text = this.citizen.Email;
        }

        private void GetCitizenFromDB()
        {
            this.citizen = this.supervisorController.GetCitizen(this.citizen.CitizenID);
            //this.citizen = this.supervisorController.GetCitizen(this.CitizenIDTextBox.Text);
        }

        private bool CheckForChangesMadeToCitizenFields()
        {
            if (this.citizen.FirstName  != this.firstNameTextBox.Text ||
                this.citizen.LastName != this.lastNameTextBox.Text ||
                this.citizen.Address1 != this.address1TextBox.Text ||
                this.citizen.Address2 != this.address2TextBox.Text ||
                this.citizen.City != this.cityTextBox.Text ||
                this.citizen.State != this.stateComboBox.SelectedValue.ToString() ||
                this.citizen.ZipCode != this.zipCodeTextBox.Text ||
                this.citizen.Phone != this.phoneNumberTextBox.Text ||
                this.citizen.Email != this.emailTextBox.Text
                )
            {
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            this.citizenIDTextBox.Text = "";
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.address1TextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateComboBox.Text = "";
            this.zipCodeTextBox.Text = "";
            this.phoneNumberTextBox.Text = "";
            this.emailTextBox.Text = "";
            this.officerComboBox.SelectedIndex = -1;
            this.allegationComboBox.SelectedIndex = -1;
            this.complaintSummaryTextBox.Text = "";
            this.firstNameErrorLabel.Text = "";
            this.zipCodeErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.officerErrorLabel.Text = "";
            this.allegationErrorLabel.Text = "";
            this.complaintSummaryErrorLabel.Text = "";
        }

        private void BindComplaintFieldsToComplaintObject()
        {
            this.complaint.SupervisorID = this.loggedInUser.UserId;
            this.complaint.OfficerID = (int)this.officerComboBox.SelectedValue;
            this.complaint.Allegation = this.allegationComboBox.Text;
            this.complaint.Summary = DateTime.Now + " by " + this.loggedInUser.FullName + ":\r\n\r\n" + this.complaintSummaryTextBox.Text;          
        }
        
        private void BindCitizenFieldsToCitizenObject()
        {
            this.citizen.FirstName = firstNameTextBox.Text;
            this.citizen.LastName = lastNameTextBox.Text;
            this.citizen.Address1 = address1TextBox.Text;
            this.citizen.Address2 = address2TextBox.Text;
            this.citizen.City = cityTextBox.Text;
            this.citizen.State = stateComboBox.SelectedValue.ToString();
            this.citizen.ZipCode = zipCodeTextBox.Text;
            this.citizen.Phone = phoneNumberTextBox.Text;
            this.citizen.Email = emailTextBox.Text;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            loginForm.Show();
        }

        private void NewComplaintForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool ValidateFields()
        {
            var isValid = true;
            if (firstNameTextBox.Text.Length == 0)
            {
                isValid = false;
                firstNameErrorLabel.Text = "Required Field";
            }
            else
            {
                firstNameErrorLabel.Text = "";
            }
            Regex zipRegex = new Regex("[0-9]{5}(-[0-9]{4})?$");
            if (!zipRegex.IsMatch(zipCodeTextBox.Text) && zipCodeTextBox.Text.Length != 0)
            {
                isValid = false;
                zipCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            } 
            else
            {
                zipCodeErrorLabel.ForeColor = System.Drawing.Color.Black;
            }
            Regex phoneRegex = new Regex("[0-9]{3}-[0-9]{3}-[0-9]{4}");
            if (!phoneRegex.IsMatch(phoneNumberTextBox.Text) &&  !string.IsNullOrWhiteSpace(this.phoneNumberTextBox.Text))
            {
                isValid = false;
                phoneNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            } 
            else
            {
                phoneNumberErrorLabel.ForeColor = System.Drawing.Color.Black;
            }
            if (officerComboBox.SelectedValue == null)
            {
                isValid = false;
                officerErrorLabel.Text = "Select a Name From the Dropdown";
            }
            else
            {
                officerErrorLabel.Text = "";
            }
            if (string.IsNullOrEmpty(allegationComboBox.Text))
            {
                isValid = false;
                allegationErrorLabel.Text = "Required Field";
            }
            else
            {
                allegationErrorLabel.Text = "";
            }
            if (string.IsNullOrWhiteSpace(complaintSummaryTextBox.Text))
            {
                isValid = false;
                complaintSummaryErrorLabel.Text = "Required Field";
            }
            else
            {
                complaintSummaryErrorLabel.Text = "";
            }
            return isValid;
        }
    }
}
