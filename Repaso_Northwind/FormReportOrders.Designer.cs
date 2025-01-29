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
            this.lbNameReport = new System.Windows.Forms.Label();
            this.cbReports = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lbFechaFinal = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelReport = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customers_orders_orderDetails_productsTableAdapter = new Repaso_Northwind.NorthwindDataSetTableAdapters.customers_orders_orderDetails_productsTableAdapter();
            this.tableAdapterManager = new Repaso_Northwind.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new Repaso_Northwind.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customers_orders_orderDetails_productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
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
            this.panelTop.Controls.Add(this.lbNameReport);
            this.panelTop.Controls.Add(this.cbReports);
            this.panelTop.Controls.Add(this.btnResetFilter);
            this.panelTop.Controls.Add(this.btnFilter);
            this.panelTop.Controls.Add(this.lbFechaFinal);
            this.panelTop.Controls.Add(this.dateTimePickerFinal);
            this.panelTop.Controls.Add(this.lbFechaInicio);
            this.panelTop.Controls.Add(this.dateTimePickerInicio);
            this.panelTop.Controls.Add(this.lbCompanyName);
            this.panelTop.Controls.Add(this.cbCompanyName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(793, 77);
            this.panelTop.TabIndex = 0;
            // 
            // lbNameReport
            // 
            this.lbNameReport.AutoSize = true;
            this.lbNameReport.Location = new System.Drawing.Point(339, 15);
            this.lbNameReport.Name = "lbNameReport";
            this.lbNameReport.Size = new System.Drawing.Size(39, 13);
            this.lbNameReport.TabIndex = 9;
            this.lbNameReport.Text = "Report";
            // 
            // cbReports
            // 
            this.cbReports.FormattingEnabled = true;
            this.cbReports.Location = new System.Drawing.Point(389, 12);
            this.cbReports.Name = "cbReports";
            this.cbReports.Size = new System.Drawing.Size(200, 21);
            this.cbReports.TabIndex = 8;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.Location = new System.Drawing.Point(715, 48);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 7;
            this.btnResetFilter.Text = "Reset Filter";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(715, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lbFechaFinal
            // 
            this.lbFechaFinal.AutoSize = true;
            this.lbFechaFinal.Location = new System.Drawing.Point(319, 57);
            this.lbFechaFinal.Name = "lbFechaFinal";
            this.lbFechaFinal.Size = new System.Drawing.Size(59, 13);
            this.lbFechaFinal.TabIndex = 5;
            this.lbFechaFinal.Text = "Fecha final";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(384, 51);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinal.TabIndex = 4;
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(21, 53);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(64, 13);
            this.lbFechaInicio.TabIndex = 3;
            this.lbFechaInicio.Text = "Fecha inicio";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(91, 51);
            this.dateTimePickerInicio.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerInicio.TabIndex = 2;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(3, 15);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lbCompanyName.TabIndex = 1;
            this.lbCompanyName.Text = "Company Name";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.DataSource = this.customersBindingSource;
            this.cbCompanyName.DisplayMember = "CompanyName";
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(91, 12);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(206, 21);
            this.cbCompanyName.TabIndex = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.reportViewer1);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 77);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(793, 373);
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
            this.reportViewer1.Size = new System.Drawing.Size(793, 373);
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
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelTop);
            this.Name = "FormReportOrders";
            this.Text = "FormReportOrders";
            this.Load += new System.EventHandler(this.FormReportOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customers_orders_orderDetails_productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lbFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Label lbNameReport;
        private System.Windows.Forms.ComboBox cbReports;
    }
}