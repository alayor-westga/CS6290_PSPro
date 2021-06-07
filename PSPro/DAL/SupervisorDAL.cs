using PSPro.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
        public void GetByUserNameAndPassword(string username, string password)
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
                        
                    }
                }
            }
        }

        /// <summary>
        /// This method will retrieve all officers from the database
        /// </summary>
        /// <returns>A List of OfficerComboBox objects</returns>
        public List<OfficerComboBox> GetOfficerForComboBox()
        {
            List<OfficerComboBox> officerList = new List<OfficerComboBox>();
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetOfficersForComboBox";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OfficerComboBox officer = new OfficerComboBox();
                            {
                                officer.PersonnelID = Int32.Parse(reader["personnel_id"].ToString());
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
    }
}
