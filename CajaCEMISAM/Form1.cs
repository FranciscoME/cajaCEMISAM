using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CajaCEMISAM.Formularios;

namespace CajaCEMISAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           //MessageBox.Show(paciente.ToString());

            //CrearPaciente formCrearPaciente = new CrearPaciente();
            //formCrearPaciente.Show();

          

            //ModificarPaciente formModificarPaciente = new ModificarPaciente();
            //formModificarPaciente.Show();

            //CostosCaja frmCostosCaja = new CostosCaja();
            //frmCostosCaja.Show();

            //PacientesForm formPacientes = new PacientesForm();
            //formPacientes.Show();

            //DatosCorteCaja formDatosCorteCaja = new DatosCorteCaja();
            //formDatosCorteCaja.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
           
                
            
        }

        private void pbPacientes_Click(object sender, EventArgs e)
        {
            PacientesForm formPacientesForm = new PacientesForm();
            formPacientesForm.Show();
        }

        private void pbRecibos_Click(object sender, EventArgs e)
        {
            CrearRecibo formCrearRecibo = new CrearRecibo();
            formCrearRecibo.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software elaborado por el L.I. Francisco Márquez Estrada\npara el Centro Michoacano de Salud Mental","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            Application.Exit();
        }
    }
}
