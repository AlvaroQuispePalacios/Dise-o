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
    public partial class menuContrato : Form
    {
        public menuContrato()
        {
            InitializeComponent();
        }

        private void contracteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contracteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentacarDataSet);

        }

        private void menuContrato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rentacarDataSet.contracte' Puede moverla o quitarla según sea necesario.
            this.contracteTableAdapter.Fill(this.rentacarDataSet.contracte);

        }
    }
}
