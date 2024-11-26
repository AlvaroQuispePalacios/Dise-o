using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar
{
    public partial class FormVehiculos : Form
    {
        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void vehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbRentacarDataSet);

        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbRentacarDataSet.tipologias' Puede moverla o quitarla según sea necesario.
            this.tipologiasTableAdapter.Fill(this.dbRentacarDataSet.tipologias);
            // TODO: esta línea de código carga datos en la tabla 'dbRentacarDataSet.vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.dbRentacarDataSet.vehiculo);
            OcultarPanelBot();
        }

        private void btnIrAlPrimerRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveFirst();
        }

        private void btnAnteriorRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MovePrevious();
        }

        private void btnSiguienteRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveNext();

        }

        private void btnIrAlUltimoRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveLast();

        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            LogicaBtnConfirmar("Eliminar Registro");
            MostrarPanelBot();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            LogicaBtnConfirmar("Agregar Registro");
            MostrarPanelBot();
            this.vehiculoBindingSource.AddNew();
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {

        }


        private void LogicaBtnConfirmar(string mensaje)
        {
            btnConfirmar.Text = mensaje;
        }

        private void MostrarPanelBot()
        {
            tableLayoutPanelContenedorBotBotones.Visible = true;
        }

        private void OcultarPanelBot()
        {
            tableLayoutPanelContenedorBotBotones.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.CancelEdit();
            OcultarPanelBot();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.btnConfirmar.Text.Equals("Agregar Registro"))
            {
                if (this.Validate())
                {
                    this.vehiculoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dbRentacarDataSet);
                }
            }
        }
    }
}
