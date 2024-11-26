using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar
{
    public partial class Form1 : Form
    {
        Form formularioActivo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarFormVehiculos_Click(object sender, EventArgs e)
        {
            MostrarFormularioHijo(new FormVehiculos());
        }

        private void MostrarFormularioHijo(Form formularioHijo)
        {
            if(formularioActivo != null)
            {
                formularioActivo = null;
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false; // Para que el formulario se comporte como un control
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
            formularioHijo.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del panel
            panelContenedorHijo.Controls.Add(formularioHijo); // Agrega el formulario al panel
            panelContenedorHijo.Tag = formularioHijo; // Asigna el formulario como tag del panel
            formularioHijo.BringToFront(); // Lleva el formulario al frente
            formularioHijo.Show(); // Muestra el formulario
        } 
    }
}
