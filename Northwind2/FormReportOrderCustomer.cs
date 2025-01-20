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
    public partial class FormReportOrderCustomer : Form
    {
        public FormReportOrderCustomer()
        {
            InitializeComponent();
        }

        private void FormReportOrderCustomer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.customer_order_detail_product' Puede moverla o quitarla según sea necesario.
            this.customer_order_detail_productTableAdapter.Fill(this.northwindDataSet.customer_order_detail_product);


            this.reportViewer1.RefreshReport();
        }
    }








    /*
SELECT * FROM Customers cu
INNER JOIN Orders ON Orders.CustomerID = cu.CustomerID
INNER JOIN [Order Details] ON [Order Details].OrderID = Orders.OrderID
INNER JOIN Products ON Products.ProductID = [Order Details].ProductID
     * 
     * 
     * REPORT
     * AGRUPAR por ORDERID
     * AGRUPAR POR ORDERDETAIL
     * 
     * 
        order - orderID
        order- orderDate

        cliente -nombre
        fechapedido
        clientecontacto

        nombreProducto
        cantidad de producto
        precioUNitario
        descuento


    companyNAme
    orderDate intervalo de fechas
     */
}
