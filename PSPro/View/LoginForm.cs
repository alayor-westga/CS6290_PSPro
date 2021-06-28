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
    /// <summary>
    /// View class for login form
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly LoginController loginController;

        /// <summary>
        /// constructor - instantiates instance variable and initializes components
        /// </summary>
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
            try
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
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("The system is not accessible. Please try again later",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
