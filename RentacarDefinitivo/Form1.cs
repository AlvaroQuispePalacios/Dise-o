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

namespace RentacarDefinitivo
{
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {            
            InitializeComponent();
        }

        private void carrecsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuCargos menuCargos = new menuCargos();
            menuCargos.ShowDialog();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuClientes mnClientes = new menuClientes();
            mnClientes.ShowDialog();
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menuVehiculos mnVehiculos = new menuVehiculos();
            //mnVehiculos.ShowDialog();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuReserva mnReserva = new menuReserva();
            mnReserva.ShowDialog();
        }

        private void contracteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuContrato mnContrato = new menuContrato();
            mnContrato.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("¿Estas seguro que deseas salir?", "Estas saliendo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            string usuario = Global.userLogin;
            try
            {
                SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=rentacar;User id=usuarioRentacar;Password=rentacar;Trusted_Connection=True;TrustServerCertificate=True");
                conn.Open();
                string sql = $"SELECT * FROM restricciones WHERE nombre_usuario='{usuario}'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0)) { 
                            string restriccion = reader.GetString(1);
                            foreach (ToolStripMenuItem item in menuStrip1.Items) {
                                Console.WriteLine(item.Text);
                                if (restriccion.Equals(item.Text)) {
                                    item.Visible = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Algo fallo en la conexion");

            }
        }
    }
}
