namespace ExamenReportsAlvaroQuispe
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelViewReport = new System.Windows.Forms.Panel();
            this.northwindDataSet = new ExamenReportsAlvaroQuispe.NorthwindDataSet();
            this.view_Employees_Territories_RegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Employees_Territories_RegionTableAdapter = new ExamenReportsAlvaroQuispe.NorthwindDataSetTableAdapters.View_Employees_Territories_RegionTableAdapter();
            this.tableAdapterManager = new ExamenReportsAlvaroQuispe.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbTerritorio = new System.Windows.Forms.ComboBox();
            this.cbListado = new System.Windows.Forms.ComboBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionTableAdapter = new ExamenReportsAlvaroQuispe.NorthwindDataSetTableAdapters.RegionTableAdapter();
            this.territoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.territoriesTableAdapter = new ExamenReportsAlvaroQuispe.NorthwindDataSetTableAdapters.TerritoriesTableAdapter();
            this.panelTop.SuspendLayout();
            this.panelViewReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Employees_Territories_RegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnFilter);
            this.panelTop.Controls.Add(this.tbCiudad);
            this.panelTop.Controls.Add(this.tbPais);
            this.panelTop.Controls.Add(this.cbListado);
            this.panelTop.Controls.Add(this.cbTerritorio);
            this.panelTop.Controls.Add(this.cbRegion);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 103);
            this.panelTop.TabIndex = 0;
            // 
            // panelViewReport
            // 
            this.panelViewReport.Controls.Add(this.reportViewer1);
            this.panelViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewReport.Location = new System.Drawing.Point(0, 103);
            this.panelViewReport.Name = "panelViewReport";
            this.panelViewReport.Size = new System.Drawing.Size(800, 395);
            this.panelViewReport.TabIndex = 1;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Employees_Territories_RegionBindingSource
            // 
            this.view_Employees_Territories_RegionBindingSource.DataMember = "View_Employees_Territories_Region";
            this.view_Employees_Territories_RegionBindingSource.DataSource = this.northwindDataSet;
            // 
            // view_Employees_Territories_RegionTableAdapter
            // 
            this.view_Employees_Territories_RegionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.listadosTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = this.regionTableAdapter;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = this.territoriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ExamenReportsAlvaroQuispe.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetEmpleados";
            reportDataSource2.Value = this.view_Employees_Territories_RegionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ExamenReportsAlvaroQuispe.ReportEmpleadosRegion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 395);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Territorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Listado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ciudad";
            // 
            // cbRegion
            // 
            this.cbRegion.DataSource = this.regionBindingSource;
            this.cbRegion.DisplayMember = "RegionDescription";
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(12, 25);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(107, 21);
            this.cbRegion.TabIndex = 5;
            // 
            // cbTerritorio
            // 
            this.cbTerritorio.DataSource = this.territoriesBindingSource;
            this.cbTerritorio.DisplayMember = "TerritoryDescription";
            this.cbTerritorio.FormattingEnabled = true;
            this.cbTerritorio.Location = new System.Drawing.Point(133, 25);
            this.cbTerritorio.Name = "cbTerritorio";
            this.cbTerritorio.Size = new System.Drawing.Size(104, 21);
            this.cbTerritorio.TabIndex = 6;
            // 
            // cbListado
            // 
            this.cbListado.FormattingEnabled = true;
            this.cbListado.Location = new System.Drawing.Point(253, 25);
            this.cbListado.Name = "cbListado";
            this.cbListado.Size = new System.Drawing.Size(192, 21);
            this.cbListado.TabIndex = 7;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(463, 25);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 20);
            this.tbPais.TabIndex = 8;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(584, 25);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(100, 20);
            this.tbCiudad.TabIndex = 9;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(725, 25);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 48);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Generar Informe";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.northwindDataSet;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // territoriesBindingSource
            // 
            this.territoriesBindingSource.DataMember = "Territories";
            this.territoriesBindingSource.DataSource = this.northwindDataSet;
            // 
            // territoriesTableAdapter
            // 
            this.territoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.panelViewReport);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelViewReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Employees_Territories_RegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.territoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelViewReport;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource view_Employees_Territories_RegionBindingSource;
        private NorthwindDataSetTableAdapters.View_Employees_Territories_RegionTableAdapter view_Employees_Territories_RegionTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbTerritorio;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.ComboBox cbListado;
        private NorthwindDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private NorthwindDataSetTableAdapters.TerritoriesTableAdapter territoriesTableAdapter;
        private System.Windows.Forms.BindingSource territoriesBindingSource;
    }
}

