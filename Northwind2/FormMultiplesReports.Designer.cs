namespace Northwind2
{
    partial class FormMultiplesReports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelReport = new System.Windows.Forms.Panel();
            this.northwindDataSet = new Northwind2.NorthwindDataSet();
            this.all_customers_orderDetails_orders_productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_customers_orderDetails_orders_productsTableAdapter = new Northwind2.NorthwindDataSetTableAdapters.all_customers_orderDetails_orders_productsTableAdapter();
            this.tableAdapterManager = new Northwind2.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbYear = new System.Windows.Forms.Label();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_customers_orderDetails_orders_productsBindingSource)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.reportViewer1);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 42);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(800, 408);
            this.panelReport.TabIndex = 1;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // all_customers_orderDetails_orders_productsBindingSource
            // 
            this.all_customers_orderDetails_orders_productsBindingSource.DataMember = "all_customers_orderDetails_orders_products";
            this.all_customers_orderDetails_orders_productsBindingSource.DataSource = this.northwindDataSet;
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
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Northwind2.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lbYear);
            this.panelTop.Controls.Add(this.btnFilter);
            this.panelTop.Controls.Add(this.cbYear);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 42);
            this.panelTop.TabIndex = 0;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(57, 12);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(97, 21);
            this.cbYear.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(722, 10);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetAll";
            reportDataSource3.Value = this.all_customers_orderDetails_orders_productsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Northwind2.ReportOrder1996.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(12, 15);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(39, 13);
            this.lbYear.TabIndex = 2;
            this.lbYear.Text = "Report";
            // 
            // FormMultiplesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelTop);
            this.Name = "FormMultiplesReports";
            this.Text = "FormMultiplesReports";
            this.Load += new System.EventHandler(this.FormMultiplesReports_Load);
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_customers_orderDetails_orders_productsBindingSource)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelReport;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource all_customers_orderDetails_orders_productsBindingSource;
        private NorthwindDataSetTableAdapters.all_customers_orderDetails_orders_productsTableAdapter all_customers_orderDetails_orders_productsTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbYear;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lbYear;
    }
}