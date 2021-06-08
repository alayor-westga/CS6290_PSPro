using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PSPro.Controller;
using PSPro.DAL;
using PSPro.Model;
using Moq;

namespace UnitTests
{
    [TestClass]
    public class LoginControllerTest
    {
        private readonly LoginController loginController;
        private readonly Mock<SupervisorDAL> supervisorDAL;
        private readonly Mock<InvestigatorDAL> investigatorDAL;
        private readonly Mock<AdministratorDAL> administratorDAL;
        public LoginControllerTest() {
            supervisorDAL = new Mock<SupervisorDAL>();
            investigatorDAL = new Mock<InvestigatorDAL>();
            administratorDAL = new Mock<AdministratorDAL>();
            setupMocks();
            loginController = new LoginController(
                supervisorDAL.Object,
                investigatorDAL.Object,
                administratorDAL.Object
            );
        }

        private void setupMocks()
        {
            supervisorDAL.Setup(m => m.GetByUserNameAndPassword("s-001", "1234")).Returns(new Supervisor() 
            {
                FirstName = "John",
                LastName = "Williams"
            });
            investigatorDAL.Setup(m => m.GetByUserNameAndPassword("i-001", "1234")).Returns(new Investigator() 
            {
                FirstName = "Jose",
                LastName = "Perez"
            });
            administratorDAL.Setup(m => m.GetByUserNameAndPassword("a-001", "1234")).Returns(new Administrator() 
            {
                FirstName = "Manny",
                LastName = "Hernandez"
            });
        }

        [TestMethod]
        public void TestLoginAsSupervisorSuccessful()
        {
            bool success = loginController.Login("s-001", "1234");
            Assert.IsTrue(success);
            User user = LoginController.GetUser();
            Assert.Equals("s-001", user.UserName);
            Assert.Equals("John Williams", user.FullName);
            Assert.Equals(UserRole.Supervisor, user.Role);
        }
        
        [TestMethod]
        public void TestLoginAsSupervisorWrongUserName()
        {
            bool success = loginController.Login("s-002", "1234");
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void TestLoginAsSupervisorWrongPassword()
        {
            bool success = loginController.Login("s-001", "1233");
            Assert.IsFalse(success);
        }
    }
}
