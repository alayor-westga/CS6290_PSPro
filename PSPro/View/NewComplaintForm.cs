using PSPro.Controller;
using PSPro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
           
            if (string.IsNullOrEmpty(this.CitizenIDTextBox.Text))
            {
                this.AddCitizen();
                //this.complaint.CitizenID = ReturnCitizenID();

                //AddCitizenAndComplaint (transaction??)
            }
            else
            {
                this.complaint.CitizenID = Int32.Parse(this.CitizenIDTextBox.Text);
            }

            //this.AddComplaint();          
        }

        private void AddComplaint()
        {
            this.complaint.OfficerID = Int32.Parse(this.OfficerComboBox.ValueMember);
            this.complaint.SupervisorID = this.loggedInUser.UserId;                      
            this.complaint.Allegation = this.AllegationComboBox.Text;
            this.complaint.Summary = this.ComplaintSummaryTextBox.Text;

            try
            {
                this.supervisorController.AddComplaint(complaint);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private int ReturnCitizenID()
        {
            try
            {
                return this.supervisorController.ReturnCitizenID();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
          
        }

        private void AddCitizen()
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
           
            try
            {
                this.supervisorController.AddCitizen(this.citizen);               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
    }
}
