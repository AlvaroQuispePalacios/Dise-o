namespace RentacarDefinitivo
{
    partial class FormVehiculo
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
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label matriculaLabel;
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContenedorTopBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnIrAlUltimoRegistro = new System.Windows.Forms.Button();
            this.btnRegistroSiguiente = new System.Windows.Forms.Button();
            this.btnRegistroPrevio = new System.Windows.Forms.Button();
            this.btnIrAlPrimerRegistro = new System.Windows.Forms.Button();
            this.tableLayoutPanelContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.vehiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentacarDataSet = new RentacarDefinitivo.rentacarDataSet();
            this.panelContenedorFormularioVehiculo = new System.Windows.Forms.Panel();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipologia = new System.Windows.Forms.ComboBox();
            this.listatipologiacochesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.panelBot = new System.Windows.Forms.Panel();
            this.tableLayoutPanelBotContenedorBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lista_tipologia_cochesTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.lista_tipologia_cochesTableAdapter();
            this.lista_marcas_cochesTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.lista_marcas_cochesTableAdapter();
            this.vehiculoTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehiculoTableAdapter();
            this.tableAdapterManager = new RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager();
            this.modeloTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.modeloTableAdapter();
            this.listamarcascochesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            colorLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanelContenedorTopBotones.SuspendLayout();
            this.tableLayoutPanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).BeginInit();
            this.panelContenedorFormularioVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listatipologiacochesBindingSource)).BeginInit();
            this.panelBot.SuspendLayout();
            this.tableLayoutPanelBotContenedorBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listamarcascochesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(148, 107);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(33, 13);
            colorLabel.TabIndex = 2;
            colorLabel.Text = "color:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(129, 61);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(52, 13);
            matriculaLabel.TabIndex = 8;
            matriculaLabel.Text = "matricula:";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanelContenedorTopBotones);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(837, 39);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanelContenedorTopBotones
            // 
            this.tableLayoutPanelContenedorTopBotones.ColumnCount = 7;
            this.tableLayoutPanelContenedorTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelContenedorTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelContenedorTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelContenedorTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelContenedorTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelContenedorTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelContenedorTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnModificarRegistro, 6, 0);
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnAgregarRegistro, 5, 0);
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnEliminarRegistro, 4, 0);
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnIrAlUltimoRegistro, 3, 0);
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnRegistroSiguiente, 2, 0);
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnRegistroPrevio, 1, 0);
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnIrAlPrimerRegistro, 0, 0);
            this.tableLayoutPanelContenedorTopBotones.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelContenedorTopBotones.Name = "tableLayoutPanelContenedorTopBotones";
            this.tableLayoutPanelContenedorTopBotones.RowCount = 1;
            this.tableLayoutPanelContenedorTopBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedorTopBotones.Size = new System.Drawing.Size(466, 33);
            this.tableLayoutPanelContenedorTopBotones.TabIndex = 0;
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarRegistro.Location = new System.Drawing.Point(399, 3);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(64, 27);
            this.btnModificarRegistro.TabIndex = 6;
            this.btnModificarRegistro.Text = "M";
            this.btnModificarRegistro.UseVisualStyleBackColor = true;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(333, 3);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(60, 27);
            this.btnAgregarRegistro.TabIndex = 5;
            this.btnAgregarRegistro.Text = "+";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(267, 3);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(60, 27);
            this.btnEliminarRegistro.TabIndex = 4;
            this.btnEliminarRegistro.Text = "-";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnIrAlUltimoRegistro
            // 
            this.btnIrAlUltimoRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlUltimoRegistro.Location = new System.Drawing.Point(201, 3);
            this.btnIrAlUltimoRegistro.Name = "btnIrAlUltimoRegistro";
            this.btnIrAlUltimoRegistro.Size = new System.Drawing.Size(60, 27);
            this.btnIrAlUltimoRegistro.TabIndex = 3;
            this.btnIrAlUltimoRegistro.Text = ">>";
            this.btnIrAlUltimoRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlUltimoRegistro.Click += new System.EventHandler(this.btnIrAlUltimoRegistro_Click);
            // 
            // btnRegistroSiguiente
            // 
            this.btnRegistroSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistroSiguiente.Location = new System.Drawing.Point(135, 3);
            this.btnRegistroSiguiente.Name = "btnRegistroSiguiente";
            this.btnRegistroSiguiente.Size = new System.Drawing.Size(60, 27);
            this.btnRegistroSiguiente.TabIndex = 2;
            this.btnRegistroSiguiente.Text = ">";
            this.btnRegistroSiguiente.UseVisualStyleBackColor = true;
            this.btnRegistroSiguiente.Click += new System.EventHandler(this.btnRegistroSiguiente_Click);
            // 
            // btnRegistroPrevio
            // 
            this.btnRegistroPrevio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistroPrevio.Location = new System.Drawing.Point(69, 3);
            this.btnRegistroPrevio.Name = "btnRegistroPrevio";
            this.btnRegistroPrevio.Size = new System.Drawing.Size(60, 27);
            this.btnRegistroPrevio.TabIndex = 1;
            this.btnRegistroPrevio.Text = "<";
            this.btnRegistroPrevio.UseVisualStyleBackColor = true;
            this.btnRegistroPrevio.Click += new System.EventHandler(this.btnRegistroPrevio_Click);
            // 
            // btnIrAlPrimerRegistro
            // 
            this.btnIrAlPrimerRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlPrimerRegistro.Location = new System.Drawing.Point(3, 3);
            this.btnIrAlPrimerRegistro.Name = "btnIrAlPrimerRegistro";
            this.btnIrAlPrimerRegistro.Size = new System.Drawing.Size(60, 27);
            this.btnIrAlPrimerRegistro.TabIndex = 0;
            this.btnIrAlPrimerRegistro.Text = "<<";
            this.btnIrAlPrimerRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlPrimerRegistro.Click += new System.EventHandler(this.btnIrAlPrimerRegistro_Click);
            // 
            // tableLayoutPanelContenedor
            // 
            this.tableLayoutPanelContenedor.ColumnCount = 2;
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContenedor.Controls.Add(this.vehiculoDataGridView, 1, 0);
            this.tableLayoutPanelContenedor.Controls.Add(this.panelContenedorFormularioVehiculo, 0, 0);
            this.tableLayoutPanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContenedor.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanelContenedor.Name = "tableLayoutPanelContenedor";
            this.tableLayoutPanelContenedor.RowCount = 1;
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tableLayoutPanelContenedor.Size = new System.Drawing.Size(837, 453);
            this.tableLayoutPanelContenedor.TabIndex = 1;
            // 
            // vehiculoDataGridView
            // 
            this.vehiculoDataGridView.AutoGenerateColumns = false;
            this.vehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vehiculoDataGridView.DataSource = this.vehiculoBindingSource;
            this.vehiculoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehiculoDataGridView.Location = new System.Drawing.Point(421, 3);
            this.vehiculoDataGridView.Name = "vehiculoDataGridView";
            this.vehiculoDataGridView.Size = new System.Drawing.Size(413, 447);
            this.vehiculoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "modelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tipologia";
            this.dataGridViewTextBoxColumn4.HeaderText = "tipologia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn5.HeaderText = "color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "vehiculo";
            this.vehiculoBindingSource.DataSource = this.rentacarDataSet;
            // 
            // rentacarDataSet
            // 
            this.rentacarDataSet.DataSetName = "rentacarDataSet";
            this.rentacarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelContenedorFormularioVehiculo
            // 
            this.panelContenedorFormularioVehiculo.Controls.Add(matriculaLabel);
            this.panelContenedorFormularioVehiculo.Controls.Add(this.matriculaTextBox);
            this.panelContenedorFormularioVehiculo.Controls.Add(this.comboBox1);
            this.panelContenedorFormularioVehiculo.Controls.Add(this.label2);
            this.panelContenedorFormularioVehiculo.Controls.Add(this.cbMarca);
            this.panelContenedorFormularioVehiculo.Controls.Add(this.label1);
            this.panelContenedorFormularioVehiculo.Controls.Add(this.cbTipologia);
            this.panelContenedorFormularioVehiculo.Controls.Add(colorLabel);
            this.panelContenedorFormularioVehiculo.Controls.Add(this.colorTextBox);
            this.panelContenedorFormularioVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorFormularioVehiculo.Location = new System.Drawing.Point(3, 3);
            this.panelContenedorFormularioVehiculo.Name = "panelContenedorFormularioVehiculo";
            this.panelContenedorFormularioVehiculo.Size = new System.Drawing.Size(412, 447);
            this.panelContenedorFormularioVehiculo.TabIndex = 0;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(187, 58);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "modelo", true));
            this.comboBox1.DataSource = this.modeloBindingSource;
            this.comboBox1.DisplayMember = "modelo_coche";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "modelo";
            this.modeloBindingSource.DataSource = this.rentacarDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // cbMarca
            // 
            this.cbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "marca", true));
            this.cbMarca.DataSource = this.listamarcascochesBindingSource;
            this.cbMarca.DisplayMember = "marca";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(166, 202);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 6;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipologia";
            // 
            // cbTipologia
            // 
            this.cbTipologia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "tipologia", true));
            this.cbTipologia.DataSource = this.listatipologiacochesBindingSource;
            this.cbTipologia.DisplayMember = "tipologia";
            this.cbTipologia.FormattingEnabled = true;
            this.cbTipologia.Location = new System.Drawing.Point(166, 153);
            this.cbTipologia.Name = "cbTipologia";
            this.cbTipologia.Size = new System.Drawing.Size(121, 21);
            this.cbTipologia.TabIndex = 4;
            this.cbTipologia.SelectedIndexChanged += new System.EventHandler(this.cbTipologia_SelectedIndexChanged);
            // 
            // listatipologiacochesBindingSource
            // 
            this.listatipologiacochesBindingSource.DataMember = "lista_tipologia_coches";
            this.listatipologiacochesBindingSource.DataSource = this.rentacarDataSet;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "color", true));
            this.colorTextBox.Location = new System.Drawing.Point(187, 104);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 3;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.tableLayoutPanelBotContenedorBotones);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 455);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(837, 37);
            this.panelBot.TabIndex = 2;
            // 
            // tableLayoutPanelBotContenedorBotones
            // 
            this.tableLayoutPanelBotContenedorBotones.ColumnCount = 2;
            this.tableLayoutPanelBotContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotContenedorBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotContenedorBotones.Controls.Add(this.btnConfirmar, 1, 0);
            this.tableLayoutPanelBotContenedorBotones.Controls.Add(this.btnCancelar, 0, 0);
            this.tableLayoutPanelBotContenedorBotones.Location = new System.Drawing.Point(533, 3);
            this.tableLayoutPanelBotContenedorBotones.Name = "tableLayoutPanelBotContenedorBotones";
            this.tableLayoutPanelBotContenedorBotones.RowCount = 1;
            this.tableLayoutPanelBotContenedorBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotContenedorBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBotContenedorBotones.Size = new System.Drawing.Size(267, 34);
            this.tableLayoutPanelBotContenedorBotones.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.Location = new System.Drawing.Point(136, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(128, 28);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 28);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lista_tipologia_cochesTableAdapter
            // 
            this.lista_tipologia_cochesTableAdapter.ClearBeforeFill = true;
            // 
            // lista_marcas_cochesTableAdapter
            // 
            this.lista_marcas_cochesTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.vehiculoTableAdapter = this.vehiculoTableAdapter;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // listamarcascochesBindingSource
            // 
            this.listamarcascochesBindingSource.DataMember = "lista_marcas_coches";
            this.listamarcascochesBindingSource.DataSource = this.rentacarDataSet;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 492);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.tableLayoutPanelContenedor);
            this.Controls.Add(this.panelTop);
            this.Name = "FormVehiculo";
            this.Text = "FormVehiculo";
            this.Load += new System.EventHandler(this.FormVehiculo_Load);
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanelContenedorTopBotones.ResumeLayout(false);
            this.tableLayoutPanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).EndInit();
            this.panelContenedorFormularioVehiculo.ResumeLayout(false);
            this.panelContenedorFormularioVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listatipologiacochesBindingSource)).EndInit();
            this.panelBot.ResumeLayout(false);
            this.tableLayoutPanelBotContenedorBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listamarcascochesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedorTopBotones;
        private System.Windows.Forms.Button btnIrAlPrimerRegistro;
        private System.Windows.Forms.Button btnModificarRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button btnIrAlUltimoRegistro;
        private System.Windows.Forms.Button btnRegistroSiguiente;
        private System.Windows.Forms.Button btnRegistroPrevio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedor;
        private System.Windows.Forms.Panel panelContenedorFormularioVehiculo;
        private System.Windows.Forms.Panel panelBot;
        private rentacarDataSet rentacarDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotContenedorBotones;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipologia;
        private System.Windows.Forms.BindingSource listatipologiacochesBindingSource;
        private rentacarDataSetTableAdapters.lista_tipologia_cochesTableAdapter lista_tipologia_cochesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMarca;
        private rentacarDataSetTableAdapters.lista_marcas_cochesTableAdapter lista_marcas_cochesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private rentacarDataSetTableAdapters.vehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.DataGridView vehiculoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private rentacarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private rentacarDataSetTableAdapters.modeloTableAdapter modeloTableAdapter;
        private System.Windows.Forms.BindingSource listamarcascochesBindingSource;
    }
}