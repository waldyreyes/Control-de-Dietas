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
    public partial class frmBusquedaRuta : Form
    {
        public frmBusquedaRuta()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmBusquedaRuta_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rellenar = dtgRuta.Rows[e.RowIndex];
            String id_ruta = rellenar.Cells["id_ruta"].Value.ToString();
            if (id_ruta != "")
            {
                frmCrudRuta cr = new frmCrudRuta();
                
                cr.txtId.Text = rellenar.Cells["id_ruta"].Value.ToString();
                cr.txtDestino.Text = rellenar.Cells["destino"].Value.ToString();
                cr.txtPeaje.Text = rellenar.Cells["peaje"].Value.ToString();
                cr.btnEliminar.Enabled = true;
                cr.btnNuevo_guardar.Enabled = true;
                cr.btnNuevo_guardar.Text = "Guardar";

                cr.Show();
            }
            else if (id_ruta == "")
            {
                MessageBox.Show("POR FAVOR SELECCIONE UNA RUTA, DE LOS REGISTROS, DE LO CONTRARIO CREE UNA");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void dtgRuta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click_3(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

            if (txtBuscar.Text.Length == 0)
            {
                DataTable dt = op.ConsultaConResultado(" SELECT  * FROM ruta ");
                dtgRuta.DataSource = dt;
                return;
            }

            if (rbtnId.Checked == true)
            {
                // buscar en la tabla de ruta por el id de la ruta
                DataTable dt = op.ConsultaConResultado("select *from ruta WHERE id_ruta = '" + txtBuscar.Text.Trim() + "'");
                dtgRuta.DataSource = dt;
            }

            if (rbtnDestono.Checked == true)
            {
                // buscar el en la tabla ruta por el destino de la ruta
                DataTable dt = op.ConsultaConResultado("select *from ruta WHERE nombre = '" + txtBuscar.Text.Trim() + "'");
                dtgRuta.DataSource = dt;
            }

        }

        private void frmBusquedaRuta_Load_1(object sender, EventArgs e)
        {
            // llenar el el data grid con la tabla de ruta
            rbtnId.Checked = true;
            Operaciones oper = new Operaciones();
            dtgRuta.DataSource = oper.ConsultaConResultado("select * from ruta");
        }

        private void btnNuevo_Click_2(object sender, EventArgs e)
        {

        }

        private void dtgRuta_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click_3(object sender, EventArgs e)
        {
            // cerrar la ventana
            this.Close();
        }
    }
}