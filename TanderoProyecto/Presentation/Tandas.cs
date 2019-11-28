using Presentation;
using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Tandas : Form
    {
        public Tandas()
        {
            InitializeComponent();
        }



        private void btnParticipante_Click(object sender, EventArgs e)
        {
            var tp = new TandasParticipante();
            tp.Show();
        }

        private void btnCrearTanda_Click(object sender, EventArgs e)
        {
            var ct = new CrearTanda();
            ct.Show();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOrganizador_Click_1(object sender, EventArgs e)
        {
            var to = new TandasOrganizador();
            to.Show();
        }

    }
}
