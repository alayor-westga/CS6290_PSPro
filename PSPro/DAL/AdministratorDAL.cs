using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PSPro.Model;

namespace PSPro.DAL
{
    public class AdministratorDAL
    {

        /// <summary>
        /// It verifies if an administrator exists with the provided username and password.
        /// </summary>
        /// <param name="username">The administrator's username.</param>
        /// <param name="password">The administrator's password.</param>
        /// <returns>The administrator if found. Null otherwise.</returns>
        public Administrator GetByUserNameAndPassword(string username, string password)
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
                string storedProcedure = "GetAdministratorByUserNameAndPassword";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Administrator administrator = new Administrator()
                            {
                                PersonelID = (int)reader["personnel_id"],
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString()
                            };
                            return administrator;
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
