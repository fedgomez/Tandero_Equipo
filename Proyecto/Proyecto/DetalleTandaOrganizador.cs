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
    public partial class DetalleTandaOrganizador : Form
    {
        public DetalleTandaOrganizador()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //TO DO: Sacar un cuadro de diálogo de ¿Seguro que quieres eliminar la tanda?
            // Validar que todos ya hayan tenido su cobro de la tanda

        }
    }
}
