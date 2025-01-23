namespace Northwind2
{
    partial class FormReportOrderCustomer
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
            this.customer_order_detail_productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Northwind2.NorthwindDataSet();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbDateFinal = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.panelReport = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customer_order_detail_productTableAdapter = new Northwind2.NorthwindDataSetTableAdapters.customer_order_detail_productTableAdapter();
            this.tableAdapterManager = new Northwind2.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new Northwind2.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.btnResetFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customer_order_detail_productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.panelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_order_detail_productBindingSource
            // 
            this.customer_order_detail_productBindingSource.DataMember = "customer_order_detail_product";
            this.customer_order_detail_productBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnResetFilter);
            this.panelTop.Controls.Add(this.cbCompanyName);
            this.panelTop.Controls.Add(this.lbDateFinal);
            this.panelTop.Controls.Add(this.dateTimePicker2);
            this.panelTop.Controls.Add(this.dateTimePicker1);
            this.panelTop.Controls.Add(this.lbOrderDate);
            this.panelTop.Controls.Add(this.btnFilter);
            this.panelTop.Controls.Add(this.tbCompanyName);
            this.panelTop.Controls.Add(this.lbCompanyName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 86);
            this.panelTop.TabIndex = 0;
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.customer_order_detail_productBindingSource, "CompanyName", true));
            this.cbCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CompanyName", true));
            this.cbCompanyName.DataSource = this.customersBindingSource;
            this.cbCompanyName.DisplayMember = "CompanyName";
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(410, 32);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(200, 21);
            this.cbCompanyName.TabIndex = 8;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // lbDateFinal
            // 
            this.lbDateFinal.AutoSize = true;
            this.lbDateFinal.Location = new System.Drawing.Point(349, 59);
            this.lbDateFinal.Name = "lbDateFinal";
            this.lbDateFinal.Size = new System.Drawing.Size(55, 13);
            this.lbDateFinal.TabIndex = 7;
            this.lbDateFinal.Text = "Date Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(410, 59);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(12, 59);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(43, 13);
            this.lbOrderDate.TabIndex = 3;
            this.lbOrderDate.Text = "Date ini";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(725, 16);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(100, 18);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(181, 20);
            this.tbCompanyName.TabIndex = 1;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(12, 21);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lbCompanyName.TabIndex = 0;
            this.lbCompanyName.Text = "Company Name";
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.reportViewer1);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 86);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(800, 377);
            this.panelReport.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReportOrder";
            reportDataSource1.Value = this.customer_order_detail_productBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Northwind2.ReportOrder.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // customer_order_detail_productTableAdapter
            // 
            this.customer_order_detail_productTableAdapter.ClearBeforeFill = true;
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
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Location = new System.Drawing.Point(725, 54);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnResetFilter.TabIndex = 9;
            this.btnResetFilter.Text = "Reset Filter";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // FormReportOrderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelTop);
            this.Name = "FormReportOrderCustomer";
            this.Text = "FormReportOrderCustomer";
            this.Load += new System.EventHandler(this.FormReportOrderCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_order_detail_productBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource customer_order_detail_productBindingSource;
        private NorthwindDataSetTableAdapters.customer_order_detail_productTableAdapter customer_order_detail_productTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbDateFinal;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button btnResetFilter;
    }
}