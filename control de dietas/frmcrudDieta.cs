using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace control_de_dietas
{
    public partial class frmcrudDieta : Form
    {
        public frmcrudDieta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // if (MessageBox.Show("Realmente decea Salir?", "Salir del CRUD", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarAyudante_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarCamion_Click(object sender, EventArgs e)
        {

        }

        private void crudDietas_Load(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            
            if(txtIdRegistro.Text !="")
            {
                btnEliminar.Enabled = true;
            }
            oper.llenarComboBox(cmbDestino, "SELECT nombre from ruta", "nombre");//llenando el combo ruta 
            oper.llenarComboBox(cmbChofer, "SELECT nombre FROM chofer" , "nombre");
            oper.llenarComboBox(cmbAyudante, "SELECT nombre FROM ayudante", "nombre");
            oper.llenarComboBox(cmbCamion, "SELECT placa FROM camion ", "placa");

            // oper.llenarComboBox(cmbFecha, )

            //DateTime.Today.AddTicks(-a.Ticks).Year - 1;   // esto captura la fecha del sistema 
            //falta ponerlo a llenar el combo


        }



        private void btnNuevo_guardar_Click(object sender, EventArgs e)
        {

            Operaciones op = new Operaciones();
            if (txtIdRegistro.Text == "")
            {
                if (validar())
                    {
                    op.ConsultaConResultado("insert into registro(fecha, id_chofer, id_camion, id_ruta, monto_dieta_chofer, monto_peaje, id_ayudante, monto_dieta_ayudante, total_gastos) values('" + txtfecha.Text + "', '" + txtIdChofer.Text  + "','" + txtIdCamion.Text + "','" + txtIdDestino.Text + "','" + txtDietaChofer.Text + "','" + txtPeaje.Text  + "','" + txtIdAyudante.Text+ "', '" + txtDietaAyudante.Text  + "', '"+txtTotalGastos.Text +"' ) ");
                    MessageBox.Show("Datos Guardados");
                    //pregunta que si quiere agregar otra dieta, de lo contrario se sale el programa
                    if (MessageBox.Show("DECEA AGREGAR OTRA DIETA? ", "SALIR O SEGUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }

            else if (txtIdRegistro.Text != "")
            {
                if (MessageBox.Show("REALMENTE DECEA MODIFICAR ESTE CAMPO ", "Actualizar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                
                    op.ConsultasSinResultados("UPDATE registro SET id_registro = '" + txtIdRegistro.Text + "', fecha= '" + txtfecha.Text + "', id_chofer = '" + Convert.ToInt16(txtIdChofer.Text) + "', id_camion = '" + Convert.ToInt16(txtIdCamion.Text) + "', id_ruta = '" + Convert.ToInt16(txtIdDestino.Text ) + "', monto_dieta_chofer = '" + Convert.ToInt16(txtDietaChofer.Text ) + "', monto_peaje = '" + Convert.ToInt16(txtPeaje.Text) + "', id_ayudante = '" + Convert.ToInt16(txtIdAyudante.Text ) + "', monto_dieta_ayudante = '" + Convert.ToInt16(txtDietaAyudante.Text ) + "', total_gastos = '"+Convert.ToInt16(txtTotalGastos.Text )+"' WHERE id_registro LIKE '%" + txtIdRegistro.Text + "%'");//todo funciona correctamente
                    MessageBox.Show(" DIETA GUARDADA CORRECTAMENTE", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            // borar();
        }
        
    
//para validar que se seleccionen todos los campos
    public bool validar()
        {
            if (cmbDestino.Text =="")
            {
                MessageBox.Show("POR FAVOR SELECCIONE UN DESTINO ", "SELECCIONAR DESTINO", MessageBoxButtons.OK);
                return false;
            }
            
            if (cmbChofer.Text == "")
            {
                MessageBox.Show("POR FAVOR SELECCIONE UN CHOFER ", "SELECCIONAR CHOFER", MessageBoxButtons.OK);
                return false;
            }

            if (cmbAyudante.Text == "")
            {
                MessageBox.Show("POR FAVOR SELECCIONE UN AYUDANTE ", "SELECCIONAR AYUADNTE", MessageBoxButtons.OK);
                return false;
            }

            if (cmbCamion.Text == "")
            {
                MessageBox.Show("POR FAVOR SELECCIONE UN CAMIóN ", "SELECCIONAR CAMIóN", MessageBoxButtons.OK);
                return false;
            }
            else
            { return true; }

        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbDestino_TextChanged(object sender, EventArgs e)
        {
            if(cmbDestino.Text !="")
            {
                btnNuevo_guardar.Enabled = true;
            }
            Operaciones oper = new Operaciones();
            ////llenar textbox del id del destino
            oper.llenarTextBox(txtIdDestino, "select id_ruta  from ruta where nombre LIKE '%" + cmbDestino.Text + "%' ", "id_ruta");//llenando el textbox con la dieta, dependiendo del destino
            ////llenar el textbox de la dieta del chofer
            oper.llenarTextBox(txtDietaChofer, "select dieta_chofer  from dieta_ruta where id_ruta LIKE '%" + txtIdDestino.Text + "%' ", "dieta_chofer");//llenando el textbox con la dieta, dependiendo del destino
            //llenar el combo con la dieta del ayudante
            oper.llenarTextBox(txtDietaAyudante, "select dieta_ayudante  from dieta_ruta where id_ruta LIKE '%" + txtIdDestino.Text + "%' ", "dieta_ayudante");//llenando el textbox con la dieta, dependiendo del destino

           // txtPrecioPorGomas.Text = "";
            oper.llenarTextBox(txtPrecioPorGomas, "select peaje_costo_gomas from ruta where id_ruta like'%" + txtIdDestino.Text  + "'", "peaje_costo_gomas");


            calcularPeaje_dietas();//funcion que calcula el peaje
           
         


        }

        public void calcularPeaje_dietas()
        {
            int costoPorGomas = 0;
            int cantidadDeGomas = 0;
            int totalGastos = 0;

            int dieta_del_chofer = Convert.ToInt32(txtDietaChofer.Text);
            int dieta_del_ayudante = Convert.ToInt16(txtDietaAyudante.Text);

            int peaje = 0;

            if (txtPrecioPorGomas.Text != "")
            {
                cantidadDeGomas = Convert.ToInt32(txtCantidadGomas.Text);
                costoPorGomas = Convert.ToInt32(txtPrecioPorGomas.Text);

                peaje = (cantidadDeGomas * costoPorGomas);

                totalGastos = (dieta_del_ayudante + dieta_del_chofer + peaje);
                
                txtPeaje.Text = Convert.ToString(peaje);//muestra el peaje en el textbox
                txtTotalGastos.Text = Convert.ToString(totalGastos);//muestra en total gastos el total de todos los gastos



            }
            else//si no hay precio por gomas entonces no hay peaje por lo tanto solo se calculan las dietas
            {
                txtPeaje.Text = "0";
                txtTotalGastos.Text =Convert.ToString( (dieta_del_chofer + dieta_del_ayudante));
             
            }




        }

        private void cmbDestino_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void cmbDestino_Click(object sender, EventArgs e)
        {


        }

        private void cmbDestino_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbAyudante_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNuevoDestino_Click(object sender, EventArgs e)
        {
            frmCrudRuta rt = new frmCrudRuta();
            rt.Show();
            
        }

        private void btnNuevoChofer_Click(object sender, EventArgs e)
        {
            frmRegistroDeEmpleado re = new frmRegistroDeEmpleado();
            re.Show();
        }

        private void cmbNuevoAyudante_Click(object sender, EventArgs e)
        {
            frmRegistroDeEmpleado re = new frmRegistroDeEmpleado();
            re.Show();

        }

        private void btnNuevoCamion_Click(object sender, EventArgs e)
        {
            frmCamion cam = new frmCamion();
            cam.Show();
        }

        private void txtIdDestino_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbAyudante_TextChanged(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            //llenando el textbox id del ayudante 
            oper.llenarTextBox(txtIdAyudante, "select id_ayudante  from ayudante where nombre like '%" + cmbAyudante.Text + "%' ", "id_ayudante");

        }

        public int totalGastos (int  DietaChofer, int  DietaAyudante,  int precioPorGomas, int cantidadDeGomas )
        {

            int peaje;
            peaje = (precioPorGomas * cantidadDeGomas);


          return DietaChofer + DietaAyudante + peaje;

            //return totalGastos;
        }
        private void cmbChofer_TextChanged(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            //llenando el textbox id del chofer 
            oper.llenarTextBox(txtIdChofer, "select id_chofer  from chofer where nombre like '%"+cmbChofer.Text +"%' " , "id_chofer");
            
            
        }

        private void cmbCamion_TextChanged(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            //llenando el textbox id del camion
            oper.llenarTextBox(txtIdCamion, "select id_camion  from camion where placa  LIKE '%" + cmbCamion.Text + "%' ", "id_camion");
            //llenando un textbox con la cantidad de gomas para luego hacer los calculos 
            oper.llenarTextBox(txtCantidadGomas,"select cant_gomas from camion where id_camion like'%"+txtIdCamion.Text+"'", "cant_gomas");

            calcularPeaje_dietas();//funcion que calcula el peaje
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("REALMENTE DECEA ELIMINAR ESTA DIETA", "ELIMINAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("DELETE FROM registro WHERE id_registro = '" + txtIdRegistro.Text + "'");
                MessageBox.Show("REGISTRO BORRADO");
                this.Close();
            }
        }

        private void txtPrecioPorGomas_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
