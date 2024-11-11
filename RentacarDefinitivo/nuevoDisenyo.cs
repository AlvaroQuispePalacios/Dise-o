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
    public partial class nuevoDisenyo : Form
    {
        private Form formularioActivo = null;
        public nuevoDisenyo()
        {
            InitializeComponent();
        }

        private void nuevoDisenyo_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

  

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Tiene todo
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirFormHijo(Form formularioHijo)
        {
            if(formularioActivo != null)
            {
                formularioActivo = null;
            }
            formularioActivo = formularioHijo;
            //Form fh = formhijo as Form;
            //fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            //this.panelContenedorFormularioHijo.Controls.Add(fh);
            //this.panelContenedorFormularioHijo.Tag = fh;
            //fh.Show();

            formularioActivo = formularioHijo; // Asigna el formulario hijo actual
            formularioHijo.TopLevel = false; // Para que el formulario se comporte como un control
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
            formularioHijo.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del panel
            panelContenedorFormularioHijo.Controls.Add(formularioHijo); // Agrega el formulario al panel
            panelContenedorFormularioHijo.Tag = formularioHijo; // Asigna el formulario como tag del panel
            formularioHijo.BringToFront(); // Lleva el formulario al frente
            formularioHijo.Show(); // Muestra el formulario

        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new menuCargos());
        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMostrarFormClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarFormVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new menuVehiculos()); 
        }
    }
}
