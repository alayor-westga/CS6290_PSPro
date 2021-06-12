using System.Data.SqlClient;

namespace E2ETests.Drivers
{
    /// <summary>
    /// Get a connection object. 
    /// </summary>
    public class PsProDBConnection
    {
        /// <summary>
        /// It returns a SQL connection to the pspro DB.
        /// </summary>
        /// <returns>A SQL connection</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=pspro_e2e_tests;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
