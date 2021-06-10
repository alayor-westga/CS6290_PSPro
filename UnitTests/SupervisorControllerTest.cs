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
        public void TestAddCitizenAndComplaint()
        {
            Citizen citizen = new Citizen();
            Complaint complaint = new Complaint();
            supervisorController.AddCitizenAndComplaint(citizen, complaint);
            supervisorDAL.Verify(v => v.AddCitizenAndComplaint(citizen, complaint));
        }
    }
}
