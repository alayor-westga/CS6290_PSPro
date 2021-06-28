﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PSPro.Controller;
using PSPro.Model;

namespace PSPro.UserControls
{
    public partial class ComplaintList : UserControl, IRefreshable
    {
        private List<ComplaintSelectionListener> complaintSelectionListeners;
        private readonly ComplaintController complaintController;
        private readonly OfficerController officerController;
        public ComplaintList()
        {
            InitializeComponent();
            complaintSelectionListeners = new List<ComplaintSelectionListener>();
            complaintController = new ComplaintController();
            officerController = new OfficerController();
        }

        public void AddComplaintSelectionListener(ComplaintSelectionListener listener)
        {
            complaintSelectionListeners.Add(listener);
        }

        public void RemoveComplaintSelectionListener(ComplaintSelectionListener listener)
        {
            complaintSelectionListeners.Remove(listener);
        }

        private void ShowAllActiveComplaints()
        {
            try
            {
                if (this.officerComboBox.SelectedValue == null)
                {
                    complaintsDataGridView.DataSource = complaintController.GetAllActiveComplaints();
                    return;
                }
                int officerId = (int)this.officerComboBox.SelectedValue;
                if (officerId > -1)
                {
                    complaintsDataGridView.DataSource = complaintController.GetActiveComplaintsByOfficer(officerId);
                }
                else
                {
                    complaintsDataGridView.DataSource = complaintController.GetAllActiveComplaints();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("An error occurred when loading the complaints.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComplaintList_Load(object sender, System.EventArgs e)
        {
            if (!this.DesignMode)
            {
                ShowAllActiveComplaints();
                PopulateOfficerComboBox();
            }
        }

        override public void Refresh()
        {
            ShowAllActiveComplaints();
        }

        private void PopulateOfficerComboBox()
        {
            try
            {
                List<OfficerComboBox> officers = officerController.GetOfficersForComboBox();
                officers.Insert(0, new OfficerComboBox()
                {
                    PersonnelID = -1,
                    FirstName = "All"
                });
                this.officerComboBox.DataSource = officers;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("An error occurred when loading the officers.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void officerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAllActiveComplaints();
        }

        private void manageComplaintButton_Click(object sender, EventArgs e)
        {
            manageComplaint();
        }

        private void complaintsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            manageComplaint();
        }

        private void manageComplaint()
        {
            ComplaintView complaintView = (ComplaintView)complaintsDataGridView.SelectedRows[0].DataBoundItem;
            foreach (ComplaintSelectionListener listener in complaintSelectionListeners)
            {
                listener.OnComplaintSelected(complaintView.ComplaintID);
            }
        }

        public int GetSelectedComplaintId()
        {
            ComplaintView complaintView = (ComplaintView)complaintsDataGridView.SelectedRows[0].DataBoundItem;
            return complaintView.ComplaintID;
        }
    }
}
