﻿using PSPro.DAL;
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

        public void AddCitizen(Citizen citizen)
        {
            this.supervisorSource.AddCitizen(citizen);
        }

        internal int ReturnCitizenID()
        {
            throw new NotImplementedException();
        }
    }
}
