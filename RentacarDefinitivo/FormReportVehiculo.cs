using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentacarDefinitivo
{
    public partial class FormReportVehiculo : Form
    {
        public FormReportVehiculo()
        {
            InitializeComponent();
        }


        private void FormReportVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.rentacarDataSet.vehiculo);

            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }
    }
}
