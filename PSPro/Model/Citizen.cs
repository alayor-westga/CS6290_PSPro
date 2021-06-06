using System;
using System.Collections.Generic;
using System.Text;

namespace PSPro.Model
{
    class Citizen
    {
        /// <summary>
        /// ID and PK for Citizen object
        /// </summary>
        public int CitizenID { get; set; }

        /// <summary>
        /// First Name for Citizen object
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name for Citizen object
        /// </summary>
        public string LastName { get; set;  }

        /// <summary>
        /// Address Field 1 for Citizen object
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Address Field 2 for Citizen object
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City for Citizen object
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State for Citizen object
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// ZipCode for Citizen object
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Phone for Citizen object
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Email for Citizen object
        /// </summary>
        public string Email { get; set; }
    }
}
