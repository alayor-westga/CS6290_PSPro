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
            string dbName = "pspro";
            if (Program.Env == Program.Environments.E2E_TESTS) 
            {
                dbName = "pspro_e2e_tests";
            }
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:pspro.database.windows.net"; 
                builder.UserID = "winforms";            
                builder.Password = "Winf0rms";     
                builder.InitialCatalog = dbName;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}
