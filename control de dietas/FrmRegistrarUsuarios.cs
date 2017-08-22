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
    public partial class FrmRegistrarUsuarios : Form
    {
        public FrmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Operaciones oper = new Operaciones();


            // condicion para que el usuario llene todos los textbox
            if (txtNombreUsuario.Text == "")
            {
                MessageBox.Show("Dijite el Numero de Usuario");
                txtNombreUsuario.Focus();

            }


            if (txtClaveUsuarios.Text == "")
            {
                MessageBox.Show("Dijite la Clave de Usuario");
                txtClaveUsuarios.Focus();

            }

            if (cmbTipoUsuarios.Text == "")
            {
                MessageBox.Show("Selecione el Tipo de Usuario");
                cmbTipoUsuarios.Focus();

            }

            // condicion para que el usuario llene todos los textbox
            else if ((txtNombreUsuario.Text.Length != 0) && (txtClaveUsuarios.Text.Length != 0) && (cmbTipoUsuarios.Text.Length != 0))
            {
                oper.ConsultaConResultado("INSERT INTO usuarios(usuario, clave, tipo_usuario) VALUES('" + txtNombreUsuario.Text + "', '" + txtClaveUsuarios.Text + "', '" + cmbTipoUsuarios.Text + "')");

                // presentación de los Usuarios Guardado en la Base de Datos en el DataGridView
                DataTable dtu = oper.ConsultaConResultado(" SELECT  * FROM usuarios ");
                dtgUsuarios.DataSource = dtu;
                

                MessageBox.Show("Usuario Guardado Corectamente");

                // Limpiando los TextBox
                txtNombreUsuario.Clear();
                txtClaveUsuarios.Clear();
                txtIdUsuario.Clear();



            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            if (txtIdUsuario.Text.Length == 0)
            {
                // Buscar la tabla usuario y presentandola en el DataGriView
                DataTable cm = oper.ConsultaConResultado("SELECT *FROM usuarios");
                dtgUsuarios.DataSource = cm;
            }
            DataTable dt_usuarios = oper.ConsultaConResultado(" SELECT  * FROM usuarios where id_usuario ='" + txtIdUsuario.Text + "' ");
            foreach (DataRow dtc in dt_usuarios.Rows)
            {
                string id_usuario, nombre_usuario, clave_usuario, tipo_usuario;

                id_usuario = dtc["id_usuario"].ToString();
                nombre_usuario = dtc["nombre_usuario"].ToString();
                clave_usuario = dtc["clave_usuario"].ToString();
                tipo_usuario = dtc["tipo_usuario"].ToString();

                // asignación de los datos del usuario a los TextBox
                txtIdUsuario.Text = id_usuario;
                txtNombreUsuario.Text = nombre_usuario;
                txtClaveUsuarios.Text = clave_usuario;
                cmbTipoUsuarios.Text = tipo_usuario;

                dtgUsuarios.DataSource = dt_usuarios;


            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            oper.ConsultasSinResultados(" DELETE FROM usuarios where id_usuario ='" + txtIdUsuario.Text + "' ");

            txtIdUsuario.Clear();
            txtNombreUsuario.Clear();
            txtClaveUsuarios.Clear();


            DataTable dt_usuarios = oper.ConsultaConResultado(" SELECT  * FROM usuarios ");
            dtgUsuarios.DataSource = dt_usuarios;


            MessageBox.Show("Usuarios Borrado Correctamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            // Actualizar los datos del usuario
            oper.ConsultasSinResultados("UPDATE usuarios SET usuario = '" + txtNombreUsuario.Text + "', clave = '" + txtClaveUsuarios.Text + "', tipo_usuario = '" + cmbTipoUsuarios.Text + "' where id_usuario = '" + txtIdUsuario.Text + "'");

            DataTable dt_act = oper.ConsultaConResultado(" SELECT  * FROM usuarios ");
            dtgUsuarios.DataSource = dt_act;

            // limpiando los textbox
            txtIdUsuario.Clear();
            txtNombreUsuario.Clear();
            txtClaveUsuarios.Clear();

            MessageBox.Show("Usuario Actualizado Corectamente");
        }
    }
}
