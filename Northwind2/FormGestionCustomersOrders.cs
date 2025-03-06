using Northwind2.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind2
{
    public partial class FormGestionCustomersOrders : FormGestionTablaBase
    {
        public FormGestionCustomersOrders()
         : base(new BindingSource(), new TableAdapterManager()) // Se pasa también TableAdapterManager
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FormGestionCustomersOrders_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.CustomerCustomerDemo' Puede moverla o quitarla según sea necesario.
            this.customerCustomerDemoTableAdapter.Fill(this.northwindDataSet.CustomerCustomerDemo);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            this.conectarBinding = customersBindingSource;

            ordersBindingSource.DataSource = customersBindingSource;
            ordersBindingSource.DataMember = "FK_Orders_Customers";

            customerCustomerDemoBindingSource.DataSource = customersBindingSource;
            customerCustomerDemoBindingSource.DataMember = "FK_CustomerCustomerDemo_Customers";
        }

        private void btnIrAlPrimero_Click(object sender, EventArgs e)
        {
            
        }
    }
}
