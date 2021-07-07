using System.Collections.Generic;
using System.Windows.Forms;
using PSPro.Controller;
using PSPro.Model;

namespace PSPro.View
{
    /// <summary>
    /// View for dashboard for logged in investigator
    /// </summary>
    public partial class AdministratorDashboard : Form, ComplaintSelectionListener
    {
        private readonly Form loginForm;
        private readonly User loggedInUser;
        private readonly List<TabPage> refreshableTabPages;

        /// <summary>
        /// Constructor; initializes components; instantiates instance variable and writes logged-in user on form
        /// </summary>
        /// <param name="loginForm"></param>
        public AdministratorDashboard(Form loginForm)
        {
            InitializeComponent();
            this.complaintList.AddComplaintSelectionListener(this);
            this.loginForm = loginForm;
            this.loggedInUser = LoginController.GetUser();
            this.ShowUserName();
            refreshableTabPages = new List<TabPage> {
               complaintListTabPage
            };
        }

        /// <summary>
        /// It renders the username.
        /// </summary>
        private void ShowUserName()
        {
            this.userFullNameLabel.Text = this.loggedInUser.FullName + " (" + this.loggedInUser.UserName + ")";
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            loginForm.Show();
        }

        private void InvestigatorDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void OnComplaintSelected(int complaintId)
        {
            this.manageComplaintAsAdministrator1.SetComplaintInfo(complaintId);
            this.complaintListTabControl.SelectedTab = manageComplaintTabPage;
        }

        private void RefreshControlsInTabPage(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                if (control is IRefreshable)
                {
                    ((IRefreshable)control).Refresh();
                }
            }
        }

        private void complaintListTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (refreshableTabPages.Contains(e.TabPage))
            {
                RefreshControlsInTabPage(e.TabPage);
            }
            if (this.complaintListTabControl.SelectedTab == manageComplaintTabPage)
            {
                int complaintId = complaintList.GetSelectedComplaintId();
                this.manageComplaintAsAdministrator1.SetComplaintInfo(complaintId);
            }
        }

        private void AdministratorDashboard_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'psproDataSet.ComplaintsStatisticsByYearReport' table. You can move, or remove it, as needed.
            this.complaintsStatisticsByYearReportTableAdapter.Fill(this.psproDataSet.ComplaintsStatisticsByYearReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
