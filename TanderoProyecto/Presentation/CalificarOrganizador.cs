
using System;
using System.Windows.Forms;

namespace Presentation
{

    public partial class CalificarOrganizador : Form
    {
        private string nombreOrganizador;
        public CalificarOrganizador(string nombre)
        {
            InitializeComponent();
            nombreOrganizador = nombre;
        }

        private void CalificarOrganizador_Load(object sender, EventArgs e)
        {
            tbCalificar.Text = "Calificar a " + nombreOrganizador;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalificarOrg_Click(object sender, EventArgs e)
        {
            //TO DO: Hacer que la tabla de la base de datos se actualice 
            this.Close();
        }
    }
}
