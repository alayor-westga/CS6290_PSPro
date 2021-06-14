using System.Windows.Forms;
using PSPro.Controller;

namespace PSPro.UserControls
{
    public partial class ComplaintList : UserControl
    {
        private readonly ComplaintController complaintController;
        public ComplaintList()
        {
            InitializeComponent();
            complaintController = new ComplaintController();
        }

        private void ShowAllActiveComplaints()
        {
            complaintsDataGridView.DataSource = complaintController.GetAllActiveComplaints();
        }

        private void ComplaintList_Load(object sender, System.EventArgs e)
        {
            ShowAllActiveComplaints();
        }
    }
}
