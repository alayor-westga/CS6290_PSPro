using System;
using System.Windows.Forms;
using PSPro.Model;
using PSPro.Controller;

namespace PSPro.View
{
    public partial class ComplaintNotesForm : Form
    {
        private ComplaintView complaintView;
        private readonly ComplaintController complaintController;
        UserControl parentForm;
        public ComplaintNotesForm(UserControl parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            complaintController = new ComplaintController();
        }

        public void SetComplaintView(ComplaintView complaintView)
        {
            this.complaintView = complaintView;
        }

        private void ComplaintNotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.parentForm.Show();
            this.Hide();
        }

        private void ComplaintNotesForm_Load(object sender, EventArgs e)
        {
            notesTextBox.Text = complaintView.Notes;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var loggedInUser = LoginController.GetUser();
            string summary = DateTime.Now + " by " + loggedInUser.FullName + ":\r\n" + this.addNotesTextBox.Text + "\r\n\r\n";
            try
            {
                complaintController.AppendNotes(complaintView.ComplaintID, summary);
                MessageBox.Show("Complaint Successfully\nUpdated.",
                              "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                notesTextBox.Text = summary + complaintView.Notes;
                this.addNotesTextBox.Clear();
                this.notesTextBox.ScrollToCaret();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("The complaint notes could not get saved.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNotesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addNotesTextBox.Text.Length > 0)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
    }
}
