using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_notas
{

    public partial class Form1 : Form
    {
        private Form formActivo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {
            MostrarFormHijo(new FormAlumnos());
        }

        private void btnMostrarNotas_Click(object sender, EventArgs e)
        {
            MostrarFormHijo(new FormNotas());
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            MostrarFormHijo(new FormAsignaturas());
        }

        private void btnViewNAA_Click(object sender, EventArgs e)
        {
            MostrarFormHijo(new FormViewNotasAsignaturasAlumnos());
        }

        public void MostrarFormHijo(Form formHijo)
        {
            if(formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            panelContenedorFormHijo.Controls.Add(formHijo);
            panelContenedorFormHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }


    }
}
