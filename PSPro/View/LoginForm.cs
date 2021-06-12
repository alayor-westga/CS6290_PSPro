using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PSPro.Controller;

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
                this.Text += " (" + Program.Env + " env)";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool success = loginController.Login(userNameTextBox.Text, passwordTextBox.Text); 
            if (success)
            {
                using (NewComplaintForm form = new NewComplaintForm(this))
                {
                    Hide();
                    form.ShowDialog();
                    userNameTextBox.Clear();
                    passwordTextBox.Clear();
                }
            }   
            else
            {
                errorMessageLabel.Text = "Invalid credentials";
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
