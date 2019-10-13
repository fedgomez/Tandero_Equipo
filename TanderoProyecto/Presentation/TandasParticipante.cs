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
    public partial class TandasParticipante : Form
    {
        String tanda;
        String nombreOrganizador;
        String apellidoOrganizador;
        String[] participantes = null;
        public TandasParticipante()
        {
            InitializeComponent();
        }

        private void btnUnirTanda_Click(object sender, EventArgs e)
        {
            //TO DO: Agregar al usuario actual a una tanda nueva con su código correspondiente
        }

        private void lbTandas_DoubleClick(object sender, EventArgs e)
        {
            tanda = lbTandas.SelectedItem.ToString();
            //TO DO: Get organizer name and last name from data base
            nombreOrganizador = "Bernardo";
            apellidoOrganizador = "Elizondo";
            //TO DO: Get participants from database
            participantes = new string[3];
            participantes[0] = "Luis";
            participantes[1] = "Felipe";
            participantes[2] = "Álvaro";

            DetalleTandaParticipante dtp = new DetalleTandaParticipante(tanda, nombreOrganizador, apellidoOrganizador, participantes);
            dtp.Show();
            Hide();
        }
    }
}
