using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Proyecto
{

    public partial class CalificarOrganizador : Form
    {
        private string nombreOrganizador;
        private int IdOrganizador = 1;
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
            if (tbCalificar.Text != "")
            {
                TandaModel rating = new TandaModel();
                var validRating = rating.UserRating(tbCalificar.Text, false, IdOrganizador);
                if (validRating == true)
                {
                    MessageBox.Show("Rating Orgnanizador asignado");
                    this.Hide();
                }
            }
            this.Close();
            this.Close();
        }
    }
}
