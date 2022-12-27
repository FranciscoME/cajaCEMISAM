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
    public enum cboxActive { Activado, Desactivado };
    public partial class ModificarPaciente : Form
    {
        
        string consulta;
        public ModificarPaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int noExpediente; 
            string[] pacientes = null;
            
            try
            {
                noExpediente = Int32.Parse(txtBuscaNoExpediente.Text.ToString());

                try
                {
                    conbd.iniciarConexion();
                    consulta = "SELECT * FROM pacientes WHERE noExpediente =" + noExpediente + "";
                    OleDbDataAdapter myAdapter = new OleDbDataAdapter(consulta, conbd.conexion);

                    DataSet myDataSet = new DataSet();
                    myAdapter.Fill(myDataSet);

                    if (myDataSet.Tables[0].Rows.Count > 0)
                    {
                        pacientes = new string[myDataSet.Tables[0].Rows.Count];
                        for (int i = 0; i < myDataSet.Tables[0].Rows.Count; i++)
                        {
                            DataRow campo = myDataSet.Tables[0].Rows[i];
                            lblId.Text = campo["id"].ToString();
                            txtNoExpediente.Text = campo["noExpediente"].ToString();
                            txtNombre.Text = campo["nombre"].ToString();
                            txtDomicilio.Text = campo["domicilio"].ToString();
                           txtNivel.Text = campo["nivel"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Existe este registro, Favor de ingresar el nuevo paciente");
                        CrearPaciente formPaciente = new CrearPaciente();
                        formPaciente.Show();
                    }

                    habilitarCajas();
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show("Error de Comunicacion:\n" + ex.Message);
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
                MessageBox.Show("Introduce un numero de expediente:\n" + ex.Message);
                txtBuscaNoExpediente.Focus();
            }
            
            

            
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(lblId.Text);
                int noExpediente = int.Parse(txtNoExpediente.Text);
                string nombre = txtNombre.Text;
                string domicilio = txtDomicilio.Text;
                short nivel = short.Parse(txtNivel.Text);





                try
                {

                    // consulta = "UPDATE pacientes SET (noExpediente,nombre,domicilio,nivel) values ('" + noExpediente + "','" + nombre + "','" + domicilio + "','" + nivel + "' WHERE id =)";
                    consulta = "UPDATE pacientes SET noExpediente='" + noExpediente + "', nombre='" + nombre + "',domicilio='" + domicilio + "',nivel='" + nivel + "' WHERE Id=" + id + "";

                    conbd.iniciarConexion();
                    OleDbCommand cmd = new OleDbCommand(consulta, conbd.conexion);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado correctamente","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show("Error de Comunicacion:\n" + ex.Message);
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
                MessageBox.Show("Hubo un error al ingresar sus datos, porfavor verifiquelos"+ex, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            

            limpiarCajas();
            
        }

        private void ModificarPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdcajaDataSet.costos' table. You can move, or remove it, as needed.
            //this.costosTableAdapter.Fill(this.bdcajaDataSet.costos);
                        
            deshabilitarCajas();
            txtNoExpediente.Enabled = false;
            btnActualizar.Enabled = false;
            txtNivel.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void deshabilitarCajas()
        {
            txtDomicilio.Enabled = false;
            txtNombre.Enabled = false;
            txtNoExpediente.Enabled = false;
            txtDomicilio.Enabled = false;
            
        }

        private void habilitarCajas()
        {
            txtDomicilio.Enabled = true;
            txtNombre.Enabled = true;            
            txtDomicilio.Enabled = true;
            txtNivel.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void limpiarCajas()
        {
            txtBuscaNoExpediente.Text = "";
            txtNoExpediente.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtNivel.Text = "";
            deshabilitarCajas();
        }

        private void btnModificarExpediente_Click(object sender, EventArgs e)
        {
            txtNoExpediente.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }
    }
}
