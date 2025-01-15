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

     */
}
