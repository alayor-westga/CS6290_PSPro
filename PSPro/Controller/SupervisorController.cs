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


        /// <summary>
        /// It creates a SupervisorController injecting dependencies.
        /// </summary>
        public SupervisorController(SupervisorDAL supervisorDAL)
        {
            this.supervisorSource = supervisorDAL;
        }

        public List<OfficerComboBox> GetOfficersForComboBox()
        {
            return this.supervisorSource.GetOfficersForComboBox();
        }

        public void AddCitizenAndComplaint(Citizen citizen, Complaint complaint)
        {
            this.supervisorSource.AddCitizenAndComplaint(citizen, complaint);
        }

       public void AddComplaint(Complaint complaint)
        {
            this.supervisorSource.AddComplaint(complaint);
        }

        internal Citizen GetCitizen(string text)
        {
            throw new NotImplementedException();
        }

        internal bool UpdateCitizen(Citizen citizen, Citizen updatedCitizen)
        {
            throw new NotImplementedException();
        }
    }
}
