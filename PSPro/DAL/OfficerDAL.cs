using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PSPro.Model;

namespace PSPro.DAL
{
    /// <summary>
    /// Officer DAL
    /// </summary>
    public class OfficerDAL
    {
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
    }
}