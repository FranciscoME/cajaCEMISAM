namespace CajaCEMISAM.Formularios
{
    partial class CrearPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPaciente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoExpediente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.costosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdcajaDataSet = new CajaCEMISAM.bdcajaDataSet();
            this.costosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recibosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recibosTableAdapter = new CajaCEMISAM.bdcajaDataSetTableAdapters.recibosTableAdapter();
            this.costosTableAdapter = new CajaCEMISAM.bdcajaDataSetTableAdapters.costosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcajaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recibosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "No de expediente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domicilio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel socioeconomico";
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.BackColor = System.Drawing.Color.Yellow;
            this.txtNoExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoExpediente.Location = new System.Drawing.Point(317, 28);
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(101, 26);
            this.txtNoExpediente.TabIndex = 1;
            this.txtNoExpediente.TextChanged += new System.EventHandler(this.txtNoExpediente_TextChanged);
            this.txtNoExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoExpediente_KeyPress);
            this.txtNoExpediente.Validating += new System.ComponentModel.CancelEventHandler(this.txtNoExpediente_Validating);
            this.txtNoExpediente.Validated += new System.EventHandler(this.txtNoExpediente_Validated);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(181, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(181, 146);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(237, 42);
            this.txtDomicilio.TabIndex = 3;
            // 
            // cbNivel
            // 
            this.cbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbNivel.Location = new System.Drawing.Point(181, 224);
            this.cbNivel.MaxLength = 1;
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(45, 24);
            this.cbNivel.TabIndex = 4;
            // 
            // costosBindingSource1
            // 
            this.costosBindingSource1.DataMember = "costos";
            this.costosBindingSource1.DataSource = this.bdcajaDataSet;
            // 
            // bdcajaDataSet
            // 
            this.bdcajaDataSet.DataSetName = "bdcajaDataSet";
            this.bdcajaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costosBindingSource
            // 
            this.costosBindingSource.DataMember = "costos";
            this.costosBindingSource.DataSource = this.bdcajaDataSet;
            // 
            // recibosBindingSource
            // 
            this.recibosBindingSource.DataMember = "recibos";
            this.recibosBindingSource.DataSource = this.bdcajaDataSet;
            // 
            // recibosTableAdapter
            // 
            this.recibosTableAdapter.ClearBeforeFill = true;
            // 
            // costosTableAdapter
            // 
            this.costosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(239, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtNoExpediente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbNivel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(30, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 402);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "AGREGAR UN NUEVO PACIENTE";
            // 
            // CrearPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearPaciente";
            this.Text = "Crear nuevo paciente";
            this.Load += new System.EventHandler(this.CrearPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdcajaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recibosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private bdcajaDataSet bdcajaDataSet;
        private System.Windows.Forms.BindingSource recibosBindingSource;
        private bdcajaDataSetTableAdapters.recibosTableAdapter recibosTableAdapter;
        private System.Windows.Forms.BindingSource costosBindingSource;
        private bdcajaDataSetTableAdapters.costosTableAdapter costosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtNoExpediente;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDomicilio;
        public System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource costosBindingSource1;
        private System.Windows.Forms.Label label5;
    }
}