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
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:pspro.database.windows.net"; 
                builder.UserID = "winforms";            
                builder.Password = "Winf0rms";     
                builder.InitialCatalog = "pspro_e2e_tests";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}
