using PSPro.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSPro.DAL
{
    /// <summary>
    /// Citizen object DAL
    /// </summary>
    class CitizenDAL
    {
        /// <summary>
        /// Searches for Citizen by first and/or last name and returns a list of matching Citizens
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>List of Citizen objects matching search criteria</returns>
        public List<Citizen> SearchByName(string firstName, string lastName)
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetCitizensByName";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@first_name", firstName);
                    command.Parameters.AddWithValue("@last_name", lastName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return this.BuildCitizenViewList(reader);
                    }
                }
            }
        }

        /// <summary>
        /// Searches for Citizen by email and returns a list of matching Citizens
        /// </summary>
        /// <param name="email"></param>
        /// <returns>List of Citizen objects matching search criteria</returns>
        public List<Citizen> SearchByEmail(string email)
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetCitizensByEmail";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return this.BuildCitizenViewList(reader);
                    }
                }
            }
        }

        /// <summary>
        /// Searches for Citizen by phone and returns a list of matching Citizens
        /// </summary>
        /// <param name="phone"></param>
        /// <returns>List of Citizen objects matching search criteria</returns>
        public List<Citizen> SearchByPhone(string phone)
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedure = "GetCitizensByPhoneNumber";
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@phone", phone);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return this.BuildCitizenViewList(reader);
                    }
                }
            }
        }

        private List<Citizen> BuildCitizenViewList(SqlDataReader reader)
        {
            List<Citizen> citizenViewList = new List<Citizen>();
            while (reader.Read())
            {
                Citizen citizenView = new Citizen();
                {
                    citizenView.CitizenID = int.Parse(reader["citizen_id"].ToString());
                    citizenView.FirstName = reader["first_name"].ToString();
                    citizenView.LastName = reader["last_name"].ToString();
                    citizenView.Address1 = reader["address1"].ToString();
                    citizenView.Address2 = reader["address2"].ToString();
                    citizenView.City = reader["city"].ToString();
                    citizenView.State = reader["state"].ToString();
                    citizenView.ZipCode = reader["zipcode"].ToString();
                    citizenView.Phone = reader["phone"].ToString();
                    citizenView.Email = reader["email"].ToString();
                }
                citizenViewList.Add(citizenView);
            }
            return citizenViewList;
        }
    }
}
