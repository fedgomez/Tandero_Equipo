using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataAccess
{
    public class TandaRegister : ConnectionToSql
    {
        public bool RegistrarTanda(int IdOrganizador, string FechaInicio, int DiaPago, int NoParticipantes, int Monto, string Codigo, string NombreTanda)
        {
            const string dupData = "Datos duplicados";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Tanda where codigo = @codigo or NombreTanda = @NombreTanda";
                    command.Parameters.AddWithValue("@codigo", Codigo);
                    command.Parameters.AddWithValue("@NombreTanda", NombreTanda);
                    
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show(dupData);
                        return false;
                    }
                }

            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "Insert into Tanda values (@IdOrganizador, @FechaInicio, @DiaPago, @NoParticipantes, @Monto, @Codigo, @NombreTanda, @TandaTerminada)";
                    command.Parameters.AddWithValue("@IdOrganizador", IdOrganizador);
                    command.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                    command.Parameters.AddWithValue("@DiaPago", DiaPago);
                    command.Parameters.AddWithValue("@NoParticipantes", NoParticipantes);
                    command.Parameters.AddWithValue("@Monto", Monto);
                    command.Parameters.AddWithValue("@Codigo", Codigo);
                    command.Parameters.AddWithValue("@NombreTanda", NombreTanda);
                    command.Parameters.AddWithValue("@TandaTerminada", 0);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;

                }
            }




        }

        public bool UserRating(string Rating, bool Tipo, int IdUsuario)
        {
            var reg = int.Parse(Rating);
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Rate", reg);
                    command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    command.CommandText = Tipo ? "Update Usuario set sumRatingP = sumRatingP + @Rate, numVotosP = numVotosP + 1 where IdUsuario = @IdUsuario" : "Update Usuario set sumVotosO = sumVotosO + @Rate, numVotosO = numVotosO + 1 where IdUsuario = @IdUsuario";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;
                }
            }
        }


    }
}
