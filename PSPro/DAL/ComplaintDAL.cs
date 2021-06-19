using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PSPro.Model;

namespace PSPro.DAL
{
    /// <summary>
    /// Complaint DAL
    /// </summary>
    public class ComplaintDAL
    {
        /// <summary>
        /// Gets all active complaints for display in view
        /// </summary>
        /// <returns>a LIst of all active complaints</returns>
        virtual public List<ComplaintView> GetAllActiveComplaints()
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetAllActiveComplaints";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return BuildComplaintViewList(reader);
                    }
                }
            }
        }

        /// <summary>
        /// Gets all active complaints by officer
        /// </summary>
        /// <param name="officerPersonelId"></param>
        /// <returns>a List of a single officer's active complaints</returns>
        virtual public List<ComplaintView> GetActiveComplaintsByOfficer(int officerPersonelId)
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetActiveComplaintsByOfficer";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@officers_personnel_id", officerPersonelId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return BuildComplaintViewList(reader);
                    }
                }
            }
        }

        private List<ComplaintView> BuildComplaintViewList(SqlDataReader reader)
        {
            List<ComplaintView> complaintViewList = new List<ComplaintView>();
            while (reader.Read())
            {
                ComplaintView complaintView = new ComplaintView();
                {
                    complaintView.ComplaintID = int.Parse(reader["complaint_id"].ToString());
                    complaintView.DateCreated = DateTime.Parse(reader["date_created"].ToString());
                    complaintView.OfficerFullName = reader["officer_full_name"].ToString();
                    complaintView.CitizenFullName = reader["citizen_full_name"].ToString();
                    complaintView.Disposition = reader["disposition"].ToString();
                }
                complaintViewList.Add(complaintView);
            }
            return complaintViewList;
        }

        /// <summary>
        /// Adds a new complaint to the complaint table
        /// </summary>
        /// <param name="complaint"></param>
        virtual public void AddComplaint(Complaint complaint)
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedureAddIncident = "AddComplaint";
                using (SqlCommand command = new SqlCommand(storedProcedureAddIncident, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@citizen_id", complaint.CitizenID);
                    this.AddComplaintDetails(command, complaint);
                }
            }
        }

        /// <summary>
        /// Adds a new citizen to the Citizen table and also creates a new complaint with the assoicated new citizen
        /// </summary>
        /// <param name="citizen"></param>
        /// <param name="complaint"></param>
        virtual public void AddCitizenAndComplaint(Citizen citizen, Complaint complaint)
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                string storedProcedureAddIncident = "AddCitizen";
                try
                {
                    using (SqlCommand command = new SqlCommand(storedProcedureAddIncident, connection, transaction))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@first_name", citizen.FirstName);
                        command.Parameters.AddWithValue("@last_name", citizen.LastName);
                        command.Parameters.AddWithValue("@address1", citizen.Address1);
                        if (citizen.Address2 == "")
                        {
                            command.Parameters.AddWithValue("@address2", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@address2", citizen.Address2);
                        }
                        command.Parameters.AddWithValue("@city", citizen.City);
                        command.Parameters.AddWithValue("@state", citizen.State);
                        command.Parameters.AddWithValue("@zipcode", citizen.ZipCode);
                        command.Parameters.AddWithValue("@phone", citizen.Phone);
                        if (citizen.Email == "")
                        {
                            command.Parameters.AddWithValue("@email", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@email", citizen.Email);
                        }
                        command.ExecuteNonQuery();
                    }
                    int citizenID = this.GetLastCitizenID(connection, transaction);
                    this.AddComplaintWithNewCitizenID(connection, transaction, citizenID, complaint);
                    transaction.Commit();
                }
                catch (Exception exception)
                {
                    transaction.Rollback();
                    throw exception;
                }
            }
        }

        private void AddComplaintWithNewCitizenID(SqlConnection connection, SqlTransaction transaction, int citizenID, Complaint complaint)
        {
            string storedProcedureAddComplaint = "AddComplaint";

            using (SqlCommand command = new SqlCommand(storedProcedureAddComplaint, connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@citizen_id", citizenID);
                this.AddComplaintDetails(command, complaint);
            }
        }

        private void AddComplaintDetails(SqlCommand command, Complaint complaint)
        {
            command.Parameters.AddWithValue("@officers_personnel_id", complaint.OfficerID);
            command.Parameters.AddWithValue("@supervisors_personnel_id", complaint.SupervisorID);
            command.Parameters.AddWithValue("@allegation_type", complaint.Allegation);
            command.Parameters.AddWithValue("@complaint_notes", complaint.Summary);
            command.ExecuteNonQuery();
        }

        private int GetLastCitizenID(SqlConnection connection, SqlTransaction transaction)
        {
            int lastCitizenID = 0;
            string storedProcedure = "GetLastCitizenID";

            using (SqlCommand selectCommand = new SqlCommand(storedProcedure, connection, transaction))
            {
                selectCommand.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))

                {
                    while (reader.Read())
                    {
                        lastCitizenID = (int)reader["citizen_id"];
                    }
                }
            }
            return lastCitizenID;
        }
    }
}
