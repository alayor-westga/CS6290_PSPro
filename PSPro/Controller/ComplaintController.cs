using System;
using System.Collections.Generic;
using System.Text;
using PSPro.DAL;
using PSPro.Model;

namespace PSPro.Controller
{
    public class ComplaintController
    {
        private readonly ComplaintDAL complaintSource;

        public ComplaintController() : this(new ComplaintDAL()) { }

        /// <summary>
        /// It creates a SupervisorController injecting dependencies.
        /// </summary>
        public ComplaintController(ComplaintDAL complaintSource)
        {
            this.complaintSource = complaintSource;
        }

        public List<ComplaintView> GetAllActiveComplaints()
        {
            return this.complaintSource.GetAllActiveComplaints();
        }

        public List<ComplaintView> GetActiveComplaintsByOfficer(int officerPersonelId)
        {
            return this.complaintSource.GetActiveComplaintsByOfficer(officerPersonelId);
        }
    }
}
