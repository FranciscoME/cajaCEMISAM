namespace CajaCEMISAM.Formularios
{
    partial class CrearRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearRecibo));
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.bdcajaDataSet = new CajaCEMISAM.bdcajaDataSet();
            this.costosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costosTableAdapter = new CajaCEMISAM.bdcajaDataSetTableAdapters.costosTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPacienteGenerico = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnGuardareImprimir = new System.Windows.Forms.Button();
            this.lblCanLetra = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSer3 = new System.Windows.Forms.TextBox();
            this.txtSer2 = new System.Windows.Forms.TextBox();
            this.txtSer1 = new System.Windows.Forms.TextBox();
            this.cbSer3 = new System.Windows.Forms.ComboBox();
            this.cbSer2 = new System.Windows.Forms.ComboBox();
            this.cbSer1 = new System.Windows.Forms.ComboBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNoExpediente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMostrarCancelados = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMostrarRecibos = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblFechaSeleccionada = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtElaboro = new System.Windows.Forms.TextBox();
            this.txtReciboFinal = new System.Windows.Forms.TextBox();
            this.txtReciboInicial = new System.Windows.Forms.TextBox();
            this.btnGenerarCorteCaja = new System.Windows.Forms.Button();
            this.costosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.costosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reciboImprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdcajaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboImprimirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(423, 17);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(75, 21);
            this.txtFecha.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscar.Location = new System.Drawing.Point(210, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 56);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Usuario";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
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
            // costosTableAdapter
            // 
            this.costosTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(33, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 522);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnPacienteGenerico);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.lblId);
            this.tabPage1.Controls.Add(this.btnGuardareImprimir);
            this.tabPage1.Controls.Add(this.lblCanLetra);
            this.tabPage1.Controls.Add(this.txtTotal);
            this.tabPage1.Controls.Add(this.btnSumar);
            this.tabPage1.Controls.Add(this.txtNivel);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.txtSer3);
            this.tabPage1.Controls.Add(this.txtSer2);
            this.tabPage1.Controls.Add(this.txtSer1);
            this.tabPage1.Controls.Add(this.cbSer3);
            this.tabPage1.Controls.Add(this.cbSer2);
            this.tabPage1.Controls.Add(this.cbSer1);
            this.tabPage1.Controls.Add(this.txtDomicilio);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtNoExpediente);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFecha);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Recibos";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnPacienteGenerico
            // 
            this.btnPacienteGenerico.Location = new System.Drawing.Point(20, 28);
            this.btnPacienteGenerico.Name = "btnPacienteGenerico";
            this.btnPacienteGenerico.Size = new System.Drawing.Size(75, 42);
            this.btnPacienteGenerico.TabIndex = 30;
            this.btnPacienteGenerico.Text = "Paceinte Generico";
            this.btnPacienteGenerico.UseVisualStyleBackColor = true;
            this.btnPacienteGenerico.Click += new System.EventHandler(this.btnPacienteGenerico_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.Location = new System.Drawing.Point(119, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Location = new System.Drawing.Point(17, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 29;
            // 
            // btnGuardareImprimir
            // 
            this.btnGuardareImprimir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGuardareImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardareImprimir.Location = new System.Drawing.Point(326, 430);
            this.btnGuardareImprimir.Name = "btnGuardareImprimir";
            this.btnGuardareImprimir.Size = new System.Drawing.Size(171, 61);
            this.btnGuardareImprimir.TabIndex = 8;
            this.btnGuardareImprimir.Text = "Guardar e imprimir";
            this.btnGuardareImprimir.UseVisualStyleBackColor = false;
            this.btnGuardareImprimir.Click += new System.EventHandler(this.txtImprimir_Click);
            // 
            // lblCanLetra
            // 
            this.lblCanLetra.AutoSize = true;
            this.lblCanLetra.Location = new System.Drawing.Point(126, 401);
            this.lblCanLetra.Name = "lblCanLetra";
            this.lblCanLetra.Size = new System.Drawing.Size(0, 13);
            this.lblCanLetra.TabIndex = 27;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(326, 361);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(56, 22);
            this.txtTotal.TabIndex = 26;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(412, 314);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(85, 30);
            this.btnSumar.TabIndex = 11;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(83, 376);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(30, 20);
            this.txtNivel.TabIndex = 24;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCalcular.Location = new System.Drawing.Point(412, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 51);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular Pago";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.txtCalcular_Click);
            // 
            // txtSer3
            // 
            this.txtSer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSer3.Location = new System.Drawing.Point(20, 314);
            this.txtSer3.Name = "txtSer3";
            this.txtSer3.Size = new System.Drawing.Size(46, 22);
            this.txtSer3.TabIndex = 10;
            this.txtSer3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSer3_KeyPress);
            this.txtSer3.Validating += new System.ComponentModel.CancelEventHandler(this.txtSer3_Validating);
            // 
            // txtSer2
            // 
            this.txtSer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSer2.Location = new System.Drawing.Point(20, 280);
            this.txtSer2.Name = "txtSer2";
            this.txtSer2.Size = new System.Drawing.Size(46, 22);
            this.txtSer2.TabIndex = 9;
            this.txtSer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSer2_KeyPress);
            this.txtSer2.Validating += new System.ComponentModel.CancelEventHandler(this.txtSer2_Validating);
            // 
            // txtSer1
            // 
            this.txtSer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSer1.Location = new System.Drawing.Point(20, 245);
            this.txtSer1.Name = "txtSer1";
            this.txtSer1.Size = new System.Drawing.Size(46, 22);
            this.txtSer1.TabIndex = 8;
            this.txtSer1.TextChanged += new System.EventHandler(this.txtSer1_TextChanged);
            this.txtSer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSer1_KeyPress);
            this.txtSer1.Validating += new System.ComponentModel.CancelEventHandler(this.txtSer1_Validating);
            // 
            // cbSer3
            // 
            this.cbSer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSer3.FormattingEnabled = true;
            this.cbSer3.Items.AddRange(new object[] {
            "",
            "Psiquiatria",
            "Psicologia",
            "Valoracion Psiquiatria",
            "Valoracion Psicologia",
            "Revaloracion Psiquiatria",
            "Revaloracion Psicologia",
            "Urgencias",
            "Psicoeducacion",
            "Crianza Positiva",
            "Grupo V",
            "Reposicion de carnet",
            "Valoracion Familiar",
            "Valoracion Conducta Alimentaria",
            "Valoracion Nutricion",
            "Consulta de Nutricion",
            "Platica de Nutricion",
            "Neuropsiquiatria",
            "Neuropsicologia",
            "Valoracion Neuropsicologica",
            "Paquete de Neuropsicologia"});
            this.cbSer3.Location = new System.Drawing.Point(169, 318);
            this.cbSer3.Name = "cbSer3";
            this.cbSer3.Size = new System.Drawing.Size(222, 26);
            this.cbSer3.TabIndex = 6;
            // 
            // cbSer2
            // 
            this.cbSer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSer2.FormattingEnabled = true;
            this.cbSer2.Items.AddRange(new object[] {
            "",
            "Psiquiatria",
            "Psicologia",
            "Valoracion Psiquiatria",
            "Valoracion Psicologia",
            "Revaloracion Psiquiatria",
            "Revaloracion Psicologia",
            "Urgencias",
            "Psicoeducacion",
            "Crianza Positiva",
            "Grupo V",
            "Reposicion de carnet",
            "Valoracion Familiar",
            "Valoracion Conducta Alimentaria",
            "Valoracion Nutricion",
            "Consulta de Nutricion",
            "Platica de Nutricion",
            "Neuropsiquiatria",
            "Neuropsicologia",
            "Valoracion Neuropsicologica",
            "Paquete de Neuropsicologia"});
            this.cbSer2.Location = new System.Drawing.Point(169, 284);
            this.cbSer2.Name = "cbSer2";
            this.cbSer2.Size = new System.Drawing.Size(222, 26);
            this.cbSer2.TabIndex = 5;
            this.cbSer2.SelectedIndexChanged += new System.EventHandler(this.cbSer2_SelectedIndexChanged);
            // 
            // cbSer1
            // 
            this.cbSer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSer1.FormattingEnabled = true;
            this.cbSer1.Items.AddRange(new object[] {
            "",
            "Psiquiatria",
            "Psicologia",
            "Valoracion Psiquiatria",
            "Valoracion Psicologia",
            "Revaloracion Psiquiatria",
            "Revaloracion Psicologia",
            "Urgencias",
            "Psicoeducacion",
            "Crianza Positiva",
            "Grupo V",
            "Reposicion de carnet",
            "Valoracion Familiar",
            "Valoracion Conducta Alimentaria",
            "Valoracion Nutricion",
            "Consulta de Nutricion",
            "Platica de Nutricion",
            "Neuropsiquiatria",
            "Neuropsicologia",
            "Valoracion Neuropsicologica",
            "Paquete de Neuropsicologia"});
            this.cbSer1.Location = new System.Drawing.Point(169, 249);
            this.cbSer1.Name = "cbSer1";
            this.cbSer1.Size = new System.Drawing.Size(222, 26);
            this.cbSer1.TabIndex = 4;
            this.cbSer1.SelectedValueChanged += new System.EventHandler(this.cbSer1_SelectedValueChanged);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(87, 170);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(322, 28);
            this.txtDomicilio.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(84, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoExpediente.Location = new System.Drawing.Point(398, 64);
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(100, 22);
            this.txtNoExpediente.TabIndex = 1;
            this.txtNoExpediente.Enter += new System.EventHandler(this.txtNoExpediente_Enter);
            this.txtNoExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoExpediente_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cantidad con letra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nivel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Servicio 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Servicio 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Servicio 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Expediente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnMostrarCancelados);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Controls.Add(this.btnMostrarRecibos);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recibos del dia ";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnMostrarCancelados
            // 
            this.btnMostrarCancelados.Location = new System.Drawing.Point(353, 87);
            this.btnMostrarCancelados.Name = "btnMostrarCancelados";
            this.btnMostrarCancelados.Size = new System.Drawing.Size(97, 34);
            this.btnMostrarCancelados.TabIndex = 12;
            this.btnMostrarCancelados.Text = "Mostrar recibos cancelados";
            this.btnMostrarCancelados.UseVisualStyleBackColor = true;
            this.btnMostrarCancelados.Click += new System.EventHandler(this.btnMostrarCancelados_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ContextMenuStrip = this.contextMenuStrip1;
            this.monthCalendar1.Location = new System.Drawing.Point(40, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eliminarToolStripMenuItem.Text = "Cancelar recibo";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // btnMostrarRecibos
            // 
            this.btnMostrarRecibos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarRecibos.Location = new System.Drawing.Point(318, 20);
            this.btnMostrarRecibos.Name = "btnMostrarRecibos";
            this.btnMostrarRecibos.Size = new System.Drawing.Size(178, 48);
            this.btnMostrarRecibos.TabIndex = 6;
            this.btnMostrarRecibos.Text = "Mostrar recibos / Actualizar";
            this.btnMostrarRecibos.UseVisualStyleBackColor = true;
            this.btnMostrarRecibos.Click += new System.EventHandler(this.btnMostrarRecibos_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(521, 319);
            this.dataGridView2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.YellowGreen;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.lblFechaSeleccionada);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtObservaciones);
            this.tabPage3.Controls.Add(this.txtElaboro);
            this.tabPage3.Controls.Add(this.txtReciboFinal);
            this.tabPage3.Controls.Add(this.txtReciboInicial);
            this.tabPage3.Controls.Add(this.btnGenerarCorteCaja);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(537, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporte de corte de caja";
            // 
            // lblFechaSeleccionada
            // 
            this.lblFechaSeleccionada.AutoSize = true;
            this.lblFechaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSeleccionada.Location = new System.Drawing.Point(219, 367);
            this.lblFechaSeleccionada.Name = "lblFechaSeleccionada";
            this.lblFechaSeleccionada.Size = new System.Drawing.Size(0, 15);
            this.lblFechaSeleccionada.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Usted generara el reporte del dia:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(160, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "Generar corte de caja";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(94, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 18);
            this.label14.TabIndex = 8;
            this.label14.Text = "Observaciones";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(142, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "Entrega";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(131, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Folio final";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(136, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Folio inicial";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(221, 274);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(246, 67);
            this.txtObservaciones.TabIndex = 4;
            // 
            // txtElaboro
            // 
            this.txtElaboro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElaboro.Location = new System.Drawing.Point(222, 193);
            this.txtElaboro.Name = "txtElaboro";
            this.txtElaboro.Size = new System.Drawing.Size(246, 22);
            this.txtElaboro.TabIndex = 3;
            // 
            // txtReciboFinal
            // 
            this.txtReciboFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReciboFinal.Location = new System.Drawing.Point(222, 121);
            this.txtReciboFinal.Name = "txtReciboFinal";
            this.txtReciboFinal.Size = new System.Drawing.Size(100, 22);
            this.txtReciboFinal.TabIndex = 2;
            // 
            // txtReciboInicial
            // 
            this.txtReciboInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReciboInicial.Location = new System.Drawing.Point(222, 61);
            this.txtReciboInicial.Name = "txtReciboInicial";
            this.txtReciboInicial.Size = new System.Drawing.Size(100, 22);
            this.txtReciboInicial.TabIndex = 1;
            // 
            // btnGenerarCorteCaja
            // 
            this.btnGenerarCorteCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGenerarCorteCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCorteCaja.Location = new System.Drawing.Point(175, 402);
            this.btnGenerarCorteCaja.Name = "btnGenerarCorteCaja";
            this.btnGenerarCorteCaja.Size = new System.Drawing.Size(189, 91);
            this.btnGenerarCorteCaja.TabIndex = 0;
            this.btnGenerarCorteCaja.Text = "Generar corte de caja";
            this.btnGenerarCorteCaja.UseVisualStyleBackColor = false;
            this.btnGenerarCorteCaja.Click += new System.EventHandler(this.btnGenerarCorteCaja_Click);
            // 
            // costosBindingSource1
            // 
            this.costosBindingSource1.DataMember = "costos";
            this.costosBindingSource1.DataSource = this.bdcajaDataSet;
            // 
            // costosBindingSource2
            // 
            this.costosBindingSource2.DataMember = "costos";
            this.costosBindingSource2.DataSource = this.bdcajaDataSet;
            // 
            // reciboImprimirBindingSource
            // 
            this.reciboImprimirBindingSource.DataSource = typeof(CajaCEMISAM.clases.ReciboImprimir);
            // 
            // CrearRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 531);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibos";
            this.Load += new System.EventHandler(this.CrearRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdcajaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reciboImprimirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnBuscar;
        private bdcajaDataSet bdcajaDataSet;
        private System.Windows.Forms.BindingSource costosBindingSource;
        private bdcajaDataSetTableAdapters.costosTableAdapter costosTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNoExpediente;
        private System.Windows.Forms.BindingSource costosBindingSource1;
        private System.Windows.Forms.ComboBox cbSer3;
        private System.Windows.Forms.ComboBox cbSer2;
        private System.Windows.Forms.ComboBox cbSer1;
        private System.Windows.Forms.BindingSource costosBindingSource2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtSer3;
        public System.Windows.Forms.TextBox txtSer2;
        public System.Windows.Forms.TextBox txtSer1;
        private System.Windows.Forms.Label lblCanLetra;
        private System.Windows.Forms.Button btnGuardareImprimir;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource reciboImprimirBindingSource;
        private System.Windows.Forms.Button btnMostrarRecibos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtElaboro;
        private System.Windows.Forms.TextBox txtReciboFinal;
        private System.Windows.Forms.TextBox txtReciboInicial;
        private System.Windows.Forms.Button btnGenerarCorteCaja;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFechaSeleccionada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnPacienteGenerico;
        private System.Windows.Forms.Button btnMostrarCancelados;
    }
}