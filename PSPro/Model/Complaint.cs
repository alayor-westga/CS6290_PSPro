using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPro.Model
{
    public class Complaint
    {
       
        public int CitizenID { get; set; }
       
        public int OfficerID { get; set; }
       
        public int SupervisorID { get; set; }

        public int InvestigatorID { get; set; }

        public int AdministratorID { get; set; }

        public string Allegation { get; set; }
        
        public int Disposition { get; set; }

        public DateTime DispositionDate { get; set; }

        public string Discipline { get; set; }

        public string Summary { get; set; }
        
        public DateTime DateCreated { get; set; }
    }
}
