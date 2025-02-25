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

        public FormGestionTablaBase(BindingSource conectarBinding)
        {
            InitializeComponent();
            this.conectarBinding = conectarBinding;
        }



        public FormGestionTablaBase()
        {
            InitializeComponent();
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

            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {

        }
    }
}
