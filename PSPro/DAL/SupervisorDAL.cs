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

        public bool UpdateCitizen(Citizen citizen, Citizen updatedCitizen)
        {
            if (citizen == null)
            {
                throw new ArgumentNullException("citizen");
            }
            if (updatedCitizen == null)
            {
                throw new ArgumentNullException("updatedCitizen");
            }
            string storedProcedure = "UpdateCitizen";

            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(storedProcedure, connection))
                {
                    updateCommand.CommandType = CommandType.StoredProcedure;
                    updateCommand.Parameters.AddWithValue("@UpdatedFirstName", updatedCitizen.FirstName);
                    updateCommand.Parameters.AddWithValue("@UpdatedLastName", updatedCitizen.LastName);
                    updateCommand.Parameters.AddWithValue("@UpdatedAddress1", updatedCitizen.Address1);
                    updateCommand.Parameters.AddWithValue("@UpdatedAddress2", updatedCitizen.Address2);
                    updateCommand.Parameters.AddWithValue("@UpdatedCity", updatedCitizen.City);
                    updateCommand.Parameters.AddWithValue("@UpdatedState", updatedCitizen.State);
                    updateCommand.Parameters.AddWithValue("@UpdatedZipcode", updatedCitizen.ZipCode);
                    updateCommand.Parameters.AddWithValue("@UpdatedPhone", updatedCitizen.Phone);
                    updateCommand.Parameters.AddWithValue("@UpdatedEmail", updatedCitizen.Email);        

                    updateCommand.Parameters.AddWithValue("@CitizenID", citizen.CitizenID);
                    updateCommand.Parameters.AddWithValue("@FirstName", citizen.FirstName);
                    updateCommand.Parameters.AddWithValue("@LastName", citizen.LastName);
                    updateCommand.Parameters.AddWithValue("@Address1", citizen.Address1);
                    updateCommand.Parameters.AddWithValue("@Address2", citizen.Address2);
                    updateCommand.Parameters.AddWithValue("@City", citizen.City);
                    updateCommand.Parameters.AddWithValue("@State", citizen.State);
                    updateCommand.Parameters.AddWithValue("@Zipcode", citizen.ZipCode);
                    updateCommand.Parameters.AddWithValue("@Phone", citizen.Phone);
                    updateCommand.Parameters.AddWithValue("@Email", citizen.Email);

                    SqlParameter returnValue = new SqlParameter("@RowCnt", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.Output;
                    updateCommand.Parameters.Add(returnValue);
                    updateCommand.ExecuteNonQuery();
                    int numberOfRowsAffected = (int) updateCommand.Parameters["@RowCnt"].Value;
                    if (numberOfRowsAffected > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public Citizen GetCitizen(int citizenID)
        {
            if (citizenID < 0)
            {
                throw new ArgumentException("patientID must not be negative");
            }
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetCitizen";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@citizen_id", citizenID);
                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            Citizen citizen = new Citizen()
                            {
                                CitizenID = (int)reader["citizen_id"],
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                ZipCode = reader["zipcode"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Email = reader["email"].ToString(),
                            };
                            return citizen;
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
