using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PSPro.Controller;
using PSPro.DAL;
using PSPro.Model;
using Moq;

namespace UnitTests
{
    [TestClass]
    public class ComplaintControllerTest
    {
        private readonly ComplaintController complaintController;
        private readonly Mock<ComplaintDAL> complaintDAL;
        public ComplaintControllerTest()
        {
            complaintDAL = new Mock<ComplaintDAL>();
            setupMocks();
            complaintController = new ComplaintController(complaintDAL.Object);
        }

        private void setupMocks() { }

        [TestMethod]
        public void TestGetAllActiveComplaints()
        {
            complaintController.GetAllActiveComplaints();
            complaintDAL.Verify(v => v.GetAllActiveComplaints());
        }

        [TestMethod]
        public void TestGetActiveComplaintsByOfficerId()
        {
            complaintController.GetActiveComplaintsByOfficerId(1);
            complaintDAL.Verify(v => v.GetActiveComplaintsByOfficerId(1));
        }
    }
}
