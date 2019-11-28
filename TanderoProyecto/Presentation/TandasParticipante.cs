using Common.Cache;

using DataAccess;

using System;
using System.Data;
using System.Windows.Forms;
using Domain;

namespace Proyecto
{
    public partial class TandasParticipante : Form
    {
        private string monto;
        private string montoPasado;
        private string fecha;
        private string fechaPasada;
        private string tanda;
        private string idTanda;
        private string nombreOrganizador;
        private string idOrganizadorPasada;
        private string idOrganizadorActual;
        private string tandaPasada;
        private string idTandaPasada;

        private string nombreOrganizadorPasada;

        private string query;

        private DataTable dtTandasActuales;
        private DataTable dtTandasPasadas;

        public TandasParticipante()
        {
            InitializeComponent();
        }

        private void btnUnirTanda_Click(object sender, EventArgs e)
        {
            const string register = "Registro exitoso";
            var rn = new Random();
            
            
              
                const string sql = "Select IdTanda from Tanda where Codigo = @codigo";
                var idt = EnteroModel.EjecutaConsulta(sql, tbUnirATanda.Text);
                const string sql2 = "Select IdOrganizador from Tanda where Codigo = @codigo";
              
                const string sql3 = "Select NoParticipantes from Tanda where Codigo = @codigo";
                var pt = EnteroModel.EjecutaConsulta(sql3, tbUnirATanda.Text);

                idOrganizadorActual = sql2;
                
                var turno = rn.Next(1,pt);

            var idUser = UserLoginCache.IdUsuario;

            var ur = new UnirseRegister();

           var registro = ur.Unirse(idt, idUser, turno);
           if (registro != true) return;
           MessageBox.Show(register);
            Hide();
        }
        private void TandasParticipante_Load(object sender, EventArgs e)
        {
            
            query = "SELECT * FROM TandaDetalle td INNER JOIN Tanda t ON t.IdTanda = td.IdTanda INNER JOIN Usuario u ON u.IdUsuario = t.idOrganizador WHERE td.idUsuario = " + UserLoginCache.IdUsuario + " AND TandaTerminada = 0";
            dtTandasActuales = ConsultaModel.EjecutaConsulta(query);
            lbTandasActuales.DataSource = dtTandasActuales;
            lbTandasActuales.DisplayMember = "NombreTanda";
            
            query = "SELECT * FROM TandaDetalle td INNER JOIN Tanda t ON t.IdTanda = td.IdTanda INNER JOIN Usuario u ON u.IdUsuario = t.idOrganizador WHERE td.idUsuario = " + UserLoginCache.IdUsuario + " AND TandaTerminada = 1";
            dtTandasPasadas = ConsultaModel.EjecutaConsulta(query);
            lbTandasPasadas.DataSource = dtTandasPasadas;
            lbTandasPasadas.DisplayMember = "NombreTanda";
        }

        private void lbTandasActuales_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasActuales.SelectedItem == null) return;
            tanda = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["NombreTanda"].ToString();
            idTanda = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["IdTanda"].ToString();
            nombreOrganizador = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["Nombre"].ToString();
            monto = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["Monto"].ToString();
            fecha = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["FechaInicio"].ToString();
            idOrganizadorActual = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["IdOrganizador"].ToString();

            var dto = new DetalleTandaParticipante(idTanda, tanda, nombreOrganizador, monto, fecha, idOrganizadorActual);
            dto.Show();
        }

        private void lbTandasPasadas_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasPasadas.SelectedItem == null) return;
            tandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["NombreTanda"].ToString();
            idTandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["IdTanda"].ToString();
            nombreOrganizadorPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["Nombre"].ToString();
            montoPasado = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["Monto"].ToString();
            fechaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["FechaInicio"].ToString();
            idOrganizadorPasada = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["IdOrganizador"].ToString();

            var dto = new DetalleTandaParticipante(idTandaPasada, tandaPasada,
                nombreOrganizadorPasada, montoPasado, fechaPasada, idOrganizadorPasada);
            dto.Show();
        }
    }
}
