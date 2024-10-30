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
    public partial class login : Form
    {
        int numIntentos = 0;
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string password = tbPassword.Text;


            try
            {
                SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=rentacar;User id=usuarioRentacar;Password=rentacar;Trusted_Connection=True;TrustServerCertificate=True");
                conn.Open();
                string sql = $"SELECT * FROM usuario WHERE nombre_usuario='{usuario}' AND pwd_usuario='{password}'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if(reader.GetBoolean(4).ToString() != "True")
                    {
                        Global.userLogin = usuario;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    numIntentos++;
                    MessageBox.Show(numIntentos + "a");
                    if (numIntentos == 3)
                    {
                        reader.Close();
                        String sql2 = $"UPDATE usuario SET bloq__usuario='True' WHERE nombre_usuario='{usuario}'";
                        SqlCommand cmd2 = new SqlCommand(sql2, conn);
                        cmd2.ExecuteReader();
                        MessageBox.Show("El usuario ha sido bloqueado contactar con el admin");
                    }

                    if (numIntentos > 3)
                    {
                        MessageBox.Show("El usuario ha sido bloqueado contactar con el admin");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("La conexion ha fallado");

            }

        }
    }
}
