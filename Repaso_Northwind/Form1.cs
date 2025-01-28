using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Northwind
{
    public partial class Form1 : Form
    {
        private Form formularioActivo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void reportOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormReportOrders());
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
            panelViewForm.Controls.Add(formularioHijo);
            panelViewForm.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }


    }
}
