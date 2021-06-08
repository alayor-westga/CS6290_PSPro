using System;
using System.Collections.Generic;
using System.Text;

namespace PSPro.Model
{
    public class Personnel
    {
        /// <summary>
        /// ID and PK for Personnel object
        /// </summary>
        public int PersonelID { get; set; }

        /// <summary>
        /// First Name for Citizen object
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name for Citizen object
        /// </summary>
        public string LastName { get; set;  }

        /// <summary>
        /// Gender for Citizen object
        /// </summary>
        public string Gender { get; set;  }

        /// <summary>
        /// Hire date for Citizen object
        /// </summary>
        public string HireDate { get; set;  }

        /// <summary>
        /// Birth date for Citizen object
        /// </summary>
        public string BirthDate { get; set;  }

        /// <summary>
        /// Assignment for Citizen object
        /// </summary>
        public string Assignment { get; set;  }
    }
}
