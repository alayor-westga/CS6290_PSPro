using System.Windows.Forms;
using PSPro.Controller;
using PSPro.Model;

namespace PSPro.View
{
    /// <summary>
    /// View for dashboard for logged in investigator
    /// </summary>
    public partial class InvestigatorDashboard : Form
    {
        private readonly Form loginForm;
        private readonly User loggedInUser;

        /// <summary>
        /// Constructor; initializes components; instantiates instance variable and writes logged-in user on form
        /// </summary>
        /// <param name="loginForm"></param>
        public InvestigatorDashboard(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.loggedInUser = LoginController.GetUser();
            this.ShowUserName();
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
    }
}
