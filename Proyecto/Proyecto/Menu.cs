﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
