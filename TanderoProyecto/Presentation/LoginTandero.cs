using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using Domain;

namespace Proyecto
{
    public partial class LoginTandero : Form
    {
        public LoginTandero()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (email.Text != "")
            {
                if (password.Text != "")
                {
                    UserModel user = new UserModel();
                    var valdLogin = user.LoginUser(email.Text, password.Text);
                    if (valdLogin == true)
                    {
                        Menu m = new Menu();
                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error, Incorrect Email or Password");
                        email.Clear();
                        password.Clear();
                        email.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error, Enter Password");
                }
            }
            else
            {
               // MessageBox.Show("Error, Enter Email");
                System.Console.WriteLine("my string");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
        }
    }
}
