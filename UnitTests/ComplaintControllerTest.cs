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
            complaintController.GetAllComplaints(StatusFilter.Open);
            complaintDAL.Verify(v => v.GetAllActiveComplaints());
        }

        [TestMethod]
        public void TestGetActiveComplaintsByOfficerId()
        {
            complaintController.GetComplaintsByOfficer(1, StatusFilter.Open);
            complaintDAL.Verify(v => v.GetActiveComplaintsByOfficer(1));
        }

        [TestMethod]
        public void TestAddCitizenAndComplaint()
        {
            Citizen citizen = new Citizen();
            Complaint complaint = new Complaint();
            complaintController.AddCitizenAndComplaint(citizen, complaint);
            complaintDAL.Verify(v => v.AddCitizenAndComplaint(citizen, complaint));
        }

        [TestMethod]
        public void TestUpdateDisposition()
        {
            complaintController.UpdateDisposition(1, "disposition1", 1);
            complaintDAL.Verify(v => v.UpdateDisposition(1, "disposition1", 1));
        }

        [TestMethod]
        public void TestAppendNotes()
        {
            complaintController.AppendNotes(1, "appendedNote");
            complaintDAL.Verify(v => v.AppendNotes(1, "appendedNote"));
        }
    }
}
