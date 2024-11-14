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
            OcultarBotonesValidarCancelar();
        }

        private void menuVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.vehicle' Puede moverla o quitarla según sea necesario.
            this.vehicleTableAdapter.Fill(this.rentacarDataSet.vehicle);
            btnValidarRegistro.Hide();
            btnCancelarValidarRegistro.Hide();
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

        // ------------------------------------------------------------------------

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.AddNew();
            btnValidarRegistro.Text = "Crear Nuevo Registro";
            btnCancelarValidarRegistro.Text = "Cancelar";
            MostrarBotonesValidarCancelar();
        }

        private void btnSeleccionarRegistroParaEliminar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnValidarRegistro_Click(object sender, EventArgs e)
        {
            foreach (Control item in panelTopFormVehiculos.Controls)
            {
                switch (item.Text)
                {
                    case "+":
                        if (this.Validate())
                        {
                            this.vehicleBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.rentacarDataSet);
                        }
                        else
                        {
                            this.Validate();
                            MessageBox.Show("D:");
                        }
                }

                //if (item.Text == "+")
                //{
                //    if (this.Validate())
                //    {
                //        this.vehicleBindingSource.EndEdit();
                //        this.tableAdapterManager.UpdateAll(this.rentacarDataSet);
                //    }
                //    else
                //    {
                //        this.Validate();
                //        MessageBox.Show("D:");
                //    }
                //}
            }
            // Cuando presionas dos veces Agregar registro explota 
            // Cuando intentas agregar un registro sin datos explota (LA TABLA NECESITA PRIMARY KEY)


        }

        private void btnCancelarValidarRegistro_Click(object sender, EventArgs e)
        {
            foreach(Control item in panelTopFormVehiculos.Controls)
            {
                if(item.Text == "+")
                {

                }
            }
     

            this.vehicleBindingSource.Remove();

            this.vehicleBindingSource.CancelEdit();
            OcultarBotonesValidarCancelar();
        }

        private void OcultarBotonesValidarCancelar()
        {
            btnValidarRegistro.Hide();
            btnCancelarValidarRegistro.Hide();
        }

        private void MostrarBotonesValidarCancelar()
        {
            btnValidarRegistro.Visible = true;
            btnCancelarValidarRegistro.Visible = true;
        }

 
    }
}
