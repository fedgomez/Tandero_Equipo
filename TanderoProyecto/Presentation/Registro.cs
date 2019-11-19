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

namespace Proyecto
{
    public partial class Registro : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=CLEOPATRA;Initial Catalog=Tandero;Integrated Security=True");

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
            string errorLog = "Error, Incorrect Email or Password";
            string Register = "Registro exitoso";
            string errorMsg = "Error";
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
                            MessageBox.Show(Register);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(errorMsg);
                            textName.Clear();
                            textEmail.Clear();
                            textPass.Clear();
                            textName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorLog);
                    }
                }
                else
                {
                    MessageBox.Show(errorLog);
                }
            }
            else
            {
                MessageBox.Show(errorLog);
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