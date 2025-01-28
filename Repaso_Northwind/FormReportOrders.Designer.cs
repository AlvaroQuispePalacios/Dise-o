namespace Repaso_Northwind
{
    partial class FormReportOrders
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.customers_orders_orderDetails_productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Repaso_Northwind.NorthwindDataSet();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customers_orders_orderDetails_productsTableAdapter = new Repaso_Northwind.NorthwindDataSetTableAdapters.customers_orders_orderDetails_productsTableAdapter();
            this.tableAdapterManager = new Repaso_Northwind.NorthwindDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.customers_orders_orderDetails_productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.panelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // customers_orders_orderDetails_productsBindingSource
            // 
            this.customers_orders_orderDetails_productsBindingSource.DataMember = "customers_orders_orderDetails_products";
            this.customers_orders_orderDetails_productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(881, 77);
            this.panelTop.TabIndex = 0;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.reportViewer1);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 77);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(881, 373);
            this.panelReport.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetReportOrders";
            reportDataSource2.Value = this.customers_orders_orderDetails_productsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Repaso_Northwind.ReportOrders.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(881, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // customers_orders_orderDetails_productsTableAdapter
            // 
            this.customers_orders_orderDetails_productsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Repaso_Northwind.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelTop);
            this.Name = "FormReportOrders";
            this.Text = "FormReportOrders";
            this.Load += new System.EventHandler(this.FormReportOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customers_orders_orderDetails_productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.panelReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelReport;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customers_orders_orderDetails_productsBindingSource;
        private NorthwindDataSetTableAdapters.customers_orders_orderDetails_productsTableAdapter customers_orders_orderDetails_productsTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}