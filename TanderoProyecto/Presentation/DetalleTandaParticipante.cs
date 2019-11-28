using Domain;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class DetalleTandaParticipante : Form
    {


        private string query = "";
        private readonly string nombreTanda;
        private readonly int idTanda;

        private readonly string nombreOrganizador;
        private readonly string fecha;
        private readonly string monto;
        private readonly int idOrg;

        private DataTable dtParticipantes;
        public DetalleTandaParticipante(string id, string tanda, string nombreOrg, string monto, string fecha, string idOrganizador)
        {
            InitializeComponent();
            idTanda = int.Parse(id);
            nombreTanda = tanda;
            nombreOrganizador = nombreOrg;
            idOrg = int.Parse(idOrganizador);
            this.fecha = fecha;
            this.monto = monto;
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            var co = new CalificarOrganizador(nombreOrganizador, idOrg);
            co.Show();
        }

        private void DetalleTandaParticipante_Load(object sender, EventArgs e)
        {
            labelNombre.Text = nombreOrganizador;
            labelMonto.Text = monto;
            labelFechaPago.Text  = fecha;
            Text = nombreTanda;

          
            query = "SELECT u.Nombre FROM Usuario u INNER JOIN TandaDetalle td ON u.IdUsuario = td.idUsuario WHERE IdTanda = " + idTanda;
            dtParticipantes = ConsultaModel.EjecutaConsulta(query);
            lbParticipantes.DataSource = dtParticipantes;
            lbParticipantes.DisplayMember = "Nombre";

        }
    }
}
