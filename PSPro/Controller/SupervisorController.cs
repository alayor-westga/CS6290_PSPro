using PSPro.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using PSPro.DAL;
using PSPro.Model;

namespace PSPro.Controller
{
    
    public class SupervisorController    
    {
        private readonly SupervisorDAL supervisorSource;

        internal List<OfficerComboBox> GetOfficersForComboBox()
        {
            return this.supervisorSource.GetOfficerForComboBox();
        }
    }
}
