using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class FormReportCustomer : Form
    {
        public FormReportCustomer()
        {
            InitializeComponent();
        }

        private void FormReportCustomer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            this.reportViewer1.RefreshReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            customersBindingSource.Filter = $"Country Like '%{tbCountry.Text}%'";
            this.reportViewer1.RefreshReport();

            String titulo = "Lista de clientes";
            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("titulo", titulo);
            //reportViewer1.LocalReport.SetParameters(parametros);
        }
    }
}
