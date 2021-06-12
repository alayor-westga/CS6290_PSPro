using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechTalk.SpecFlow;
using E2ETests.Drivers;

namespace E2ETests.Steps
{
    [Binding]
    public class DBSupportSteps
    {
        private readonly Dictionary<string, string> storedProcedures = new Dictionary<string, string>()
        {
            { "supervisor", "AddSupervisor" },
            { "investigator", "AddInvestigator" },
            { "administrator", "AddAdministrator" },
            { "officer", "AddOfficer" }
        };

        [Given(@"personnel exists on the DB with this info")]
        public void GivenPersonnelExistsOnTheDBWithThisInfo(Table table)
        {
            foreach (var row in table.Rows)
            {
                AddPersonnel(row);
            }
        }

        private void AddPersonnel(TableRow tableRow)
        {
            using (SqlConnection connection = PsProDBConnection.GetConnection())
            {
                connection.Open();
                var storedProcedure = storedProcedures.GetValueOrDefault(tableRow[0]);
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user_name", tableRow[1]);
                    command.Parameters.AddWithValue("@password", tableRow[2]);
                    command.Parameters.AddWithValue("@first_name", tableRow[3]);
                    command.Parameters.AddWithValue("@last_name", tableRow[4]);
                    command.Parameters.AddWithValue("@gender", tableRow[5]);
                    command.Parameters.AddWithValue("@hire_date", DateTime.Parse(tableRow[6]));
                    command.Parameters.AddWithValue("@birthdate", DateTime.Parse(tableRow[7]));
                    command.Parameters.AddWithValue("@assignment", tableRow[8]);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
