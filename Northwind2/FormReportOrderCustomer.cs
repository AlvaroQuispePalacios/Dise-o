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
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.customer_order_detail_product' Puede moverla o quitarla según sea necesario.
            this.customer_order_detail_productTableAdapter.Fill(this.northwindDataSet.customer_order_detail_product);
            this.reportViewer1.RefreshReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime dateIni = dateTimePicker1.Value;
            DateTime dateFinal = dateTimePicker2.Value;
            customer_order_detail_productBindingSource.Filter = $"CompanyName Like '%{cbCompanyName.Text}%' AND OrderDate >= '{dateIni:yyyy-MM-dd}' AND OrderDate <= '{dateFinal:yyyy-MM-dd}'";
            this.reportViewer1.RefreshReport();

        }
    }
}
