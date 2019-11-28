using System;
using System.Globalization;
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
            if (UserLoginCache.SumRatingP == 0 && UserLoginCache.NumVotosP == 0)
            {
                const string i = "0";
                labelRating.Text = i;
            }
            else
            {
                var res = UserLoginCache.SumRatingP / (float)UserLoginCache.NumVotosP;
                labelRating.Text = res.ToString(CultureInfo.CurrentCulture);
            }
        }

        private void logput_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTandas_Click(object sender, EventArgs e)
        {
            var t = new Tandas();
            t.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            var p = new Perfil();
            p.Show();
        }


        private void HelpButton_Click(object sender, EventArgs e)
        {
            var h = new Help();
            h.Show();
        }
    }
}
