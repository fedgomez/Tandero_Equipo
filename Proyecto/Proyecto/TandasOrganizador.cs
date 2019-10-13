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
    public partial class TandasOrganizador : Form
    {
        String tanda;
        String nombreOrganizador;
        String apellidoOrganizador;
        String [] participantes = null;
        public TandasOrganizador()
        {
            InitializeComponent();
        }

        private void lbTandasOrganizador_DoubleClick(object sender, EventArgs e)
        {
            if (lbTandasOrganizador.SelectedItem != null)
            {
                tanda = lbTandasOrganizador.SelectedItem.ToString();
                //TO DO: Get organizer name and last name from data base
                nombreOrganizador = "Bernardo";
                apellidoOrganizador = "Elizondo";
                //TO DO: Get participants from database
                participantes = new string[3];
                participantes[0] = "Luis";
                participantes[1] = "Felipe";
                participantes[2] = "Álvaro";

                DetalleTandaOrganizador dto = new DetalleTandaOrganizador(tanda, nombreOrganizador, apellidoOrganizador, participantes);
                dto.Show();
            }

            //TO DO: Hacer un get de la base de datos de la tanda seleccionada para abrirla en la ventana de detalle
        }

    }
}
