namespace RentacarDefinitivo
{
    partial class menuVehiculos
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label colorLabel;
            this.panelTopFormVehiculos = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnSeleccionarRegistroParaEliminar = new System.Windows.Forms.Button();
            this.btnIrAlPrimerRegistro = new System.Windows.Forms.Button();
            this.btnIrAlUltimoRegistro = new System.Windows.Forms.Button();
            this.btnIrAlSiguienteRegistro = new System.Windows.Forms.Button();
            this.btnIrAlAnteriorRegistro = new System.Windows.Forms.Button();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.panelMidFormVehiculos = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.vehicle_modeloBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.rentacarDataSet = new RentacarDefinitivo.rentacarDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.listatipologiacochesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentacarDataSet1 = new RentacarDefinitivo.rentacarDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listamodelocochesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listamarcascochesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnValidarRegistro = new System.Windows.Forms.Button();
            this.btnCancelarValidarRegistro = new System.Windows.Forms.Button();
            this.panelBotFormVehiculos = new System.Windows.Forms.Panel();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehicleTableAdapter();
            this.tableAdapterManager = new RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager();
            this.vehicle_modeloTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehicle_modeloTableAdapter();
            this.modeloTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.modeloTableAdapter();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_marcas_cochesTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.lista_marcas_cochesTableAdapter();
            this.lista_modelo_cochesTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.lista_modelo_cochesTableAdapter();
            this.lista_tipologia_cochesTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.lista_tipologia_cochesTableAdapter();
            this.tipologiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelococheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicle_modeloDataGridView = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            this.panelTopFormVehiculos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelMidFormVehiculos.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_modeloBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listatipologiacochesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listamodelocochesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listamarcascochesBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBotFormVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_modeloDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(37, 177);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 16);
            label1.TabIndex = 12;
            label1.Text = "marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(-1, 220);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 16);
            label2.TabIndex = 13;
            label2.Text = "modelo coche:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(27, 137);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 16);
            label3.TabIndex = 14;
            label3.Text = "tipologia:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(74, 54);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(52, 13);
            matriculaLabel.TabIndex = 15;
            matriculaLabel.Text = "matricula:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(93, 100);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(33, 13);
            colorLabel.TabIndex = 16;
            colorLabel.Text = "color:";
            // 
            // panelTopFormVehiculos
            // 
            this.panelTopFormVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.panelTopFormVehiculos.Controls.Add(this.tableLayoutPanel2);
            this.panelTopFormVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopFormVehiculos.Location = new System.Drawing.Point(0, 0);
            this.panelTopFormVehiculos.Name = "panelTopFormVehiculos";
            this.panelTopFormVehiculos.Size = new System.Drawing.Size(934, 42);
            this.panelTopFormVehiculos.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.36871F));
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarRegistro, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSeleccionarRegistroParaEliminar, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIrAlPrimerRegistro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIrAlUltimoRegistro, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIrAlSiguienteRegistro, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIrAlAnteriorRegistro, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModificarRegistro, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(448, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(288, 3);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(51, 30);
            this.btnAgregarRegistro.TabIndex = 5;
            this.btnAgregarRegistro.Text = "+";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnSeleccionarRegistroParaEliminar
            // 
            this.btnSeleccionarRegistroParaEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeleccionarRegistroParaEliminar.Location = new System.Drawing.Point(231, 3);
            this.btnSeleccionarRegistroParaEliminar.Name = "btnSeleccionarRegistroParaEliminar";
            this.btnSeleccionarRegistroParaEliminar.Size = new System.Drawing.Size(51, 30);
            this.btnSeleccionarRegistroParaEliminar.TabIndex = 4;
            this.btnSeleccionarRegistroParaEliminar.Text = "-";
            this.btnSeleccionarRegistroParaEliminar.UseVisualStyleBackColor = true;
            this.btnSeleccionarRegistroParaEliminar.Click += new System.EventHandler(this.btnSeleccionarRegistroParaEliminar_Click);
            // 
            // btnIrAlPrimerRegistro
            // 
            this.btnIrAlPrimerRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlPrimerRegistro.Location = new System.Drawing.Point(3, 3);
            this.btnIrAlPrimerRegistro.Name = "btnIrAlPrimerRegistro";
            this.btnIrAlPrimerRegistro.Size = new System.Drawing.Size(51, 30);
            this.btnIrAlPrimerRegistro.TabIndex = 0;
            this.btnIrAlPrimerRegistro.Text = "<<";
            this.btnIrAlPrimerRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlPrimerRegistro.Click += new System.EventHandler(this.btnIrAlPrimerRegistro_Click);
            // 
            // btnIrAlUltimoRegistro
            // 
            this.btnIrAlUltimoRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlUltimoRegistro.Location = new System.Drawing.Point(174, 3);
            this.btnIrAlUltimoRegistro.Name = "btnIrAlUltimoRegistro";
            this.btnIrAlUltimoRegistro.Size = new System.Drawing.Size(51, 30);
            this.btnIrAlUltimoRegistro.TabIndex = 1;
            this.btnIrAlUltimoRegistro.Text = ">>";
            this.btnIrAlUltimoRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlUltimoRegistro.Click += new System.EventHandler(this.btnIrAlUltimoRegistro_Click);
            // 
            // btnIrAlSiguienteRegistro
            // 
            this.btnIrAlSiguienteRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlSiguienteRegistro.Location = new System.Drawing.Point(117, 3);
            this.btnIrAlSiguienteRegistro.Name = "btnIrAlSiguienteRegistro";
            this.btnIrAlSiguienteRegistro.Size = new System.Drawing.Size(51, 30);
            this.btnIrAlSiguienteRegistro.TabIndex = 3;
            this.btnIrAlSiguienteRegistro.Text = ">";
            this.btnIrAlSiguienteRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlSiguienteRegistro.Click += new System.EventHandler(this.btnIrAlSiguienteRegistro_Click);
            // 
            // btnIrAlAnteriorRegistro
            // 
            this.btnIrAlAnteriorRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlAnteriorRegistro.Location = new System.Drawing.Point(60, 3);
            this.btnIrAlAnteriorRegistro.Name = "btnIrAlAnteriorRegistro";
            this.btnIrAlAnteriorRegistro.Size = new System.Drawing.Size(51, 30);
            this.btnIrAlAnteriorRegistro.TabIndex = 2;
            this.btnIrAlAnteriorRegistro.Text = "<";
            this.btnIrAlAnteriorRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlAnteriorRegistro.Click += new System.EventHandler(this.btnIrAlAnteriorRegistro_Click);
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarRegistro.Location = new System.Drawing.Point(345, 3);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(100, 30);
            this.btnModificarRegistro.TabIndex = 6;
            this.btnModificarRegistro.Text = "Modificar";
            this.btnModificarRegistro.UseVisualStyleBackColor = true;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // panelMidFormVehiculos
            // 
            this.panelMidFormVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelMidFormVehiculos.Controls.Add(this.tableLayoutPanel3);
            this.panelMidFormVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMidFormVehiculos.Location = new System.Drawing.Point(0, 42);
            this.panelMidFormVehiculos.Name = "panelMidFormVehiculos";
            this.panelMidFormVehiculos.Size = new System.Drawing.Size(934, 438);
            this.panelMidFormVehiculos.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.vehicle_modeloDataGridView, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 484F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(934, 438);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // vehicle_modeloBindingSource6
            // 
            this.vehicle_modeloBindingSource6.DataMember = "vehicle_modelo";
            this.vehicle_modeloBindingSource6.DataSource = this.rentacarDataSet;
            // 
            // rentacarDataSet
            // 
            this.rentacarDataSet.DataSetName = "rentacarDataSet";
            this.rentacarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50);
            this.panel1.Size = new System.Drawing.Size(461, 432);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(colorLabel);
            this.panel2.Controls.Add(this.colorTextBox);
            this.panel2.Controls.Add(matriculaLabel);
            this.panel2.Controls.Add(this.matriculaTextBox);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(50, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(361, 332);
            this.panel2.TabIndex = 0;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicle_modeloBindingSource6, "color", true));
            this.colorTextBox.Location = new System.Drawing.Point(132, 97);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 17;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicle_modeloBindingSource6, "matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(132, 51);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vehicle_modeloBindingSource6, "tipologia", true));
            this.comboBox3.DataSource = this.listatipologiacochesBindingSource;
            this.comboBox3.DisplayMember = "tipologia";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(101, 137);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(131, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // listatipologiacochesBindingSource
            // 
            this.listatipologiacochesBindingSource.DataMember = "lista_tipologia_coches";
            this.listatipologiacochesBindingSource.DataSource = this.rentacarDataSet1;
            // 
            // rentacarDataSet1
            // 
            this.rentacarDataSet1.DataSetName = "rentacarDataSet";
            this.rentacarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vehicle_modeloBindingSource6, "modelo_coche", true));
            this.comboBox2.DataSource = this.listamodelocochesBindingSource;
            this.comboBox2.DisplayMember = "modelo_coche";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(101, 219);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // listamodelocochesBindingSource
            // 
            this.listamodelocochesBindingSource.DataMember = "lista_modelo_coches";
            this.listamodelocochesBindingSource.DataSource = this.rentacarDataSet1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vehicle_modeloBindingSource6, "marca", true));
            this.comboBox1.DataSource = this.listamarcascochesBindingSource;
            this.comboBox1.DisplayMember = "marca";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listamarcascochesBindingSource
            // 
            this.listamarcascochesBindingSource.DataMember = "lista_marcas_coches";
            this.listamarcascochesBindingSource.DataSource = this.rentacarDataSet1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnValidarRegistro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarValidarRegistro, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(573, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnValidarRegistro
            // 
            this.btnValidarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValidarRegistro.Location = new System.Drawing.Point(182, 3);
            this.btnValidarRegistro.Name = "btnValidarRegistro";
            this.btnValidarRegistro.Size = new System.Drawing.Size(173, 34);
            this.btnValidarRegistro.TabIndex = 1;
            this.btnValidarRegistro.Text = "Validar";
            this.btnValidarRegistro.UseVisualStyleBackColor = true;
            this.btnValidarRegistro.Click += new System.EventHandler(this.btnValidarRegistro_Click);
            // 
            // btnCancelarValidarRegistro
            // 
            this.btnCancelarValidarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarValidarRegistro.Location = new System.Drawing.Point(3, 3);
            this.btnCancelarValidarRegistro.Name = "btnCancelarValidarRegistro";
            this.btnCancelarValidarRegistro.Size = new System.Drawing.Size(173, 34);
            this.btnCancelarValidarRegistro.TabIndex = 0;
            this.btnCancelarValidarRegistro.Text = "Cancelar";
            this.btnCancelarValidarRegistro.UseVisualStyleBackColor = true;
            this.btnCancelarValidarRegistro.Click += new System.EventHandler(this.btnCancelarValidarRegistro_Click);
            // 
            // panelBotFormVehiculos
            // 
            this.panelBotFormVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.panelBotFormVehiculos.Controls.Add(this.tableLayoutPanel1);
            this.panelBotFormVehiculos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotFormVehiculos.Location = new System.Drawing.Point(0, 434);
            this.panelBotFormVehiculos.Name = "panelBotFormVehiculos";
            this.panelBotFormVehiculos.Size = new System.Drawing.Size(934, 46);
            this.panelBotFormVehiculos.TabIndex = 4;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "vehicle";
            this.vehicleBindingSource.DataSource = this.rentacarDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carrecsTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contracteTableAdapter = null;
            this.tableAdapterManager.modeloTableAdapter = null;
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.restriccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.vehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // vehicle_modeloTableAdapter
            // 
            this.vehicle_modeloTableAdapter.ClearBeforeFill = true;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "modelo";
            this.modeloBindingSource.DataSource = this.rentacarDataSet;
            // 
            // lista_marcas_cochesTableAdapter
            // 
            this.lista_marcas_cochesTableAdapter.ClearBeforeFill = true;
            // 
            // lista_modelo_cochesTableAdapter
            // 
            this.lista_modelo_cochesTableAdapter.ClearBeforeFill = true;
            // 
            // lista_tipologia_cochesTableAdapter
            // 
            this.lista_tipologia_cochesTableAdapter.ClearBeforeFill = true;
            // 
            // tipologiaDataGridViewTextBoxColumn
            // 
            this.tipologiaDataGridViewTextBoxColumn.DataPropertyName = "tipologia";
            this.tipologiaDataGridViewTextBoxColumn.HeaderText = "tipologia";
            this.tipologiaDataGridViewTextBoxColumn.Name = "tipologiaDataGridViewTextBoxColumn";
            // 
            // modelococheDataGridViewTextBoxColumn
            // 
            this.modelococheDataGridViewTextBoxColumn.DataPropertyName = "modelo_coche";
            this.modelococheDataGridViewTextBoxColumn.HeaderText = "modelo_coche";
            this.modelococheDataGridViewTextBoxColumn.Name = "modelococheDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // vehicle_modeloDataGridView
            // 
            this.vehicle_modeloDataGridView.AutoGenerateColumns = false;
            this.vehicle_modeloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicle_modeloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modelococheDataGridViewTextBoxColumn,
            this.tipologiaDataGridViewTextBoxColumn});
            this.vehicle_modeloDataGridView.DataSource = this.vehicle_modeloBindingSource6;
            this.vehicle_modeloDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicle_modeloDataGridView.Location = new System.Drawing.Point(470, 3);
            this.vehicle_modeloDataGridView.Name = "vehicle_modeloDataGridView";
            this.vehicle_modeloDataGridView.Size = new System.Drawing.Size(461, 432);
            this.vehicle_modeloDataGridView.TabIndex = 1;
            // 
            // menuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 480);
            this.Controls.Add(this.panelBotFormVehiculos);
            this.Controls.Add(this.panelMidFormVehiculos);
            this.Controls.Add(this.panelTopFormVehiculos);
            this.Name = "menuVehiculos";
            this.Text = "menuVehiculos";
            this.Load += new System.EventHandler(this.menuVehiculos_Load);
            this.panelTopFormVehiculos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelMidFormVehiculos.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_modeloBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listatipologiacochesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listamodelocochesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listamarcascochesBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBotFormVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_modeloDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private rentacarDataSetTableAdapters.vehicleTableAdapter vehicleTableAdapter;
        private rentacarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelTopFormVehiculos;
        private System.Windows.Forms.Panel panelMidFormVehiculos;
        private System.Windows.Forms.Button btnIrAlSiguienteRegistro;
        private System.Windows.Forms.Button btnIrAlAnteriorRegistro;
        private System.Windows.Forms.Button btnIrAlUltimoRegistro;
        private System.Windows.Forms.Button btnIrAlPrimerRegistro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnValidarRegistro;
        private System.Windows.Forms.Button btnCancelarValidarRegistro;
        private System.Windows.Forms.Panel panelBotFormVehiculos;
        private System.Windows.Forms.Button btnSeleccionarRegistroParaEliminar;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnModificarRegistro;
        private rentacarDataSetTableAdapters.vehicle_modeloTableAdapter vehicle_modeloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource vehicle_modeloBindingSource6;
        private rentacarDataSetTableAdapters.modeloTableAdapter modeloTableAdapter;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource listamarcascochesBindingSource;
        private rentacarDataSetTableAdapters.lista_marcas_cochesTableAdapter lista_marcas_cochesTableAdapter;
        private rentacarDataSet rentacarDataSet1;
        private rentacarDataSet rentacarDataSet;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource listamodelocochesBindingSource;
        private rentacarDataSetTableAdapters.lista_modelo_cochesTableAdapter lista_modelo_cochesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource listatipologiacochesBindingSource;
        private rentacarDataSetTableAdapters.lista_tipologia_cochesTableAdapter lista_tipologia_cochesTableAdapter;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.DataGridView vehicle_modeloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelococheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipologiaDataGridViewTextBoxColumn;
    }
}