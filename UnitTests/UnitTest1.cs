using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PSPro.Controller;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LoginController loginController = new LoginController();
            Assert.IsFalse(loginController.IsLoggedIn());
        }
    }
}
