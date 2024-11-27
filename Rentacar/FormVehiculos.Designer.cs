namespace Rentacar
{
    partial class FormVehiculos
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
            System.Windows.Forms.Label vehiculo_matriculaLabel;
            System.Windows.Forms.Label vehiculo_colorLabel;
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContenedorTopBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnIrAlUltimoRegistro = new System.Windows.Forms.Button();
            this.btnSiguienteRegistro = new System.Windows.Forms.Button();
            this.btnAnteriorRegistro = new System.Windows.Forms.Button();
            this.btnIrAlPrimerRegistro = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.tableLayoutPanelContenedorBotBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dbRentacarDataSet = new Rentacar.dbRentacarDataSet();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculoTableAdapter = new Rentacar.dbRentacarDataSetTableAdapters.vehiculoTableAdapter();
            this.tableAdapterManager = new Rentacar.dbRentacarDataSetTableAdapters.TableAdapterManager();
            this.vehiculo_matriculaTextBox = new System.Windows.Forms.TextBox();
            this.vehiculo_colorTextBox = new System.Windows.Forms.TextBox();
            this.cbTipologia = new System.Windows.Forms.ComboBox();
            this.tipologiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbTipologia = new System.Windows.Forms.Label();
            this.tipologiasTableAdapter = new Rentacar.dbRentacarDataSetTableAdapters.tipologiasTableAdapter();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.marcascochesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbMarca = new System.Windows.Forms.Label();
            this.marcas_cochesTableAdapter = new Rentacar.dbRentacarDataSetTableAdapters.marcas_cochesTableAdapter();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbModelo = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.modeloTableAdapter = new Rentacar.dbRentacarDataSetTableAdapters.modeloTableAdapter();
            vehiculo_matriculaLabel = new System.Windows.Forms.Label();
            vehiculo_colorLabel = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanelContenedorTopBotones.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.tableLayoutPanelContenedorBotBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbRentacarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipologiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcascochesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculo_matriculaLabel
            // 
            vehiculo_matriculaLabel.AutoSize = true;
            vehiculo_matriculaLabel.Location = new System.Drawing.Point(270, 332);
            vehiculo_matriculaLabel.Name = "vehiculo_matriculaLabel";
            vehiculo_matriculaLabel.Size = new System.Drawing.Size(95, 13);
            vehiculo_matriculaLabel.TabIndex = 3;
            vehiculo_matriculaLabel.Text = "vehiculo matricula:";
            // 
            // vehiculo_colorLabel
            // 
            vehiculo_colorLabel.AutoSize = true;
            vehiculo_colorLabel.Location = new System.Drawing.Point(289, 358);
            vehiculo_colorLabel.Name = "vehiculo_colorLabel";
            vehiculo_colorLabel.Size = new System.Drawing.Size(76, 13);
            vehiculo_colorLabel.TabIndex = 5;
            vehiculo_colorLabel.Text = "vehiculo color:";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanelContenedorTopBotones);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(895, 38);
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
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnSiguienteRegistro, 2, 0);
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnAnteriorRegistro, 1, 0);
            this.tableLayoutPanelContenedorTopBotones.Controls.Add(this.btnIrAlPrimerRegistro, 0, 0);
            this.tableLayoutPanelContenedorTopBotones.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelContenedorTopBotones.Name = "tableLayoutPanelContenedorTopBotones";
            this.tableLayoutPanelContenedorTopBotones.RowCount = 1;
            this.tableLayoutPanelContenedorTopBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedorTopBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelContenedorTopBotones.Size = new System.Drawing.Size(399, 32);
            this.tableLayoutPanelContenedorTopBotones.TabIndex = 0;
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarRegistro.Location = new System.Drawing.Point(345, 3);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(51, 26);
            this.btnModificarRegistro.TabIndex = 6;
            this.btnModificarRegistro.Text = "M";
            this.btnModificarRegistro.UseVisualStyleBackColor = true;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(288, 3);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(51, 26);
            this.btnAgregarRegistro.TabIndex = 5;
            this.btnAgregarRegistro.Text = "+";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(231, 3);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(51, 26);
            this.btnEliminarRegistro.TabIndex = 4;
            this.btnEliminarRegistro.Text = "-";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnIrAlUltimoRegistro
            // 
            this.btnIrAlUltimoRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlUltimoRegistro.Location = new System.Drawing.Point(174, 3);
            this.btnIrAlUltimoRegistro.Name = "btnIrAlUltimoRegistro";
            this.btnIrAlUltimoRegistro.Size = new System.Drawing.Size(51, 26);
            this.btnIrAlUltimoRegistro.TabIndex = 3;
            this.btnIrAlUltimoRegistro.Text = ">>";
            this.btnIrAlUltimoRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlUltimoRegistro.Click += new System.EventHandler(this.btnIrAlUltimoRegistro_Click);
            // 
            // btnSiguienteRegistro
            // 
            this.btnSiguienteRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiguienteRegistro.Location = new System.Drawing.Point(117, 3);
            this.btnSiguienteRegistro.Name = "btnSiguienteRegistro";
            this.btnSiguienteRegistro.Size = new System.Drawing.Size(51, 26);
            this.btnSiguienteRegistro.TabIndex = 2;
            this.btnSiguienteRegistro.Text = ">";
            this.btnSiguienteRegistro.UseVisualStyleBackColor = true;
            this.btnSiguienteRegistro.Click += new System.EventHandler(this.btnSiguienteRegistro_Click);
            // 
            // btnAnteriorRegistro
            // 
            this.btnAnteriorRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnteriorRegistro.Location = new System.Drawing.Point(60, 3);
            this.btnAnteriorRegistro.Name = "btnAnteriorRegistro";
            this.btnAnteriorRegistro.Size = new System.Drawing.Size(51, 26);
            this.btnAnteriorRegistro.TabIndex = 1;
            this.btnAnteriorRegistro.Text = "<";
            this.btnAnteriorRegistro.UseVisualStyleBackColor = true;
            this.btnAnteriorRegistro.Click += new System.EventHandler(this.btnAnteriorRegistro_Click);
            // 
            // btnIrAlPrimerRegistro
            // 
            this.btnIrAlPrimerRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlPrimerRegistro.Location = new System.Drawing.Point(3, 3);
            this.btnIrAlPrimerRegistro.Name = "btnIrAlPrimerRegistro";
            this.btnIrAlPrimerRegistro.Size = new System.Drawing.Size(51, 26);
            this.btnIrAlPrimerRegistro.TabIndex = 0;
            this.btnIrAlPrimerRegistro.Text = "<<";
            this.btnIrAlPrimerRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlPrimerRegistro.Click += new System.EventHandler(this.btnIrAlPrimerRegistro_Click);
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.tableLayoutPanelContenedorBotBotones);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 490);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(895, 37);
            this.panelBot.TabIndex = 3;
            // 
            // tableLayoutPanelContenedorBotBotones
            // 
            this.tableLayoutPanelContenedorBotBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelContenedorBotBotones.ColumnCount = 2;
            this.tableLayoutPanelContenedorBotBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContenedorBotBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContenedorBotBotones.Controls.Add(this.btnConfirmar, 1, 0);
            this.tableLayoutPanelContenedorBotBotones.Controls.Add(this.btnCancelar, 0, 0);
            this.tableLayoutPanelContenedorBotBotones.Location = new System.Drawing.Point(637, 0);
            this.tableLayoutPanelContenedorBotBotones.Name = "tableLayoutPanelContenedorBotBotones";
            this.tableLayoutPanelContenedorBotBotones.RowCount = 1;
            this.tableLayoutPanelContenedorBotBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedorBotBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelContenedorBotBotones.Size = new System.Drawing.Size(258, 37);
            this.tableLayoutPanelContenedorBotBotones.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.Location = new System.Drawing.Point(132, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(123, 31);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Validar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dbRentacarDataSet
            // 
            this.dbRentacarDataSet.DataSetName = "dbRentacarDataSet";
            this.dbRentacarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "vehiculo";
            this.vehiculoBindingSource.DataSource = this.dbRentacarDataSet;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.modeloTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Rentacar.dbRentacarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.vehiculoTableAdapter = this.vehiculoTableAdapter;
            // 
            // vehiculo_matriculaTextBox
            // 
            this.vehiculo_matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "vehiculo_matricula", true));
            this.vehiculo_matriculaTextBox.Location = new System.Drawing.Point(371, 329);
            this.vehiculo_matriculaTextBox.Name = "vehiculo_matriculaTextBox";
            this.vehiculo_matriculaTextBox.Size = new System.Drawing.Size(139, 20);
            this.vehiculo_matriculaTextBox.TabIndex = 4;
            // 
            // vehiculo_colorTextBox
            // 
            this.vehiculo_colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "vehiculo_color", true));
            this.vehiculo_colorTextBox.Location = new System.Drawing.Point(371, 355);
            this.vehiculo_colorTextBox.Name = "vehiculo_colorTextBox";
            this.vehiculo_colorTextBox.Size = new System.Drawing.Size(139, 20);
            this.vehiculo_colorTextBox.TabIndex = 6;
            // 
            // cbTipologia
            // 
            this.cbTipologia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "vehiculo_tipologia", true));
            this.cbTipologia.DataSource = this.tipologiasBindingSource;
            this.cbTipologia.DisplayMember = "modelo_tipologia";
            this.cbTipologia.FormattingEnabled = true;
            this.cbTipologia.Location = new System.Drawing.Point(371, 381);
            this.cbTipologia.Name = "cbTipologia";
            this.cbTipologia.Size = new System.Drawing.Size(139, 21);
            this.cbTipologia.TabIndex = 7;
            this.cbTipologia.SelectedIndexChanged += new System.EventHandler(this.cbTipologia_SelectedIndexChanged);
            // 
            // tipologiasBindingSource
            // 
            this.tipologiasBindingSource.DataMember = "tipologias";
            this.tipologiasBindingSource.DataSource = this.dbRentacarDataSet;
            // 
            // lbTipologia
            // 
            this.lbTipologia.AutoSize = true;
            this.lbTipologia.Location = new System.Drawing.Point(315, 384);
            this.lbTipologia.Name = "lbTipologia";
            this.lbTipologia.Size = new System.Drawing.Size(50, 13);
            this.lbTipologia.TabIndex = 8;
            this.lbTipologia.Text = "Tipologia";
            // 
            // tipologiasTableAdapter
            // 
            this.tipologiasTableAdapter.ClearBeforeFill = true;
            // 
            // cbMarca
            // 
            this.cbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "vehiculo_marca", true));
            this.cbMarca.DataSource = this.marcascochesBindingSource;
            this.cbMarca.DisplayMember = "modelo_marca";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(371, 408);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(139, 21);
            this.cbMarca.TabIndex = 9;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // marcascochesBindingSource
            // 
            this.marcascochesBindingSource.DataMember = "marcas_coches";
            this.marcascochesBindingSource.DataSource = this.dbRentacarDataSet;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(328, 411);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 10;
            this.lbMarca.Text = "Marca";
            // 
            // marcas_cochesTableAdapter
            // 
            this.marcas_cochesTableAdapter.ClearBeforeFill = true;
            // 
            // cbModelo
            // 
            this.cbModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "vehiculo_modelo", true));
            this.cbModelo.DataSource = this.modeloBindingSource;
            this.cbModelo.DisplayMember = "modelo_coche";
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(371, 435);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(139, 21);
            this.cbModelo.TabIndex = 11;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "modelo";
            this.modeloBindingSource.DataSource = this.dbRentacarDataSet;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(323, 438);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 12;
            this.lbModelo.Text = "Modelo";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "vehiculo_modelo";
            this.dataGridViewTextBoxColumn6.HeaderText = "vehiculo_modelo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "vehiculo_marca";
            this.dataGridViewTextBoxColumn5.HeaderText = "vehiculo_marca";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vehiculo_tipologia";
            this.dataGridViewTextBoxColumn4.HeaderText = "vehiculo_tipologia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "vehiculo_color";
            this.dataGridViewTextBoxColumn2.HeaderText = "vehiculo_color";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vehiculo_matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "vehiculo_matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // vehiculoDataGridView
            // 
            this.vehiculoDataGridView.AutoGenerateColumns = false;
            this.vehiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vehiculoDataGridView.DataSource = this.vehiculoBindingSource;
            this.vehiculoDataGridView.Location = new System.Drawing.Point(0, 38);
            this.vehiculoDataGridView.Name = "vehiculoDataGridView";
            this.vehiculoDataGridView.Size = new System.Drawing.Size(889, 269);
            this.vehiculoDataGridView.TabIndex = 3;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 527);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lbTipologia);
            this.Controls.Add(this.cbTipologia);
            this.Controls.Add(vehiculo_colorLabel);
            this.Controls.Add(this.vehiculo_colorTextBox);
            this.Controls.Add(vehiculo_matriculaLabel);
            this.Controls.Add(this.vehiculo_matriculaTextBox);
            this.Controls.Add(this.vehiculoDataGridView);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Name = "FormVehiculos";
            this.Text = "FormVehiculos";
            this.Load += new System.EventHandler(this.FormVehiculos_Load);
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanelContenedorTopBotones.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.tableLayoutPanelContenedorBotBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbRentacarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipologiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcascochesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedorTopBotones;
        private dbRentacarDataSet dbRentacarDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private dbRentacarDataSetTableAdapters.vehiculoTableAdapter vehiculoTableAdapter;
        private dbRentacarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnModificarRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button btnIrAlUltimoRegistro;
        private System.Windows.Forms.Button btnSiguienteRegistro;
        private System.Windows.Forms.Button btnAnteriorRegistro;
        private System.Windows.Forms.Button btnIrAlPrimerRegistro;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedorBotBotones;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox vehiculo_matriculaTextBox;
        private System.Windows.Forms.TextBox vehiculo_colorTextBox;
        private System.Windows.Forms.ComboBox cbTipologia;
        private System.Windows.Forms.Label lbTipologia;
        private System.Windows.Forms.BindingSource tipologiasBindingSource;
        private dbRentacarDataSetTableAdapters.tipologiasTableAdapter tipologiasTableAdapter;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.BindingSource marcascochesBindingSource;
        private dbRentacarDataSetTableAdapters.marcas_cochesTableAdapter marcas_cochesTableAdapter;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView vehiculoDataGridView;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private dbRentacarDataSetTableAdapters.modeloTableAdapter modeloTableAdapter;
    }
}