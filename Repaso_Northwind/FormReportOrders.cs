using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Northwind
{
    public partial class FormReportOrders : Form
    {
        public FormReportOrders()
        {
            InitializeComponent();
        }

        private void FormReportOrders_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.customers_orders_orderDetails_products' Puede moverla o quitarla según sea necesario.
            this.customers_orders_orderDetails_productsTableAdapter.Fill(this.northwindDataSet.customers_orders_orderDetails_products);

            this.reportViewer1.RefreshReport();
        }
    }
}
