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
    public partial class Tandas : Form
    {
        public Tandas()
        {
            InitializeComponent();
        }

        private void btnOrganizador_Click(object sender, EventArgs e)
        {
            TandasOrganizador to = new TandasOrganizador();
            to.Show();
        }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            TandasParticipante tp = new TandasParticipante();
            tp.Show();
        }

        private void btnCrearTanda_Click(object sender, EventArgs e)
        {
            CrearTanda ct = new CrearTanda();
            ct.Show();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOrganizador_Click_1(object sender, EventArgs e)
        {
            TandasOrganizador to = new TandasOrganizador();
            to.Show();
        }

    }
}
