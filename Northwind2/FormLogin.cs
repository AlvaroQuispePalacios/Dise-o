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
                String query = $"SELECT * FROM NCLusuario WHERE nombre_usuario = '{tbUsuario}' AND pwd='{tbPwd}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    String querySesion = $"INSERT INTO NCLsesion";
                }
            }
            catch (Exception ex) { 
            
            }

        }
    }
}
