using System;
using System.Data;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Proyecto
{
    public partial class TandasOrganizador : Form
    {
        private DataTable dtTandasActuales;
        private DataTable dtTandasPasadas;
        private string query;
        private string tanda;
        private string idTanda;
        private string tandaPasada;

        private string idTandaPasada;

        public TandasOrganizador()
        {
            InitializeComponent();
        }

        private void TandasOrganizador_Load(object sender, EventArgs e)
        {
            
            query = "SELECT * FROM Tanda WHERE IdOrganizador = " + UserLoginCache.IdUsuario + "AND TandaTerminada = 0";
            dtTandasActuales = ConsultaModel.EjecutaConsulta(query);
            lbTandasOrganizador.DataSource = dtTandasActuales;
            lbTandasOrganizador.DisplayMember = "NombreTanda";
            
            query = "SELECT * FROM Tanda WHERE IdOrganizador = " + UserLoginCache.IdUsuario + "AND TandaTerminada = 1";
            dtTandasPasadas = ConsultaModel.EjecutaConsulta(query);
            lbTandasPasadas.DataSource = dtTandasPasadas;
            lbTandasPasadas.DisplayMember = "NombreTanda";

        }

        private void lbTandasOrganizador_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasOrganizador.SelectedItem == null) return;
            tanda = dtTandasActuales.Rows[lbTandasOrganizador.SelectedIndex]["NombreTanda"].ToString();
            idTanda = dtTandasActuales.Rows[lbTandasOrganizador.SelectedIndex]["IdTanda"].ToString();

            var dto = new DetalleTandaOrganizador(idTanda, tanda);
            dto.Show();

        }   

        private void lbTandasPasadas_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasPasadas.SelectedItem == null) return;
            tandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["NombreTanda"].ToString();
            idTandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["IdTanda"].ToString();

            var dto = new DetalleTandaOrganizador(idTandaPasada, tandaPasada);
            dto.Show();
        }
    }
}

