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
    public partial class FormMultiplesReports : Form
    {
        public FormMultiplesReports()
        {
            InitializeComponent();
        }

        private void FormMultiplesReports_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.all_customers_orderDetails_orders_products' Puede moverla o quitarla según sea necesario.
            this.all_customers_orderDetails_orders_productsTableAdapter.Fill(this.northwindDataSet.all_customers_orderDetails_orders_products);
            cbYear.Items.Add("ReportOrder1996");
            cbYear.Items.Add("ReportPrueba");

            this.reportViewer1.RefreshReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = $"Northwind2.{cbYear.SelectedItem}.rdlc";
            this.reportViewer1.RefreshReport();

            // Falta filtro

            //if (cbYear.Equals("ReportOrder1996"))
            //{
            //    DateTime date = new DateTime(1997, 1, 1);
            //    this.reportViewer1.LocalReport.ReportEmbeddedResource = $"Northwind2.{cbYear.SelectedItem}.rdlc";
            //    all_customers_orderDetails_orders_productsBindingSource.Filter = $"OrderDate <= '{date:yyyy-MM-dd}'";
            //}
            //else if(cbYear.Text == "ReportPrueba")
            //{
            //    this.reportViewer1.LocalReport.ReportEmbeddedResource = $"Northwind2.{cbYear.Text}.rdlc";

            //}

            //this.reportViewer1.RefreshReport();
        }
    }
}
