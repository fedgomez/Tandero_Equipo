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
            //TO DO: Hacer que la tabla de la base de datos se actualice 
            this.Close();
        }

        private DataTable GetData(string query)
        {
            dtUsuario = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString;

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
            query = "SELECT Nombre FROM Usuario WHERE IdUsuario = " + idUsuario;
            dtUsuario = GetData(query);

            nombreUsuario = dtUsuario.Rows[0]["Nombre"].ToString();

            this.Text = nombreUsuario;

        }
    }
}
