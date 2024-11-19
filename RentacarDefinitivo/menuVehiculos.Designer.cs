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
            System.Windows.Forms.Label tipologiaLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rentacarDataSet = new RentacarDefinitivo.rentacarDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehicleTableAdapter();
            this.tableAdapterManager = new RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager();
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
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.tipologiaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnValidarRegistro = new System.Windows.Forms.Button();
            this.btnCancelarValidarRegistro = new System.Windows.Forms.Button();
            this.panelBotFormVehiculos = new System.Windows.Forms.Panel();
            matriculaLabel = new System.Windows.Forms.Label();
            tipologiaLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.panelTopFormVehiculos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelMidFormVehiculos.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBotFormVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            matriculaLabel.Location = new System.Drawing.Point(66, 58);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(77, 20);
            matriculaLabel.TabIndex = 0;
            matriculaLabel.Text = "matricula:";
            // 
            // tipologiaLabel
            // 
            tipologiaLabel.AutoSize = true;
            tipologiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipologiaLabel.Location = new System.Drawing.Point(71, 95);
            tipologiaLabel.Name = "tipologiaLabel";
            tipologiaLabel.Size = new System.Drawing.Size(72, 20);
            tipologiaLabel.TabIndex = 2;
            tipologiaLabel.Text = "tipologia:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(80, 140);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(57, 20);
            marcaLabel.TabIndex = 4;
            marcaLabel.Text = "marca:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelLabel.Location = new System.Drawing.Point(81, 193);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(56, 20);
            modelLabel.TabIndex = 6;
            modelLabel.Text = "model:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colorLabel.Location = new System.Drawing.Point(90, 238);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(47, 20);
            colorLabel.TabIndex = 8;
            colorLabel.Text = "color:";
            // 
            // rentacarDataSet
            // 
            this.rentacarDataSet.DataSetName = "rentacarDataSet";
            this.rentacarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.vehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // panelTopFormVehiculos
            // 
            this.panelTopFormVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.panelTopFormVehiculos.Controls.Add(this.tableLayoutPanel2);
            this.panelTopFormVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopFormVehiculos.Location = new System.Drawing.Point(0, 0);
            this.panelTopFormVehiculos.Name = "panelTopFormVehiculos";
            this.panelTopFormVehiculos.Size = new System.Drawing.Size(990, 42);
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
            this.btnSeleccionarRegistroParaEliminar.MouseHover += new System.EventHandler(this.btnSeleccionarRegistroParaEliminar_MouseHover);
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
            this.panelMidFormVehiculos.Size = new System.Drawing.Size(990, 435);
            this.panelMidFormVehiculos.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.vehicleDataGridView, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(990, 435);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // vehicleDataGridView
            // 
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.vehicleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vehicleDataGridView.DataSource = this.vehicleBindingSource;
            this.vehicleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleDataGridView.Location = new System.Drawing.Point(498, 3);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.Size = new System.Drawing.Size(489, 429);
            this.vehicleDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipologia";
            this.dataGridViewTextBoxColumn2.HeaderText = "tipologia";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn4.HeaderText = "model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn5.HeaderText = "color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50);
            this.panel1.Size = new System.Drawing.Size(489, 429);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(colorLabel);
            this.panel2.Controls.Add(this.colorTextBox);
            this.panel2.Controls.Add(modelLabel);
            this.panel2.Controls.Add(this.modelTextBox);
            this.panel2.Controls.Add(marcaLabel);
            this.panel2.Controls.Add(this.marcaTextBox);
            this.panel2.Controls.Add(tipologiaLabel);
            this.panel2.Controls.Add(this.tipologiaTextBox);
            this.panel2.Controls.Add(matriculaLabel);
            this.panel2.Controls.Add(this.matriculaTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(50, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(389, 329);
            this.panel2.TabIndex = 0;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "color", true));
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(149, 238);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(180, 22);
            this.colorTextBox.TabIndex = 9;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "model", true));
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(149, 193);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(180, 22);
            this.modelTextBox.TabIndex = 7;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTextBox.Location = new System.Drawing.Point(149, 140);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(180, 22);
            this.marcaTextBox.TabIndex = 5;
            // 
            // tipologiaTextBox
            // 
            this.tipologiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "tipologia", true));
            this.tipologiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipologiaTextBox.Location = new System.Drawing.Point(149, 93);
            this.tipologiaTextBox.Name = "tipologiaTextBox";
            this.tipologiaTextBox.Size = new System.Drawing.Size(180, 22);
            this.tipologiaTextBox.TabIndex = 3;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "matricula", true));
            this.matriculaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaTextBox.Location = new System.Drawing.Point(149, 58);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(180, 22);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(629, 3);
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
            this.panelBotFormVehiculos.Location = new System.Drawing.Point(0, 431);
            this.panelBotFormVehiculos.Name = "panelBotFormVehiculos";
            this.panelBotFormVehiculos.Size = new System.Drawing.Size(990, 46);
            this.panelBotFormVehiculos.TabIndex = 4;
            // 
            // menuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 477);
            this.Controls.Add(this.panelBotFormVehiculos);
            this.Controls.Add(this.panelMidFormVehiculos);
            this.Controls.Add(this.panelTopFormVehiculos);
            this.Name = "menuVehiculos";
            this.Text = "menuVehiculos";
            this.Load += new System.EventHandler(this.menuVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.panelTopFormVehiculos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelMidFormVehiculos.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBotFormVehiculos.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnValidarRegistro;
        private System.Windows.Forms.Button btnCancelarValidarRegistro;
        private System.Windows.Forms.Panel panelBotFormVehiculos;
        private System.Windows.Forms.Button btnSeleccionarRegistroParaEliminar;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox tipologiaTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.Button btnModificarRegistro;
    }
}