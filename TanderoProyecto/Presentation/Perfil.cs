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
            this.Close();
        }

        private void LoadUserData()
        {
            float resP;
            float resO;
            labelName.Text = UserLoginCache.Nombre;
            labelEmail.Text = UserLoginCache.Email;
            if (UserLoginCache.sumRatingP == 0 && UserLoginCache.numVotosP == 0)
            {
                string i = "0";
                labelRatingP.Text = i;
            }
            else
            {
                resP = (float)UserLoginCache.sumRatingP / (float)UserLoginCache.numVotosP;
                labelRatingP.Text = resP.ToString();
            }
            if (UserLoginCache.sumRatingO == 0 && UserLoginCache.numVotosO == 0)
            {
                string i = "0";
                labelRatingO.Text = i;
            }
            else
            {
                resO = (float)UserLoginCache.sumRatingO / (float)UserLoginCache.numVotosO;
                labelRatingO.Text = resO.ToString();
            }
        }
    }
}
