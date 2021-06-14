using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPro.Model
{
    public class ComplaintView
    {
        public int ComplaintID { get; set; }
       
        public Date DateCreated { get; set; }
       
        public string OfficerFullName { get; set; }

        public string CitizenFullName { get; set; }

        public string Disposition { get; set; }

        public string Discipline { get; set; }
    }
}
