using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_notas
{
    public partial class FormNotas : Form
    {
        public FormNotas()
        {
            InitializeComponent();
        }

        private void notasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notasDataSet);

        }

        private void FormNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'notasDataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.notasDataSet.Notas);

        }
    }
}
