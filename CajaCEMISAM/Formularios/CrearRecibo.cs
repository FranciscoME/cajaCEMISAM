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
using CajaCEMISAM.clases;

namespace CajaCEMISAM.Formularios
{
    public partial class CrearRecibo : Form
    {
        DateTime fechaActual = DateTime.Now;
        string fechaCorta;
        string fecha;
        string idRecibo;
        string noExpediente;
        string nombre;
        string Domicilio;
        string ser1;
        string ser2;
        string ser3;
        string nivel;
        string total;
        string totalLetra;


        //datos de la  sumatoria para corte de caja
        int sumPsiquiatria = 0;
        int sumPsicologia = 0;
        int sumvaloracionPsiq = 0;
        int sumvaloracionPsic = 0;
        int sumvaloracionFam = 0;
        int sumvaloracionCal = 0;
        int sumvaloracionNut = 0;
        int sumconsultaNut = 0;
        int sumplaticaNut = 0;
        int sumvaloracionNeu = 0;
        int sumpaqueteNeu = 0;
        int sumurgencias = 0;
        int sumrevaloracionPsiq = 0;
        int sumrevaloracionPsic = 0;
        int sumpsicoeducacion = 0;
        int sumreposicionCar = 0;       
        int sumcrianzaPositiva = 0;
        int sumgrupoV = 0;
        int sumneuroPsiq = 0;
        int sumneuroPsic = 0;

        //*************************


        //ReciboImprimir paciente = new ReciboImprimir();

        //Costos de servicios
        int id = 0;
        Int16 cpsiquiatria =0;
        Int16 cpsicologia = 0;
        Int16 cvaloracionPsiq = 0;
        Int16 cvaloracionPsic = 0;
        Int16 crevaloracionPsiq = 0;
        Int16 crevaloracionPsic = 0; 
        Int16 cvaloracionFam = 0;
        Int16 cvaloracionCal = 0;
        Int16 cvaloracionNut = 0;
        Int16 cconsultaNut = 0;
        Int16 cplaticaNut = 0;
        Int16 cvaloracionNeu = 0;
        Int16 cpaqueteNeu = 0;
        Int16 curgencias = 0;        
        Int16 cpsicoeducacion=0;
        Int16 creposicionCar = 0;
        Int16 ccriazaPositiva = 0;
        Int16 cgrupoV = 0;
        Int16 cneuroPsiq= 0;
        Int16 cneuroPsic = 0;
       
        //********
        
        //Crea un objeto de herramientas necesarias para convertir de numero a letra
        Herramientas herramienta = new Herramientas();

        // Mostrar datagridview
        private BindingSource bindingsource1 = new BindingSource();
        private OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        DataTable tabla;
        //+++++++++++++++++


        string consulta;
        public CrearRecibo()
        {
            InitializeComponent();
        }

        private void CrearRecibo_Load(object sender, EventArgs e)
        {
            txtElaboro.Text = "C. MARIA VELA TAFOYA";
            // TODO: esta línea de código carga datos en la tabla 'bdcajaDataSet.costos' Puede moverla o quitarla según sea necesario.
            //this.costosTableAdapter.Fill(this.bdcajaDataSet.costos);
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //fechaCorta = txtFecha.Text.ToString();
            fechaCorta = txtFecha.Text.ToString();
            limpiarFormCrearRecibo();
            

            //mostrar datagridview
            dataGridView2.DataSource = bindingsource1;
            
            //MessageBox.Show(fechaActual.ToString("d"));
            //string fech = "5/11/2014";
             //fechaCorta = fechaActual.ToString("MM/dd/yyyy");            

            //mostrarRecibos("Select * From recibos WHERE  (((recibos.fecha) =#" + fechaCorta + "#))");
             //dataGridView2.AutoGenerateColumns = false;

             //mostrarRecibos("Select * From recibos WHERE  (((recibos.fecha) =#" + fechaCorta + "#))");

             monthCalendar1.Visible = true;
             btnCalcular.BackColor = Color.Gray;
             btnGuardareImprimir.BackColor = Color.Gray;
             lblFechaSeleccionada.Text = fechaCorta;
        }
                

        private void button1_Click(object sender, EventArgs e)
        {
            buscarPaciente();
        }

        private void buscarPaciente()
        {
            string[] pacientes = null;
            conbd.iniciarConexion();
            txtNoExpediente.Enabled = false;
            try
            {
                int noExpediente = Int32.Parse(txtNoExpediente.Text.ToString());

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
                        txtNombre.Text = campo["nombre"].ToString();
                        txtDomicilio.Text = campo["domicilio"].ToString();
                        txtNivel.Text = campo["nivel"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No Existe este paciente con el numero de expediente: "+noExpediente+"\nPor favor ingrese el nuevo paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    CrearPaciente formPaciente = new CrearPaciente();
                    formPaciente.Show();
                }

                cbSer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor introduzca el numero de expediente\n" + ex, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtNoExpediente.Focus();
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            short nivel = short.Parse(txtNivel.Text);
            EstablecerPrecios(nivel);
            
            string ser1 = cbSer1.Text;                       
            txtSer1.Text= calcularSer1(ser1).ToString();
            string ser2 = cbSer2.Text;
            txtSer2.Text = calcularSer1(ser2).ToString();
            string ser3 = cbSer3.Text;
            txtSer3.Text = calcularSer1(ser3).ToString();

            txtTotal.Text = Herramientas.sumarTotales(this).ToString();
            string totalLetra=txtTotal.Text.ToString();
            lblCanLetra.Text = herramienta.ConvertLetter(totalLetra, "MX");

           
            btnGuardareImprimir.Enabled = true;
            txtSer1.Enabled = true;
            txtSer2.Enabled = true;
            txtSer3.Enabled = true;
            btnGuardareImprimir.BackColor = Color.DarkOrange;
        }

        private void EstablecerPrecios(short _nivel)
        {
            string[] precios = null;
            conbd.iniciarConexion();
            
            consulta = "SELECT * FROM costos WHERE nivelSoc =" + _nivel + "";

            OleDbDataAdapter myAdapter = new OleDbDataAdapter(consulta, conbd.conexion);

            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);

            if (myDataSet.Tables[0].Rows.Count > 0)
            {
                precios = new string[myDataSet.Tables[0].Rows.Count];
                for (int i = 0; i < myDataSet.Tables[0].Rows.Count; i++)
                {
                    DataRow campo = myDataSet.Tables[0].Rows[i];                     
                     cpsiquiatria = Int16.Parse( campo["cpsiquiatria"].ToString());
                     cpsicologia = Int16.Parse( campo["cpsicologia"].ToString());
                     cvaloracionPsiq = Int16.Parse(campo["cvaloracionPsiq"].ToString());
                     cvaloracionPsic = Int16.Parse(campo["cvaloracionPsic"].ToString());
                     cvaloracionFam = Int16.Parse(campo["cvaloracionFam"].ToString());
                     cvaloracionCal = Int16.Parse(campo["cvaloracionCal"].ToString());
                     cvaloracionNut = Int16.Parse(campo["cvaloracionNut"].ToString());
                     cvaloracionNeu = Int16.Parse(campo["cvaloracionNeu"].ToString());
                     cpaqueteNeu = Int16.Parse(campo["cpaqueteNeu"].ToString());
                     curgencias = Int16.Parse(campo["curgencias"].ToString());
                     crevaloracionPsiq = Int16.Parse(campo["crevaloracionPsiq"].ToString());
                     crevaloracionPsic = Int16.Parse(campo["crevaloracionPsic"].ToString());
                     cpsicoeducacion = Int16.Parse(campo["cpsicoeducacion"].ToString());
                     creposicionCar = Int16.Parse(campo["creposicionCar"].ToString());
                     ccriazaPositiva = Int16.Parse(campo["ccrianzaPositiva"].ToString());
                     cgrupoV = Int16.Parse(campo["cModuloV"].ToString());
                     cneuroPsiq = Int16.Parse(campo["cneuropsiquiatria"].ToString());
                     cneuroPsic = Int16.Parse(campo["cneuropsicologia"].ToString());
                     cconsultaNut = Int16.Parse(campo["cconsultaNut"].ToString());
                     cplaticaNut = Int16.Parse(campo["cplaticaNut"].ToString());          
                     
                      
                }
            }           
            
        }

        private int calcularSer1(string _ser1)
        {
            Int16 totalSer1=0;
            switch (_ser1)
            {
                case "Psiquiatria":
                    totalSer1 = cpsiquiatria;
                    break;
                case "Psicologia":
                    totalSer1 = cpsicologia;
                    break;
                case "Valoracion Psiquiatria":
                    totalSer1 = cvaloracionPsiq;
                    break;
                case "Valoracion Psicologia":
                    totalSer1 = cvaloracionPsic;
                    break;
                case "Revaloracion Psiquiatria":
                    totalSer1 = crevaloracionPsiq;
                    break;
                case "Revaloracion Psicologia":
                    totalSer1 = crevaloracionPsic;
                    break;
                case "Urgencias":
                    totalSer1 = curgencias;
                    break;
                case "Psicoeducacion":
                    totalSer1 = cpsicoeducacion;
                    break;
                case "Reposicion de carnet":
                    totalSer1 = creposicionCar;
                    break;
                case "Valoracion Familiar":
                    totalSer1 = cvaloracionFam;
                    break;
                case "Valoracion Conducta Alimentaria":
                    totalSer1 = cvaloracionCal;
                    break;
                case "Valoracion Nutricion":
                    totalSer1 = cvaloracionNut;
                    break;
                case "Consulta de Nutricion":
                    totalSer1 = cconsultaNut;
                    break;
                case "Platica de Nutricion":
                    totalSer1 = cplaticaNut;
                    break;
                case "Valoracion Neuropsicologica":
                    totalSer1 = cvaloracionNeu;
                    break;
                case "Paquete de Neuropsicologia":
                    totalSer1 = cpaqueteNeu;
                    break;
                case "Crianza Positiva":
                    totalSer1 = ccriazaPositiva;
                    break;
                case "Grupo V":
                    totalSer1 = cgrupoV;
                    break;
                case "Neuropsiquiatria":
                    totalSer1 = cneuroPsiq;
                    break;
                case "Neuropsicologia":
                    totalSer1 = cneuroPsic;
                    break;
                                 

            }
            return totalSer1;            
        }

        private int calcularSer2(string _ser2)
        {
            Int16 totalSer2 = 0;
            switch (_ser2)
            {
                case "Psiquiatria":
                    totalSer2 = cpsiquiatria;
                    break;
                case "Psicologia":
                    totalSer2 = cpsicologia;
                    break;
                case "Valoracion Psiquiatria":
                    totalSer2 = cvaloracionPsiq;
                    break;
                case "Valoracion Psicologia":
                    totalSer2 = cvaloracionPsic;
                    break;
                case "Revaloracion Psiquiatria":
                    totalSer2 = crevaloracionPsiq;
                    break;
                case "Revaloracion Psicologia":
                    totalSer2 = crevaloracionPsic;
                    break;
                case "Urgencias":
                    totalSer2 = curgencias;
                    break;
                case "Psicoeducacion":
                    totalSer2 = cpsicoeducacion;
                    break;
                case "Reposicion de carnet":
                    totalSer2 = creposicionCar;
                    break;
                case "Valoracion Familiar":
                    totalSer2 = cvaloracionFam;
                    break;
                case "Valoracion Conducta Alimentaria":
                    totalSer2 = cvaloracionCal;
                    break;
                case "Valoracion Nutricion":
                    totalSer2 = cvaloracionNut;
                    break;
                case "Consulta de Nutricion":
                    totalSer2 = cconsultaNut;
                    break;
                case "Platica de Nutricion":
                    totalSer2 = cplaticaNut;
                    break;
                case "Valoracion Neuropsicologica":
                    totalSer2 = cvaloracionNeu;
                    break;
                case "Paquete de Neuropsicologia":
                    totalSer2 = cpaqueteNeu;
                    break;
                case "Crianza Positiva":
                    totalSer2 = ccriazaPositiva;
                    break;
                case "Grupo V":
                    totalSer2 = cgrupoV;
                    break;
                case "Neuropsiquiatria":
                    totalSer2 = cneuroPsiq;
                    break;
                case "Neuropsicologia":
                    totalSer2 = cneuroPsic;
                    break;

            }
            return totalSer2;
        }

        private int calcularSer3(string _ser3)
        {
            Int16 totalSer3 = 0;
            switch (_ser3)
            {
                case "Psiquiatria":
                    totalSer3 = cpsiquiatria;
                    break;
                case "Psicologia":
                    totalSer3 = cpsicologia;
                    break;
                case "Valoracion Psiquiatria":
                    totalSer3 = cvaloracionPsiq;
                    break;
                case "Valoracion Psicologia":
                    totalSer3 = cvaloracionPsic;
                    break;
                case "Revaloracion Psiquiatria":
                    totalSer3 = crevaloracionPsiq;
                    break;
                case "Revaloracion Psicologia":
                    totalSer3 = crevaloracionPsic;
                    break;
                case "Urgencias":
                    totalSer3 = curgencias;
                    break;
                case "Psicoeducacion":
                    totalSer3 = cpsicoeducacion;
                    break;
                case "Reposicion de carnet":
                    totalSer3 = creposicionCar;
                    break;
                case "Valoracion Familiar":
                    totalSer3 = cvaloracionFam;
                    break;
                case "Valoracion Conducta Alimentaria":
                    totalSer3 = cvaloracionCal;
                    break;
                case "Valoracion Nutricion":
                    totalSer3 = cvaloracionNut;
                    break;
                case "Consulta de Nutricion":
                    totalSer3 = cconsultaNut;
                    break;
                case "Platica de Nutricion":
                    totalSer3 = cplaticaNut;
                    break;
                case "Valoracion Neuropsicologica":
                    totalSer3 = cvaloracionNeu;
                    break;
                case "Paquete de Neuropsicologia":
                    totalSer3 = cpaqueteNeu;
                    break;
                case "Crianza Positiva":
                    totalSer3 = ccriazaPositiva;
                    break;
                case "Grupo V":
                    totalSer3 = cgrupoV;
                    break;
                case "Neuropsiquiatria":
                    totalSer3 = cneuroPsiq;
                    break;
                case "Neuropsicologia":
                    totalSer3 = cneuroPsic;
                    break;

            }
            return totalSer3;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtTotal.Text = Herramientas.sumarTotales(this).ToString();
            string totalLetra = txtTotal.Text.ToString();
            lblCanLetra.Text = herramienta.ConvertLetter(totalLetra, "MX");
        }

        private void txtImprimir_Click(object sender, EventArgs e)
        {
            obtenerIdRecibo();
            GuardarRecibo();
            generarImpresion();
            limpiarFormCrearRecibo();           
            
        }

        private void GuardarRecibo()
        {
            Recibos recibo = HacerRecibo();
            try
            {
               // string insertar = "insert into recibos (fecha,ser1,ser2,ser3,cser1,cser2,cser3,costoTotal,fkPacientes) values ('" + recibo.Fecha + "', '" + recibo.Serv1 + "', '" + recibo.Serv2 + "', '" + recibo.Serv3 + "' , '" + recibo.Cantidad + "', '" + recibo.NoExpediente + "')";
                string insertar = "insert into recibos (fecha,ser1,ser2,ser3,cser1,cser2,cser3,costoTotal,fkPacientes) values ('" + recibo.Fecha + "', '" + recibo.Serv1 + "', '" + recibo.Serv2 + "', '" + recibo.Serv3 + "' ,'" + recibo.Cserv1 + "','" + recibo.Cserv2 + "','" + recibo.Cserv3 + "', '" + recibo.Cantidad + "', '" + recibo.NoExpediente + "')";
                conbd.iniciarConexion();
                OleDbCommand cmd = new OleDbCommand(insertar, conbd.conexion);
                cmd.ExecuteNonQuery();
                
                // limpiar();


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

        private Recibos HacerRecibo()
        {
                   
              DateTime fecha = DateTime.Parse(txtFecha.Text);
              int noExpediente;
              string ser1 = cbSer1.Text;
              string ser2 = cbSer2.Text;
              string ser3 = cbSer3.Text;
              int cser1 =int.Parse(txtSer1.Text);
              int cser2 =int.Parse(txtSer2.Text);;
              int cser3 = int.Parse(txtSer3.Text); ;
               
              int total = int.Parse(txtTotal.Text);

              if (lblId.Text == "")
              {
                  noExpediente = 1;
              }
              else
              {
                  noExpediente = int.Parse(lblId.Text);
              }           

            Recibos r = new Recibos(fecha, ser1, ser2, ser3, cser1, cser2, cser3, total, noExpediente);
            return r;

            
        }

        //private Recibos HacerReciboGenerico()
        //{

        //    DateTime fecha = DateTime.Parse(txtFecha.Text);
        //    string ser1 = cbSer1.Text;
        //    string ser2 = cbSer2.Text;
        //    string ser3 = cbSer3.Text;
        //    int cser1 = int.Parse(txtSer1.Text);
        //    int cser2 = int.Parse(txtSer2.Text); ;
        //    int cser3 = int.Parse(txtSer3.Text); ;

        //    int total = int.Parse(txtTotal.Text);
        //    int noExpediente = int.Parse(lblId.Text);

        //    Recibos r = new Recibos(fecha, ser1, ser2, ser3, cser1, cser2, cser3, total, noExpediente);
        //    return r;


        //}

        

        private void generarImpresion()
        {
            ser1 = cbSer1.Text;
            ser2 = cbSer2.Text;
            ser3 = cbSer3.Text;
            idRecibo = obtenerIdRecibo();
            try
            {

                 fecha = txtFecha.Text.ToString();
                 noExpediente = txtNoExpediente.Text.ToString();
                 nombre =  txtNombre.Text.ToString();
                 Domicilio = txtDomicilio.Text.ToString();                
                 nivel = txtNivel.Text.ToString();
                 total = txtTotal.Text.ToString();
                 totalLetra = lblCanLetra.Text.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en los datos ingresados, por favor verifiquelos"+ex,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
            }

            ReciboImprimir impRecibo = new ReciboImprimir(idRecibo,fecha, noExpediente, nombre, Domicilio, ser1, ser2, ser3, total, nivel, totalLetra);

            VistaRecibo formVistaRecibo = new VistaRecibo();

            formVistaRecibo.listaRecibo.Add(impRecibo);
            formVistaRecibo.Show();
        }

        private void txtNoExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDigitaNumeros(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscarPaciente();
            }
                
        }

        

        private void limpiarFormCrearRecibo()
        {

            txtNoExpediente.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            cbSer1.Text = "";
            cbSer2.Text = "";
            cbSer3.Text = "";
            txtSer1.Text = "";
            txtSer2.Text = "";
            txtSer3.Text = "";
            txtTotal.Text = "";
            txtNivel.Text = "";
            lblCanLetra.Text = "";
            btnCalcular.Enabled = false;
            btnSumar.Enabled = false;
            txtNombre.Enabled = false;
            txtDomicilio.Enabled = false;
            cbSer1.Enabled = false;
            cbSer2.Enabled = false;
            cbSer3.Enabled = false;
            btnGuardareImprimir.Enabled = false;
            txtTotal.Enabled = false;
            txtSer1.Enabled = false;
            txtSer2.Enabled = false;
            txtSer3.Enabled = false;
            btnCalcular.Enabled = false;
            txtNoExpediente.Enabled = true;
            btnCalcular.BackColor = Color.Gray;
            btnGuardareImprimir.BackColor = Color.Gray;
           
        }


        private void mostrarRecibos(string consulta)
        {
            conbd.iniciarConexion();
            //string con = "Select * From costos";

            dataAdapter = new OleDbDataAdapter(consulta, conbd.conexion);

            OleDbCommandBuilder comando = new OleDbCommandBuilder(dataAdapter);

            tabla = new DataTable();

            dataAdapter.Fill(tabla);

            bindingsource1.DataSource = tabla;

            dataGridView2.DataSource = bindingsource1;


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarRecibos_Click(object sender, EventArgs e)
        {
            //string fecha = monthCalendar1.SelectionEnd.ToShortDateString();
            string fecha = monthCalendar1.SelectionEnd.ToString("MM/dd/yyyy");
            
            // muestra y rellena la tabla datagrid
            obtenerSumatoriaCostos(fecha);

            reiniciarCantidades();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
            //int renglon = Convert.ToInt32(dataGridView2.CurrentCell.RowIndex);
            //int ncuenta = Convert.ToInt32(dataGridView2[0, renglon].Value.ToString());

            //if (ncuenta != 1)
            //{
            //    if (MessageBox.Show("Esta seguro que desea eliminar el recibo del paciente con el ID?\n" + dataGridView2[0, renglon].Value.ToString(), "EliminarRegistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        consulta = "DELETE * FROM recibos WHERE Id=" + ncuenta + "";
            //        conbd.iniciarConexion();
            //        OleDbCommand cmd = new OleDbCommand(consulta, conbd.conexion);
            //        cmd.ExecuteNonQuery();
            //        dataGridView2.Rows.RemoveAt(renglon);
            //    }

            //}
            //conbd.cerrarConexion();

            int renglon = Convert.ToInt32(dataGridView2.CurrentCell.RowIndex);
            int ncuenta = Convert.ToInt32(dataGridView2[0, renglon].Value.ToString());

            if (ncuenta != 0)
            {
                if (MessageBox.Show("Esta usted seguro que desea cancelar el recibo del paciente con el ID?\n" + dataGridView2[0, renglon].Value.ToString(), "EliminarRegistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    consulta = "UPDATE recibos SET cancelado = 'SI' WHERE Id=" + ncuenta + "";                    
                    conbd.iniciarConexion();
                    OleDbCommand cmd = new OleDbCommand(consulta, conbd.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El recibo con el ID "+ncuenta+" ha sido cancelado");
                    //dataGridView2.Rows.RemoveAt(renglon);
                }

            }
            conbd.cerrarConexion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarFormCrearRecibo();
        }

        private string obtenerIdRecibo()
        {
            conbd.iniciarConexion();
            

            try
            {
                consulta = "SELECT TOP 1 * FROM recibos ORDER BY id DESC";
                OleDbCommand cmd = new OleDbCommand(consulta, conbd.conexion);
                object value = cmd.ExecuteScalar();
                return value.ToString();

            }
            catch
            {
                return "1";
            }

   
        }

        private void txtSer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDigitaNumeros(e);
            btnSumar.Enabled = true;
        }

        private void txtSer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDigitaNumeros(e);
            btnSumar.Enabled = true;
        }

        private void txtSer3_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDigitaNumeros(e);
            btnSumar.Enabled = true;
        }

        private void txtSer1_Validating(object sender, CancelEventArgs e)
        {
            if (txtSer1.Text == "")
            {
                MessageBox.Show("Introduce un numero en el Servicio1");
                txtSer1.Focus();
            }
            else
            {
                try
                {
                    Int32.Parse(txtSer1.Text);
                }
                catch
                {
                    MessageBox.Show("El campo servicio1 solo puede contener numeros");
                    txtNoExpediente.Focus();
                }
            }
        }

        private void txtSer2_Validating(object sender, CancelEventArgs e)
        {
            if (txtSer2.Text == "")
            {
                MessageBox.Show("Introduce Un numero en el Servicio2");
                txtSer2.Focus();
            }
            else
            {
                try
                {
                    Int32.Parse(txtSer2.Text);
                }
                catch
                {
                    MessageBox.Show("El campo servicio2 solo puede contener numeros");
                    txtNoExpediente.Focus();
                }
            }
        }

        private void txtSer3_Validating(object sender, CancelEventArgs e)
        {
            if (txtSer3.Text == "")
            {
                MessageBox.Show("Introduce Un numero en el Servicio3");
                txtSer3.Focus();
            }
            else
            {
                try
                {
                    Int32.Parse(txtSer3.Text);
                }
                catch
                {
                    MessageBox.Show("El campo servicio3 solo puede contener numeros");
                    txtNoExpediente.Focus();
                }
            }
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

        //public void obtenerSumatoriaCostos()
        //{


        //    dataGridView2.DataSource = bindingsource1;
        //    mostrarRecibos("Select * From recibos WHERE  (((recibos.fecha) =#" + fechaCorta + "#))");
        //    dataGridView2.Refresh();

        //    int numRenglones = dataGridView2.RowCount - 1;

        //    // MessageBox.Show(numRenglones.ToString());
        //    //int ncuenta = Convert.ToInt32(dataGridView2[1, 2].Value.ToString());

        //    for (int fila = 0; fila < numRenglones; fila++)
        //    {
        //        for (int columna = 2; columna <= 4; columna++)
        //        {
        //            string valorCelda = dataGridView2.Rows[fila].Cells[columna].Value.ToString();


        //            switch (columna)
        //            {
        //                case 2:
        //                    {
        //                        switch (valorCelda)
        //                        {
        //                            case "Psiquiatria":
        //                                sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Psicologia":
        //                                sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Valoracion Psiquiatria":
        //                                sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Valoracion Psicologia":
        //                                sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Revaloracion Psiquiatria":
        //                                sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Revaloracion Psicologia":
        //                                sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Urgencias":
        //                                sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Psicoeducacion":
        //                                sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Reposicion de carnet":
        //                                sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Valoracion Familiar":
        //                                sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Valoracion Conducta Alimentaria":
        //                                sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Valoracion Nutricion":
        //                                sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Valoracion Neuropsicologica":
        //                                sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Paquete de Neuropsicologia":
        //                                sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Crianza Positiva":
        //                                sumcrianzaPositiva  += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            case "Grupo V":
        //                                sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
        //                                break;
        //                            default:
        //                                break;

        //                        }

        //                        break;
        //                    }

        //                case 3:
        //                    {
        //                        switch (valorCelda)
        //                        {
        //                            case "Psiquiatria":
        //                                sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Psicologia":
        //                                sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Valoracion Psiquiatria":
        //                                sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Valoracion Psicologia":
        //                                sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Revaloracion Psiquiatria":
        //                                sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Revaloracion Psicologia":
        //                                sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Urgencias":
        //                                sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Psicoeducacion":
        //                                sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Reposicion de carnet":
        //                                sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Valoracion Familiar":
        //                                sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Valoracion Conducta Alimentaria":
        //                                sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Valoracion Nutricion":
        //                                sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Valoracion Neuropsicologica":
        //                                sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Paquete de Neuropsicologia":
        //                                sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Crianza Positiva":
        //                                sumcrianzaPositiva += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            case "Grupo V":
        //                                sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
        //                                break;
        //                            default:
        //                                break;

        //                        }

        //                        break;
        //                    }

        //                case 4:
        //                    {
        //                        switch (valorCelda)
        //                        {
        //                            case "Psiquiatria":
        //                                sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Psicologia":
        //                                sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Valoracion Psiquiatria":
        //                                sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Valoracion Psicologia":
        //                                sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Revaloracion Psiquiatria":
        //                                sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Revaloracion Psicologia":
        //                                sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Urgencias":
        //                                sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Psicoeducacion":
        //                                sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Reposicion de carnet":
        //                                sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Valoracion Familiar":
        //                                sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Valoracion Conducta Alimentaria":
        //                                sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Valoracion Nutricion":
        //                                sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Valoracion Neuropsicologica":
        //                                sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Paquete de Neuropsicologia":
        //                                sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Crianza Positiva":
        //                                sumcrianzaPositiva += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            case "Grupo V":
        //                                sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
        //                                break;
        //                            default:
        //                                break;

        //                        }

        //                        break;
        //                    }
        //            }

        //        }

        //    }
            
        //}

        public void obtenerSumatoriaCostos(string fechaDia)
        {

           
            dataGridView2.DataSource = bindingsource1;
            string diahoy = DateTime.Now.ToShortDateString();
            //mostrarRecibos("Select * From recibos WHERE  (((recibos.fecha) =#" + fechaDia + "#))  ");
            //mostrarRecibos("Select * From recibos WHERE  (((recibos.fecha) =#" + fechaDia + "#)) AND cancelado IS null ");
            mostrarRecibos("Select * From recibos WHERE (((recibos.fecha)=#" + fechaDia + "#));");
            dataGridView2.Refresh();

            int numRenglones = dataGridView2.RowCount - 1;

            // MessageBox.Show(numRenglones.ToString());
            //int ncuenta = Convert.ToInt32(dataGridView2[1, 2].Value.ToString());

            for (int fila = 0; fila < numRenglones; fila++)
            {
                for (int columna = 2; columna <= 4; columna++)
                {
                    string valorCelda = dataGridView2.Rows[fila].Cells[columna].Value.ToString();


                    switch (columna)
                    {
                        case 2:
                            {
                                switch (valorCelda)
                                {
                                    case "Psiquiatria":
                                        sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Psicologia":
                                        sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Psiquiatria":
                                        sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Psicologia":
                                        sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Revaloracion Psiquiatria":
                                        sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Revaloracion Psicologia":
                                        sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Urgencias":
                                        sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Psicoeducacion":
                                        sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Reposicion de carnet":
                                        sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Familiar":
                                        sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Conducta Alimentaria":
                                        sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Nutricion":
                                        sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Neuropsicologica":
                                        sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Paquete de Neuropsicologia":
                                        sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Crianza Positiva":
                                        sumcrianzaPositiva += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Grupo V":
                                        sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Consulta de Nutricion":
                                        sumconsultaNut += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Platica de Nutricion":
                                        sumplaticaNut += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Neuropsiquiatria":
                                        sumneuroPsiq += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Neuropsicologia":
                                        sumneuroPsic += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    default:
                                        break;

                                }

                                break;
                            }

                        case 3:
                            {
                                switch (valorCelda)
                                {
                                    case "Psiquiatria":
                                        sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Psicologia":
                                        sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Psiquiatria":
                                        sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Psicologia":
                                        sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Revaloracion Psiquiatria":
                                        sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Revaloracion Psicologia":
                                        sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Urgencias":
                                        sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Psicoeducacion":
                                        sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Reposicion de carnet":
                                        sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Familiar":
                                        sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Conducta Alimentaria":
                                        sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Nutricion":
                                        sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Neuropsicologica":
                                        sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Paquete de Neuropsicologia":
                                        sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Crianza Positiva":
                                        sumcrianzaPositiva += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Grupo V":
                                        sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Consulta de Nutricion":
                                        sumconsultaNut += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Platica de Nutricion":
                                        sumplaticaNut += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Neuropsiquiatria":
                                        sumneuroPsiq += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Neuropsicologia":
                                        sumneuroPsic += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    default:
                                        break;

                                }

                                break;
                            }

                        case 4:
                            {
                                switch (valorCelda)
                                {
                                    case "Psiquiatria":
                                        sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Psicologia":
                                        sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Psiquiatria":
                                        sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Psicologia":
                                        sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Revaloracion Psiquiatria":
                                        sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Revaloracion Psicologia":
                                        sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Urgencias":
                                        sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Psicoeducacion":
                                        sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Reposicion de carnet":
                                        sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Familiar":
                                        sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Conducta Alimentaria":
                                        sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Nutricion":
                                        sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Neuropsicologica":
                                        sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Paquete de Neuropsicologia":
                                        sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Crianza Positiva":
                                        sumcrianzaPositiva += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Grupo V":
                                        sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Consulta de Nutricion":
                                        sumconsultaNut += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Platica de Nutricion":
                                        sumplaticaNut += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Neuropsiquiatria":
                                        sumneuroPsiq += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Neuropsicologia":
                                        sumneuroPsic += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    default:
                                        break;

                                }

                                break;
                            }
                    }

                }

            }

        }

        private void btnGenerarCorteCaja_Click(object sender, EventArgs e)
        {
            //Obtener todos los datos
            
            obtenerSumatoriaCostos(monthCalendar1.SelectionEnd.ToString("MM/dd/yyyy"));
            fechaCorta = monthCalendar1.SelectionEnd.ToShortDateString();
            ////*******************************************

            string reciboInicial = txtReciboInicial.Text;
            string reciboFinal = txtReciboFinal.Text;
            string entrego = txtElaboro.Text;
            entrego = entrego.ToUpper();
            string observaciones = txtObservaciones.Text;
            observaciones = observaciones.ToUpper();
            string total = sumarTotalCorte();

            CorteCaja objCorteCaja = new CorteCaja(fechaCorta, reciboInicial, reciboFinal, sumPsiquiatria.ToString(),
                sumPsicologia.ToString(), sumvaloracionPsiq.ToString(), sumvaloracionPsic.ToString(), sumvaloracionFam.ToString(), sumvaloracionCal.ToString(),
                sumvaloracionNut.ToString(), sumconsultaNut.ToString(), sumplaticaNut.ToString(), sumvaloracionNeu.ToString(), sumpaqueteNeu.ToString(), sumurgencias.ToString(),
                sumrevaloracionPsiq.ToString(), sumrevaloracionPsic.ToString(), sumpsicoeducacion.ToString(), sumreposicionCar.ToString(), sumcrianzaPositiva.ToString(), sumgrupoV.ToString(), sumneuroPsiq.ToString(), sumneuroPsic.ToString(), total, entrego, observaciones);

            VistaCorteCaja formVistaCorteCaja = new VistaCorteCaja();

            formVistaCorteCaja.listaCorteCaja.Add(objCorteCaja);
            formVistaCorteCaja.Show();
            reiniciarCantidades();
        }

        private string sumarTotalCorte()
        {
            //Hacer las sumas totales
            

            int sumatotalCorte = int.Parse(sumPsicologia.ToString())+
            int.Parse(sumPsiquiatria.ToString())+
            int.Parse(sumvaloracionPsiq.ToString())+
            int.Parse(sumvaloracionPsic.ToString()) +
            int.Parse(sumrevaloracionPsiq.ToString())+
            int.Parse(sumrevaloracionPsic.ToString()) +
            int.Parse(sumurgencias.ToString())+
            int.Parse(sumpsicoeducacion.ToString())+
            int.Parse(sumreposicionCar.ToString())+
            int.Parse(sumcrianzaPositiva.ToString()) +
            int.Parse(sumgrupoV.ToString()) +
            int.Parse(sumvaloracionFam.ToString())+
            int.Parse(sumvaloracionCal.ToString())+
            int.Parse(sumvaloracionNut.ToString())+
            int.Parse(sumvaloracionNeu.ToString())+
            int.Parse(sumpaqueteNeu.ToString());

            return sumatotalCorte.ToString();
        }

        private void reiniciarCantidades()
        { 
            
            sumpsicoeducacion = 0;
            sumPsiquiatria = 0;
            sumPsicologia = 0;
            sumvaloracionPsiq = 0;
            sumvaloracionPsic = 0;
            sumvaloracionFam = 0;
            sumvaloracionCal = 0;
            sumvaloracionNut = 0;
            sumvaloracionNeu = 0;
            sumpaqueteNeu = 0;
            sumurgencias = 0;
            sumrevaloracionPsiq = 0;
            sumrevaloracionPsic = 0;
            sumpsicoeducacion = 0;
            sumreposicionCar = 0;           
            sumcrianzaPositiva = 0;
            sumgrupoV = 0;
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            lblFechaSeleccionada.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void cbSer1_SelectedValueChanged(object sender, EventArgs e)
        {
            cbSer2.Enabled = true;
            btnCalcular.Enabled = true;
            btnCalcular.BackColor = Color.LimeGreen;
        }

        private void cbSer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSer3.Enabled = true;
        }

        private void txtSer1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPacienteGenerico_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDomicilio.Enabled = true;
            txtNivel.Text = (0).ToString();
            txtNoExpediente.Text = (0).ToString();
            txtNoExpediente.Enabled = false;
            cbSer1.Enabled = true;

        }

        private void txtNoExpediente_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarCancelados_Click(object sender, EventArgs e)
        {
            string fecha = monthCalendar1.SelectionEnd.ToString("MM/dd/yyyy");
            
            // muestra y rellena la tabla datagrid
            mostrarCancelados(fecha);

            reiniciarCantidades();
        }


        public void mostrarCancelados(string fechaDia)
        {
            fechaDia = "30/05/2014";
            dataGridView2.DataSource = bindingsource1;
            //mostrarRecibos("Select * From recibos WHERE  (((recibos.fecha) =#" + fechaDia + "#))  ");
            mostrarRecibos("Select * From recibos WHERE  (((recibos.fecha) =#" + fechaDia + "#)) AND cancelado = 'SI' ");
            dataGridView2.Refresh();

            int numRenglones = dataGridView2.RowCount - 1;

            // MessageBox.Show(numRenglones.ToString());
            //int ncuenta = Convert.ToInt32(dataGridView2[1, 2].Value.ToString());

            for (int fila = 0; fila < numRenglones; fila++)
            {
                for (int columna = 2; columna <= 4; columna++)
                {
                    string valorCelda = dataGridView2.Rows[fila].Cells[columna].Value.ToString();


                    switch (columna)
                    {
                        case 2:
                            {
                                switch (valorCelda)
                                {
                                    case "Psiquiatria":
                                        sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Psicologia":
                                        sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Psiquiatria":
                                        sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Psicologia":
                                        sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Revaloracion Psiquiatria":
                                        sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Revaloracion Psicologia":
                                        sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Urgencias":
                                        sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Psicoeducacion":
                                        sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Reposicion de carnet":
                                        sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Familiar":
                                        sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Conducta Alimentaria":
                                        sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Nutricion":
                                        sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Valoracion Neuropsicologica":
                                        sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Paquete de Neuropsicologia":
                                        sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Crianza Positiva":
                                        sumcrianzaPositiva += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    case "Grupo V":
                                        sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[5].Value.ToString());
                                        break;
                                    default:
                                        break;

                                }

                                break;
                            }

                        case 3:
                            {
                                switch (valorCelda)
                                {
                                    case "Psiquiatria":
                                        sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Psicologia":
                                        sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Psiquiatria":
                                        sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Psicologia":
                                        sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Revaloracion Psiquiatria":
                                        sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Revaloracion Psicologia":
                                        sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Urgencias":
                                        sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Psicoeducacion":
                                        sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Reposicion de carnet":
                                        sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Familiar":
                                        sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Conducta Alimentaria":
                                        sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Nutricion":
                                        sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Valoracion Neuropsicologica":
                                        sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Paquete de Neuropsicologia":
                                        sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Crianza Positiva":
                                        sumcrianzaPositiva += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    case "Grupo V":
                                        sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[6].Value.ToString());
                                        break;
                                    default:
                                        break;

                                }

                                break;
                            }

                        case 4:
                            {
                                switch (valorCelda)
                                {
                                    case "Psiquiatria":
                                        sumPsiquiatria += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Psicologia":
                                        sumPsicologia += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Psiquiatria":
                                        sumvaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Psicologia":
                                        sumvaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Revaloracion Psiquiatria":
                                        sumrevaloracionPsiq += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Revaloracion Psicologia":
                                        sumrevaloracionPsic += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Urgencias":
                                        sumurgencias += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Psicoeducacion":
                                        sumpsicoeducacion += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Reposicion de carnet":
                                        sumreposicionCar += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Familiar":
                                        sumvaloracionFam += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Conducta Alimentaria":
                                        sumvaloracionCal += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Nutricion":
                                        sumvaloracionNut += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Valoracion Neuropsicologica":
                                        sumvaloracionNeu += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Paquete de Neuropsicologia":
                                        sumpaqueteNeu += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Crianza Positiva":
                                        sumcrianzaPositiva += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    case "Grupo V":
                                        sumgrupoV += int.Parse(dataGridView2.Rows[fila].Cells[7].Value.ToString());
                                        break;
                                    default:
                                        break;

                                }

                                break;
                            }
                    }

                }

            }
        }

    }
}
