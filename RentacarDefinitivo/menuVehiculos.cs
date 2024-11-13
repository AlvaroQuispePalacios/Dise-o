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
    public partial class menuVehiculos : Form
    {
        public menuVehiculos()
        {
            InitializeComponent();
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentacarDataSet);

        }

        private void menuVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.vehicle' Puede moverla o quitarla según sea necesario.
            this.vehicleTableAdapter.Fill(this.rentacarDataSet.vehicle);

        }

        private void btnIrAlPrimerRegistro_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveFirst();
        }

        private void btnIrAlAnteriorRegistro_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MovePrevious();
        }

        private void btnIrAlSiguienteRegistro_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveNext();
        }

        private void btnIrAlUltimoRegistro_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.MoveLast();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.AddNew();


        }

        private void btnValidarRegistro_Click(object sender, EventArgs e)
        {
            this.Validate();

            //this.vehicleBindingSource.EndEdit();
            //foreach(var item in this.vehicleBindingSource.List)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //MessageBox.Show(vehicleBindingSource.List);
            //string matricula = tbMatricula.Text;
            //string tipologia = tbTipologia.Text;
            //string marca = tbMarca.Text;
            //string modelo = tbModelo.Text;
            //string color = tbColor.Text;
            //this.vehicleDataGridView.Rows.Add(new object[] {
            //   matricula, tipologia, marca, modelo, color
            //});
        }
    }
}
