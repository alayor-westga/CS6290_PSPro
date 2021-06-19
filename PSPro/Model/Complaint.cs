using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPro.Model
{
    /// <summary>
    /// Complaint Model
    /// </summary>
    public class Complaint
    {
       /// <summary>
       /// CitizenID for Complaint
       /// </summary>
        public int CitizenID { get; set; }

        /// <summary>
        /// OfficerID for Complaint
        /// </summary>
        public int OfficerID { get; set; }

        /// <summary>
        /// SupervisorID for Complaint
        /// </summary>
        public int SupervisorID { get; set; }

        /// <summary>
        /// InvestigatorID for Complaint
        /// </summary>
        public int InvestigatorID { get; set; }

        /// <summary>
        /// AdministratorID for Complaint
        /// </summary>
        public int AdministratorID { get; set; }

        /// <summary>
        /// Allegation for Complaint
        /// </summary>
        public string Allegation { get; set; }

        /// <summary>
        /// Disposition for Complaint
        /// </summary>
        public int Disposition { get; set; }

        /// <summary>
        /// DispositionDate for Complaint
        /// </summary>
        public DateTime DispositionDate { get; set; }

        /// <summary>
        /// Discipline for Complaint
        /// </summary>
        public string Discipline { get; set; }

        /// <summary>
        /// CitizenID for Complaint
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// DateCreated for Complaint
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
