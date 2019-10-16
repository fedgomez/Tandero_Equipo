using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.Net.Sockets;
using System.Windows.Forms;

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
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUsuario = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.Email = reader.GetString(2);
                            UserLoginCache.numVotosO = reader.GetInt32(6);
                            UserLoginCache.numVotosP = reader.GetInt32(4);
                            UserLoginCache.sumRatingP = reader.GetInt32(5);
                            UserLoginCache.sumRatingO = reader.GetInt32(7);

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
