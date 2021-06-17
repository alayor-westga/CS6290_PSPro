using PSPro.DAL;
using PSPro.Model;
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
    }
}
