using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PSPro.Controller;

namespace UnitTests
{
    [TestClass]
    public class LoginControllerTest
    {
        private readonly LoginController loginController;
        public LoginControllerTest() {
            loginController = new LoginController();
        }

        [TestMethod]
        public void TestLoginAsSupervisor()
        {
            bool success = loginController.Login("s-001", "1234");
            Assert.IsTrue(success);
        }
    }
}
