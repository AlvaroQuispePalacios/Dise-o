using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Northwind2.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind2
{
    public partial class FormGestionTablaBase : FormBase
    {
        protected BindingSource conectarBinding;
        protected TableAdapterManager conectarTableAdapter;

        public FormGestionTablaBase(BindingSource conectarBinding, TableAdapterManager conectarTableAdapter)
        {
            InitializeComponent();
            this.conectarBinding = conectarBinding;
            this.conectarTableAdapter = conectarTableAdapter;
        }

        public FormGestionTablaBase()
        {
            InitializeComponent();
        }

        private void FormGestionTablaBase_Load(object sender, EventArgs e)
        {
            OcultarPanelBot();
        }

        private void btnIrAlPrimero_Click(object sender, EventArgs e)
        {
            if(conectarBinding != null)
            {
                this.conectarBinding.MoveFirst();

            }
        }

        private void btnIrAlAnterior_Click(object sender, EventArgs e)
        {
            if (conectarBinding != null)
            {
                this.conectarBinding.MovePrevious();

            }
        }

        private void btnIrAlSiguiente_Click(object sender, EventArgs e)
        {
            if (conectarBinding != null)
            {
                this.conectarBinding.MoveNext();

            }
        }

        private void btnIrAlUltimo_Click(object sender, EventArgs e)
        {
            if (conectarBinding != null)
            {
                this.conectarBinding.MoveLast();

            }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            if(conectarBinding != null)
            {
                DeshabilitarBotonExceptoSeleccionado(btnAgregarRegistro.Text);
                MostrarPanelBot();
                this.conectarBinding.AddNew();
                MensajeBtnConfirmar("Agregar Registro");
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            DeshabilitarBotonExceptoSeleccionado(btnEliminarRegistro.Text);
            MostrarPanelBot();
            MensajeBtnConfirmar("Eliminar Registro");

        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            DeshabilitarBotonExceptoSeleccionado(btnModificarRegistro.Text);
            MostrarPanelBot();
            MensajeBtnConfirmar("Modificar Registro");

        }

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            this.conectarBinding.CancelEdit();
            HabilitarBotonesTop();
            OcultarPanelBot();
        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {
  
            if (btnAceptarCambios.Text.Equals("Agregar Registro"))
            {
                if (this.Validate())
                {
                    this.conectarBinding.EndEdit();
                    //this.tableAdapterManager.UpdateAll(this.northwindDataSet);
                }
            }
            else if (btnAceptarCambios.Text.Equals("Eliminar Registro"))
            {
                this.conectarBinding.RemoveCurrent();
                //this.tableAdapterManager.UpdateAll(this.northwindDataSet);

            }
            else if (btnAceptarCambios.Text.Equals("Modificar Registro"))
            {
                if (this.Validate())
                {
                    this.conectarBinding.EndEdit();
                    //this.tableAdapterManager.UpdateAll(this.northwindDataSet);
                }

            }
            else
            {
                Console.WriteLine("Algo paso en el bntAceptarCambios");
            }
            HabilitarBotonesTop();
            OcultarPanelBot();
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

        public void OcultarPanelBot()
        {
            this.panelBot.Hide();
        }

        private void MostrarPanelBot()
        {
            this.panelBot.Visible = true;
        }

        private void MensajeBtnConfirmar(string mensaje)
        {
            btnAceptarCambios.Text = mensaje;
        }
    }
}
