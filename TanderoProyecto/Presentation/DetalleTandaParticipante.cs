
using System;
using System.Data;

namespace Presentation
{
    public partial class DetalleTandaParticipante : Form
    {

        private DataTable dtTanda;
        private DataTable dtTandaDetalle;
        private string query = "";
        private string nombreTanda;
        private int idTanda;
        private string nombreUsuario;
        private string idUsuario;
        private string nombreOrganizador;
        private string fecha;
        private string monto;

        private DataTable dtParticipantes;
        public DetalleTandaParticipante(string id, string tanda, string nombreOrg, string monto, string fecha)
        {
            InitializeComponent();
            idTanda = Int32.Parse(id);
            nombreTanda = tanda;
            nombreOrganizador = nombreOrg;
            this.fecha = fecha;
            this.monto = monto;
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            CalificarOrganizador co = new CalificarOrganizador(nombreOrganizador);
            co.Show();
        }

        private void DetalleTandaParticipante_Load(object sender, EventArgs e)
        {
            labelNombre.Text = nombreOrganizador;
            labelMonto.Text = monto;
            labelFechaPago.Text  = fecha;
            this.Text = nombreTanda;

            query = "SELECT u.Nombre FROM Usuario u INNER JOIN TandaDetalle td ON u.IdUsuario = td.idUsuario WHERE IdTanda = " + idTanda;
            lbParticipantes.DataSource = GetData(query);
            dtParticipantes = GetData(query);
            lbParticipantes.DisplayMember = "Nombre";

        }

        private DataTable GetData(string query)
        {
            DataTable dtTandas = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtTandas.Load(reader);
                }
            }

            return dtTandas;

        }
    }
}
