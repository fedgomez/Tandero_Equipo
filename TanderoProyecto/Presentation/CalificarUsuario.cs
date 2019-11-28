using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Domain;

namespace Proyecto
{
    public partial class CalificarUsuario : Form
    {
        private readonly int idUsuario;
        private string nombreUsuario;
        private DataTable dtUsuario;
        private string query;
        public CalificarUsuario(string id)
        {
            InitializeComponent();
            idUsuario = int.Parse(id);
            
        }

        private void btnCalificarUsuario_Click(object sender, EventArgs e)
        {
            const string assignRating = "Rating Participante asignado";
            if (textBoxCalificarUsuario.Text != "")
            {
                var rating = new TandaModel();
                var validRating = rating.UserRating(textBoxCalificarUsuario.Text, true, idUsuario);
                if (validRating)
                {
                    MessageBox.Show(assignRating);
                }
            }
            Close();
        }

        private DataTable GetData(string query)
        {
            const string dbconnection = "dbtest";
            dtUsuario = new DataTable();

            var connectionString = ConfigurationManager.ConnectionStrings[dbconnection].ConnectionString;

            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    dtUsuario.Load(reader);
                }
            }

            return dtUsuario;

        }

        private void CalificarUsuario_Load(object sender, EventArgs e)
        {
            const string name = "Nombre";
            query = "SELECT Nombre FROM Usuario WHERE IdUsuario = " + idUsuario;
            
            dtUsuario = GetData(query);
            nombreUsuario = dtUsuario.Rows[0][name].ToString();
            Text = nombreUsuario;

        }

    }
}
