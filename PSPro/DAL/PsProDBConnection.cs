using System;
using System.Collections.Generic;
using System.Text;

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
            string connectionString =
                "Server=tcp:pspro.database.windows.net,1433;Initial Catalog=pspro;Persist Security Info=False;User ID=winforms;Password=Winf0rms;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
