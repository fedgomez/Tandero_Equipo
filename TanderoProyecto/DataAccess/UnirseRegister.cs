using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess
{
    public class UnirseRegister: ConnectionToSql
    {
        public bool Unirse(int IdTanda, int IdUsuario, int turno)
        {
            const string prevUser = "El usuario se había unido previamente a la tanda";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Tandadetalle where IdTanda = @idTanda and IdUsuario = @IdUsuario";
                    command.Parameters.AddWithValue("@IdTanda", IdTanda);
                    command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show(prevUser);
                        return false;
                    }
                }
            }

            using (var connect = GetConnection())
            {
                connect.Open();
                using (var com = new SqlCommand())
                {
                    const char noiniciado = '0';
                    com.Connection = connect;
                    com.CommandText = "Insert into TandaDetalle values(@IdTanda, @IdUsuario, @Cobrado, @Turno)";
                    com.Parameters.AddWithValue("@IdTanda", IdTanda);
                    com.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    com.Parameters.AddWithValue("@Cobrado", noiniciado);
                    com.Parameters.AddWithValue("@Turno", turno);
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
