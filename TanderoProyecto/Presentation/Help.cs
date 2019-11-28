using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
