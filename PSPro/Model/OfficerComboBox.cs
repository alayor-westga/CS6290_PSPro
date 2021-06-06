using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPro.Model
{
    public class OfficerComboBox
    {
        /// <summary>
        /// Personnel ID associated with Officer Combo Box
        /// </summary>
        public int PersonnelID { get; set; }

        /// <summary>
        /// First Name associated with Officer Combo Box
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name associated with Officer Combo Box
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Display Name for Officer Combo Box
        /// </summary>
        public string DisplayName
        {
            get
            {
                return LastName + ", " + FirstName + " (" + PersonnelID + ")";
            }
        }

    }
}
