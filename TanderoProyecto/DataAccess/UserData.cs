using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserData:ConnectionToSql
    {
        public bool Login(string Email, string Password)
        {
            using (var connection = GetConnection()) 
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection=connection;
                    command.CommandText = "Select * from Usuario where Email = @email and Password = @password";
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@password", Password); 
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (!reader.HasRows) return false;
                    while (reader.Read())
                    {
                        UserLoginCache.IdUsuario = reader.GetInt32(0);
                        UserLoginCache.Nombre = reader.GetString(1);
                        UserLoginCache.Email = reader.GetString(2);
                        UserLoginCache.NumVotosO = reader.GetInt32(6);
                        UserLoginCache.NumVotosP = reader.GetInt32(4);
                        UserLoginCache.SumRatingP = reader.GetInt32(5);
                        UserLoginCache.SumRatingO = reader.GetInt32(7);

                    }
                    return true;

                }
            }
        }
    }
}