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
        private Form formActivo = null;
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
            this.WindowState=FormWindowState.Maximized;
        }

  

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Tiene todo
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirFormHijo(object formhijo)
        {
            if(formActivo != null)
            {
                formActivo = null;
            }
            formActivo = formActivo;
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            
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
    }
}
