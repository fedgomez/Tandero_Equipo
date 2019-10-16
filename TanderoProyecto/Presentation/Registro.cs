using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Domain;

namespace Presentation
{
    public partial class Registro : Form
    {

    

        public Registro()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (textName.Text != "")
            {
                if (textEmail.Text != "")
                {
                    if (textPass.Text != "")
                    {
                        RegisterModel register = new RegisterModel();
                        var validRegister = register.RegisterUser(textName.Text, textEmail.Text, textPass.Text);
                        if (validRegister == true)
                        {
                            MessageBox.Show("Registro exitoso");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                            textName.Clear();
                            textEmail.Clear();
                            textPass.Clear();
                            textName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, Inserte un Password valido");
                    }
                }
                else
                {
                    MessageBox.Show("Error, Inserte un Email Valido");
                }
            }
            else
            {
                MessageBox.Show("Error, Inserte un nombre valido");
            }
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}