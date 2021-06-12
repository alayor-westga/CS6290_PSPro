using System;
using System.Data;
using System.Data.SqlClient;
using TechTalk.SpecFlow;
using E2ETests.Drivers;

namespace E2ETests.Steps
{
    [Binding]
    public class DBSupportSteps
    {
        [Given(@"personnel exists on the DB with this info")]
        public void GivenPersonnelExistsOnTheDBWithThisInfo(Table table)
        {

        }

        private void AddPersonnel()
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                string storedProcedureAddIncident = "AddPersonnel";
                using (SqlCommand command = new SqlCommand(storedProcedureAddIncident, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@citizen_id", "");
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
