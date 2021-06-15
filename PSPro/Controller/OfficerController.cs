using System.Collections.Generic;
using PSPro.DAL;
using PSPro.Model;

namespace PSPro.Controller
{
    public class OfficerController
    {
        private readonly OfficerDAL officerSource;

        public OfficerController() : this(new OfficerDAL()) { }

        /// <summary>
        /// It creates a OfficerController injecting dependencies.
        /// </summary>
        public OfficerController(OfficerDAL officerDAL)
        {
            this.officerSource = officerDAL;
        }

        public List<OfficerComboBox> GetOfficersForComboBox()
        {
            return this.officerSource.GetOfficersForComboBox();
        }
    }
}