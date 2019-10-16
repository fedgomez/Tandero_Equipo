using Common.Cache;
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
    public partial class DetalleTandaOrganizador : Form
    {
        private DataTable dtParticipantes;
        private string query = "";
        private string nombreTanda;
        private int idTanda;
        public DetalleTandaOrganizador(string id, string tanda)
        {
            InitializeComponent();
            idTanda = Int32.Parse(id);
            nombreTanda = tanda;

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //TO DO: Habilitar el botón cuando todos hayan recibido un número igual de pagos.
            // Validar que todos ya hayan tenido su cobro de la tanda

        }

        private void DetalleTandaOrganizador_Load(object sender, EventArgs e)
        {
            labelNombre.Text = UserLoginCache.Nombre.ToString();
            query = "SELECT u.Nombre FROM Usuario u INNER JOIN TandaDetalle td ON u.IdUsuario = td.idUsuario WHERE IdTanda = " + idTanda + " EXCEPT SELECT u.Nombre FROM Usuario u INNER JOIN TandaDetalle td ON u.IdUsuario = td.idUsuario WHERE td.idUsuario = " + UserLoginCache.IdUsuario;
            lbParticipantes.DataSource = GetData(query);
            lbParticipantes.DisplayMember = "Nombre";

            this.Text = nombreTanda;


        }

        private DataTable GetData(string query)
        {
            dtParticipantes = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtParticipantes.Load(reader);
                }
            }

            return dtParticipantes;

        }
    }
}
