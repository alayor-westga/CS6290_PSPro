﻿using System.Windows.Forms;
using PSPro.Controller;
using PSPro.Model;

namespace PSPro.View
{
    public partial class AdministratorDashboard : Form
    {
        private readonly Form loginForm;
        private readonly User loggedInUser;
        public AdministratorDashboard(Form loginForm)
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