using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ConsultaRegister : ConnectionToSql
    {
        public DataTable GetInfo(string query)
        {
            var dt = new DataTable();
            using (var connection = GetConnection())
            {
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;

                    connection.Open();

                    var reader = cmd.ExecuteReader();

                    dt.Load(reader);
                }
            }
            return dt;
        }
    }
}
