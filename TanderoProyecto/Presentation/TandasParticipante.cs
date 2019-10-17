using Common.Cache;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class TandasParticipante : Form
    {
        public TandasParticipante()
        {
            InitializeComponent();
        }

        private void btnUnirTanda_Click(object sender, EventArgs e)
        {
            //TO DO: Agregar al usuario actual a una tanda nueva con su código correspondiente
            /*SqlConnection con = new SqlConnection(@"Data Source=CLEOPATRA;Initial Catalog=Tandero;Integrated Security=True");

            SqlCommand cmd = con.CreateCommand;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * "
                */
            int idt, ido, turno, pt;
            
            Random rn = new Random();
            
            
            using (var con = new SqlConnection(@"Data Source=CLEOPATRA;Initial Catalog=Tandero;Integrated Security=True"))
            {
                var sql = "Select IdTanda from Tanda where Codigo = @codigo";
                var sql2 = "Select IdOrganizador from Tanda where Codigo = @codigo";
                var sql3 = "Select NoParticipantes from Tanda where Codigo = @codigo";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Codigo", tbUnirATanda.Text);
                    con.Open();
                    idt = (int)cmd.ExecuteScalar();
                }
                using (var cmd2 = new SqlCommand(sql2, con))
                {
                    cmd2.Parameters.AddWithValue("@codigo", tbUnirATanda.Text);
                    ido = (int)cmd2.ExecuteScalar();
                }

                using (var cmd3 = new SqlCommand(sql3, con))
                {
                    cmd3.Parameters.AddWithValue("@codigo", tbUnirATanda.Text);
                    pt = (int)cmd3.ExecuteScalar();
                }
                turno = rn.Next(1,pt);



                con.Close();
            }


            var idUser = UserLoginCache.IdUsuario;

            UnirseRegister ur = new UnirseRegister();

           var registro = ur.Unirse(idt, idUser, '0', turno);
            if (registro == true)
            {
                MessageBox.Show("Registro exitoso");
                this.Hide();
            }
        }

        private void lbTandas_DoubleClick(object sender, EventArgs e)
        {
          
        }
    }
}
