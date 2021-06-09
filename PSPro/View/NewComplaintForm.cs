using PSPro.Controller;
using PSPro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PSPro.View
{
    public partial class NewComplaintForm : Form
    {
        private readonly LoginController loginController;
        private readonly SupervisorController supervisorController;
        private Complaint complaint;
        private Citizen citizen;

        public NewComplaintForm()
        {
            InitializeComponent();
            this.loginController = new LoginController();
            this.supervisorController = new SupervisorController();
            this.complaint = new Complaint();
            this.citizen = new Citizen();
            this.PopulateOfficerComboBox();
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
            this.complaint.SupervisorID = 3333; // placeholder                     
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
    }
}
