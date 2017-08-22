using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_de_dietas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBusquedaEmpleado em = new frmBusquedaEmpleado();
            em.Show();

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBusquedaDietas bd = new frmBusquedaDietas();
            bd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBusquedaRuta br = new frmBusquedaRuta();
            br.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCamion cm = new frmCamion();
            cm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmCrudRuta rt = new frmCrudRuta();
            rt.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmRegistroDeEmpleado re = new frmRegistroDeEmpleado();
            re.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
