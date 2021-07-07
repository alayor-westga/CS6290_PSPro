using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPro.Model
{
    class StatReport
    {
        public int TotalComplaints { get; set; }
        public string MostCommonComplaint { get; set; }
        public int PercentOfSustainedComplaints { get; set; }
        public string MostFrequentlyNamedOfc { get; set; }
        public string LeastFrequentlyNamedOfc { get; set; }
    }
}
