using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace control_de_dietas
{
    public partial class frmLogin : Form
    {
        Operaciones oper = new Operaciones();
        public frmLogin()
        {
            InitializeComponent();
        }

        /* SQLiteConnection conec = new SQLiteConnection("Data Source=C:\\SISTEMAS\\dietas.s3db; Version=3;");
         public void login(string usuario, string clave)

         {
             try
             {
                  conec.Open();
                 //Operaciones op = new Operaciones();
                 SqlCommand cmd = new SqlCommand("select usuario, tipo_usuario FROM usuarios where usuario = @usuario AND @clave = @cont");
                 cmd.Parameters.AddWithValue("usuario", usuario);
                 cmd.Parameters.AddWithValue("clave", clave);
                 SqlDataAdapter sda = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);

                 if (dt.Rows.Count == 1)
                 {
                     this.Hide();
                     if (dt.Rows[0].ToString() == "admin")
                     {
                         frmPrincipal ad = new frmPrincipal();
                         ad.Show();

                     }
                     else if (dt.Rows[0].ToString() == "usuario")
                     {

                     }

                 }

                 else
                 {
                     MessageBox.Show("Usuario y/o Contraceña Incorrecta");
                 }



             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);


             }
             finally
             {
                 conec.Close();

             }

         }
         */
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtUsuario.Focus();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            if (cmbTipo.Text == "Administrador")
            {
                if ((txtUsuario.Text != "0") && (txtContracena.Text != "0"))
                {
                    DataTable dtu = oper.ConsultaConResultado(" SELECT * FROM usuarios where usuario ='" + txtUsuario.Text + "' and clave = '" + txtContracena + "' ");



                    /* if (dtu.Rows[0][1].ToString() == "admin")
                         {
                             frmPrincipal ad = new frmPrincipal();
                             ad.Show();

                         }
                         else if (dtu.Rows[0][1].ToString() == "usuario")
                         {

                             frmPrincipal ad = new frmPrincipal();
                             ad.Show();

                         }



                     {
                         MessageBox.Show("Usuario y/o Contraceña Incorrecta");
                     }

                   /*  string usuario, clave, tipo_usuario;


                         txtUsuario.Text = usuario;
                         txtContracena.Text = clave;

                         frmPrincipal fp = new frmPrincipal();
                         fp.Show();




         */
                }

                else
                {
                    MessageBox.Show(" Dijite Usuario y/o Contraceña");

                }

            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}