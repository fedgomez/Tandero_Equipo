using System;
using System.Collections;
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
using Common.Cache;
using DataAccess;
using Domain;

namespace Proyecto
{
    public partial class TandasOrganizador : Form
    {
        private DataTable dtTandasActuales;
        private DataTable dtTandasPasadas;
        private string query;
        string tanda;
        string idTanda;
        string tandaPasada;
        string idTandaPasada;
        string tandaTerminada;
        String nombreOrganizador;
        static SqlConnection connection;
        public TandasOrganizador()
        {
            InitializeComponent();
        }

        private void TandasOrganizador_Load(object sender, EventArgs e)
        {
            //Tandas actuales
            ConsultaModel consulta = new ConsultaModel();
            query = "SELECT * FROM Tanda WHERE IdOrganizador = " + UserLoginCache.IdUsuario + "AND TandaTerminada = 0";
            dtTandasActuales = consulta.ejecutaConsulta(query);
            lbTandasOrganizador.DataSource = dtTandasActuales;
            lbTandasOrganizador.DisplayMember = "NombreTanda";
            //Tandas pasadas
            query = "SELECT * FROM Tanda WHERE IdOrganizador = " + UserLoginCache.IdUsuario + "AND TandaTerminada = 1";
            dtTandasPasadas = consulta.ejecutaConsulta(query);
            lbTandasPasadas.DataSource = dtTandasPasadas;
            lbTandasPasadas.DisplayMember = "NombreTanda";

        }

        private void lbTandasOrganizador_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasOrganizador.SelectedItem != null)
            {
                tanda = dtTandasActuales.Rows[lbTandasOrganizador.SelectedIndex]["NombreTanda"].ToString();
                idTanda = dtTandasActuales.Rows[lbTandasOrganizador.SelectedIndex]["IdTanda"].ToString();

                DetalleTandaOrganizador dto = new DetalleTandaOrganizador(idTanda, tanda);
                dto.Show();
            }

        }   

        private void lbTandasPasadas_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasPasadas.SelectedItem != null)
            {
                tandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["NombreTanda"].ToString();
                idTandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["IdTanda"].ToString();

                DetalleTandaOrganizador dto = new DetalleTandaOrganizador(idTandaPasada, tandaPasada);
                dto.Show();
            }
        }
    }
}

