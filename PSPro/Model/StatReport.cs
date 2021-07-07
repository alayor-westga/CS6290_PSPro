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
        public int MostCommonComplaint { get; set; }
        public int PercentOfSustainedComplaints { get; set; }
        public int MostFrequentlyNamedOfc { get; set; }
        public int LeastFrequentlyNamedOfc { get; set; }
    }
}
