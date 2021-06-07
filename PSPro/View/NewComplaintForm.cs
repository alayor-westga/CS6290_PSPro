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
        private readonly SupervisorController supervisorController;

        public NewComplaintForm()
        {
            InitializeComponent();
            loginController = new LoginController();
            loginController.LoginAsSupervisor("user", "pass");
            this.PopulateOfficerComboBox();
        }

        private void PopulateOfficerComboBox()
        {
            try
            {
                officers = this.supervisorController.GetOfficersForComboBox();
                foreach (LabTest labTest in allLabTests)
                {
                    if (this.labTestController.GetSingleLabTestResult(labTest.LabTestCode, this.visit.AppointmentID) == null)
                    {
                        labTestsNotSelected.Add(labTest);
                    }
                }
                if (labTestsNotSelected.Count == 0)
                {
                    this.orderTestButton.Enabled = false;
                }
                this.labTestListBox.DataSource = labTestsNotSelected;
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
