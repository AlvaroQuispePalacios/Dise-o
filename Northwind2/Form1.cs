﻿using System;
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

        private void reportesPorAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormMultiplesReports());

        }

        private void formularioHeredadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormHeredado());
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormGestionCustomers());
        }

        private void gestiónEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormLogin());
        }

        public void cargarRestricciones() {
            try
            {
                

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }

        private void gestionProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormGestionProducts());
        }

        private void gestionCustomersOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormGestionCustomersOrders());

        }
    }
}
