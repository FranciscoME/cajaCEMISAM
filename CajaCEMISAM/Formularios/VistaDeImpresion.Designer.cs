namespace CajaCEMISAM.Formularios
{
    partial class VistaDeImpresion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReciboImprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reciboImprimirBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReciboImprimirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboImprimirBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reciboImprimirBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CajaCEMISAM.Reportes.VistaRecibos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(858, 465);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReciboImprimirBindingSource
            // 
            this.ReciboImprimirBindingSource.DataSource = typeof(CajaCEMISAM.clases.ReciboImprimir);
            // 
            // reciboImprimirBindingSource1
            // 
            this.reciboImprimirBindingSource1.DataSource = typeof(CajaCEMISAM.clases.ReciboImprimir);
            // 
            // VistaDeImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 465);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VistaDeImpresion";
            this.Text = "VistaDeImpresion";
            this.Load += new System.EventHandler(this.VistaDeImpresion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReciboImprimirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboImprimirBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReciboImprimirBindingSource;
        private System.Windows.Forms.BindingSource reciboImprimirBindingSource1;
    }
}