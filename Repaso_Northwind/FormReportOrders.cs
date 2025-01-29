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
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.customers_orders_orderDetails_products' Puede moverla o quitarla según sea necesario.
            this.customers_orders_orderDetails_productsTableAdapter.Fill(this.northwindDataSet.customers_orders_orderDetails_products);
            cbReports.Items.Add("ReportOrders");
            cbReports.Items.Add("ReportPrueba");
            cbReports.SelectedIndex = 0;
            SetTitle($"Historial Ordenes");
            cbCompanyName.SelectedIndex = -1;
            this.reportViewer1.RefreshReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = $"Repaso_Northwind.{cbReports.SelectedItem}.rdlc";
            customers_orders_orderDetails_productsBindingSource.RemoveFilter();

            //if (cbReports.SelectedItem.ToString().Equals("ReportOrders"))
            //{
                // Escapar apóstrofes en el texto ingresado
                string companyName = cbCompanyName.Text.Replace("'", "''");
                DateTime dateIni = dateTimePickerInicio.Value;
                DateTime dateFinal = dateTimePickerFinal.Value;
                customers_orders_orderDetails_productsBindingSource.Filter = $"CompanyName Like '%{companyName}%' AND OrderDate >= '{dateIni:yyyy-MM-dd}' AND OrderDate <= '{dateFinal:yyyy-MM-dd}'";
                SetTitle($"Historial Ordenes de {companyName}  {dateIni:yyyy-MM-dd} - {dateFinal:yyyy-MM-dd}");
                this.reportViewer1.RefreshReport();

            //}
            //else if(cbReports.SelectedItem.ToString().Equals("ReportPrueba"))
            //{
                //this.reportViewer1.RefreshReport();

            //}

        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            customers_orders_orderDetails_productsBindingSource.RemoveFilter();
            cbCompanyName.SelectedIndex = -1;
            SetTitle($"Historial Ordenes");

            this.reportViewer1.RefreshReport();
        }

        private void SetTitle(string title)
        {
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("titulo", title);
            reportViewer1.LocalReport.SetParameters(parametros);
            
        }
    }
}
