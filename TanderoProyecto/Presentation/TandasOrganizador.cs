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

namespace Proyecto
{
    public partial class TandasOrganizador : Form
    {
        private DataTable dtTandas;
        private string query;
        String tanda;
        string idTanda;
        String nombreOrganizador;
        static SqlConnection connection;
        public TandasOrganizador()
        {
            InitializeComponent();
        }

        private void TandasOrganizador_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM Tanda WHERE IdOrganizador = " + UserLoginCache.IdUsuario;
            lbTandasOrganizador.DataSource = GetData(query);
            lbTandasOrganizador.DisplayMember = "NombreTanda";
        }

        private void lbTandasOrganizador_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasOrganizador.SelectedItem != null)
            {
                tanda = dtTandas.Rows[lbTandasOrganizador.SelectedIndex]["NombreTanda"].ToString();
                idTanda = dtTandas.Rows[lbTandasOrganizador.SelectedIndex]["IdTanda"].ToString();


                //tanda = lbTandasOrganizador.SelectedItem.ToString();
                //TO DO: Get organizer name and last name from data base
                //TO DO: Get participants from database   

                DetalleTandaOrganizador dto = new DetalleTandaOrganizador(idTanda, tanda);
                dto.Show();
            }

            //TO DO: Hacer un get de la base de datos de la tanda seleccionada para abrirla en la ventana de detalle
        }   
        
        private DataTable GetData(string query)
        {
            dtTandas = new DataTable();

            string connectionString = ConfigurationManager.ConnectionStrings["dbtest"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
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

