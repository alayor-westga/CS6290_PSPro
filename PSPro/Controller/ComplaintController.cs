using System;
using System.Collections.Generic;
using System.Text;
using PSPro.DAL;
using PSPro.Model;

namespace PSPro.Controller
{
    /// <summary>
    /// Controller class for Complaints
    /// </summary>
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

        /// <summary>
        /// Gets all active complaints
        /// </summary>
        /// <returns>a List of active complaints</returns>
        public List<ComplaintView> GetAllActiveComplaints()
        {
            return this.complaintSource.GetAllActiveComplaints();
        }

        /// <summary>
        /// Gets all active complaints by officer
        /// </summary>
        /// <param name="officerPersonelId"></param>
        /// <returns>a List of active complaints by officer</returns>
        public List<ComplaintView> GetActiveComplaintsByOfficer(int officerPersonelId)
        {
            return this.complaintSource.GetActiveComplaintsByOfficer(officerPersonelId);
        }
    }
}
