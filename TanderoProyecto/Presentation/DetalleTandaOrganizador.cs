using Common.Cache;
using Domain;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class DetalleTandaOrganizador : Form
    {
        private DataTable dtParticipantes;
        private DataTable dtTandaDetalle;
        private string query = "";
        private readonly string nombreTanda;
        private readonly int idTanda;

        private string idUsuario;
        public DetalleTandaOrganizador(string id, string tanda)
        {
            InitializeComponent();
            idTanda = int.Parse(id);
            nombreTanda = tanda;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void DetalleTandaOrganizador_Load(object sender, EventArgs e)
        {
            
            labelNombre.Text = UserLoginCache.Nombre;
            query = "SELECT u.Nombre FROM Usuario u INNER JOIN TandaDetalle td ON u.IdUsuario = td.idUsuario WHERE IdTanda = " + idTanda + " ORDER BY td.IdTanda OFFSET 1 ROWS";
            dtParticipantes = ConsultaModel.EjecutaConsulta(query);
            lbParticipantes.DataSource = dtParticipantes;
            lbParticipantes.DisplayMember = "Nombre";

            Text = nombreTanda;

            var flag = true;
            

            query = "SELECT * FROM TandaDetalle WHERE IdTanda = " + idTanda;
            dtTandaDetalle = ConsultaModel.EjecutaConsulta(query);

            foreach (DataRow row in dtTandaDetalle.Rows)
            {
                var cobro = row["Cobrado"].ToString();
                if (cobro.Equals("False"))
                {
                    flag = false;
                }
            }

            btnEliminar.Visible = flag;

        }

        private void lbParticipantes_DoubleClick(object sender, EventArgs e)
        {
            if (lbParticipantes.SelectedItem == null) return;
            idUsuario = dtTandaDetalle.Rows[lbParticipantes.SelectedIndex + 1]["idUsuario"].ToString();

            var cu = new CalificarUsuario(idUsuario);
            cu.Show();
        }
    }
}
