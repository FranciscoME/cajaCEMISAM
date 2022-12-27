using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CajaCEMISAM.Formularios
{
    public partial class VistaCorteCaja : Form
    {
        public List<CorteCaja> listaCorteCaja = new List<CorteCaja>();
        public VistaCorteCaja()
        {
            InitializeComponent();
        }

        private void VistaCorteCaja_Load(object sender, EventArgs e)
        {

            this.rvCorteCaja.RefreshReport();

            rvCorteCaja.LocalReport.DataSources.Clear();
            rvCorteCaja.LocalReport.DataSources.Add(new ReportDataSource("DataSetCorteCaja",listaCorteCaja));
            this.rvCorteCaja.RefreshReport();
        }
    }
}
