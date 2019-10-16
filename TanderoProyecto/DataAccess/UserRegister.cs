using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess
{
    public class UserRegister:ConnectionToSql
    {

        public bool Register(string Name, string Email, string Password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Usuario where Email = @email";
                    command.Parameters.AddWithValue("@email", Email);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Usuario ya existente");
                        return false;
                    }
                }
            }

            using (var connect = GetConnection())
            {
                connect.Open();
                using (var com = new SqlCommand())
                {
                        com.Connection = connect;
                        com.CommandText = "Insert into Usuario values(@name, @email, @pass ,0,0,0,0)";
                        com.Parameters.AddWithValue("@name", Name);
                        com.Parameters.AddWithValue("@email", Email);
                        com.Parameters.AddWithValue("@pass", Password);
                        com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                        return true;
                }
            }
        }
    }
}
