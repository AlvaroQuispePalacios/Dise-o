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
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void vehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentacarDataSet);

        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.modelo' Puede moverla o quitarla según sea necesario.
            this.modeloTableAdapter.Fill(this.rentacarDataSet.modelo);
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.lista_modelo_coches' Puede moverla o quitarla según sea necesario.
            this.lista_modelo_cochesTableAdapter.Fill(this.rentacarDataSet.lista_modelo_coches);
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.lista_marcas_coches' Puede moverla o quitarla según sea necesario.
            this.lista_marcas_cochesTableAdapter.Fill(this.rentacarDataSet.lista_marcas_coches);
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.lista_tipologia_coches' Puede moverla o quitarla según sea necesario.
            this.lista_tipologia_cochesTableAdapter.Fill(this.rentacarDataSet.lista_tipologia_coches);
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.rentacarDataSet.vehiculo);
            OcultarPanelBot();

        }

        private void btnIrAlPrimerRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveFirst();
        }

        private void btnRegistroPrevio_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MovePrevious();
        }

        private void btnRegistroSiguiente_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveNext();
        }

        private void btnIrAlUltimoRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveLast();
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            MensajeBtnConfirmar("Eliminar Registro");
            MostrarPanelBot();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.AddNew();
            MensajeBtnConfirmar("Agregar Registro");
            MostrarPanelBot();
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            MensajeBtnConfirmar("Modificar Registro");
            this.MostrarPanelBot();
        }


        private void OcultarPanelBot()
        {
            tableLayoutPanelBotContenedorBotones.Hide();
        }

        private void MostrarPanelBot()
        {
            tableLayoutPanelBotContenedorBotones.Visible = true;
        }

        private void MensajeBtnConfirmar(string mensaje)
        {
            btnConfirmar.Text = mensaje;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OcultarPanelBot();
            this.vehiculoBindingSource.CancelEdit();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(btnConfirmar.Text.Equals("Agregar Registro"))
            {
                if (this.Validate())
                {
                    this.vehiculoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.rentacarDataSet);
                }
            }else if(btnConfirmar.Text.Equals("Eliminar Registro"))
            {
                this.vehiculoBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.rentacarDataSet);

            }
            else if(btnConfirmar.Text.Equals("Modificar Registro"))
            {
                if (this.Validate()) {
                    this.vehiculoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.rentacarDataSet);
                }

            }

            OcultarPanelBot();
        }

    }
}
