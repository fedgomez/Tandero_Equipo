using System.Data.SqlClient;

namespace DataAccess
{
    public class EnteroRegister : ConnectionToSql
    {
        public int GetInfo(string query, string text)
        {
            int res;
            using (var connection = GetConnection())
            {
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    connection.Open();

                    cmd.Parameters.AddWithValue("@codigo", text);

                    res = (int)cmd.ExecuteScalar();
                }
            }
            return res;
        }
    }
}
