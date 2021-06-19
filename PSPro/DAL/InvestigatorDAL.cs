using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PSPro.Model;

namespace PSPro.DAL
{
    /// <summary>
    /// Investigator DAL
    /// </summary>
    public class InvestigatorDAL
    {

        /// <summary>
        /// It verifies if an investigator exists with the provided username and password.
        /// </summary>
        /// <param name="username">The investigator's username.</param>
        /// <param name="password">The investigator's password.</param>
        /// <returns>The investigator if found. Null otherwise.</returns>
        virtual public Investigator GetByUserNameAndPassword(string username, string password)
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
                string storedProcedure = "GetInvestigatorByUserNameAndPassword";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Investigator investigator = new Investigator()
                            {
                                PersonelID = (int)reader["personnel_id"],
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString()
                            };
                            return investigator;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

    }
}
