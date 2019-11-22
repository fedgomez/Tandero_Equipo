using Common.Cache;

using DataAccess;

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
    public partial class TandasParticipante : Form
    {
        String monto;
        String montoPasado;
        String fecha;
        String fechaPasada;
        String tanda;
        String idTanda;
        String nombreOrganizador;
        String idOrganizadorPasada;
        String idOrganizadorActual;
        String tandaPasada;
        String idTandaPasada;
        String nombreOrganizadorPasada;
        String apellidoOrganizador;
        String[] participantes = null;
        String query;

        DataTable dtTandasActuales;
        DataTable dtTandasPasadas;

        public TandasParticipante()
        {
            InitializeComponent();
        }

        private void btnUnirTanda_Click(object sender, EventArgs e)
        {
            string register = "Registro exitoso";
            int idt, ido, turno, pt;
            Random rn = new Random();
            
            
            using (var con = new SqlConnection(@"Data Source=DESKTOP-0KG1EJO;Initial Catalog=Tandero;Integrated Security=True"))
            {
                var sql = "Select IdTanda from Tanda where Codigo = @codigo";
                var sql2 = "Select IdOrganizador from Tanda where Codigo = @codigo";
                var sql3 = "Select NoParticipantes from Tanda where Codigo = @codigo";
                idOrganizadorActual = sql2;
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Codigo", tbUnirATanda.Text);
                    con.Open();
                    idt = (int)cmd.ExecuteScalar();
                }
                using (var cmd2 = new SqlCommand(sql2, con))
                {
                    cmd2.Parameters.AddWithValue("@codigo", tbUnirATanda.Text);
                    ido = (int)cmd2.ExecuteScalar();
                }

                using (var cmd3 = new SqlCommand(sql3, con))
                {
                    cmd3.Parameters.AddWithValue("@codigo", tbUnirATanda.Text);
                    pt = (int)cmd3.ExecuteScalar();
                }
                turno = rn.Next(1,pt);

                con.Close();
            }


            var idUser = UserLoginCache.IdUsuario;

            UnirseRegister ur = new UnirseRegister();

           var registro = ur.Unirse(idt, idUser, '0', turno);
            if (registro == true)
            {
                MessageBox.Show(register);
                this.Hide();
            }
        }
        private void TandasParticipante_Load(object sender, EventArgs e)
        {
            //Tandas actuales
            ConsultaModel consulta = new ConsultaModel();
            query = "SELECT * FROM TandaDetalle td INNER JOIN Tanda t ON t.IdTanda = td.IdTanda INNER JOIN Usuario u ON u.IdUsuario = t.idOrganizador WHERE td.idUsuario = " + UserLoginCache.IdUsuario + " AND TandaTerminada = 0";
            dtTandasActuales = consulta.ejecutaConsulta(query);
            lbTandasActuales.DataSource = dtTandasActuales;
            lbTandasActuales.DisplayMember = "NombreTanda";
            //Tandas pasadas
            query = "SELECT * FROM TandaDetalle td INNER JOIN Tanda t ON t.IdTanda = td.IdTanda INNER JOIN Usuario u ON u.IdUsuario = t.idOrganizador WHERE td.idUsuario = " + UserLoginCache.IdUsuario + " AND TandaTerminada = 1";
            dtTandasPasadas = consulta.ejecutaConsulta(query);
            lbTandasPasadas.DataSource = dtTandasPasadas;
            lbTandasPasadas.DisplayMember = "NombreTanda";
        }

        private void lbTandasActuales_DoubleClick(object sender, EventArgs e)
        {

            if (lbTandasActuales.SelectedItem != null)
            {
                tanda = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["NombreTanda"].ToString();
                idTanda = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["IdTanda"].ToString();
                nombreOrganizador = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["Nombre"].ToString();
                monto = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["Monto"].ToString();
                fecha = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["FechaInicio"].ToString();
                idOrganizadorActual = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["IdOrganizador"].ToString();

                DetalleTandaParticipante dto = new DetalleTandaParticipante(idTanda, tanda, nombreOrganizador, monto, fecha, idOrganizadorActual);
                dto.Show();
            }
        }

        private void lbTandasPasadas_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasPasadas.SelectedItem != null)
            {
                tandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["NombreTanda"].ToString();
                idTandaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["IdTanda"].ToString();
                nombreOrganizadorPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["Nombre"].ToString();
                montoPasado = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["Monto"].ToString();
                fechaPasada = dtTandasPasadas.Rows[lbTandasPasadas.SelectedIndex]["FechaInicio"].ToString();
                idOrganizadorPasada = dtTandasActuales.Rows[lbTandasActuales.SelectedIndex]["IdOrganizador"].ToString();

                DetalleTandaParticipante dto = new DetalleTandaParticipante(idTandaPasada, tandaPasada, nombreOrganizadorPasada, montoPasado, fechaPasada, idOrganizadorPasada);
                dto.Show();
            }
        }
    }
}
