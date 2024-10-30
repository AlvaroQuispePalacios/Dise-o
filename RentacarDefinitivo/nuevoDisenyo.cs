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
        public nuevoDisenyo()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
            //if(this.panelContenedor.Controls.Count > 0)
                //{
                //this.panelContenedor.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            //}
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new menuCargos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new menuCargos());

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
