using System;

namespace PSPro.Model
{
    /// <summary>
    /// ComplaintView Model
    /// </summary>
    public class ComplaintView
    {
        /// <summary>
        /// ComplaintID for ComplaintView
        /// </summary>
        public int ComplaintID { get; set; }

        /// <summary>
        /// DateCreated for ComplaintView
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// OfficerFullName for ComplaintView
        /// </summary>
        public string OfficerFullName { get; set; }

        /// <summary>
        /// CitizenFullName for ComplaintView
        /// </summary>
        public string CitizenFullName { get; set; }

        /// <summary>
        /// CitizenFullAddress for ComplaintView
        /// </summary>
        public string CitizenFullAddress { get; set; }

        /// <summary>
        /// CitizenPhone for ComplaintView
        /// </summary>
        public string CitizenPhone { get; set; }

        /// <summary>
        /// Disposition for ComplaintView
        /// </summary>
        public string Disposition { get; set; }

        /// <summary>
        /// Discipline for ComplaintView
        /// </summary>
        public string Discipline { get; set; }


        /// <summary>
        /// Status for ComplaintView
        /// </summary>
        public string Status
        {
            get
            {
                return Discipline == null ? "Closed" : "Open";
            }
        }
    }
}
