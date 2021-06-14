using System;

namespace PSPro.Model
{
    public class ComplaintView
    {
        public int ComplaintID { get; set; }
       
        public DateTime DateCreated { get; set; }
       
        public string OfficerFullName { get; set; }

        public string CitizenFullName { get; set; }

        public string Disposition { get; set; }
    }
}
