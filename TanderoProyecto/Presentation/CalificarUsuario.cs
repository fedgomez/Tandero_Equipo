using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Proyecto
{
    public partial class CalificarUsuario : Form
    {
        private int idUsuario;
        private string nombreUsuario;
        private DataTable dtUsuario;
        private string query;
        public CalificarUsuario(string id)
        {
            InitializeComponent();
            idUsuario = Int32.Parse(id);
            
        }

        private void btnCalificarUsuario_Click(object sender, EventArgs e)
        {
            string AssignRating = "Rating Participante asignado";
            if (textBox1.Text != "")
            {
                TandaModel rating = new TandaModel();
                var validRating = rating.UserRating(textBox1.Text, true, idUsuario);
                if (validRating == true)
                {
                    MessageBox.Show(AssignRating);
                }
            }
            this.Close();
        }

        private DataTable GetData(string query)
        {
            string dbconnection = "dbtest";
            dtUsuario = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings[dbconnection].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtUsuario.Load(reader);
                }
            }

            return dtUsuario;

        }

        private void CalificarUsuario_Load(object sender, EventArgs e)
        {
            string name = "Nombre";
            query = "SELECT Nombre FROM Usuario WHERE IdUsuario = " + idUsuario;
            
            dtUsuario = GetData(query);
            nombreUsuario = dtUsuario.Rows[0][name].ToString();
            this.Text = nombreUsuario;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string AssignRating = "Rating Participante asignado";
            if (labelRaring.Text != "")
            {
                TandaModel getrating = new TandaModel();
                var validRating = getrating.GetUserRating(idUsuario, true);
                if (validRating == true)
                {
                    MessageBox.Show(AssignRating);
                }
            }
        }
    }
}
