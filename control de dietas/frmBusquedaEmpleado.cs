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
    public partial class frmBusquedaEmpleado : Form
    {
        public frmBusquedaEmpleado()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistroDeEmpleado emp = new frmRegistroDeEmpleado();
            emp.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

            if (cmbBuscar.Text == "")
            {
                MessageBox.Show("SELECCIONE EL CARGO");
                cmbBuscar.Focus();

            }


            if (cmbBuscar.Text == "Chofer")
            {
                if (txtBuscar.Text.Length == 0)
                {
                    DataTable dt = op.ConsultaConResultado(" SELECT  * FROM chofer ");
                    dtgBusquedaEmpleado.DataSource = dt;
                    return;
                }

                if (radioId.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from chofer WHERE id_chofer = '" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

                if (radioNombre.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from chofer WHERE nombre ='" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

                if (radioApellido.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from chofer WHERE apellido = '" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }
            }

            else if (cmbBuscar.Text == "Ayudante")
            {
                if (txtBuscar.Text.Length == 0)
                {
                    DataTable dt = op.ConsultaConResultado(" SELECT  * FROM ayudante");
                    dtgBusquedaEmpleado.DataSource = dt;
                    return;
                }

                if (radioId.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from ayudante WHERE id_ayudante = '" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

                if (radioNombre.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from ayudante WHERE nombre ='" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

                if (radioApellido.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from ayudante WHERE apellido = '" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

            }



        }

        private void dtgBusquedaEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgBusquedaEmpleado_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

            if (cmbBuscar.Text == "")
            {
                MessageBox.Show("SELECCIONE EL CARGO");
                cmbBuscar.Focus();

            }


            if (cmbBuscar.Text == "Chofer")
            {
                if (txtBuscar.Text.Length == 0)
                {
                    DataTable dt = op.ConsultaConResultado(" SELECT  * FROM chofer ");
                    dtgBusquedaEmpleado.DataSource = dt;
                    return;
                }

                if (radioId.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from chofer WHERE id_chofer = '" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

                if (radioNombre.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from chofer WHERE nombre ='" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

                if (radioApellido.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from chofer WHERE apellido = '" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }
            }

            else if (cmbBuscar.Text == "Ayudante")
            {
                if (txtBuscar.Text.Length == 0)
                {
                    DataTable dt = op.ConsultaConResultado(" SELECT  * FROM ayudante");
                    dtgBusquedaEmpleado.DataSource = dt;
                    return;
                }

                if (radioId.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from ayudante WHERE id_ayudante = '" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

                if (radioNombre.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from ayudante WHERE nombre ='" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

                if (radioApellido.Checked == true)
                {
                    DataTable dt = op.ConsultaConResultado("select *from ayudante WHERE apellido = '" + txtBuscar.Text.Trim() + "'");
                    dtgBusquedaEmpleado.DataSource = dt;
                }

            }



        

    }

        private void button1_Click(object sender, EventArgs e)
        {
            // cerrar la ventana de busqueda de empleados
            this.Close();

        }
    }
}

