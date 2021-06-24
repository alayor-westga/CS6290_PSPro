using System;
using System.Windows.Forms;
using PSPro.Model;

namespace PSPro.View
{
    public partial class ComplaintNotesForm : Form
    {
        private ComplaintView complaintView;
        UserControl parentForm;
        public ComplaintNotesForm(UserControl parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
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
    }
}
