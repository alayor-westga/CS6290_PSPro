using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSPro.Controller;
using PSPro.Model;

namespace PSPro.UserControls
{
    public partial class ManageComplaintAsInvestigator : UserControl
    {
        private int complaintID;
        private readonly ComplaintController complaintController;
        public ManageComplaintAsInvestigator()
        {
            InitializeComponent();
            complaintController = new ComplaintController();
        }

        public void SetComplaintInfo(int complaintID)
        {
            this.complaintID = complaintID;
            ComplaintView complaintView = complaintController.GetComplaintById(complaintID);
            this.citizenNameLabelValue.Text = complaintView.CitizenFullName;
            this.citizenAddressLabelValue.Text = complaintView.CitizenFullAddress;
            this.citizenPhoneLabelValue.Text = complaintView.CitizenPhone;
            this.officerFullNameLabelValue.Text = complaintView.OfficerFullName;
            this.complaintIdLabelValue.Text = complaintView.ComplaintID.ToString();
            this.statusLabelValue.Text = complaintView.Status;
            this.allegationLabelValue.Text = complaintView.Allegation;
            this.notesTextBox.Text = complaintView.Notes;
            this.dateLabelValue.Text = complaintView.DateCreated.ToShortDateString();
            if (complaintView.Disposition != null && complaintView.Disposition.Length > 0)
            {
                this.dispositionComboBox.SelectedItem = complaintView.Disposition;
            } 
            else
            {
                this.dispositionComboBox.SelectedIndex = -1;
            }
            
            var discipline = complaintView.Discipline != null && complaintView.Discipline.Length > 0
                    ? complaintView.Discipline : "--";
            this.disciplineLabelValue.Text = discipline;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                complaintController.UpdateDisposition(complaintID, this.dispositionComboBox.SelectedItem.ToString());
                MessageBox.Show("Complaint Successfully\nUpdated.",
                           "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
