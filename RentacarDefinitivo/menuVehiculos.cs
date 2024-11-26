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

        //private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.vehicleBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.rentacarDataSet);
        //    OcultarBotonesValidarCancelar();
        //}

        private void menuVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet1.lista_tipologia_coches' Puede moverla o quitarla según sea necesario.
            this.lista_tipologia_cochesTableAdapter.Fill(this.rentacarDataSet1.lista_tipologia_coches);
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet1.lista_modelo_coches' Puede moverla o quitarla según sea necesario.
            this.lista_modelo_cochesTableAdapter.Fill(this.rentacarDataSet1.lista_modelo_coches);
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet1.lista_marcas_coches' Puede moverla o quitarla según sea necesario.
            this.lista_marcas_cochesTableAdapter.Fill(this.rentacarDataSet1.lista_marcas_coches);

            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet1.modelo' Puede moverla o quitarla según sea necesario.
            //this.modeloTableAdapter.Fill(this.rentacarDataSet1.modelo);

            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.vehicle_modelo' Puede moverla o quitarla según sea necesario.
            this.vehicle_modeloTableAdapter.Fill(this.rentacarDataSet.vehicle_modelo);


            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.vehicle' Puede moverla o quitarla según sea necesario.
            //this.vehicleTableAdapter.Fill(this.rentacarDataSet.vehicle);

            OcultarBotonesValidarCancelar();

            // Si la tabla vehiculos no tiene filas solo estara habilitado el boton de agregarRegistro
            //if(this.vehicleDataGridView.RowCount <= 0)
            //{
            //    DeshabilitarBotonesDelPanelTopExceptoSeleccionado(btnAgregarRegistro.Text);
            //}
        }

        private void btnIrAlPrimerRegistro_Click(object sender, EventArgs e)
        {
            //this.vehicleBindingSource.MoveFirst();
            this.vehicle_modeloBindingSource6.MoveFirst();
        }

        private void btnIrAlAnteriorRegistro_Click(object sender, EventArgs e)
        {
            //this.vehicleBindingSource.MovePrevious();
            this.vehicle_modeloBindingSource6.MovePrevious();

        }

        private void btnIrAlSiguienteRegistro_Click(object sender, EventArgs e)
        {
            //this.vehicleBindingSource.MoveNext();
            this.vehicle_modeloBindingSource6.MoveNext();
        }

        private void btnIrAlUltimoRegistro_Click(object sender, EventArgs e)
        {
            //this.vehicleBindingSource.MoveLast();
            this.vehicle_modeloBindingSource6.MoveLast();

        }

        // ------------------------------------------------------------------------

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            DeshabilitarBotonesDelPanelTopExceptoSeleccionado(btnAgregarRegistro.Text);
            //this.vehicleBindingSource.AddNew();
            this.vehicle_modeloBindingSource6.AddNew();
            MostrarBotonesValidarCancelar("Crear Nuevo Registro");
        }

        private void btnSeleccionarRegistroParaEliminar_Click(object sender, EventArgs e)
        {
            DeshabilitarBotonesDelPanelTopExceptoSeleccionado(btnSeleccionarRegistroParaEliminar.Text);
            MostrarBotonesValidarCancelar("Eliminar Registro");
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            DeshabilitarBotonesDelPanelTopExceptoSeleccionado(btnModificarRegistro.Text);
            MostrarBotonesValidarCancelar("Modificar Registro");
        }

        private void btnValidarRegistro_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item.Text.Equals("Crear Nuevo Registro"))
                {
                    if (this.Validate())
                    {
                        //this.vehicleBindingSource.EndEdit();
                        this.vehicle_modeloBindingSource6.EndEdit();
                        //this.tableAdapterManager.UpdateAll(this.rentacarDataSet);
                        this.tableAdapterManager.UpdateAll(this.rentacarDataSet1);
                    }
                }
                else if (item.Text.Equals("Eliminar Registro"))
                {
                    //this.vehicleBindingSource.RemoveCurrent();
                    this.vehicle_modeloBindingSource6.RemoveCurrent();
                    //this.tableAdapterManager.UpdateAll(this.rentacarDataSet);
                    this.tableAdapterManager.UpdateAll(this.rentacarDataSet1);

                }
                else if (item.Text.Equals("Modificar Registro"))
                {
                    // Luego que Modelo sea una tabla aparte que este relacionado con los vehiculos 
                    // La tabla de modelo tendra Marca, Modelo, Tipologia y Eliminamos estos atributos de la tabla vehicle
                    // Hacer un combo box para elegir 
                    if (this.Validate())
                    {
                        //this.vehicleBindingSource.EndEdit();
                        this.vehicle_modeloBindingSource6.EndEdit();
                        //this.tableAdapterManager.UpdateAll(this.rentacarDataSet);
                        this.tableAdapterManager.UpdateAll(this.rentacarDataSet1);

                    }


                }
            }
            OcultarBotonesValidarCancelar();
            HabilitarBotonesPanelTop();
        }

        private void btnCancelarValidarRegistro_Click(object sender, EventArgs e)
        {
            //this.vehicleBindingSource.CancelEdit();
            this.vehicle_modeloBindingSource6.CancelEdit();
            OcultarBotonesValidarCancelar();
            HabilitarBotonesPanelTop();
        }

        // ------------------------------- H ------------------------------------
        private void OcultarBotonesValidarCancelar()
        {
            btnValidarRegistro.Hide();
            btnCancelarValidarRegistro.Hide();
        }

        private void MostrarBotonesValidarCancelar(String MensajeBtnValidar = "Validar")
        {
            btnValidarRegistro.Text = MensajeBtnValidar;
            btnValidarRegistro.Visible = true;
            btnCancelarValidarRegistro.Visible = true;
        }

        // Deshabilita los botones del panel top cuando presionas encima de agregar, eliminar o modificar
        private void DeshabilitarBotonesDelPanelTopExceptoSeleccionado(String botonText)
        {
            foreach(Control item in tableLayoutPanel2.Controls)
            {
                if (!item.Text.Equals(botonText))
                {
                    item.Enabled = false;
                    // 
                    //item.MouseHover(Cursors.No);
                }
            }
        }

        private void HabilitarBotonesPanelTop()
        {
            foreach (Control item in tableLayoutPanel2.Controls)
            {
                item.Enabled = true;
            }
        }

        // Tipologia
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.
            //this.vehicle_modeloBindingSource6.Filter = $"tipologia = '{comboBox3.Text}'";
        }

        //Marca
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.vehicle_modeloBindingSource6.Filter);
            //this.modeloBindingSource.Filter = $"tipologia='{comboBox3.Text} AND '";
        }


    }
}
