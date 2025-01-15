using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind2
{
    public partial class Form1 : Form
    {
        private Form formularioActivo = null;

        public Form1()
        {
            InitializeComponent();
        }

        public void AbrirFormHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo = null;
            }
            formularioActivo = formularioHijo;


            formularioActivo = formularioHijo; 
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None; 
            formularioHijo.Dock = DockStyle.Fill; 
            panelContainer.Controls.Add(formularioHijo); 
            panelContainer.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show(); 

        }
        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormReportCustomer());
        }

        private void reporteOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormReportOrderCustomer());

        }
    }
}
