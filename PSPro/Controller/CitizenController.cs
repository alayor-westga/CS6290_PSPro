using PSPro.DAL;
using PSPro.Model;
using System;
using System.Collections.Generic;

namespace PSPro.Controller
{
    /// <summary>
    /// Model for Citizen
    /// </summary>
    class CitizenController      
    {
        CitizenDAL citizenSource = new CitizenDAL();

        /// <summary>
        /// Search for Citizen by name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>a List of Citizen objects</returns>
        public List<Citizen> SearchByName(string firstName, string lastName)
        {
            return this.citizenSource.SearchByName(firstName, lastName);
        }

        /// <summary>
        /// Search for Citizen by phone
        /// </summary>
        /// <param name="phone"></param>
        /// <returns>a List of Citizen objects</returns>
        public List<Citizen> SearchByPhone(string phone)
        {
            return this.citizenSource.SearchByPhone(phone);
        }

        /// <summary>
        /// Search for Citizen by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>a list of Citizen objects</returns>
        public List<Citizen> SearchByEmail(string email)
        {
            return this.citizenSource.SearchByEmail(email);
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
            return citizenSource.GetCitizen(citizenID);
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
            return citizenSource.UpdateCitizen(citizen, updatedCitizen);
        }
    }
}
