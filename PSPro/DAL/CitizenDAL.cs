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
                    if (updatedCitizen.Address2 == "")
                    {
                        updateCommand.Parameters.AddWithValue("@UpdatedAddress2", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@UpdatedAddress2", updatedCitizen.Address2);
                    }
                    updateCommand.Parameters.AddWithValue("@UpdatedCity", updatedCitizen.City);
                    updateCommand.Parameters.AddWithValue("@UpdatedState", updatedCitizen.State);
                    updateCommand.Parameters.AddWithValue("@UpdatedZipcode", updatedCitizen.ZipCode);
                    updateCommand.Parameters.AddWithValue("@UpdatedPhone", updatedCitizen.Phone);
                    if (updatedCitizen.Email == "")
                    {
                        updateCommand.Parameters.AddWithValue("@UpdatedEmail", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@UpdatedEmail", updatedCitizen.Email);
                    }

                    updateCommand.Parameters.AddWithValue("@CitizenID", citizen.CitizenID);
                    updateCommand.Parameters.AddWithValue("@FirstName", citizen.FirstName);
                    updateCommand.Parameters.AddWithValue("@LastName", citizen.LastName);
                    updateCommand.Parameters.AddWithValue("@Address1", citizen.Address1);
                    if (citizen.Address2 == "")
                    {
                        updateCommand.Parameters.AddWithValue("@Address2", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@Address2", citizen.Address2);
                    }
                    updateCommand.Parameters.AddWithValue("@City", citizen.City);
                    updateCommand.Parameters.AddWithValue("@State", citizen.State);
                    updateCommand.Parameters.AddWithValue("@Zipcode", citizen.ZipCode);
                    updateCommand.Parameters.AddWithValue("@Phone", citizen.Phone);
                    if (citizen.Email == "")
                    {
                        updateCommand.Parameters.AddWithValue("@Email", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@Email", citizen.Email);
                    }

                    SqlParameter returnValue = new SqlParameter("@RowCnt", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.Output;
                    updateCommand.Parameters.Add(returnValue);
                    updateCommand.ExecuteNonQuery();
                    int numberOfRowsAffected = (int)updateCommand.Parameters["@RowCnt"].Value;
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
