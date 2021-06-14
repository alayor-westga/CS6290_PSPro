using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PSPro.Controller;
using PSPro.Model;

namespace PSPro.UserControls
{
    public partial class ComplaintList : UserControl
    {
        private readonly ComplaintController complaintController;
        private readonly SupervisorController supervisorController;
        public ComplaintList()
        {
            InitializeComponent();
            complaintController = new ComplaintController();
            supervisorController = new SupervisorController();
        }

        private void ShowAllActiveComplaints()
        {
            if (this.officerComboBox.SelectedValue == null)
            {
                complaintsDataGridView.DataSource = complaintController.GetAllActiveComplaints();
                return;
            }
            int officerId =(int) this.officerComboBox.SelectedValue;
            if (officerId > -1)
            {
                complaintsDataGridView.DataSource = complaintController.GetActiveComplaintsByOfficer(officerId);
            } 
            else
            {
                complaintsDataGridView.DataSource = complaintController.GetAllActiveComplaints();
            }
        }

        private void ComplaintList_Load(object sender, System.EventArgs e)
        {
            ShowAllActiveComplaints();
            PopulateOfficerComboBox();
        }

        private void PopulateOfficerComboBox()
        {
            try
            {
                List<OfficerComboBox> officers = supervisorController.GetOfficersForComboBox();
                officers.Insert(0, new OfficerComboBox()
                {
                    PersonnelID = -1,
                    FirstName = "All"
                });
                this.officerComboBox.DataSource = officers;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void officerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllActiveComplaints();
        }
    }
}
