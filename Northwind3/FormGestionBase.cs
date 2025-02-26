using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind3
{
    public partial class FormGestionBase : FormBase
    {
        protected BindingSource myBindingSource;
        public FormGestionBase(BindingSource bindingSource)
        {
            InitializeComponent();
            this.myBindingSource = bindingSource;
        }

        public FormGestionBase()
        {
            InitializeComponent();
        }

        private void btnIrAlPrimero_Click(object sender, EventArgs e)
        {
            if(myBindingSource != null)
            {
                this.myBindingSource.MoveFirst();
            }
        }

        private void btnIrAlAnterior_Click(object sender, EventArgs e)
        {
            if (myBindingSource != null)
            {
                this.myBindingSource.MovePrevious();
            }
        }

        private void btnIrAlSiguiente_Click(object sender, EventArgs e)
        {
            if (myBindingSource != null)
            {
                this.myBindingSource.MoveNext();
            }
        }

        private void btnIrAlUltimo_Click(object sender, EventArgs e)
        {
            if (myBindingSource != null)
            {
                this.myBindingSource.MoveLast();
            }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
