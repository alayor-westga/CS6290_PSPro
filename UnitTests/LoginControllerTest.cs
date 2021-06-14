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
            User user = loginController.Login("s-001", "1234");
            Assert.IsNotNull(user);
            Assert.AreEqual("s-001", user.UserName);
            Assert.AreEqual("John Williams", user.FullName);
            Assert.AreEqual(UserRole.Supervisor, user.Role);
        }
        
        [TestMethod]
        public void TestLoginAsSupervisorWrongUserName()
        {
            User user = loginController.Login("s-002", "1234");
            Assert.IsNull(user);
            Assert.IsNull(LoginController.GetUser());
        }

        [TestMethod]
        public void TestLoginAsSupervisorWrongPassword()
        {
            User user = loginController.Login("s-001", "1233");
            Assert.IsNull(user);
            Assert.IsNull(LoginController.GetUser());
        }

        [TestMethod]
        public void TestLoginAsInvestigatorSuccessful()
        {
            User user = loginController.Login("i-001", "1234");
            Assert.IsNotNull(user);
            Assert.AreEqual("i-001", user.UserName);
            Assert.AreEqual("Jose Perez", user.FullName);
            Assert.AreEqual(UserRole.Investigator, user.Role);
        }

        [TestMethod]
        public void TestLoginAsInvestigatorWrongUserName()
        {
            User user = loginController.Login("i-002", "1234");
            Assert.IsNull(user);
            Assert.IsNull(LoginController.GetUser());
        }

        [TestMethod]
        public void TestLoginAsInvestigatorWrongPassword()
        {
            User user = loginController.Login("i-001", "1233");
            Assert.IsNull(user);
            Assert.IsNull(LoginController.GetUser());
        }
    }
}
