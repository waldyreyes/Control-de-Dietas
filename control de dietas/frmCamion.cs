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
    public partial class frmCamion : Form
    {
        public frmCamion()
        {
            InitializeComponent();
        }

        private void dgvCargarDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCargarDestino_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           

        }

        private void btnBuacar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            // Condición para que el usuario llene todos los campo del formulario
            if (txt_placa.Text == "")
            {
                MessageBox.Show("Dijite el Numero de placa");
                txt_placa.Focus();

            }


            if (txt_capacidad.Text == "")
            {
                MessageBox.Show("Dijite la capacidad");
                txt_capacidad.Focus();

            }

            if (txt_cantidad_gomas.Text == "")
            {
                MessageBox.Show("Dijite La Cantidad de Gomas");
                txt_cantidad_gomas.Focus();

            }
            // Guardando los textBox en la Base de Datos 
            oper.ConsultaConResultado("INSERT INTO camion(placa, capacidad, cant_gomas) VALUES('" + txt_placa.Text + "', '" + txt_capacidad.Text + "', '" + txt_cantidad_gomas.Text + "')");

            //llamado de la Base de Datos al DataGridView
            DataTable dt_camion = oper.ConsultaConResultado(" SELECT  * FROM camion ");
            dtgvCamion.DataSource = dt_camion;

            MessageBox.Show("Registro Guardado Corectamente");

            // limpiando los texbox
            txt_IdCamion.Clear();
            txt_placa.Clear();
            txt_capacidad.Clear();
            txt_cantidad_gomas.Clear();



        }

        private void btnBuacar_Click_1(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            if (txt_IdCamion.Text.Length == 0)
            {
                DataTable cm = oper.ConsultaConResultado("SELECT *FROM camion");
                dtgvCamion.DataSource = cm;
            }
            DataTable dt_camion = oper.ConsultaConResultado(" SELECT  * FROM camion where id_camion ='" + txt_IdCamion.Text + "' ");
            foreach (DataRow dtc in dt_camion.Rows)
            {
                string id_camion, placa, capacidad, cant_gomas;
                id_camion = dtc["id_camion"].ToString();
                placa = dtc["placa"].ToString();
                capacidad = dtc["capacidad"].ToString();
                cant_gomas = dtc["cant_gomas"].ToString();

                txt_IdCamion.Text = id_camion;
                txt_placa.Text = placa;
                txt_capacidad.Text = capacidad;
                txt_cantidad_gomas.Text = cant_gomas;

                dtgvCamion.DataSource = dt_camion;

                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            //Eliminar un registro de Camion de la Base de Dato
            oper.ConsultasSinResultados(" DELETE FROM camion where id_camion ='" + txt_IdCamion.Text + "' ");

            //Limpiando los textbox
            txt_IdCamion.Clear();
            txt_placa.Clear();
            txt_capacidad.Clear();
            txt_cantidad_gomas.Clear();
            txt_placa.Focus();

            DataTable dt_camion = oper.ConsultaConResultado(" SELECT  * FROM camion ");
            dtgvCamion.DataSource = dt_camion;


            MessageBox.Show("Camion Borrado Correctamente");
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            // cerrando el formulario
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();

            // Actualizar los datos del usuario
            oper.ConsultasSinResultados("UPDATE camion SET id_camion = '" + txt_IdCamion.Text + "', placa = '" + txt_placa.Text + "', capacidad = '" + txt_capacidad.Text + "', cant_gomas = '"+ txt_cantidad_gomas.Text+"' where id_camion = '" + txt_IdCamion.Text + "'");

            DataTable dt_camion = oper.ConsultaConResultado(" SELECT  * FROM camion ");
            dtgvCamion.DataSource = dt_camion;

            // limpiando los textbox
            txt_IdCamion.Clear();
            txt_placa.Clear();
            txt_capacidad.Clear();
            txt_cantidad_gomas.Clear();

            MessageBox.Show("Camion Actualizado Corectamente");
        }
    }
}