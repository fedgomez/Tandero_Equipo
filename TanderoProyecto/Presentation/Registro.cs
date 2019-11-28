using System;
using System.Windows.Forms;
using Domain;


namespace Proyecto
{
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            const string errorLog = "Error, Incorrect Email or Password";
            const string register = "Registro exitoso";
            const string errorMsg = "Error";
            if (textName.Text != "")
            {
                if (textEmail.Text != "")
                {
                    if (textPass.Text != "")
                    {
                        var registro = new RegisterModel();
                        var validRegister = registro.RegisterUser(textName.Text, textEmail.Text, textPass.Text);
                        if (validRegister)
                        {
                            MessageBox.Show(register);
                            Hide();
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


    }
}