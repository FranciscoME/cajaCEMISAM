namespace CajaCEMISAM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbRecibos = new System.Windows.Forms.PictureBox();
            this.pbPacientes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCemisam1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCemisam1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FME V1.2";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(354, 171);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(332, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbRecibos
            // 
            this.pbRecibos.Image = global::CajaCEMISAM.Properties.Resources.Recibo4;
            this.pbRecibos.Location = new System.Drawing.Point(466, 225);
            this.pbRecibos.Name = "pbRecibos";
            this.pbRecibos.Size = new System.Drawing.Size(190, 184);
            this.pbRecibos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecibos.TabIndex = 15;
            this.pbRecibos.TabStop = false;
            this.pbRecibos.Click += new System.EventHandler(this.pbRecibos_Click);
            // 
            // pbPacientes
            // 
            this.pbPacientes.Image = global::CajaCEMISAM.Properties.Resources.usuarios2;
            this.pbPacientes.Location = new System.Drawing.Point(80, 225);
            this.pbPacientes.Name = "pbPacientes";
            this.pbPacientes.Size = new System.Drawing.Size(200, 184);
            this.pbPacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPacientes.TabIndex = 14;
            this.pbPacientes.TabStop = false;
            this.pbPacientes.Click += new System.EventHandler(this.pbPacientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "SISTEMA DE CAJA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "CENTRO MICHOACANO DE SALUD MENTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CajaCEMISAM.Properties.Resources.cemisam_128x128;
            this.pictureBox1.Location = new System.Drawing.Point(656, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 126);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pbCemisam1
            // 
            this.pbCemisam1.Image = global::CajaCEMISAM.Properties.Resources.cemisam_128x128;
            this.pbCemisam1.Location = new System.Drawing.Point(10, 26);
            this.pbCemisam1.Name = "pbCemisam1";
            this.pbCemisam1.Size = new System.Drawing.Size(89, 126);
            this.pbCemisam1.TabIndex = 10;
            this.pbCemisam1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pacientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Recibos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 495);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbRecibos);
            this.Controls.Add(this.pbPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbCemisam1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCemisam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbRecibos;
        private System.Windows.Forms.PictureBox pbPacientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbCemisam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

