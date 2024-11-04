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

namespace Prueba
{
    public partial class formLogin : Form
    {
        int intentos = 0;
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnValidarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tbNombre.Text;
            string pwd = tbPwd.Text;

            SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=dbSistema;User id=alvaro;Password=alvaro;Trusted_Connection=True;TrustServerCertificate=True");
            conn.Open();
            string query = $"SELECT * FROM Profesores WHERE usuario='{nombreUsuario}' AND pwd='{pwd}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();


            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var nombreProfesor = reader["nombre"].ToString();
                        var apellidoProfesor = reader["primer_apellido"].ToString();
                        var bloqueado = Convert.ToBoolean(reader["bloqueado"]);

                        if (!bloqueado)
                        {
                            Global.userLogin = $"{nombreProfesor} {apellidoProfesor}";
                            DialogResult = DialogResult.OK;
                            MessageBox.Show($"Bienvenido {nombreProfesor} {apellidoProfesor}");
                        }
                        else
                        {
                            MessageBox.Show("El usuario esta bloqueado contactar con el administrador");
                        }
                    }
                }
                else
                {
                    reader.Close();
                    intentos++;
                    if (intentos == 3)
                    {
                        string query2 = $"UPDATE Profesores SET bloqueado='True' WHERE usuario='{nombreUsuario}'";
                        SqlCommand bloqueado = new SqlCommand(query2, conn);
                        bloqueado.ExecuteReader();
                    }
                    if(intentos > 3)
                    {
                        MessageBox.Show("El usuario esta bloqueado contactar con el administrador");
                    }
          
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al conectarse a la base de datos {ex.Message}");
            }

        }
    }
}
