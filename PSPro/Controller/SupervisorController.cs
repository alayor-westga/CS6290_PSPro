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

        public SupervisorController()
        {
            this.supervisorSource = new SupervisorDAL();
        }

        public List<OfficerComboBox> GetOfficersForComboBox()
        {
            return this.supervisorSource.GetOfficersForComboBox();
        }

        internal void AddComplaint(Complaint complaint)
        {
            throw new NotImplementedException();
        }

        internal int AddCitizen(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        internal int ReturnCitizenID(object citizen)
        {
            throw new NotImplementedException();
        }
    }
}
