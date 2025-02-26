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

    public partial class FormGestionBase : FormBase
    {
        protected BindingSource conectarBinding;

        public FormGestionBase(BindingSource conectarBinding)
        {
            InitializeComponent();
            this.conectarBinding = conectarBinding;

        }
        public FormGestionBase()
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

        private void btnIrAlSiquiente_Click(object sender, EventArgs e)
        {
            if (conectarBinding != null)
            {
                this.conectarBinding.MoveNext();

            }

        }

        private void btnIrAlFinal_Click(object sender, EventArgs e)
        {
            if (conectarBinding != null)
            {
                this.conectarBinding.MoveLast();

            }
        }
    }
}
