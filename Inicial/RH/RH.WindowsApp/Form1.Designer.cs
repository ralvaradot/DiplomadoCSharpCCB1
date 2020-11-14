namespace RH.WindowsApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCentroCosto = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnEstadoCivil = new System.Windows.Forms.Button();
            this.btnGenero = new System.Windows.Forms.Button();
            this.btnCiudad = new System.Windows.Forms.Button();
            this.btnTipoDOcumento = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.panEmpleado = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbAdicionar = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panCiudad = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panEstadoCivil = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panGenero = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panTipoDocumento = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panCentroCosto = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panCargos = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbIdentificacion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panEmpleado.SuspendLayout();
            this.gbAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panCiudad.SuspendLayout();
            this.panEstadoCivil.SuspendLayout();
            this.panGenero.SuspendLayout();
            this.panTipoDocumento.SuspendLayout();
            this.panCentroCosto.SuspendLayout();
            this.panCargos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCentroCosto);
            this.groupBox1.Controls.Add(this.btnCargos);
            this.groupBox1.Controls.Add(this.btnEstadoCivil);
            this.groupBox1.Controls.Add(this.btnGenero);
            this.groupBox1.Controls.Add(this.btnCiudad);
            this.groupBox1.Controls.Add(this.btnTipoDOcumento);
            this.groupBox1.Controls.Add(this.btnEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Principal";
            // 
            // btnCentroCosto
            // 
            this.btnCentroCosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCentroCosto.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCentroCosto.Location = new System.Drawing.Point(6, 335);
            this.btnCentroCosto.Name = "btnCentroCosto";
            this.btnCentroCosto.Size = new System.Drawing.Size(178, 39);
            this.btnCentroCosto.TabIndex = 6;
            this.btnCentroCosto.Text = "Centro de Costo";
            this.btnCentroCosto.UseVisualStyleBackColor = false;
            this.btnCentroCosto.Click += new System.EventHandler(this.btnCentroCosto_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargos.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCargos.Location = new System.Drawing.Point(6, 284);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(178, 39);
            this.btnCargos.TabIndex = 5;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.UseVisualStyleBackColor = false;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnEstadoCivil
            // 
            this.btnEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadoCivil.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEstadoCivil.Location = new System.Drawing.Point(6, 233);
            this.btnEstadoCivil.Name = "btnEstadoCivil";
            this.btnEstadoCivil.Size = new System.Drawing.Size(178, 39);
            this.btnEstadoCivil.TabIndex = 4;
            this.btnEstadoCivil.Text = "Estado Civil";
            this.btnEstadoCivil.UseVisualStyleBackColor = false;
            this.btnEstadoCivil.Click += new System.EventHandler(this.btnEstadoCivil_Click);
            // 
            // btnGenero
            // 
            this.btnGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenero.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGenero.Location = new System.Drawing.Point(6, 182);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(178, 39);
            this.btnGenero.TabIndex = 3;
            this.btnGenero.Text = "Genero";
            this.btnGenero.UseVisualStyleBackColor = false;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btnCiudad
            // 
            this.btnCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCiudad.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCiudad.Location = new System.Drawing.Point(6, 131);
            this.btnCiudad.Name = "btnCiudad";
            this.btnCiudad.Size = new System.Drawing.Size(178, 39);
            this.btnCiudad.TabIndex = 2;
            this.btnCiudad.Text = "Ciudad";
            this.btnCiudad.UseVisualStyleBackColor = false;
            this.btnCiudad.Click += new System.EventHandler(this.btnCiudad_Click);
            // 
            // btnTipoDOcumento
            // 
            this.btnTipoDOcumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTipoDOcumento.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTipoDOcumento.Location = new System.Drawing.Point(6, 80);
            this.btnTipoDOcumento.Name = "btnTipoDOcumento";
            this.btnTipoDOcumento.Size = new System.Drawing.Size(178, 39);
            this.btnTipoDOcumento.TabIndex = 1;
            this.btnTipoDOcumento.Text = "Tipo Documento";
            this.btnTipoDOcumento.UseVisualStyleBackColor = false;
            this.btnTipoDOcumento.Click += new System.EventHandler(this.btnTipoDOcumento_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpleado.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEmpleado.Location = new System.Drawing.Point(6, 29);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(178, 39);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // panEmpleado
            // 
            this.panEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEmpleado.Controls.Add(this.btnAgregar);
            this.panEmpleado.Controls.Add(this.gbAdicionar);
            this.panEmpleado.Controls.Add(this.comboBox1);
            this.panEmpleado.Controls.Add(this.cboCiudad);
            this.panEmpleado.Controls.Add(this.label8);
            this.panEmpleado.Controls.Add(this.dgvEmpleados);
            this.panEmpleado.Controls.Add(this.label1);
            this.panEmpleado.Location = new System.Drawing.Point(209, 24);
            this.panEmpleado.Name = "panEmpleado";
            this.panEmpleado.Size = new System.Drawing.Size(579, 436);
            this.panEmpleado.TabIndex = 1;
            this.panEmpleado.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Blue;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(469, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 33);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbAdicionar
            // 
            this.gbAdicionar.Controls.Add(this.btnEliminar);
            this.gbAdicionar.Controls.Add(this.tbIdentificacion);
            this.gbAdicionar.Controls.Add(this.label15);
            this.gbAdicionar.Controls.Add(this.cboTipoDoc);
            this.gbAdicionar.Controls.Add(this.label14);
            this.gbAdicionar.Controls.Add(this.btnCancelar);
            this.gbAdicionar.Controls.Add(this.btnGuardar);
            this.gbAdicionar.Controls.Add(this.dateTimePicker2);
            this.gbAdicionar.Controls.Add(this.label13);
            this.gbAdicionar.Controls.Add(this.dateTimePicker1);
            this.gbAdicionar.Controls.Add(this.label12);
            this.gbAdicionar.Controls.Add(this.tbCelular);
            this.gbAdicionar.Controls.Add(this.label11);
            this.gbAdicionar.Controls.Add(this.tbApellidos);
            this.gbAdicionar.Controls.Add(this.label10);
            this.gbAdicionar.Controls.Add(this.tbNombre);
            this.gbAdicionar.Controls.Add(this.label9);
            this.gbAdicionar.Location = new System.Drawing.Point(15, 241);
            this.gbAdicionar.Name = "gbAdicionar";
            this.gbAdicionar.Size = new System.Drawing.Size(544, 190);
            this.gbAdicionar.TabIndex = 5;
            this.gbAdicionar.TabStop = false;
            this.gbAdicionar.Text = "Adicionar un Empleado";
            this.gbAdicionar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(290, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 27);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(403, 155);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 29);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(88, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Fecha Ingreso";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Fec. Nacimiento";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(63, 58);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(188, 20);
            this.tbCelular.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Celular";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(342, 19);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(196, 20);
            this.tbApellidos.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Apellidos";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(63, 20);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(188, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombres";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(74, 207);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(174, 21);
            this.cboCiudad.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ciudades";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres,
            this.Apellidos,
            this.Celular,
            this.Direccion,
            this.Ciudad,
            this.NumIdentificacion});
            this.dgvEmpleados.Location = new System.Drawing.Point(23, 23);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(546, 173);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panCiudad
            // 
            this.panCiudad.Controls.Add(this.label3);
            this.panCiudad.Location = new System.Drawing.Point(149, 466);
            this.panCiudad.Name = "panCiudad";
            this.panCiudad.Size = new System.Drawing.Size(579, 413);
            this.panCiudad.TabIndex = 2;
            this.panCiudad.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(579, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ciudades";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panEstadoCivil
            // 
            this.panEstadoCivil.Controls.Add(this.label5);
            this.panEstadoCivil.Location = new System.Drawing.Point(734, 466);
            this.panEstadoCivil.Name = "panEstadoCivil";
            this.panEstadoCivil.Size = new System.Drawing.Size(579, 413);
            this.panEstadoCivil.TabIndex = 3;
            this.panEstadoCivil.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(579, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estado Civil";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panGenero
            // 
            this.panGenero.Controls.Add(this.label4);
            this.panGenero.Location = new System.Drawing.Point(81, 486);
            this.panGenero.Name = "panGenero";
            this.panGenero.Size = new System.Drawing.Size(579, 413);
            this.panGenero.TabIndex = 3;
            this.panGenero.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(579, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Generos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panTipoDocumento
            // 
            this.panTipoDocumento.Controls.Add(this.label2);
            this.panTipoDocumento.Location = new System.Drawing.Point(935, 444);
            this.panTipoDocumento.Name = "panTipoDocumento";
            this.panTipoDocumento.Size = new System.Drawing.Size(579, 413);
            this.panTipoDocumento.TabIndex = 3;
            this.panTipoDocumento.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo Documentos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panCentroCosto
            // 
            this.panCentroCosto.Controls.Add(this.label7);
            this.panCentroCosto.Location = new System.Drawing.Point(842, 24);
            this.panCentroCosto.Name = "panCentroCosto";
            this.panCentroCosto.Size = new System.Drawing.Size(579, 413);
            this.panCentroCosto.TabIndex = 5;
            this.panCentroCosto.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(579, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Centros de Costo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panCargos
            // 
            this.panCargos.Controls.Add(this.label6);
            this.panCargos.Location = new System.Drawing.Point(909, 12);
            this.panCargos.Name = "panCargos";
            this.panCargos.Size = new System.Drawing.Size(579, 413);
            this.panCargos.TabIndex = 4;
            this.panCargos.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(579, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cargos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "FechaNacimiento";
            this.Direccion.HeaderText = "F. Nacimiento";
            this.Direccion.Name = "Direccion";
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Celular";
            this.Ciudad.HeaderText = "Celular";
            this.Ciudad.Name = "Ciudad";
            // 
            // NumIdentificacion
            // 
            this.NumIdentificacion.DataPropertyName = "NumDocIdentificacion";
            this.NumIdentificacion.HeaderText = "Numero Identificacion";
            this.NumIdentificacion.Name = "NumIdentificacion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Tipo Documento";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(97, 120);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(166, 21);
            this.cboTipoDoc.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Numero Id.";
            // 
            // tbIdentificacion
            // 
            this.tbIdentificacion.Location = new System.Drawing.Point(354, 119);
            this.tbIdentificacion.MaxLength = 10;
            this.tbIdentificacion.Name = "tbIdentificacion";
            this.tbIdentificacion.Size = new System.Drawing.Size(174, 20);
            this.tbIdentificacion.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(167, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 27);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 496);
            this.Controls.Add(this.panCentroCosto);
            this.Controls.Add(this.panGenero);
            this.Controls.Add(this.panEstadoCivil);
            this.Controls.Add(this.panTipoDocumento);
            this.Controls.Add(this.panCargos);
            this.Controls.Add(this.panCiudad);
            this.Controls.Add(this.panEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aplicacion de Recursos Humanos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panEmpleado.ResumeLayout(false);
            this.panEmpleado.PerformLayout();
            this.gbAdicionar.ResumeLayout(false);
            this.gbAdicionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panCiudad.ResumeLayout(false);
            this.panEstadoCivil.ResumeLayout(false);
            this.panGenero.ResumeLayout(false);
            this.panTipoDocumento.ResumeLayout(false);
            this.panCentroCosto.ResumeLayout(false);
            this.panCargos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCentroCosto;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnEstadoCivil;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.Button btnCiudad;
        private System.Windows.Forms.Button btnTipoDOcumento;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Panel panEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panCiudad;
        private System.Windows.Forms.Panel panEstadoCivil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panCentroCosto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panTipoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panCargos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumIdentificacion;
        private System.Windows.Forms.TextBox tbIdentificacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEliminar;
    }
}

