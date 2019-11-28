using System;
using System.Windows.Forms;
using Domain;


namespace Proyecto
{
    public partial class LoginTandero : Form
    {
        public LoginTandero()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string error = "Error, Incorrect Email or Password";
            if (email.Text != "")
            {
                if (password.Text != "")
                {
                    var user = new UserModel();
                    var valdLogin = user.LoginUser(email.Text, password.Text);
                    if (valdLogin)
                    {
                        var m = new Menu();
                        m.Show();
                        m.FormClosed += Logout;
                        Hide();
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
            var r = new Registro();
            r.Show();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            email.Clear();
            password.Clear();
            Show();
            email.Focus();
        }
    }
}
