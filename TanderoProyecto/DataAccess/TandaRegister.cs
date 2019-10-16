using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// Actualizar Base de datos para autoincrementar ID de las Tandas y del Usuario
/// </summary>
namespace DataAccess
{
    public class TandaRegister : ConnectionToSql
    {
        public bool RegistrarTanda(int IdOrganizador, String FechaInicio, int DiaPago, int NoParticipantes, int Monto, String Codigo, String NombreTanda)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Tanda where IdOrganizador = @IdOrganizador and NombreTanda = @NombreTanda";
                    command.Parameters.AddWithValue("@IdOrganizador", IdOrganizador);
                    command.Parameters.AddWithValue("@NombreTanda", NombreTanda);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Tanda ya existe");
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

    }
}
