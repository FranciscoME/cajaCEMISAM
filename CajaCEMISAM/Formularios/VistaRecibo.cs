using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CajaCEMISAM.clases;
using Microsoft.Reporting.WinForms;

namespace CajaCEMISAM.Formularios
{
    public partial class VistaRecibo : Form
    {
        public List<ReciboImprimir> listaRecibo = new List<ReciboImprimir>();

        public VistaRecibo()
        {
            InitializeComponent();
        }

        private void VistaRecibo_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Recibo",listaRecibo));
            reportViewer1.RefreshReport();
        }
    }
}
