using System;
using System.Collections.Generic;
using System.Text;
using PSPro.DAL;

namespace PSPro.Controller
{
     /// <summary>
    /// It provides authentication functionality for system users.
    /// </summary>
    public class LoginController
    {
        private readonly SupervisorDAL supervisorDAL;

        /// <summary>
        /// It creates a LoginController object.
        /// </summary>
        public LoginController()
        {
            supervisorDAL = new SupervisorDAL();
        }
        
        public bool IsLoggedIn()
        {
            return false;
        }

        public void Login(string username, string password)
        {
            supervisorDAL.GetByUserNameAndPassword(username, password);
        }
    }
}
