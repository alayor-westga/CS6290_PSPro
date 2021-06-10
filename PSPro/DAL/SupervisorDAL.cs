using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PSPro.Model;

namespace PSPro.DAL
{
    public class SupervisorDAL
    {

        /// <summary>
        /// It verifies if a supervisor exists with the provided username and password.
        /// </summary>
        /// <param name="username">The supervisor's username.</param>
        /// <param name="password">The supervisor's password.</param>
        /// <returns>The supervisor if found. Null otherwise.</returns>
        virtual public Supervisor GetByUserNameAndPassword(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("username cannot be null or empty.");
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("password cannot be null or empty.");
            }

            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetSupervisorByUserNameAndPassword";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Supervisor supervisor = new Supervisor()
                            {
                                PersonelID = (int)reader["personnel_id"],
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString()
                            };
                            return supervisor;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method will retrieve all officers from the database
        /// </summary>
        /// <returns>A List of OfficerComboBox objects</returns>
        virtual public List<OfficerComboBox> GetOfficersForComboBox()
        {
            List<OfficerComboBox> officerList = new List<OfficerComboBox>();
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetAllOfficersForComboBox";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OfficerComboBox officer = new OfficerComboBox();
                            {
                                officer.PersonnelID = (int)reader["personnel_id"];
                                officer.FirstName = reader["first_name"].ToString();
                                officer.LastName = reader["last_name"].ToString();
                            }
                            officerList.Add(officer);
                        }
                    }
                }
            }
            return officerList;
        }

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
                        command.Parameters.AddWithValue("@address2", citizen.Address2);
                        command.Parameters.AddWithValue("@city", citizen.City);
                        command.Parameters.AddWithValue("@state", citizen.State);
                        command.Parameters.AddWithValue("@zipcode", citizen.ZipCode);
                        command.Parameters.AddWithValue("@phone", citizen.Phone);
                        command.Parameters.AddWithValue("@email", citizen.Email);
                        command.ExecuteNonQuery();
                    }
                    int citizenID = this.GetLastCitizenID(connection, transaction);
                    this.AddComplaintWithNewCitizenID(connection, transaction, citizenID, complaint);
                    transaction.Commit();
                }
                catch(Exception exception)
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
           
            //command.Parameters.Add("@date_created", SqlDbType.DateTime2).Value = "2002-09-09" ;
            command.Parameters.AddWithValue("@allegation_type", complaint.Allegation);
            command.Parameters.AddWithValue("@complaint_notes", complaint.Summary);
            //command.Parameters.AddWithValue("@disposition", complaint.Disposition);
            //command.Parameters.AddWithValue("@disposition_date", complaint.DispositionDate);
            //command.Parameters.AddWithValue("@discipline", complaint.Discipline);
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
