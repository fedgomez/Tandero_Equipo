using System;
using System.Globalization;
using System.Windows.Forms;
using Common.Cache;

namespace Proyecto
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadUserData()
        {
            labelName.Text = UserLoginCache.Nombre;
            labelEmail.Text = UserLoginCache.Email;
            if (UserLoginCache.SumRatingP == 0 && UserLoginCache.NumVotosP == 0)
            {
                const string i = "0";
                labelRatingP.Text = i;
            }
            else
            {
                var resP = UserLoginCache.SumRatingP / (float)UserLoginCache.NumVotosP;
                labelRatingP.Text = resP.ToString(CultureInfo.CurrentCulture);
            }
            if (UserLoginCache.SumRatingO == 0 && UserLoginCache.NumVotosO == 0)
            {
                const string i = "0";
                labelRatingO.Text = i;
            }
            else
            {
                var resO = UserLoginCache.SumRatingO / (float)UserLoginCache.NumVotosO;
                labelRatingO.Text = resO.ToString(CultureInfo.CurrentCulture);
            }
        }
    }
}
