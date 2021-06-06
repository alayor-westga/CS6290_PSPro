using PSPro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PSPro.View
{
    public partial class NewComplaintForm : Form
    {
        private readonly LoginController loginController;

        public NewComplaintForm()
        {
            InitializeComponent();
            loginController = new LoginController();
            loginController.LoginAsSupervisor("user", "pass");
        }


    }
}
