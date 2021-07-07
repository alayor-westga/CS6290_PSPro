using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPro.UserControls
{
      public partial class StatisticalReportUserControl : UserControl
    {
        public StatisticalReportUserControl()
        {
            InitializeComponent();
        }

        private void MostPerformedTestsForm_Load(object sender, EventArgs e)
        {
     
            this.reportViewer1.RefreshReport();



        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            //if (this.startDateTimePicker.Value < this.endDateTimePicker.Value)
            //{
                //this.getMostPerformedTestsDuringDatesTableAdapter.Fill(this._cs6232_g1DataSet.getMostPerformedTestsDuringDates, this.startDateTimePicker.Value, this.endDateTimePicker.Value);
               // this.reportViewer1.RefreshReport();
            //}
           // else
            //{
                //MessageBox.Show("Start Date Must be before End Date.", "Operation not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
