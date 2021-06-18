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
    }
}
