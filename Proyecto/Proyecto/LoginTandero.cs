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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0KG1EJO;Initial Catalog=Tandero;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into usuario(nombre)", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Data Saved");
                Menu m = new Menu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
        }
    }
}
