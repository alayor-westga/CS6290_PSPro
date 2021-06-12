using System.Data.SqlClient;

namespace PSPro.DAL
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
            string connectionString = "Server=tcp:pspro.database.windows.net,1433;" +
            "Initial Catalog=pspro;Persist Security Info=False;User ID=adm1n;" +
            "Password=Pa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;" +
            "TrustServerCertificate=False;Connection Timeout=30;";

            if (Program.Env == Program.Environments.E2E_TESTS)
            {
                connectionString = "Data Source=localhost;Initial Catalog=pspro_e2e_tests;" +
                "Integrated Security=True";
            }

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
