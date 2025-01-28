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

namespace Northwind2
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

            //String titulo = $"Lista de clientes";
            //ReportParameter[] parametros = new ReportParameter[1];
            //parametros[0] = new ReportParameter("Titulo", titulo);
            //reportViewer1.LocalReport.SetParameters(parametros);

            this.reportViewer1.RefreshReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            customersBindingSource.Filter = $"Country Like '%{tbCountry.Text}%' AND City Like '%{tbCity.Text}%'";

            String titulo = $"Lista de clientes {tbCountry.Text} - {tbCity.Text}";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Titulo", titulo);
            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();

        }
    }
}



/**
 * Hacer una tabla listados
 * id
 * FornName
 * Nombre del report 
 * Vista o tabla asociada (Nombre)
 * Descripcion
 */
