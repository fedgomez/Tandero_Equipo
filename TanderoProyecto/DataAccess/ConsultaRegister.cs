using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class ConsultaRegister : ConnectionToSql
    {
        public DataTable getInfo(string query)
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }
            return dt;
        }
    }
}
