using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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

namespace Northwind2
{
    public partial class FormLogin : FormBase
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnValidarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                String query = $"SELECT * FROM NCLusuario WHERE nombre_usuario = '{tbUsuario.Text}' AND pwd_usuario = '{tbPwd.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Boolean estaUsuarioBloqueado = false;

                    while (reader.Read())
                    {
                        estaUsuarioBloqueado = Convert.ToBoolean(reader["bloqueado"]);
                    }
                    reader.Close();

                    if (!estaUsuarioBloqueado)
                    {
                        // Insertar en la tabla de sesion el intento exitoso
                        insertarIntentoSesion(conn, tbUsuario.Text, true);
                        Global.userLogin = tbUsuario.Text;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Console.WriteLine("El usuario esta bloqueado");
                    }
                }
                else
                {
                    // Comprobamos que el usuario exista para poder insertar en la tabla de sesiones los intentos y bloquear la cuenta si es necesario
                    reader.Close();

                    query = $"SELECT * FROM NCLusuario WHERE nombre_usuario = '{tbUsuario.Text}'";
                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Boolean estaUsuarioBloqueado = false;

                        while (reader.Read())
                        {
                            estaUsuarioBloqueado = Convert.ToBoolean(reader["bloqueado"]);
                        }
                        reader.Close();

                        if (!estaUsuarioBloqueado)
                        {
                            insertarIntentoSesion(conn, tbUsuario.Text, false);
                            int resultado = VerificarNumeroIntentos(conn, tbUsuario.Text);
                            if (resultado == 1)
                            {
                                BloquearUsuario(conn, tbUsuario.Text);
                            }
                        }
                        else
                        {
                            Console.WriteLine("El usuario esta bloqueado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void BloquearUsuario(SqlConnection conn, string nombreUsuario)
        {
            using (SqlCommand cmd = new SqlCommand("BloquearUsuario", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        public static void insertarIntentoSesion(SqlConnection conn, string usuario, bool estado)
        {
            using (SqlCommand cmd = new SqlCommand("InsertarIntentoSesion", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreUsuario", usuario);
                cmd.Parameters.AddWithValue("@intentoEstado", estado);
                cmd.ExecuteNonQuery();
            }
        }

        public static int VerificarNumeroIntentos(SqlConnection conn, String nombreUsuario)
        {
            string query = "SELECT dbo.VerificarIntento(@nombreUsuario)";
            int resultadoFinal = -1;

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                var resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    resultadoFinal = Convert.ToInt32(resultado);
                }

            }

            return resultadoFinal;
        }
    }
}
