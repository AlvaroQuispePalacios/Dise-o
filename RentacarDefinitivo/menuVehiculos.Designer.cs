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
            this.rentacarDataSet = new RentacarDefinitivo.rentacarDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehicleTableAdapter();
            this.tableAdapterManager = new RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager();
            this.panelTopFormVehiculos = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIrAlPrimerRegistro = new System.Windows.Forms.Button();
            this.btnIrAlUltimoRegistro = new System.Windows.Forms.Button();
            this.btnIrAlSiguienteRegistro = new System.Windows.Forms.Button();
            this.btnIrAlAnteriorRegistro = new System.Windows.Forms.Button();
            this.panelMidFormVehiculos = new System.Windows.Forms.Panel();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.lblTipologia = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.tbTipologia = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBotFormVehiculos = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.panelTopFormVehiculos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelMidFormVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBotFormVehiculos.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTopFormVehiculos.Size = new System.Drawing.Size(967, 42);
            this.panelTopFormVehiculos.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnIrAlPrimerRegistro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIrAlUltimoRegistro, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIrAlSiguienteRegistro, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIrAlAnteriorRegistro, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(236, 36);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnIrAlPrimerRegistro
            // 
            this.btnIrAlPrimerRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlPrimerRegistro.Location = new System.Drawing.Point(3, 3);
            this.btnIrAlPrimerRegistro.Name = "btnIrAlPrimerRegistro";
            this.btnIrAlPrimerRegistro.Size = new System.Drawing.Size(53, 30);
            this.btnIrAlPrimerRegistro.TabIndex = 0;
            this.btnIrAlPrimerRegistro.Text = "<<";
            this.btnIrAlPrimerRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlPrimerRegistro.Click += new System.EventHandler(this.btnIrAlPrimerRegistro_Click);
            // 
            // btnIrAlUltimoRegistro
            // 
            this.btnIrAlUltimoRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlUltimoRegistro.Location = new System.Drawing.Point(180, 3);
            this.btnIrAlUltimoRegistro.Name = "btnIrAlUltimoRegistro";
            this.btnIrAlUltimoRegistro.Size = new System.Drawing.Size(53, 30);
            this.btnIrAlUltimoRegistro.TabIndex = 1;
            this.btnIrAlUltimoRegistro.Text = ">>";
            this.btnIrAlUltimoRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlUltimoRegistro.Click += new System.EventHandler(this.btnIrAlUltimoRegistro_Click);
            // 
            // btnIrAlSiguienteRegistro
            // 
            this.btnIrAlSiguienteRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlSiguienteRegistro.Location = new System.Drawing.Point(121, 3);
            this.btnIrAlSiguienteRegistro.Name = "btnIrAlSiguienteRegistro";
            this.btnIrAlSiguienteRegistro.Size = new System.Drawing.Size(53, 30);
            this.btnIrAlSiguienteRegistro.TabIndex = 3;
            this.btnIrAlSiguienteRegistro.Text = ">";
            this.btnIrAlSiguienteRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlSiguienteRegistro.Click += new System.EventHandler(this.btnIrAlSiguienteRegistro_Click);
            // 
            // btnIrAlAnteriorRegistro
            // 
            this.btnIrAlAnteriorRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlAnteriorRegistro.Location = new System.Drawing.Point(62, 3);
            this.btnIrAlAnteriorRegistro.Name = "btnIrAlAnteriorRegistro";
            this.btnIrAlAnteriorRegistro.Size = new System.Drawing.Size(53, 30);
            this.btnIrAlAnteriorRegistro.TabIndex = 2;
            this.btnIrAlAnteriorRegistro.Text = "<";
            this.btnIrAlAnteriorRegistro.UseVisualStyleBackColor = true;
            this.btnIrAlAnteriorRegistro.Click += new System.EventHandler(this.btnIrAlAnteriorRegistro_Click);
            // 
            // panelMidFormVehiculos
            // 
            this.panelMidFormVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelMidFormVehiculos.Controls.Add(this.tableLayoutPanel3);
            this.panelMidFormVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMidFormVehiculos.Location = new System.Drawing.Point(0, 42);
            this.panelMidFormVehiculos.Name = "panelMidFormVehiculos";
            this.panelMidFormVehiculos.Size = new System.Drawing.Size(967, 525);
            this.panelMidFormVehiculos.TabIndex = 3;
            // 
            // vehicleDataGridView
            // 
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
            this.vehicleDataGridView.Location = new System.Drawing.Point(486, 3);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.Size = new System.Drawing.Size(478, 519);
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 514F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(967, 525);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50);
            this.panel1.Size = new System.Drawing.Size(477, 519);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(50, 50);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(377, 419);
            this.panel2.TabIndex = 0;
            // 
            // tbMatricula
            // 
            this.tbMatricula.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vehicleBindingSource, "matricula", true));
            this.tbMatricula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "matricula", true));
            this.tbMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMatricula.Location = new System.Drawing.Point(113, 3);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(244, 20);
            this.tbMatricula.TabIndex = 35;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.Color.White;
            this.lblMatricula.Location = new System.Drawing.Point(3, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(104, 44);
            this.lblMatricula.TabIndex = 30;
            this.lblMatricula.Text = "Matricula";
            this.lblMatricula.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbColor
            // 
            this.tbColor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vehicleBindingSource, "color", true));
            this.tbColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "color", true));
            this.tbColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbColor.Location = new System.Drawing.Point(113, 47);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(244, 20);
            this.tbColor.TabIndex = 39;
            // 
            // lblTipologia
            // 
            this.lblTipologia.AutoSize = true;
            this.lblTipologia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipologia.ForeColor = System.Drawing.Color.White;
            this.lblTipologia.Location = new System.Drawing.Point(3, 44);
            this.lblTipologia.Name = "lblTipologia";
            this.lblTipologia.Size = new System.Drawing.Size(104, 44);
            this.lblTipologia.TabIndex = 31;
            this.lblTipologia.Text = "Tipologia";
            this.lblTipologia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbModelo
            // 
            this.tbModelo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vehicleBindingSource, "model", true));
            this.tbModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "model", true));
            this.tbModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbModelo.Location = new System.Drawing.Point(113, 91);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(244, 20);
            this.tbModelo.TabIndex = 38;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(3, 88);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(104, 44);
            this.lblMarca.TabIndex = 32;
            this.lblMarca.Text = "Marca";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbMarca
            // 
            this.tbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vehicleBindingSource, "marca", true));
            this.tbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "marca", true));
            this.tbMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMarca.Location = new System.Drawing.Point(113, 135);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(244, 20);
            this.tbMarca.TabIndex = 37;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(3, 132);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(104, 44);
            this.lblModelo.TabIndex = 33;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbTipologia
            // 
            this.tbTipologia.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.vehicleBindingSource, "tipologia", true));
            this.tbTipologia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "tipologia", true));
            this.tbTipologia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTipologia.Location = new System.Drawing.Point(113, 179);
            this.tbTipologia.Name = "tbTipologia";
            this.tbTipologia.Size = new System.Drawing.Size(244, 20);
            this.tbTipologia.TabIndex = 36;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(3, 176);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(104, 48);
            this.lblColor.TabIndex = 34;
            this.lblColor.Text = "Color";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(797, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(167, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(86, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelBotFormVehiculos
            // 
            this.panelBotFormVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.panelBotFormVehiculos.Controls.Add(this.tableLayoutPanel1);
            this.panelBotFormVehiculos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotFormVehiculos.Location = new System.Drawing.Point(0, 521);
            this.panelBotFormVehiculos.Name = "panelBotFormVehiculos";
            this.panelBotFormVehiculos.Size = new System.Drawing.Size(967, 46);
            this.panelBotFormVehiculos.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.55556F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.44444F));
            this.tableLayoutPanel4.Controls.Add(this.tbTipologia, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.tbMarca, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tbModelo, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbColor, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbMatricula, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTipologia, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblMarca, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblModelo, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblColor, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lblMatricula, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 116);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(360, 224);
            this.tableLayoutPanel4.TabIndex = 40;
            // 
            // menuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 567);
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
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBotFormVehiculos.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lblTipologia;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox tbTipologia;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelBotFormVehiculos;
    }
}