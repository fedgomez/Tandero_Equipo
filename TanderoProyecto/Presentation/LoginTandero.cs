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
            string error = "Error, Incorrect Email or Password";
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
                        m.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(error);
                        email.Clear();
                        password.Clear();
                        email.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            else
            {
                MessageBox.Show(error);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            email.Clear();
            password.Clear();
            this.Show();
            email.Focus();
        }
    }
}
