

using System;
using System.Windows.Forms;

namespace Presentation
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
                        m.FormClosed += Logout;
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

        private void Logout(object sender, FormClosedEventArgs e)
        {
            email.Clear();
            password.Clear();
            this.Show();
            email.Focus();
        }
    }
}
