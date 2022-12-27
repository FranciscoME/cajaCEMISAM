namespace CajaCEMISAM.Formularios
{
    partial class VistaCorteCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaCorteCaja));
            this.CorteCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvCorteCaja = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CorteCajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CorteCajaBindingSource
            // 
            this.CorteCajaBindingSource.DataSource = typeof(CajaCEMISAM.CorteCaja);
            // 
            // rvCorteCaja
            // 
            this.rvCorteCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCorteCaja";
            reportDataSource1.Value = this.CorteCajaBindingSource;
            this.rvCorteCaja.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCorteCaja.LocalReport.ReportEmbeddedResource = "CajaCEMISAM.Reportes.ReporteCorteCaja.rdlc";
            this.rvCorteCaja.Location = new System.Drawing.Point(0, 0);
            this.rvCorteCaja.Name = "rvCorteCaja";
            this.rvCorteCaja.Size = new System.Drawing.Size(801, 601);
            this.rvCorteCaja.TabIndex = 0;
            // 
            // VistaCorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 601);
            this.Controls.Add(this.rvCorteCaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaCorteCaja";
            this.Text = "Reporte de corte de caja";
            this.Load += new System.EventHandler(this.VistaCorteCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CorteCajaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCorteCaja;
        private System.Windows.Forms.BindingSource CorteCajaBindingSource;
    }
}