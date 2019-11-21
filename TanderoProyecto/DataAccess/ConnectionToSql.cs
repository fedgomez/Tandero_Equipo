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

            connectionString = "Data Source=DESKTOP-0KG1EJO;Initial Catalog=Tandero;Integrated Security=True";

        }

        protected SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(connectionString);
            }
            catch (InvalidCastException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }
    }
}
