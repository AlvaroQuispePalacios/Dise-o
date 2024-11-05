using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace sistema_de_notas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnValidarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string pwd = tbPwd.Text;
            try
            {
                SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=notas;User id=usuarionotas;Password=notas;Trusted_Connection=True;TrustServerCertificate=True");
                conn.Open();
                string query = $"SELECT * FROM Profesores WHERE usuario='{usuario}' AND pwd='{pwd}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var nombre = reader["nombre"].ToString();
                        var primerApellido = reader["primer_apellido"].ToString();
                        Global.usrLogin = $"{nombre} {primerApellido}";
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
