namespace Northwind2
{
    partial class FormHeredado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.all_customers_orderDetails_orders_productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Northwind2.NorthwindDataSet();
            this.all_customers_orderDetails_orders_productsTableAdapter = new Northwind2.NorthwindDataSetTableAdapters.all_customers_orderDetails_orders_productsTableAdapter();
            this.tableAdapterManager = new Northwind2.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadosTableAdapter = new Northwind2.NorthwindDataSetTableAdapters.listadosTableAdapter();
            this.panelTop.SuspendLayout();
            this.panelViewReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.all_customers_orderDetails_orders_productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelViewReport
            // 
            this.panelViewReport.Controls.Add(this.reportViewer1);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cbReports
            // 
            this.cbReports.DataSource = this.listadosBindingSource;
            this.cbReports.DisplayMember = "nombre_report";
            this.cbReports.ValueMember = "nombre_report";
            // 
            // all_customers_orderDetails_orders_productsBindingSource
            // 
            this.all_customers_orderDetails_orders_productsBindingSource.DataMember = "all_customers_orderDetails_orders_products";
            this.all_customers_orderDetails_orders_productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // all_customers_orderDetails_orders_productsTableAdapter
            // 
            this.all_customers_orderDetails_orders_productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.listadosTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Northwind2.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetAll";
            reportDataSource1.Value = this.all_customers_orderDetails_orders_productsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Northwind2.ReportPrueba.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 359);
            this.reportViewer1.TabIndex = 0;
            // 
            // listadosBindingSource
            // 
            this.listadosBindingSource.DataMember = "listados";
            this.listadosBindingSource.DataSource = this.northwindDataSet;
            // 
            // listadosTableAdapter
            // 
            this.listadosTableAdapter.ClearBeforeFill = true;
            // 
            // FormHeredado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormHeredado";
            this.Text = "FormHeredado";
            this.Load += new System.EventHandler(this.FormHeredado_Load);
            this.panelTop.ResumeLayout(false);
            this.panelViewReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.all_customers_orderDetails_orders_productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource all_customers_orderDetails_orders_productsBindingSource;
        private NorthwindDataSetTableAdapters.all_customers_orderDetails_orders_productsTableAdapter all_customers_orderDetails_orders_productsTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listadosBindingSource;
        private NorthwindDataSetTableAdapters.listadosTableAdapter listadosTableAdapter;
    }
}