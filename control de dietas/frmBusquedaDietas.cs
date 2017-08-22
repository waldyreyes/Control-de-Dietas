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
    public partial class frmBusquedaDietas : Form
    {
        public frmBusquedaDietas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmcrudDieta die = new frmcrudDieta();
            die.Show();
        }

        private void frmBusquedaDietas_Load(object sender, EventArgs e)
        {
            rbtnFecha.Checked = true;
            Operaciones oper = new Operaciones();
            dataGridView1.DataSource = oper.ConsultaConResultado("SELECT * FROM registro order by fecha asc");
            oper.llenarComboBox(cmbDestino, "SELECT nombre from ruta ", "nombre");//llenando el combo destino 

            oper.llenarComboBox(cmbDesde, "SELECT fecha from registro order by fecha asc ", "fecha");

            oper.llenarComboBox(cmbHasta, "SELECT fecha from registro order by fecha desc", "fecha");

        }

        private void frmBusquedaDietas_Click(object sender, EventArgs e)
        {
        }

        private void rbtnChofer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbtnDestino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDestino.Checked)
            {

                grbChoferMasViajado.Visible = false;
                grpDetallesFaltantes.Visible = true;
                cmbDestino.Enabled = true;
            }
            else
            {
                cmbDestino.Enabled = false;
            }

        }

        private void rbtnFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFecha.Checked == true)//si el radio de la busqueda de fecha esta cheq a la fecha final desabilitala
            {
                grbChoferMasViajado.Visible = false;
                grpDetallesFaltantes.Visible = true;
                cmbDesde.Enabled = true;
                cmbHasta.Enabled = true;
            }
            else   // de lo contrario habilitala
            {
                cmbDesde.Enabled = false;
                cmbHasta.Enabled = false;
            }
        }

        private void rbtnChofer_CheckedChanged(object sender, EventArgs e)
        {

            grbChoferMasViajado.Visible = true;
            grpDetallesFaltantes.Visible = false;
            cmbDesde.Enabled = true;
            cmbHasta.Enabled = true;
        }

        private void rbtnAyudante_CheckedChanged(object sender, EventArgs e)
        {

            grbChoferMasViajado.Visible = true;
            lblChofer.Text = "Ayudante que más ha viajado";

            grpDetallesFaltantes.Visible = false;
            cmbDesde.Enabled = true;
            cmbHasta.Enabled = true;
        }

        //funsion que calcula el total gastado
        public void calculaTotalGastado()
        {
            double total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["total_gastos"].Value);
            }
            txtTotalGastado.Text = Convert.ToString(total);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();//haciendo una instancia de la clase

             
                    
                            
            if (rbtnDestino.Checked == true)
            {
                //dataGridView1.DataSource = op.ConsultaConResultado(" select  registro.id_registro, registro.fecha, chofer.nombre as conductor, registro.monto_dieta_chofer as dieta_chofer, ayudante.nombre as ayudant, registro.monto_dieta_ayudante as dieta_ayud, ruta.nombre as destino, camion.placa as placa_camion, registro.monto_peaje, registro.total_gastos  from registro inner join chofer on chofer.id_chofer = registro.id_chofer  inner join ayudante on registro.id_ayudante = ayudante.id_ayudante inner join ruta on ruta.id_ruta = registro.id_ruta   inner join camion on registro.id_camion = camion.id_camion  where registro.id_ruta ='"+ Convert.ToInt16(txtIdDestino.Text) +"'");

                dataGridView1.DataSource = op.ConsultaConResultado("select * from registro where id_ruta LIKE '%" + Convert.ToInt16(txtIdDestino.Text) + "%'");
                calculaTotalGastado();
            }



            else if (rbtnFecha.Checked == true)
            {
                dataGridView1.DataSource = op.ConsultaConResultado("select * from registro where fecha between  '"+cmbDesde.Text +"' and '"+cmbHasta.Text + "'order by fecha asc");
                calculaTotalGastado();
            }

           else if (rbtnChofer.Checked==true)
            {
                dataGridView1.DataSource =op.ConsultaConResultado("select  id_registro, id_chofer, count(id_chofer) cantidad_registros from registro where fecha between  '" + cmbDesde.Text + "' and '" + cmbHasta.Text + "'");
            }

            
            else if (rbtnAyudante.Checked == true)
            {
                dataGridView1.DataSource = op.ConsultaConResultado("select  id_registro, id_ayudante, count(id_ayudante) cantidad_registros from registro where fecha between  '" + cmbDesde.Text + "' and '" + cmbHasta.Text + "'");
            }
            
            else 
            {
                dataGridView1.DataSource = op.ConsultaConResultado("SELECT * FROM  registro");
            }

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones oper = new Operaciones();
            //creando una variable de tipo datagrid viewRow
            DataGridViewRow rellenar = dataGridView1.Rows[e.RowIndex];
            //creando variable de id_detalle dietas para coparar si hay algo en el data grid para hacer lo que pido 
            String id_detalle_dietas = rellenar.Cells["id_registro"].Value.ToString();





            if (rbtnFecha.Checked == true || rbtnDestino.Checked == true)// comprueba si estan check para agregar a los campos correspondietes

            {
                if (id_detalle_dietas != "")
                {
                    // creando una variable para guardar el id que se encuantra el el data grid este es para el chofer

                    int id_epleado = Convert.ToInt16(rellenar.Cells["id_chofer"].Value.ToString());
                    // creando una variable para guardar el id que se encuantra el el data grid, este es para el ayudante
                    int id_ayudante = Convert.ToInt16(rellenar.Cells["id_ayudante"].Value.ToString());
                    int id_camion = Convert.ToInt16(rellenar.Cells["id_camion"].Value.ToString());
                    int id_ruta = Convert.ToInt16(rellenar.Cells["id_ruta"].Value.ToString());

                    //llenando los textbox
                    oper.llenarTextBox(txtChofer, "select  nombre from chofer where id_chofer ='" + id_epleado + "'", "nombre");

                    oper.llenarTextBox(txtAyudante, "select  nombre from ayudante where id_ayudante ='" + id_ayudante + "'", "nombre");

                    oper.llenarTextBox(txtCamion, "SELECT  placa from camion where id_camion = '" + id_camion + "'", "placa");

                    oper.llenarTextBox(txtRuta, "select nombre from ruta where id_ruta = '" + id_ruta + "'", "nombre");

                }
                else
                {
                    MessageBox.Show("POR FAVOR SELECCIONE UNA DIETA");
                }
            }

            else
            {
               
                // creando una variable para guardar el id que se encuantra el el data grid, este es para el ayudante
                
                if (rbtnChofer.Checked==true)
                {
                    
                    int id_epleado = Convert.ToInt16(rellenar.Cells["id_chofer"].Value.ToString());
                    oper.llenarTextBox(textBox1, "select  nombre from chofer where id_chofer ='" + id_epleado + "'", "nombre");
                }
                else if(rbtnAyudante.Checked==true)
                {
                    int id_ayudante = Convert.ToInt16(rellenar.Cells["id_ayudante"].Value.ToString());

                    oper.llenarTextBox(textBox1, "select  nombre from ayudante where id_ayudante ='" + id_ayudante +"'", "nombre");

                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmcrudDieta cd = new frmcrudDieta();



                
                //grpDetallesFaltantes.Visible = true;
                DataGridViewRow rellenar = dataGridView1.Rows[e.RowIndex];

                cd.txtIdRegistro.Text = rellenar.Cells["id_registro"].Value.ToString();
                //cd.txt .Text = rellenar.Cells["fecha"].Value.ToString();
                cd.cmbChofer.Text = txtChofer.Text;
                cd.cmbAyudante.Text = txtAyudante.Text;
                cd.cmbCamion.Text = txtCamion.Text;
                cd.cmbDestino.Text = txtRuta.Text;
                // cd.txtObservaciones.Text = rellenar.Cells["observaciones"].Value.ToString();
                cd.btnNuevo_guardar.Text = "Guardar";// cambiandole el letrero al boton por de nuevo a guardar
                cd.Show();
            
        
        }
        private void cmbDestino_TextChanged(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            //llenar el textbox de la dieta 
            oper.llenarTextBox(txtIdDestino, "select id_ruta  from ruta where nombre LIKE '%" + cmbDestino.Text + "%' ", "id_ruta");//llenando el textbox con el id _ ruta, dependiendo del destino

        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string fecha;
        private void cmbDesde_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHasta_TextChanged(object sender, EventArgs e)
        {
            //if (cmbDesde.Text  != "")
            //{
            //    Operaciones op = new Operaciones();
            //    dataGridView1.DataSource = op.ConsultaConResultado("select * from registro where fecha between  '" + cmbDesde.Text + "' and '" + cmbHasta.Text + "'order by fecha asc");
            //    calculaTotalGastado();
            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (rbtnFecha.Checked == true)
            {
                Operaciones oper = new Operaciones();
                DataSet ds = new DataSet();

                DataTable dt = oper.ConsultaConResultado("select registro.fecha, chofer.nombre as Conductor,  registro.monto_dieta_chofer as Dieta_Conductor, registro.monto_peaje as Peaje,  ayudante.nombre as Ayud, registro.monto_dieta_ayudante as Dieta_Ayud, camion.placa, ruta.nombre as Destino, registro.total_gastos  from registro inner join chofer on chofer.id_chofer=registro.id_chofer inner join ayudante on ayudante.id_ayudante=registro.id_ayudante inner join camion  on camion.id_camion = registro.id_camion inner join ruta on ruta.id_ruta= registro.id_ruta   where fecha between  '" + cmbDesde.Text + "' and '" + cmbHasta.Text + "'order by fecha asc");

                ds.Tables.Add(dt);


                ds.WriteXml(@"C:\SISTEMAS\xml\porFecha.xml");

                frmVisorReportePorFecha be = new frmVisorReportePorFecha();
                be.Show();
            }


            else if(rbtnChofer.Checked ==true)
            {
                Operaciones oper = new Operaciones();
                DataSet ds = new DataSet();

                DataTable dt = oper.ConsultaConResultado("select registro.fecha,  chofer.nombre, count(registro.id_chofer) from registro inner join chofer on registro.id_chofer=chofer.id_chofer  where fecha between  '" + cmbDesde.Text + "' and '" + cmbHasta.Text + "'order by fecha asc");

                ds.Tables.Add(dt);


                ds.WriteXml(@"C:\SISTEMAS\xml\choferMasViajo.xml");
                frmVisorChoferMasViajo c = new frmVisorChoferMasViajo();
                c.Show();
            }

            else if (rbtnAyudante.Checked == true)
            {
                Operaciones oper = new Operaciones();
                DataSet ds = new DataSet();

                DataTable dt = oper.ConsultaConResultado("select registro.fecha,  ayudante.nombre, count(registro.id_ayudante) from registro inner join ayudante on registro.id_ayudante=ayudante.id_ayudante  where fecha between  '" + cmbDesde.Text + "' and '" + cmbHasta.Text + "'order by fecha asc");

                ds.Tables.Add(dt);


                ds.WriteXml(@"C:\SISTEMAS\xml\ayudanteMasViajo.xml");
                frmVisorAyudanteMasViajo a = new frmVisorAyudanteMasViajo();
                a.Show();
            }

            else if (rbtnDestino.Checked==true)
            {

                Operaciones oper = new Operaciones();
                DataSet ds = new DataSet();

                DataTable dt = oper.ConsultaConResultado(" select  registro.id_registro, registro.fecha, chofer.nombre as conductor, registro.monto_dieta_chofer as dieta_chofer, ayudante.nombre as ayudant, registro.monto_dieta_ayudante as dieta_ayud, ruta.nombre as destino, camion.placa as placa_camion, registro.monto_peaje, registro.total_gastos  from registro inner join chofer on chofer.id_chofer = registro.id_chofer  inner join ayudante on registro.id_ayudante = ayudante.id_ayudante inner join ruta on ruta.id_ruta = registro.id_ruta   inner join camion on registro.id_camion = camion.id_camion  where registro.id_ruta ='" + Convert.ToInt16(txtIdDestino.Text) + "'");

                ds.Tables.Add(dt);


                ds.WriteXml(@"C:\SISTEMAS\xml\porRuta.xml");
                frmVisorPorRuta vr = new frmVisorPorRuta();
                vr.Show();
            }
        }
    } 
}
