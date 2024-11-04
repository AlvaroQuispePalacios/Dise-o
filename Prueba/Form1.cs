using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        //Guardamos el formulario activo en el panel para que cuando presionemos un boton para mostrar otro formulario se cierre el anterior y no se pongan uno encima de otro
        private Form formularioActivo = null;

        public Form1()
        {
            InitializeComponent();
            lblMostrarNombreUsuario.Text = Global.userLogin;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarRestaurar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizarRestaurar.Text = "C";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizarRestaurar.Text = "c";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrarFormProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormProfesores());
        }

        private void btnMostrarFormAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormAlumnos());
        }

        private void btnMostrarNotas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormNotas());
        }

        private void btnMostrarFormAsignaturas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormAsignaturas());

        }

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo; // Asigna el formulario hijo actual
            formularioHijo.TopLevel = false; // Para que el formulario se comporte como un control
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
            formularioHijo.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del panel
            panelContenedorFormularioHijo.Controls.Add(formularioHijo); // Agrega el formulario al panel
            panelContenedorFormularioHijo.Tag = formularioHijo; // Asigna el formulario como tag del panel
            formularioHijo.BringToFront(); // Lleva el formulario al frente
            formularioHijo.Show(); // Muestra el formulario

        }


    }
}
