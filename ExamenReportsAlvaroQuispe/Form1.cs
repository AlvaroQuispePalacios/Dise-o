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

namespace ExamenReportsAlvaroQuispe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Territories' Puede moverla o quitarla según sea necesario.
            this.territoriesTableAdapter.Fill(this.northwindDataSet.Territories);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Region' Puede moverla o quitarla según sea necesario.
            this.regionTableAdapter.Fill(this.northwindDataSet.Region);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.View_Employees_Territories_Region' Puede moverla o quitarla según sea necesario.
            this.view_Employees_Territories_RegionTableAdapter.Fill(this.northwindDataSet.View_Employees_Territories_Region);
            setTitle("LISTADO DE EMPLEADOS POR REGION Y TERRITORIO");
            
            cbListado.Items.Add("ReportEmpleadosRegion");
            cbListado.Items.Add("ReportEmpleadosTerritorioRegion");
            cbListado.SelectedIndex = 0;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = $"ExamenReportsAlvaroQuispe.{cbListado.SelectedItem}.rdlc";

            if (cbListado.SelectedItem.Equals("ReportEmpleadosTerritorioRegion"))
            {
                setTitle("LISTADO DE EMPLADOS POR TERRITORIO Y REGION");
            }else if (cbListado.SelectedItem.Equals("ReportEmpleadosRegion")){
                setTitle("LISTADO DE EMPLEADOS POR REGION Y TERRITORIO");
            }

            if (tbPais.Equals("*") || tbCiudad.Equals("*"))
            {
                view_Employees_Territories_RegionBindingSource.Filter = $"RegionDescription Like '%{cbRegion.Text}%' AND TerritoryDescription Like '%{cbTerritorio.Text}%' AND Country Like '%%' AND City Like '%%'";
                this.reportViewer1.RefreshReport();
                return;
            }


            view_Employees_Territories_RegionBindingSource.Filter = $"RegionDescription Like '%{cbRegion.Text}%' AND TerritoryDescription Like '%{cbTerritorio.Text}%' AND Country Like '%{tbPais.Text}%' AND City Like '%{tbCiudad.Text}%'";
            this.reportViewer1.RefreshReport();

        }

        private void setTitle(String title)
        {

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("titulo", title);
            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            view_Employees_Territories_RegionBindingSource.RemoveFilter();
            this.reportViewer1.RefreshReport();

        }
    }
}
