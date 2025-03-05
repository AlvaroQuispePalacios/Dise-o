using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenHerencialAlvaroQuispe
{
    public partial class FormSuppliers : FormGestionBase
    {
        public FormSuppliers() : base(new BindingSource())
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);
        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            this.conectarBinding = suppliersBindingSource;
            OcultarPanelBot();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MostrarPanelBot();
            DeshabilitarBotonExceptoSeleccionado(this.btnEliminar.Text);
            MensajeBtnConfirmar("Eliminar Registro");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.suppliersBindingSource.AddNew();
            MostrarPanelBot();
            DeshabilitarBotonExceptoSeleccionado(this.btnAgregar.Text);
            MensajeBtnConfirmar("Agregar Registro");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MostrarPanelBot();
            DeshabilitarBotonExceptoSeleccionado(this.btnModificar.Text);
            MensajeBtnConfirmar("Modificar Registro");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.suppliersBindingSource.CancelEdit();
            OcultarPanelBot();
            HabilitarBotonesTop();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (btnConfirmar.Text.Equals("Agregar Registro"))
            {
                if (this.Validate())
                {
                    this.suppliersBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.northwindDataSet);
                }
            }
            else if (btnConfirmar.Text.Equals("Eliminar Registro"))
            {
                this.suppliersBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.northwindDataSet);

            }
            else if (btnConfirmar.Text.Equals("Modificar Registro"))
            {
                if (this.Validate())
                {
                    this.suppliersBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.northwindDataSet);
                }

            }
            OcultarPanelBot();
            HabilitarBotonesTop();
        }

        private void DeshabilitarBotonExceptoSeleccionado(string botonTexto)
        {
            foreach (Control item in panelTop.Controls)
            {
                if (!item.Text.Equals(botonTexto))
                {
                    item.Enabled = false;
                }
            }
        }

        private void HabilitarBotonesTop()
        {
            foreach (Control item in panelTop.Controls)
            {
                item.Enabled = true;
            }
        }

        private void MensajeBtnConfirmar(string mensaje)
        {
            btnConfirmar.Text = mensaje;
        }

        public void OcultarPanelBot()
        {
            this.panelBot.Hide();
        }

        private void MostrarPanelBot()
        {
            this.panelBot.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }

}
