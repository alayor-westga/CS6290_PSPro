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
            if (username.StartsWith("s")) {
                Supervisor supervisor = supervisorDAL.GetByUserNameAndPassword(username, password);
                if (supervisor == null)
                {
                    return false;
                }
                user = new User()
                {
                    UserId = supervisor.PersonelID,
                    UserName = username,
                    FullName = supervisor.FullName,
                    Role = UserRole.Supervisor
                };
                return true;
            }
            return false;
        }
    }
}
