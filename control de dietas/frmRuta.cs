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
    public partial class frmCrudRuta : Form
    {
        public frmCrudRuta()
        {
            InitializeComponent();
        }

        private void btnNuevo_guardar_Click(object sender, EventArgs e)
        {
           

        }


        public void borar()
        {
            txtDestino.Text = "";
            txtPeaje.Text = "";
        }

        public bool validar()
        {
            if (txtDestino.Text == "")
            {

                MessageBox.Show("Por Favor Escriba el Destino", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDestino.Focus();
                return false;

            }
            else return true;
        }

        private void frmCrudRuta_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDieta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.soloNumeros(e);
        }

        private void txtPeaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.soloNumeros(e);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_guardar_Click_1(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

            // Guardar los textbox en la tabla de ruta 
            op.ConsultaConResultado("Insert into ruta (nombre, peaje_costo_gomas) values('" + txtDestino.Text + "',  '" + txtPeaje.Text + "')");
            MessageBox.Show("Datos Guardados");

            // Limpiar los textbox
            txtDestino.Clear();
            txtPeaje.Clear();

            // presentación de mensaje de opcion para cerrar la ventana de crear o modificar ruta, de lo contrario la ventana se cierra
            
            if (MessageBox.Show("DECEA AGREGAR OTRA RUTA? ", "SALIR O SEGUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
              {
                  this.Close();
              }
           
            

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("REALMENTE DECEA ELIMINAR A " + txtDestino.Text, "ELIMINAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Operaciones op = new Operaciones();

                // el comando DELETE elimina el registro de la tabla que tenga la ID selecionado
                op.ConsultasSinResultados("DELETE FROM ruta WHERE id_ruta = '" + txtId.Text + "'");
                borar();//llamando metodo para borrar los campos
                MessageBox.Show("REGISTRO BORRADO");


                DataTable dt_r = op.ConsultaConResultado(" SELECT  * FROM ruta ");
                dataGridView1.DataSource = dt_r;
            }


            

        }

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                
                // al celecionar un registro en el DataGridView se llenan para textbox permitiendo poder modicor el registro
                txtId.Text = r.Cells["id_ruta"].Value.ToString();
                txtDestino.Text = r.Cells["nombre"].Value.ToString();
                txtPeaje.Text = r.Cells["peaje_costo_gomas"].Value.ToString();
            }
        }

        private void frmCrudRuta_Load_1(object sender, EventArgs e)
        {
            // llenar el el data grid con la tabla de ruta

            Operaciones oper = new Operaciones();
            dataGridView1.DataSource = oper.ConsultaConResultado("select * from ruta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Operaciones oper = new Operaciones();

            // Actualizar los datos de la ruta
            oper.ConsultasSinResultados("UPDATE ruta SET nombre = '" + txtDestino.Text + "', peaje_costo_gomas = '" + txtPeaje.Text + "' where id_ruta = '" + txtId.Text + "'");

            DataTable dt_r = oper.ConsultaConResultado(" SELECT  * FROM ruta ");
            dataGridView1.DataSource = dt_r;

            // limpiando los textbox
            txtId.Clear();
            txtDestino.Clear();
            txtPeaje.Clear();

            MessageBox.Show("Ruta Actualizada Corectamente");
              
    }
    }
}
