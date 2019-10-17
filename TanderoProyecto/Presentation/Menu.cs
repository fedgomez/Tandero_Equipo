
using Common.Cache;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LoadUserData();
        }


        private void LoadUserData()
        {
            nombreLabel.Text = UserLoginCache.Nombre;
            if (UserLoginCache.sumRatingP == 0 && UserLoginCache.numVotosP == 0)
            {
                string i = "0";
                label2.Text = i;
            }
            else
            {
                float res = (float)UserLoginCache.sumRatingP / (float)UserLoginCache.numVotosP;
                label2.Text = res.ToString();
            }
        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoginTandero l = new LoginTandero();
            //l.Show();
            //TO DO: Cerrar la sesión activa con base de datos
        }

        private void btnTandas_Click(object sender, EventArgs e)
        {
            Tandas t = new Tandas();
            t.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil();
            p.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
