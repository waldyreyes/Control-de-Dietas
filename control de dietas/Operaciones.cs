using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
namespace control_de_dietas
{
    class Operaciones
    {
        SQLiteConnection cnn;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public  Operaciones()
        { 
            cnn= new SQLiteConnection("Data Source=C:\\SISTEMAS\\dietas.s3db; Version=3;");
            try
            {
                cnn.Open();
                //return "conexion exitosa";
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            
        }

        public void llenarComboBox(ComboBox combo, string query, string nombCampo)//coje como parametro el combobox, el select de la bd y el nombre del campo
        {
            try
            {
                cmd = new SQLiteCommand(query, cnn);//  le paso el query( select )de la base de datos y el sqlite command
                dr = cmd.ExecuteReader();//llenando el datareader con los registros del sqlite command
                
                while (dr.Read())//ciclo para que lea cada uno de los registros de la base de datos
                {
                    combo.Items.Add(dr[nombCampo].ToString());//agregando los items de la base de datos
                }
                dr.Close();//cerrando la conexion 

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo cargar nada"+ ex.ToString() );
            }
        }


       
        //funcion  para llenar un textbox
        public void llenarTextBox(TextBox textbox, string query, string nombCampo)//coje como parametro el textbox, el select de la bd y el nombre del campo
        {
            try
            {
                cmd = new SQLiteCommand(query, cnn);//  le paso el query( select )de la base de datos y el sqlite command
                dr = cmd.ExecuteReader();//llenando el datareader con los registros del sqlite command

                if (dr.Read())
                {
                    textbox.Text = dr[nombCampo].ToString();//agregando los items de la base de datos
                }
                dr.Close();//cerrando la conexion 

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar nada " + ex.ToString());
            }
        }

        /// <summary>
        /// ///////////
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>




        public string ConsultasSinResultados(string sql)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SISTEMAS\\dietas.s3db; Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }
        }


        public DataTable ConsultaConResultado(string sql)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\SISTEMAS\\dietas.s3db; Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {

            }
            cnx.Close();
            return dt;
        }

        // METODO PARA QUE PERMITA SOLO LETRAS 
        public void soloLetras(KeyPressEventArgs l)
        {
            if (char.IsLetter(l.KeyChar))
            {
                l.Handled = false;
            }
            else if (char.IsSeparator(l.KeyChar))
            {
                l.Handled = false;

            }
            else if (char.IsControl(l.KeyChar))
            {
                l.Handled = false;

            }
            else
            {
                l.Handled = true;
            }
        }
        //METODO PARA QUE PERMITA SOLO NUMEROS
        public void soloNumeros(KeyPressEventArgs l)
        {
            if (char.IsDigit(l.KeyChar))
            {
                l.Handled = false;
            }
            else if (char.IsSeparator(l.KeyChar))
            {
                l.Handled = false;
            }
            else if (char.IsControl(l.KeyChar))
            {
                l.Handled = false;

            }
            else if (l.KeyChar.ToString().Equals("."))
            {
                l.Handled = false;
            }
            else
            {
                l.Handled = true;
            }
        }
    }
}
