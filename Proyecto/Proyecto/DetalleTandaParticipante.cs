using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class DetalleTandaParticipante : Form
    {
        public DetalleTandaParticipante(string tanda, string nombreOrg, string apellidoOrg, string[] participantes)
        {
            InitializeComponent();
            this.Text = tanda;
            labelNombre.Text = nombreOrg;
            labelApellido.Text = apellidoOrg;

            for (int i = 0; i < participantes.Length; i++)
            {
                lbParticipantes.Items.Add(participantes[i].ToString());
            }
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            CalificarOrganizador co = new CalificarOrganizador();
            co.Show();
        }
    }
}
