using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfesores formProfesores = new FormProfesores();
            formProfesores.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlumnos formAlumnos = new FormAlumnos();
            formAlumnos.ShowDialog();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotas formNotas = new FormNotas();
            formNotas.ShowDialog();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignaturas formAsignaturas = new FormAsignaturas();
            formAsignaturas.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Esto es para esconder botones
            try
            {
                SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=dbSistema;User id=alvaro;Password=alvaro;Trusted_Connection=True;TrustServerCertificate=True");
                conn.Open();
                string query = $"SELECT * FROM Restricciones WHERE usuario='{Global.userLogin}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var restriccion = reader["restriccion"].ToString();
                        foreach (Control item in flowLayoutPanelContenedor.Controls)
                        {
                            if (restriccion.Equals(item.Text))
                            {
                                item.Hide();
                            }
                        }
                    }
                }
                else
                {

                    //Muestra todas las opciones de manera normal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Esto es para esconder un menuTripItem
            //try
            //{
            //    SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=dbSistema;User id=alvaro;Password=alvaro;Trusted_Connection=True;TrustServerCertificate=True");
            //    conn.Open();
            //    string query = $"SELECT * FROM Restricciones WHERE usuario='{Global.userLogin}'";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            var restriccion = reader["restriccion"].ToString();
            //            foreach (ToolStripMenuItem item in menuStrip1.Items)
            //            {
            //                Console.WriteLine(item.Text);
            //                if (restriccion.Equals(item.Text))
            //                {
            //                    item.Visible = false;
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {

            //        //Muestra todas las opciones de manera normal
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
