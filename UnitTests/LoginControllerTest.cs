using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSPro.Controller;

namespace UnitTests
{
    [TestClass]
    public class LoginControllerTest
    {
        [TestMethod]
        public void TestIsLoggedIn()
        {
            LoginController loginController = new LoginController();
            Assert.IsTrue(loginController.IsLoggedIn());
        }
    }
}
