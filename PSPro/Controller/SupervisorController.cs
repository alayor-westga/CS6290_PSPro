using System;
using System.Collections.Generic;
using System.Text;
using PSPro.DAL;
using PSPro.Model;

namespace PSPro.Controller
{

    /// <summary>
    /// Controller class for Supervisor
    /// </summary>
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

        /// <summary>
        /// Adds Citizen object to Citizen table and adds a new Complaint object to Complaint table
        /// </summary>
        /// <param name="citizen"></param>
        /// <param name="complaint"></param>
        public void AddCitizenAndComplaint(Citizen citizen, Complaint complaint)
        {
            this.supervisorSource.AddCitizenAndComplaint(citizen, complaint);
        }

        /// <summary>
        /// Adds new Complaint object to Complaint table
        /// </summary>
        /// <param name="complaint"></param>
        public void AddComplaint(Complaint complaint)
        {
            this.supervisorSource.AddComplaint(complaint);
        }

        /// <summary>
        /// Gets Citizen object from the db by citizenID
        /// </summary>
        /// <param name="citizenID"></param>
        /// <returns>Citizen object</returns>
        public Citizen GetCitizen(int citizenID)
        {
            if (citizenID < 0)
            {
                throw new ArgumentException("The patientID must not be negative");
            }
            return supervisorSource.GetCitizen(citizenID);
        }

        /// <summary>
        /// Attempts to update Citizen to db and returns true if successful, false otherwise
        /// </summary>
        /// <param name="citizen"></param>
        /// <param name="updatedCitizen"></param>
        /// <returns>True if Citizen is updated, false otherwise</returns>
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
