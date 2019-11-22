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
    public partial class DetalleTandaOrganizador : Form
    {
        private DataTable dtParticipantes;
        private DataTable dtTandaDetalle;
        private string query = "";
        private string nombreTanda;
        private int idTanda;
        private string nombreUsuario;
        private string idUsuario;
        public DetalleTandaOrganizador(string id, string tanda)
        {
            InitializeComponent();
            idTanda = Int32.Parse(id);
            nombreTanda = tanda;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void DetalleTandaOrganizador_Load(object sender, EventArgs e)
        {
            ConsultaModel consulta = new ConsultaModel();
            labelNombre.Text = UserLoginCache.Nombre.ToString();
            query = "SELECT u.Nombre FROM Usuario u INNER JOIN TandaDetalle td ON u.IdUsuario = td.idUsuario WHERE IdTanda = " + idTanda + " ORDER BY td.IdTanda OFFSET 1 ROWS";
            dtParticipantes = consulta.ejecutaConsulta(query);
            lbParticipantes.DataSource = dtParticipantes;
            lbParticipantes.DisplayMember = "Nombre";

            this.Text = nombreTanda;

            bool flag = true;
            string cobro;
            int cobroI;

            query = "SELECT * FROM TandaDetalle WHERE IdTanda = " + idTanda;
            dtTandaDetalle = consulta.ejecutaConsulta(query);

            foreach (DataRow row in dtTandaDetalle.Rows)
            {
                cobro = row["Cobrado"].ToString();
                if (cobro.Equals("False"))
                {
                    flag = false;
                }
            }

            if (!flag)
            {
                btnEliminar.Visible = false;
            }
            else
            {
                btnEliminar.Visible = true;
            }

        }

        private void lbParticipantes_DoubleClick(object sender, EventArgs e)
        {
            if (lbParticipantes.SelectedItem != null)
            {
                idUsuario = dtTandaDetalle.Rows[lbParticipantes.SelectedIndex + 1]["idUsuario"].ToString();

                CalificarUsuario cu = new CalificarUsuario(idUsuario);
                cu.Show();
            }
        }
    }
}
