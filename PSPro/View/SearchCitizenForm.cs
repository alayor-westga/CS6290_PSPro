﻿using PSPro.Controller;
using PSPro.Model;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PSPro.View
{
    /// <summary>
    /// View class for SearchCitizenForm
    /// </summary>
    public partial class SearchCitizenForm : Form        
    {
        NewComplaintForm newComplaintForm;
        CitizenController citizenController;
        List<Citizen> citizens;
        Citizen existingCitizen = new Citizen();

        /// <summary>
        /// Constructor - initialize components; instantiate instance variables
        /// </summary>
        /// <param name="newComplaintForm"></param>
        public SearchCitizenForm(NewComplaintForm newComplaintForm)
        {
            InitializeComponent();
            this.DisableAllSearchBoxes();
            this.newComplaintForm = newComplaintForm;
            this.citizenController = new CitizenController();
            this.citizens = new List<Citizen>();
            this.SelectCitizenButton.Enabled = false;
            Console.WriteLine("In Search form");
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
                if (!this.ValidateName()) return;
                try
                {
                    this.citizens = this.citizenController.SearchByName(this.firstNameTextBox.Text, this.lastNameTextBox.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    MessageBox.Show("An error occurred when searching for a citizen.",
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }

            if (this.PhoneRadioButton.Checked)
            {
                if (!this.ValidatePhone()) return;
                try
                {
                    this.citizens = this.citizenController.SearchByPhone(this.phoneTextBox.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    MessageBox.Show("An error occurred when searching for a citizen.",
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (this.EmailRadioButton.Checked)
            {
                if (!this.ValidateEmail()) return;
                try
                {
                    this.citizens = this.citizenController.SearchByEmail(this.emailTextBox.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    MessageBox.Show("An error occurred when searching for a citizen.",
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.citizenResultDataGridView.DataSource = this.citizens;
            if (this.citizens.Count > 0)
            {
                this.SelectCitizenButton.Enabled = true;
                this.noResultsLabel.Text = "";
            } 
            else
            {
                this.SelectCitizenButton.Enabled = false;
                this.noResultsLabel.Text = "No results";
            }
        }

        private bool ValidateEmail()
        {
            var isValid = true;
            if (!this.EmailIsValid())
            {
                isValid = false;
                emailErrorLabel.Text = "Enter a valid email address";
            }
            else
            {
                this.emailErrorLabel.Text = "";
            }
            return isValid;
        }

        private bool ValidatePhone()
        {
            var isValid = true;          
            Regex phoneRegex = new Regex("[0-9]{3}-[0-9]{3}-[0-9]{4}");
            if (!phoneRegex.IsMatch(phoneTextBox.Text))
            {
                isValid = false;
                phoneFormatLabel.ForeColor = System.Drawing.Color.Red;
                phoneErrorLabel.Text = "Required Field Using Shown Format";
            }
            else
            {
                phoneFormatLabel.ForeColor = System.Drawing.Color.Black;
                phoneErrorLabel.Text = "";
            }           
            return isValid;
        }

        private bool ValidateName()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) && string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                isValid = false;
                firstNameErrorLabel.Text = "One or Both Fields Required";
            }
            else
            {
                firstNameErrorLabel.Text = "";
            }
            return isValid;
        }

        private void RadioButtons_CheckChanged(object sender, EventArgs e)
        {
            this.ResetErrorMessages();

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

        private void ResetErrorMessages()
        {
            this.firstNameErrorLabel.Text = "";
            this.emailErrorLabel.Text = "";
            this.phoneErrorLabel.Text = "";
            this.phoneFormatLabel.ForeColor = System.Drawing.Color.Black;
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
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

            this.existingCitizen = (Citizen)this.citizenResultDataGridView.CurrentRow.DataBoundItem;
            this.newComplaintForm.Show();
            this.newComplaintForm.PopulateCitizenFieldsWithExistingCitizenInformation(existingCitizen);
            this.Hide();
        }

        private bool EmailIsValid()
        {
            if (string.IsNullOrWhiteSpace(this.emailTextBox.Text))
            {
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(this.emailTextBox.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
