using Common.Cache;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string error = "Error";
            string register = "Registro exitoso";
            int date3 = dateTimePicker.Value.Day;
            int date2 = dateTimePicker.Value.Month;
            int date = dateTimePicker.Value.Year;
            String fecha = (date + "-" + date2 + "-" + date3);



            var IdOrganiza = UserLoginCache.IdUsuario;

            TandaRegister tanda = new TandaRegister();
            var registro = tanda.RegistrarTanda(IdOrganiza, fecha, Convert.ToInt32(this.diapago.Text), Convert.ToInt32(this.participantes.Text), Convert.ToInt32(this.monto.Text), codigo.Text, nombre.Text);
            if (registro == true)
            {
                MessageBox.Show(register);
                this.Hide();
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