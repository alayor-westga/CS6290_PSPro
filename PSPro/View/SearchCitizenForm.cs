using PSPro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPro.View
{
    public partial class SearchCitizenForm : Form        
    {
        NewComplaintForm newComplaintForm;

        public SearchCitizenForm(NewComplaintForm newComplaintForm)
        {
            InitializeComponent();
            this.DisableAllSearchBoxes();
            this.newComplaintForm = newComplaintForm;
        }

        private void DisableAllSearchBoxes()
        {
            this.firstNameTextBox.Enabled = false;
            this.lastNameTextBox.Enabled = false;
            this.emailTextBox.Enabled = false;
            this.phoneTextBox.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (this.FirstAndLastNameRadioButton.Checked)
            {
                this.SearchByName();
            }
            if (this.PhoneRadioButton.Checked)
            {
                this.SearchByPhone();
            }
            if (this.EmailRadioButton.Checked)
            {
                this.SearchByEmail();
            }
        }

        private void SearchByEmail()
        {
            throw new NotImplementedException();
        }

        private void SearchByPhone()
        {
            throw new NotImplementedException();
        }

        private void SearchByName()
        {
            throw new NotImplementedException();
        }

        private void RadioButtons_CheckChanged(object sender, EventArgs e)
        {
            if (this.FirstAndLastNameRadioButton.Checked)
            {
                this.firstNameTextBox.Enabled = true;
                this.lastNameTextBox.Enabled = true;
                this.emailTextBox.Enabled = false;
                this.phoneTextBox.Enabled = false;
            }
            if (this.PhoneRadioButton.Checked)
            {
                this.firstNameTextBox.Enabled = false;
                this.lastNameTextBox.Enabled = false;
                this.emailTextBox.Enabled = false;
                this.phoneTextBox.Enabled = true;
            }
            if (this.EmailRadioButton.Checked)
            {
                this.firstNameTextBox.Enabled = false;
                this.lastNameTextBox.Enabled = false;
                this.emailTextBox.Enabled = true;
                this.phoneTextBox.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.newComplaintForm.Show();
            this.Hide();
        }

        private void SearchCitizenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.newComplaintForm.Show();
            this.Hide();
        }

        private void SelectCitizenButton_Click(object sender, EventArgs e)
        {
            Citizen newCitizen = new Citizen();
            newCitizen.CitizenID = 1000;
            newCitizen.FirstName = "Mike";
           

            this.Hide();
        }
    }
}
