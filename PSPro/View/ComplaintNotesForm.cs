using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPro.View
{
    public partial class ComplaintNotesForm : Form
    {
        UserControl parentForm;
        public ComplaintNotesForm(UserControl parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void ComplaintNotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.parentForm.Show();
            this.Hide();
        }
    }
}
