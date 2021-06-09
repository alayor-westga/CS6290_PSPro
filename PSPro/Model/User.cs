using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSPro.Model
{
    /// <summary>
    /// The Role of a user.
    /// </summary>
    public enum UserRole {
        Supervisor, Investigator, Administrator, Unknown
    }

    /// <summary>
    /// The User model class.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The User ID.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The User Name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The User Password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The User Full Name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The User Role.
        /// </summary>
        public UserRole Role { get; set; }
    }
}
