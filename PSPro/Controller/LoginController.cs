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
        private readonly InvestigatorDAL investigatorDAL;
        private readonly AdministratorDAL administratorDAL;
        private static User user;

        /// <summary>
        /// It creates a LoginController object.
        /// </summary>
        public LoginController()
        {
            supervisorDAL = new SupervisorDAL();
            investigatorDAL = new InvestigatorDAL();
            administratorDAL = new AdministratorDAL();
        }

        /// <summary>
        /// It creates a LoginController injecting dependencies.
        /// </summary>
        public LoginController(
            SupervisorDAL supervisorDAL, 
            InvestigatorDAL investigatorDAL, 
            AdministratorDAL administratorDAL)
        {
            this.supervisorDAL = supervisorDAL;
            this.investigatorDAL = investigatorDAL;
            this.administratorDAL = administratorDAL;
        }

        /// <summary>
        /// Gets current logged in user
        /// </summary>
        /// <returns>returns logged in user</returns>
        public static User GetUser()
        {
            return LoginController.user;
        }

        /// <summary>
        /// Assigns roles based on login credentials and returns user information
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>returns a User object of the current logged in user</returns>
        public User Login(string username, string password)
        {
            Personnel personnel = null;
            UserRole role = UserRole.Unknown;
            if (username.StartsWith("s-")) {
                personnel = (Personnel)supervisorDAL.GetByUserNameAndPassword(username, password);
                role = UserRole.Supervisor;
            }
            if (username.StartsWith("i-")) {
                personnel = (Personnel)investigatorDAL.GetByUserNameAndPassword(username, password);
                role = UserRole.Investigator;
            }
            if (username.StartsWith("a-")) {
                personnel = (Personnel)administratorDAL.GetByUserNameAndPassword(username, password);
                role = UserRole.Administrator;
            }
            if (personnel == null)
            {
                user = null;
                return null;
            }
            user = new User()
            {
                UserId = personnel.PersonelID,
                UserName = username,
                FullName = personnel.FullName,
                Role = role
            };
            return user;
        }
    }
}
