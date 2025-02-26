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
            panelContenedorForm.Controls.Add(formularioHijo);
            panelContenedorForm.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void gestionCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormGestionCustomers());
        }

        private void reportCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormReportCustomers());

        }
    }
}
