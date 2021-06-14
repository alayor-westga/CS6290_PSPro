using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PSPro.Controller;
using PSPro.Model;

namespace PSPro.View
{
    public partial class LoginForm : Form
    {
        private readonly LoginController loginController;

        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
            if (Program.Env != Program.Environments.PROD)
            {
                this.Text += " (" + Program.Env + ")";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = loginController.Login(userNameTextBox.Text, passwordTextBox.Text);
            if (user != null)
            {
                switch (user.Role)
                {
                    case UserRole.Supervisor:
                        ShowWindow(new NewComplaintForm(this));
                        break;
                    case UserRole.Investigator:
                        ShowWindow(new InvestigatorDashboard(this));
                        break;
                    case UserRole.Administrator:
                        ShowWindow(new AdministratorDashboard(this));
                        break;
                }
            }
            else
            {
                errorMessageLabel.Text = "Invalid credentials";
            }
        }

        private void ShowWindow(Form form)
        {
            using (form)
            {
                Hide();
                form.ShowDialog();
                userNameTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
