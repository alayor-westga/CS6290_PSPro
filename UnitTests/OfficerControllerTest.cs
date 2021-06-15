using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PSPro.Controller;
using PSPro.DAL;
using PSPro.Model;
using Moq;

namespace UnitTests
{
    [TestClass]
    public class OfficerControllerTest
    {
        private readonly OfficerController supervisorController;
        private readonly Mock<OfficerDAL> officerDAL;
        public OfficerControllerTest() {
            officerDAL = new Mock<OfficerDAL>();
            setupMocks();
            officerController = new OfficerController(officerDAL.Object);
        }

        private void setupMocks() {}

        [TestMethod]
        public void TestGetOfficersForCombobox()
        {
            officerController.GetOfficersForComboBox();
            officerDAL.Verify(v => v.GetOfficersForComboBox());
        }
    }
}
