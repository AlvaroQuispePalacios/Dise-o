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
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modelo_cocheLabel;
            System.Windows.Forms.Label tipologiaLabel;
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
            this.rentacarDataSet = new RentacarDefinitivo.rentacarDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tipologiaTextBox = new System.Windows.Forms.TextBox();
            this.modelo_cocheTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnValidarRegistro = new System.Windows.Forms.Button();
            this.btnCancelarValidarRegistro = new System.Windows.Forms.Button();
            this.panelBotFormVehiculos = new System.Windows.Forms.Panel();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehicleTableAdapter();
            this.tableAdapterManager = new RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager();
            this.vehicle_modeloTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehicle_modeloTableAdapter();
            this.vehicle_modeloBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.modeloTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.modeloTableAdapter();
            this.vehicle_modeloDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            matriculaLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modelo_cocheLabel = new System.Windows.Forms.Label();
            tipologiaLabel = new System.Windows.Forms.Label();
            this.panelTopFormVehiculos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelMidFormVehiculos.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBotFormVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_modeloBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_modeloDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(37, 59);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(52, 13);
            matriculaLabel.TabIndex = 0;
            matriculaLabel.Text = "matricula:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(56, 85);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(33, 13);
            colorLabel.TabIndex = 2;
            colorLabel.Text = "color:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(50, 111);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(39, 13);
            marcaLabel.TabIndex = 4;
            marcaLabel.Text = "marca:";
            // 
            // modelo_cocheLabel
            // 
            modelo_cocheLabel.AutoSize = true;
            modelo_cocheLabel.Location = new System.Drawing.Point(12, 166);
            modelo_cocheLabel.Name = "modelo_cocheLabel";
            modelo_cocheLabel.Size = new System.Drawing.Size(77, 13);
            modelo_cocheLabel.TabIndex = 6;
            modelo_cocheLabel.Text = "modelo coche:";
            // 
            // tipologiaLabel
            // 
            tipologiaLabel.AutoSize = true;
            tipologiaLabel.Location = new System.Drawing.Point(40, 140);
            tipologiaLabel.Name = "tipologiaLabel";
            tipologiaLabel.Size = new System.Drawing.Size(49, 13);
            tipologiaLabel.TabIndex = 8;
            tipologiaLabel.Text = "tipologia:";
            // 
            // panelTopFormVehiculos
            // 
            this.panelTopFormVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.panelTopFormVehiculos.Controls.Add(this.tableLayoutPanel2);
            this.panelTopFormVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopFormVehiculos.Location = new System.Drawing.Point(0, 0);
            this.panelTopFormVehiculos.Name = "panelTopFormVehiculos";
            this.panelTopFormVehiculos.Size = new System.Drawing.Size(882, 42);
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
            this.panelMidFormVehiculos.Size = new System.Drawing.Size(882, 699);
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 607F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(882, 699);
            this.tableLayoutPanel3.TabIndex = 11;
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
            this.panel1.Size = new System.Drawing.Size(435, 693);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(tipologiaLabel);
            this.panel2.Controls.Add(this.tipologiaTextBox);
            this.panel2.Controls.Add(modelo_cocheLabel);
            this.panel2.Controls.Add(this.modelo_cocheTextBox);
            this.panel2.Controls.Add(marcaLabel);
            this.panel2.Controls.Add(this.marcaTextBox);
            this.panel2.Controls.Add(colorLabel);
            this.panel2.Controls.Add(this.colorTextBox);
            this.panel2.Controls.Add(matriculaLabel);
            this.panel2.Controls.Add(this.matriculaTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(50, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(335, 593);
            this.panel2.TabIndex = 0;
            // 
            // tipologiaTextBox
            // 
            this.tipologiaTextBox.Location = new System.Drawing.Point(95, 137);
            this.tipologiaTextBox.Name = "tipologiaTextBox";
            this.tipologiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipologiaTextBox.TabIndex = 9;
            // 
            // modelo_cocheTextBox
            // 
            this.modelo_cocheTextBox.Location = new System.Drawing.Point(95, 163);
            this.modelo_cocheTextBox.Name = "modelo_cocheTextBox";
            this.modelo_cocheTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelo_cocheTextBox.TabIndex = 7;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Location = new System.Drawing.Point(95, 108);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 5;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(95, 82);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox.TabIndex = 3;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.Location = new System.Drawing.Point(95, 56);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnValidarRegistro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarValidarRegistro, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(521, 3);
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
            this.panelBotFormVehiculos.Location = new System.Drawing.Point(0, 695);
            this.panelBotFormVehiculos.Name = "panelBotFormVehiculos";
            this.panelBotFormVehiculos.Size = new System.Drawing.Size(882, 46);
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
            // vehicle_modeloBindingSource6
            // 
            this.vehicle_modeloBindingSource6.DataMember = "vehicle_modelo";
            this.vehicle_modeloBindingSource6.DataSource = this.rentacarDataSet;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // vehicle_modeloDataGridView
            // 
            this.vehicle_modeloDataGridView.AutoGenerateColumns = false;
            this.vehicle_modeloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicle_modeloDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vehicle_modeloDataGridView.DataSource = this.vehicle_modeloBindingSource6;
            this.vehicle_modeloDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicle_modeloDataGridView.Location = new System.Drawing.Point(444, 3);
            this.vehicle_modeloDataGridView.Name = "vehicle_modeloDataGridView";
            this.vehicle_modeloDataGridView.Size = new System.Drawing.Size(435, 693);
            this.vehicle_modeloDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn5.HeaderText = "color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn6.HeaderText = "marca";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "modelo_coche";
            this.dataGridViewTextBoxColumn7.HeaderText = "modelo_coche";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "tipologia";
            this.dataGridViewTextBoxColumn8.HeaderText = "tipologia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "modelo";
            this.modeloBindingSource.DataSource = this.rentacarDataSet;
            // 
            // menuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(882, 741);
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
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBotFormVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_modeloBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_modeloDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private rentacarDataSet rentacarDataSet;
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
        private System.Windows.Forms.TextBox tipologiaTextBox;
        private System.Windows.Forms.TextBox modelo_cocheTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.BindingSource vehicle_modeloBindingSource6;
        private rentacarDataSetTableAdapters.modeloTableAdapter modeloTableAdapter;
        private System.Windows.Forms.DataGridView vehicle_modeloDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource modeloBindingSource;
    }
}