using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CajaCEMISAM.Utilerias;
using System.Data.OleDb;

namespace CajaCEMISAM.Formularios
{
    public partial class CrearPaciente : Form
    {
        
        public CrearPaciente()
        {
            InitializeComponent();
        }

        private void CrearPaciente_Load(object sender, EventArgs e)
        {
                        
            // TODO: esta línea de código carga datos en la tabla 'bdcajaDataSet.costos' Puede moverla o quitarla según sea necesario.
           // this.costosTableAdapter.Fill(this.bdcajaDataSet.costos);
            // TODO: esta línea de código carga datos en la tabla 'bdcajaDataSet.recibos' Puede moverla o quitarla según sea necesario.
           // this.recibosTableAdapter.Fill(this.bdcajaDataSet.recibos);
            txtDomicilio.Text = "MORELIA";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int noExpediente = Int32.Parse(txtNoExpediente.Text);
                string nombre = txtNombre.Text.ToString().ToUpper();
                string domicilio = txtDomicilio.Text.ToString().ToUpper();
                short cbnivel = short.Parse(cbNivel.Text);
                Pacientes paciente = new Pacientes(noExpediente, nombre, domicilio, cbnivel);

                try
                {


                    string insertar = "insert into pacientes (noExpediente,nombre,domicilio,nivel) values ('" + noExpediente + "', '" + nombre + "', '" + domicilio + "', '" + cbnivel + "')";
                    conbd.iniciarConexion();
                    OleDbCommand cmd = new OleDbCommand(insertar, conbd.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado correctamente ","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                    limpiar();
                    this.Close();
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show("Error de Comunicacion:\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    conbd.cerrarConexion();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se han podido ingresar sus datos, por favor verifiquelos\n"+ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }

        public void limpiar()
        {
            txtNoExpediente.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            cbNivel.Text = "";
        }

        //private void txtNoExpediente_Validated(object sender, EventArgs e)
        //{
            
        //}

        private void txtNoExpediente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNoExpediente_Validating(object sender, CancelEventArgs e)
        {
           
        }      

        private void txtNoExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDigitaNumeros(e);
        }

        private void soloDigitaNumeros(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

        private void txtNoExpediente_Validated(object sender, EventArgs e)
        {
            //if (txtNoExpediente.Text == "")
            //{
            //    MessageBox.Show("Ingrese un numero de expediente");
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
