using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PSPro.Controller;
using PSPro.DAL;
using PSPro.Model;
using Moq;

namespace UnitTests
{
    [TestClass]
    public class SupervisorControllerTest
    {
        private readonly SupervisorController supervisorController;
        private readonly Mock<SupervisorDAL> supervisorDAL;
        public SupervisorControllerTest() {
            supervisorDAL = new Mock<SupervisorDAL>();
            setupMocks();
            supervisorController = new SupervisorController(supervisorDAL.Object);
        }

        private void setupMocks() {}

        [TestMethod]
        public void TestGetOfficersForCombobox()
        {
            supervisorController.GetOfficersForComboBox();
            supervisorDAL.Verify(v => v.GetOfficersForComboBox());
        }
        
        [TestMethod]
        public void TestAddCitizen()
        {
            Citizen citizen = new Citizen();
            supervisorController.AddCitizen(citizen);
            supervisorDAL.Verify(v => v.AddCitizen(citizen));
        }
    }
}
