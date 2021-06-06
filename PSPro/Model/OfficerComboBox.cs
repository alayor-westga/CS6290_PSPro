using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPro.Model
{
    public class OfficerComboBox
    {
        public int PersonnelID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName
        {
            get
            {
                return LastName + ", " + FirstName + " (" + PersonnelID + ")";
            }
        }

    }
}
