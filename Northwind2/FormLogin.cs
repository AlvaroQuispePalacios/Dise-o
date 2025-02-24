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
                String query = $"SELECT dbo.usuarioExiste(@usuario_param, @password_param)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario_param", tbUsuario.Text);
                cmd.Parameters.AddWithValue("@password_param", tbPwd.Text);
                SqlDataReader result = cmd.ExecuteReader();
                //SqlCommand cmdProcedure = new SqlCommand("myProcedure", conn);
                //cmdProcedure.CommandType = CommandType.StoredProcedure;
                //cmdProcedure.Parameters.Add(new SqlParameter("@usuario_param", tbUsuario.Text));
                //cmdProcedure.Parameters.Add(new SqlParameter("@password_param", tbPwd.Text));

                if (result != null) {
                    Console.WriteLine("Todo correcto" + result.ToString());

                }
                else
                {
                    Console.WriteLine("Algo fallo");
                }

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
