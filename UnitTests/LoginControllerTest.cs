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
        public LoginControllerTest() {
            supervisorDAL = new Mock<SupervisorDAL>();
            loginController = new LoginController();
            setupMocks();
        }

        private void setupMocks()
        {
            supervisorDAL.Setup(m => m.GetByUserNameAndPassword("s-001", "1234")).Returns(new Supervisor());
        }

        [TestMethod]
        public void TestLoginAsSupervisorSuccessful()
        {
            bool success = loginController.Login("s-001", "1234");
            Assert.IsTrue(success);
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
