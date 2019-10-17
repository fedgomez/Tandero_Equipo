using System;
using System.Data.SqlClient;
//Install-Package System.Data.SqlClient -Version 4.7.0 Right click your project in "Solution Explorer" and "Manage NuGet Packages...", then search and install it from there

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
<<<<<<< HEAD
            connectionString = "Data Source=CLEOPATRA;Initial Catalog=Tandero;Integrated Security=True";
=======
            connectionString = "Server=DESKTOP-13R66OG\\SQLEXPRESS;Initial Catalog=Tandero;Integrated Security=True";
>>>>>>> bernardo
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
