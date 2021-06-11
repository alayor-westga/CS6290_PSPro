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
            this.PhoneNumberErrorLabel.Text = "###-###-####";
            this.ZipCodeErrorLabel.Text = "##### or #####-####";
            this.ShowUserName();
            this.PopulateOfficerComboBox();
            PopulateStateComboBox(this.StateComboBox);           
        }

        private static void PopulateStateComboBox(ComboBox cbo)
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
                this.OfficerComboBox.DataSource = officers;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.OfficerComboBox.SelectedIndex = -1;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateFields()) return;
           
            if (string.IsNullOrEmpty(this.CitizenIDTextBox.Text))
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
                this.complaint.CitizenID = Int32.Parse(this.CitizenIDTextBox.Text);
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

        private void ClearForm()
        {
            this.FirstNameTextBox.Text = "";
            this.LastNameTextBox.Text = "";
            this.Address1TextBox.Text = "";
            this.Address2TextBox.Text = "";
            this.CityTextBox.Text = "";
            this.StateComboBox.Text = "";
            this.ZipCodeTextBox.Text = "";
            this.PhoneNumberTextBox.Text = "";
            this.EmailTextBox.Text = "";
            this.OfficerComboBox.SelectedIndex = -1;
            this.AllegationComboBox.SelectedIndex = -1;
            this.ComplaintSummaryTextBox.Text = "";
            this.FirstNameErrorLabel.Text = "";
            this.ZipCodeErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.PhoneNumberErrorLabel.ForeColor = System.Drawing.Color.Black;
            this.OfficerErrorLabel.Text = "";
            this.AllegationErrorLabel.Text = "";
            this.ComplaintSummaryErrorLabel.Text = "";
        }

        private void BindComplaintFieldsToComplaintObject()
        {
            this.complaint.SupervisorID = this.loggedInUser.UserId;
            this.complaint.OfficerID = (int)this.OfficerComboBox.SelectedValue;
            this.complaint.Allegation = this.AllegationComboBox.Text;
            this.complaint.Summary = this.ComplaintSummaryTextBox.Text;          
        }
        
        private void BindCitizenFieldsToCitizenObject()
        {
            this.citizen.FirstName = FirstNameTextBox.Text;
            this.citizen.LastName = LastNameTextBox.Text;
            this.citizen.Address1 = Address1TextBox.Text;
            this.citizen.Address2 = Address2TextBox.Text;
            this.citizen.City = CityTextBox.Text;
            this.citizen.State = StateComboBox.Text;
            this.citizen.ZipCode = ZipCodeTextBox.Text;
            this.citizen.Phone = PhoneNumberTextBox.Text;
            this.citizen.Email = EmailTextBox.Text;
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
            if (FirstNameTextBox.Text.Length == 0)
            {
                isValid = false;
                FirstNameErrorLabel.Text = "Required Field";
            }
            else
            {
                FirstNameErrorLabel.Text = "";
            }
            Regex zipRegex = new Regex("[0-9]{5}(-[0-9]{4})?$");
            if (!zipRegex.IsMatch(ZipCodeTextBox.Text) && ZipCodeTextBox.Text.Length != 0)
            {
                isValid = false;
                ZipCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            } 
            else
            {
                ZipCodeErrorLabel.ForeColor = System.Drawing.Color.Black;
            }
            Regex phoneRegex = new Regex("[0-9]{3}-[0-9]{3}-[0-9]{4}");
            if (!phoneRegex.IsMatch(PhoneNumberTextBox.Text) &&  !string.IsNullOrWhiteSpace(this.PhoneNumberTextBox.Text))
            {
                isValid = false;
                PhoneNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            } 
            else
            {
                PhoneNumberErrorLabel.ForeColor = System.Drawing.Color.Black;
            }
            if (OfficerComboBox.SelectedValue == null)
            {
                isValid = false;
                OfficerErrorLabel.Text = "Select a Name From the Dropdown";
            }
            else
            {
                OfficerErrorLabel.Text = "";
            }
            if (string.IsNullOrEmpty(AllegationComboBox.Text))
            {
                isValid = false;
                AllegationErrorLabel.Text = "Required Field";
            }
            else
            {
                AllegationErrorLabel.Text = "";
            }
            if (string.IsNullOrWhiteSpace(ComplaintSummaryTextBox.Text))
            {
                isValid = false;
                ComplaintSummaryErrorLabel.Text = "Required Field";
            }
            else
            {
                ComplaintSummaryErrorLabel.Text = "";
            }
            return isValid;
        }
    }
}
