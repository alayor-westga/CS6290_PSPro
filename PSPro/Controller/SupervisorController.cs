﻿using System;
using System.Collections.Generic;
using System.Text;
using PSPro.DAL;
using PSPro.Model;

namespace PSPro.Controller
{
    public class SupervisorController
    {
        private readonly SupervisorDAL supervisorSource;

        public SupervisorController() : this(new SupervisorDAL()) {}

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

        public Citizen GetCitizen(int citizenID)
        {
            if (citizenID < 0)
            {
                throw new ArgumentException("The patientID must not be negative");
            }
            return supervisorSource.GetCitizen(citizenID);
        }

        public bool UpdateCitizen(Citizen citizen, Citizen updatedCitizen)
        {
            if (citizen == null)
            {
                throw new ArgumentNullException("oldPatient");
            }
            if (updatedCitizen == null)
            {
                throw new ArgumentNullException("newPatient");
            }
            return supervisorSource.UpdateCitizen(citizen, updatedCitizen);
        }
    }
}
