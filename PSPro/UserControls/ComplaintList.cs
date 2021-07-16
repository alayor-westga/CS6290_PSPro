using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using PSPro.Controller;
using PSPro.Model;

namespace PSPro.UserControls
{
    public partial class ComplaintList : UserControl, IRefreshable
    {
        private abstract class BaseComplaintComparer : IComparer<ComplaintView>
        {
            protected SortOrder sortOrder;
            public BaseComplaintComparer(SortOrder sortOrder)
            {
                this.sortOrder = sortOrder;
            }
            public abstract int Compare(ComplaintView x, ComplaintView y);
        }
        private class IdComparer : BaseComplaintComparer
        {
            public IdComparer(SortOrder sortOrder) : base(sortOrder) { }
            override public int Compare(ComplaintView x, ComplaintView y)
            {
                return sortOrder == SortOrder.Ascending || sortOrder == SortOrder.None ?
                    x.ComplaintID - y.ComplaintID :
                    y.ComplaintID - x.ComplaintID;
            }
        }
        private class DateComparer : BaseComplaintComparer
        {
            public DateComparer(SortOrder sortOrder) : base(sortOrder) { }
            override public int Compare(ComplaintView x, ComplaintView y)
            {
                return sortOrder == SortOrder.Ascending || sortOrder == SortOrder.None ?
                    DateTime.Compare(x.DateCreated, y.DateCreated) :
                    DateTime.Compare(y.DateCreated, x.DateCreated);
            }
        }
        private class OfficerComparer : BaseComplaintComparer
        {
            public OfficerComparer(SortOrder sortOrder) : base(sortOrder) { }
            override public int Compare(ComplaintView x, ComplaintView y)
            {
                return sortOrder == SortOrder.Ascending || sortOrder == SortOrder.None ?
                    String.Compare(x.OfficerFullName, y.OfficerFullName) :
                    String.Compare(y.OfficerFullName, x.OfficerFullName);
            }
        }
        private class CitizenComparer : BaseComplaintComparer
        {
            public CitizenComparer(SortOrder sortOrder) : base(sortOrder) { }
            override public int Compare(ComplaintView x, ComplaintView y)
            {
                return sortOrder == SortOrder.Ascending || sortOrder == SortOrder.None ?
                    String.Compare(x.CitizenFullName, y.CitizenFullName) :
                    String.Compare(y.CitizenFullName, x.CitizenFullName);
            }
        }
        private class AllegationComparer : BaseComplaintComparer
        {
            public AllegationComparer(SortOrder sortOrder) : base(sortOrder) { }
            override public int Compare(ComplaintView x, ComplaintView y)
            {
                return sortOrder == SortOrder.Ascending || sortOrder == SortOrder.None ? 
                    String.Compare(x.Allegation, y.Allegation) : 
                    String.Compare(y.Allegation, x.Allegation);
            }
        }
        private List<ComplaintSelectionListener> complaintSelectionListeners;
        private readonly ComplaintController complaintController;
        private readonly OfficerController officerController;
        private List<ComplaintView> list;
        public ComplaintList()
        {
            InitializeComponent();
            complaintSelectionListeners = new List<ComplaintSelectionListener>();
            complaintController = new ComplaintController();
            officerController = new OfficerController();
            list = new List<ComplaintView>();
        }

        public void AddComplaintSelectionListener(ComplaintSelectionListener listener)
        {
            complaintSelectionListeners.Add(listener);
        }

        public void RemoveComplaintSelectionListener(ComplaintSelectionListener listener)
        {
            complaintSelectionListeners.Remove(listener);
        }

        private void ShowComplaints()
        {
            StatusFilter statusFilter = statusComboBox.SelectedIndex == 0 || statusComboBox.SelectedIndex == -1 ? StatusFilter.Open : StatusFilter.Closed;
            try
            {
                if (this.officerComboBox.SelectedValue == null)
                {
                    list = complaintController.GetAllComplaints(statusFilter);
                    complaintsDataGridView.DataSource = list;
                    return;
                }
                int officerId = (int)this.officerComboBox.SelectedValue;
                if (officerId > -1)
                {
                    list = complaintController.GetComplaintsByOfficer(officerId, statusFilter);
                    complaintsDataGridView.DataSource = list;
                }
                else if (this.officerComboBox.Text.Contains("Complaints for officers having > 3 complaints in past year"))
                {                    
                    list = complaintController.GetComplaintsForOfficersWithGreaterThanThreeComplaints(statusFilter);
                    complaintsDataGridView.DataSource = list;
                } 
                else 
                {
                    list = complaintController.GetAllComplaints(statusFilter);
                    complaintsDataGridView.DataSource = list;
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
                ShowComplaints();
                PopulateOfficerComboBox();
                statusComboBox.SelectedIndex = 0;
            }
        }

        override public void Refresh()
        {
            ShowComplaints();
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

                officers.Insert(1, new OfficerComboBox()
                {
                    PersonnelID = -1,
                    FirstName = "Complaints for officers having > 3 complaints in past year"
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
            ShowComplaints();
        }

        private void manageComplaintButton_Click(object sender, EventArgs e)
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

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowComplaints();
        }

        private void complaintsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = complaintsDataGridView.Columns[e.ColumnIndex].HeaderText;
            SortOrder currentOrder = complaintsDataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;
            SortOrder newOrder = currentOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            if (columnName == "ID")
            {
                list.Sort(new IdComparer(newOrder));
            } else if (columnName == "Date")
            {
                list.Sort(new DateComparer(newOrder));
            }
            else if (columnName == "Officer")
            {
                list.Sort(new OfficerComparer(newOrder));
            }
            else if (columnName == "Citizen")
            {
                list.Sort(new CitizenComparer(newOrder));
            }
            else if (columnName == "Allegation")
            {
                list.Sort(new AllegationComparer(newOrder));
            }

            complaintsDataGridView.DataSource = null;
            complaintsDataGridView.DataSource = list;
            complaintsDataGridView.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = newOrder;
        }

        private void complaintsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            manageComplaint();
        }
    }
}
