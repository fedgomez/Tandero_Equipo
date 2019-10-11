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
        public DetalleTandaParticipante()
        {
            InitializeComponent();
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            CalificarOrganizador co = new CalificarOrganizador();
            co.Show();
        }
    }
}
