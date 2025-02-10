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
            //try
            //{
            //    SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;User id=usuarioRentacar;Password=rentacar;Trusted_Connection=True;TrustServerCertificate=True");
            //    conn.Open();
            //    string sql = $"SELECT * FROM usuario WHERE nombre_usuario='{lbUsuario}' AND pwd_usuario='{lbPwd}'";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //}
            //catch (Exception ex)
            //{

            //}

        }
    }
}
