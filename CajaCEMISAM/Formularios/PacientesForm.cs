using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CajaCEMISAM.Formularios
{
    public partial class PacientesForm : Form
    {
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CrearPaciente formCrearPaciente = new CrearPaciente();
            formCrearPaciente.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ModificarPaciente formModificarPaciente = new ModificarPaciente();
            formModificarPaciente.Show();
        }
    }
}
