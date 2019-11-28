using System;
using System.Windows.Forms;
using Domain;

namespace Proyecto
{

    public partial class CalificarOrganizador : Form
    {
        private const string Calif = "Calificar a ";
        private const string AssignRating = "Rating Orgnanizador asignado";
        private readonly string nombreOrganizador;
        private readonly int idOrganizador;
        public CalificarOrganizador(string nombre, int idOrg)
        {
            InitializeComponent();
            nombreOrganizador = nombre;
            idOrganizador = idOrg;
        }

        private void CalificarOrganizador_Load(object sender, EventArgs e)
        {
            tbCalificar.Text = Calif + nombreOrganizador;
        }

        private void btnCalificarOrg_Click(object sender, EventArgs e)
        {
            if (tbCalificar.Text != "")
            {
                var rating = new TandaModel();
                var validRating = rating.UserRating(tbCalificar.Text, false, idOrganizador);
                if (validRating)
                {
                    MessageBox.Show(AssignRating);
                    Hide();
                }
            }
            Close();
            Close();
        }
    }
}
