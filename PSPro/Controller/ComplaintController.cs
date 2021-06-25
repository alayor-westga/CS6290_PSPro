using System;
using System.Collections.Generic;
using System.Text;
using PSPro.DAL;
using PSPro.Model;

namespace PSPro.Controller
{
    /// <summary>
    /// Controller class for Complaints
    /// </summary>
    public class ComplaintController
    {
        private readonly ComplaintDAL complaintSource;

        public ComplaintController() : this(new ComplaintDAL()) { }

        /// <summary>
        /// It creates a SupervisorController injecting dependencies.
        /// </summary>
        public ComplaintController(ComplaintDAL complaintSource)
        {
            this.complaintSource = complaintSource;
        }

        /// <summary>
        /// Gets all active complaints
        /// </summary>
        /// <returns>a List of active complaints</returns>
        public List<ComplaintView> GetAllActiveComplaints()
        {
            return this.complaintSource.GetAllActiveComplaints();
        }

        /// <summary>
        /// Gets all active complaints by officer
        /// </summary>
        /// <param name="officerPersonelId"></param>
        /// <returns>a List of active complaints by officer</returns>
        public List<ComplaintView> GetActiveComplaintsByOfficer(int officerPersonelId)
        {
            return this.complaintSource.GetActiveComplaintsByOfficer(officerPersonelId);
        }

        /// <summary>
        /// Adds Citizen object to Citizen table and adds a new Complaint object to Complaint table
        /// </summary>
        /// <param name="citizen"></param>
        /// <param name="complaint"></param>
        public void AddCitizenAndComplaint(Citizen citizen, Complaint complaint)
        {
            this.complaintSource.AddCitizenAndComplaint(citizen, complaint);
        }

        /// <summary>
        /// Adds new Complaint object to Complaint table
        /// </summary>
        /// <param name="complaint"></param>
        public void AddComplaint(Complaint complaint)
        {
            this.complaintSource.AddComplaint(complaint);
        }

        internal void UpdateDiscipline(int complaintId, string discipline)
        {
            this.complaintSource.UpdateDiscipline(complaintId, discipline);
        }

        /// <summary>
        /// Get complaint view by id
        /// </summary>
        /// <param name="complaintId">the complaint id to be retrieved.</param>
        /// <returns>Complaint information</returns>
        public ComplaintView GetComplaintById(int complaintId)
        {
            return this.complaintSource.GetComplaintById(complaintId);
        }

        /// <summary>
        /// Update complaint's disposition.
        /// </summary>
        /// <param name="complaintId">the complaint id to be updates.</param>
        /// <param name="disposition">the new disposition of the complaint.</param>
        public void UpdateDisposition(int complaintId, string disposition)
        {
            this.complaintSource.UpdateDisposition(complaintId, disposition);
        }

        /// <summary>
        /// Append to complaint's notes.
        /// </summary>
        /// <param name="complaintId">the complaint id to be updates.</param>
        /// <param name="notesToAppend">the notes to be appended.</param>
        public void AppendNotes(int complaintId, string notesToAppend)
        {
            this.complaintSource.AppendNotes(complaintId, notesToAppend);
        }
    }
}
