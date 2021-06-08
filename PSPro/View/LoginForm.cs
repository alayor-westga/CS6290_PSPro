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
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loginController.Login(usernameTextBox.Text, passwordTextBox.Text);    
        }
    }
}
