using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Help = Presentation.Help;


namespace Proyecto
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
                labelRating.Text = i;
            }
            else
            {
                float res = (float)UserLoginCache.sumRatingP / (float)UserLoginCache.numVotosP;
                labelRating.Text = res.ToString();
            }
        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }
}
