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
    public partial class FormAsignaturas : Form
    {
        public FormAsignaturas()
        {
            InitializeComponent();
        }

        private void asignaturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.asignaturasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notasDataSet);

        }

        private void FormAsignaturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'notasDataSet.Asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.notasDataSet.Asignaturas);

        }
    }
}
