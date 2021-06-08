using System;
using System.Collections.Generic;
using System.Text;
using PSPro.DAL;
using PSPro.Model;

namespace PSPro.Controller
{
     /// <summary>
    /// It provides authentication functionality for system users.
    /// </summary>
    public class LoginController
    {
        private readonly SupervisorDAL supervisorDAL;
        public static User user;

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

        public static User GetUser()
        {
            return LoginController.user;
        }

        public bool Login(string username, string password)
        {
            Personnel personnel = null;
            UserRole role = UserRole.Unknown;
            if (username.StartsWith("s")) {
                personnel = (Personnel)supervisorDAL.GetByUserNameAndPassword(username, password);
                role = UserRole.Supervisor;
            }
            if (personnel == null)
            {
                return false;
            }
            user = new User()
            {
                UserId = personnel.PersonelID,
                UserName = username,
                FullName = personnel.FullName,
                Role = role
            };
            return true;
        }
    }
}
