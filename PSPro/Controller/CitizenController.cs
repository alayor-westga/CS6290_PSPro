using PSPro.DAL;
using PSPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPro.Controller
{
    class CitizenController      
    {
        CitizenDAL citizenSource = new CitizenDAL();

        public List<Citizen> SearchByName(string firstName, string lastName)
        {
            return this.citizenSource.SearchByName(firstName, lastName);
        }

        public List<Citizen> SearchByPhone(string phone)
        {
            return this.citizenSource.SearchByPhone(phone);
        }

        public List<Citizen> SearchByEmail(string email)
        {
            return this.citizenSource.SearchByEmail(email);
        }
    }
}
