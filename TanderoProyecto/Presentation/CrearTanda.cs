using Common.Cache;
using DataAccess;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class CrearTanda : Form
    {
        public CrearTanda()
        {
            InitializeComponent();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            const string error = "Error";
            const string register = "Registro exitoso";
            var date3 = dateTimePicker.Value.Day;
            var date2 = dateTimePicker.Value.Month;
            var date = dateTimePicker.Value.Year;
            var fecha = date + "-" + date2 + "-" + date3;



            var idOrganiza = UserLoginCache.IdUsuario;

            var tanda = new TandaRegister();
            var registro = tanda.RegistrarTanda(idOrganiza, fecha, Convert.ToInt32(diapago.Text), Convert.ToInt32(participantes.Text), Convert.ToInt32(monto.Text), codigo.Text, nombre.Text);
            if (registro)
            {
                MessageBox.Show(register);
                Hide();
            }
            else
            {
                MessageBox.Show(error);
                codigo.Clear();
                nombre.Clear();
                participantes.Clear();
                diapago.Clear();
                monto.Clear();
                nombre.Focus();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}