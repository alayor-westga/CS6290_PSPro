using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPro
{
    public partial class TestReportForm : Form
    {
        public TestReportForm()
        {
            InitializeComponent();
        }

        private void TestReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psproDataSet.ComplaintsStatisticsByYearReport' table. You can move, or remove it, as needed.
            this.ComplaintsStatisticsByYearReportTableAdapter.Fill(this.psproDataSet.ComplaintsStatisticsByYearReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
