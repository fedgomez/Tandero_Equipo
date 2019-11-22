using Common.Cache;
using Domain;
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
        private int idOrg;

        private DataTable dtParticipantes;
        public DetalleTandaParticipante(string id, string tanda, string nombreOrg, string monto, string fecha, string idOrganizador)
        {
            InitializeComponent();
            idTanda = Int32.Parse(id);
            nombreTanda = tanda;
            nombreOrganizador = nombreOrg;
            idOrg = Int32.Parse(idOrganizador);
            this.fecha = fecha;
            this.monto = monto;
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            CalificarOrganizador co = new CalificarOrganizador(nombreOrganizador, idOrg);
            co.Show();
        }

        private void DetalleTandaParticipante_Load(object sender, EventArgs e)
        {
            labelNombre.Text = nombreOrganizador;
            labelMonto.Text = monto;
            labelFechaPago.Text  = fecha;
            this.Text = nombreTanda;

            ConsultaModel consulta = new ConsultaModel();
            query = "SELECT u.Nombre FROM Usuario u INNER JOIN TandaDetalle td ON u.IdUsuario = td.idUsuario WHERE IdTanda = " + idTanda;
            dtParticipantes = consulta.ejecutaConsulta(query);
            lbParticipantes.DataSource = dtParticipantes;
            lbParticipantes.DisplayMember = "Nombre";

        }
    }
}
