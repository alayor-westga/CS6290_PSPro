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
        public Supervisor GetByUserNameAndPassword(string username, string password)
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
        public List<OfficerComboBox> GetOfficersForComboBox()
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

        public void AddCitizen(Citizen citizen)
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "AddIncident";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
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
            }
        }
    }
}
