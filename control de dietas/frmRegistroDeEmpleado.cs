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

namespace control_de_dietas
{
    public partial class frmRegistroDeEmpleado : Form

    {
        Operaciones oper = new Operaciones();
        public OpenFileDialog examinar = new OpenFileDialog();


        public frmRegistroDeEmpleado()
        {
            InitializeComponent();
            txt_id.Focus();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {



        }

        private void btnNuevo_guardar_Click(object sender, EventArgs e)
        {
           



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

           
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click_1(object sender, EventArgs e)
        {
            // buscar en los archivos cualquier imagen 
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            // presentar en el picturebox la imagen seleccionda
            pictureBox1.Text = examinar.FileName;
            pictureBox1.ImageLocation = examinar.FileName;
        }

        private void btnNuevo_guardar_Click_1(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            
            if (cmbcargo.Text == "Chofer")
            {
                // la imagen seleccionada en el pictureBox la copias a una cepeta imagenes en el programa
                string destino = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\imagenes") + examinar.FileName.Substring(examinar.FileName.LastIndexOf('\\'), examinar.FileName.Length - examinar.FileName.LastIndexOf('\\'));
                File.Copy(examinar.FileName, destino);

                // guardando los campo en la Base de Dsto
                oper.ConsultaConResultado("INSERT INTO chofer(nombre, apellido, cedula, telefono, flota, direccion, sexo, foto) VALUES('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtCedula.Text + "', '" + txtTelefono.Text + "', '" + txtFlota.Text + "', '" + txtDireccion.Text + "', '" + cmbSexo.Text + "', '" + destino + "')");
                MessageBox.Show("EMPLEADO GUARDADO");

                // limpiando los textBox del formulario
                txt_id.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                txtDireccion.Clear();
                txtFlota.Clear();
                txtTelefono.Clear();

            }

            if (cmbcargo.Text == "Ayudante")
            {
                string destino = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\imagenes") + examinar.FileName.Substring(examinar.FileName.LastIndexOf('\\'), examinar.FileName.Length - examinar.FileName.LastIndexOf('\\'));
                File.Copy(examinar.FileName, destino);

                oper.ConsultaConResultado("INSERT INTO ayudante(nombre, apellido, cedula, telefono, flota, direccion, sexo, foto) VALUES('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtCedula.Text + "', '" + txtTelefono.Text + "', '" + txtFlota.Text + "', '" + txtDireccion.Text + "', '" + cmbSexo.Text + "', '" + destino + "')");
                MessageBox.Show("EMPLEADO GUARDADO");           

                txt_id.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                txtDireccion.Clear();
                txtFlota.Clear();
                txtTelefono.Clear();

               
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            // buscar en la base de dato segun el cargo seleccionado 
            if (cmbcargo.Text == "Chofer")
            {
                DataTable dt_chofer = oper.ConsultaConResultado(" SELECT * FROM chofer where id_chofer ='" + txt_id.Text + "' ");

                foreach (DataRow dcf in dt_chofer.Rows)
                {
                    string id_chofer, nombre, apellido, cedula, telefono, flota, direccion, sexo;


                    id_chofer = dcf["id_chofer"].ToString();
                    nombre = dcf["nombre"].ToString();
                    apellido = dcf["apellido"].ToString();
                    cedula = dcf["cedula"].ToString();
                    telefono = dcf["telefono"].ToString();
                    flota = dcf["flota"].ToString();
                    direccion = dcf["direccion"].ToString();
                    sexo = dcf["sexo"].ToString();


                    txtNombre.Text = nombre;
                    txtApellido.Text = apellido;
                    txt_id.Text = id_chofer;
                    txtCedula.Text = cedula;
                    txtTelefono.Text = telefono;
                    txtFlota.Text = flota;
                    txtDireccion.Text = direccion;
                    cmbSexo.Text = sexo;



                    try
                    {

                    }
                    catch (Exception)
                    {

                    }

                }
            }

            if (cmbcargo.Text == "Ayudante")
            {
                DataTable dt_ayud = oper.ConsultaConResultado(" SELECT * FROM ayudante where id_ayudante ='" + txt_id.Text + "' ");

                foreach (DataRow dca in dt_ayud.Rows)
                {
                    string id_ayudante, nombre, apellido, cedula, telefono, flota, direccion, sexo;


                    id_ayudante = dca["id_ayudante"].ToString();
                    nombre = dca["nombre"].ToString();
                    apellido = dca["apellido"].ToString();
                    cedula = dca["cedula"].ToString();
                    telefono = dca["telefono"].ToString();
                    flota = dca["flota"].ToString();
                    direccion = dca["direccion"].ToString();
                    sexo = dca["sexo"].ToString();


                    txtNombre.Text = nombre;
                    txtApellido.Text = apellido;
                    txt_id.Text = id_ayudante;
                    txtCedula.Text = cedula;
                    txtTelefono.Text = telefono;
                    txtFlota.Text = flota;
                    txtDireccion.Text = direccion;
                    cmbSexo.Text = sexo;



                    try
                    {

                       
                    }
                    catch (Exception)
                    {

                    }

                }
            }

           
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            
            // eliminar un empleado de la base de datos segun el cargo seleccionado
            if (cmbcargo.Text == "Chofer")
            {
                // borrar el empleado de la tabla chofer que segun el ID seleccionado 
                op.ConsultasSinResultados(" DELETE FROM chofer where id_chofer ='" + txt_id.Text + "' ");

                MessageBox.Show("Empleado Borrado");
                
                // limpiando los textbox del formulario
                txt_id.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                txtDireccion.Clear();
                txtFlota.Clear();
                txtTelefono.Clear();

            }

            if (cmbcargo.Text == "Ayudante")
            {
                op.ConsultasSinResultados(" DELETE FROM ayudante where id_ayudante ='" + txt_id.Text + "' ");

                MessageBox.Show("Empleado Borrado");
                txt_id.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                txtDireccion.Clear();
                txtFlota.Clear();
                txtTelefono.Clear();

            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbcargo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
