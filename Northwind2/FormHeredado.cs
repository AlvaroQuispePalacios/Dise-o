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
    public partial class FormHeredado : FormReportBase
    {
        public FormHeredado()
        {
            InitializeComponent();
        }

        private void FormHeredado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.listados' Puede moverla o quitarla según sea necesario.
            this.listadosTableAdapter.Fill(this.northwindDataSet.listados);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.all_customers_orderDetails_orders_products' Puede moverla o quitarla según sea necesario.
            this.all_customers_orderDetails_orders_productsTableAdapter.Fill(this.northwindDataSet.all_customers_orderDetails_orders_products);
            this.listadosBindingSource.Filter = $"nombre_formulario = '{this.Name}'";
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = $"Northwind2.{cbReports.SelectedValue}";
            this.reportViewer1.RefreshReport();
        }
    }
}
