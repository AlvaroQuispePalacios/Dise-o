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
            this.northwindDataSet = new Northwind2.NorthwindDataSet();
            this.all_customers_orderDetails_orders_productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_customers_orderDetails_orders_productsTableAdapter = new Northwind2.NorthwindDataSetTableAdapters.all_customers_orderDetails_orders_productsTableAdapter();
            this.tableAdapterManager = new Northwind2.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.listadosTableAdapter = new Northwind2.NorthwindDataSetTableAdapters.listadosTableAdapter();
            this.listadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_customers_orderDetails_orders_productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(859, 91);
            // 
            // panelViewReport
            // 
            this.panelViewReport.Size = new System.Drawing.Size(859, 359);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 12);
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
            this.tableAdapterManager.CustomerCustomerDemoTableAdapter = null;
            this.tableAdapterManager.CustomerDemographicsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.EmployeeTerritoriesTableAdapter = null;
            this.tableAdapterManager.listadosTableAdapter = this.listadosTableAdapter;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.TerritoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Northwind2.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listadosTableAdapter
            // 
            this.listadosTableAdapter.ClearBeforeFill = true;
            // 
            // listadosBindingSource
            // 
            this.listadosBindingSource.DataMember = "listados";
            this.listadosBindingSource.DataSource = this.northwindDataSet;
            // 
            // FormHeredado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Name = "FormHeredado";
            this.Text = "FormHeredado";
            this.Load += new System.EventHandler(this.FormHeredado_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_customers_orderDetails_orders_productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource all_customers_orderDetails_orders_productsBindingSource;
        private NorthwindDataSetTableAdapters.all_customers_orderDetails_orders_productsTableAdapter all_customers_orderDetails_orders_productsTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NorthwindDataSetTableAdapters.listadosTableAdapter listadosTableAdapter;
        private System.Windows.Forms.BindingSource listadosBindingSource;
    }
}