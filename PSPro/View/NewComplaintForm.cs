﻿using PSPro.Controller;
using PSPro.Model;
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
        private readonly SupervisorController supervisorController;

        public NewComplaintForm()
        {
            InitializeComponent();
            loginController = new LoginController();
            supervisorController = new SupervisorController();
            this.PopulateOfficerComboBox();
        }

        private void PopulateOfficerComboBox()
        {         
            try
            {
                List<OfficerComboBox> officers = this.supervisorController.GetOfficersForComboBox();      
                this.OfficerComboBox.DataSource = officers;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.OfficerComboBox.SelectedIndex = -1;
        }
    }
}
