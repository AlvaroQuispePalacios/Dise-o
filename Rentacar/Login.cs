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

namespace Rentacar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=dbRentacar;User id=rentacar;Password=rentacar;Trusted_Connection=True;TrustServerCertificate=True");
                conn.Open();
                string query = $"SELECT * FROM usuario WHERE usuario_nombre='{tbUsuario.Text}' AND usuario_pwd='{tbPwd.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) { 
                        var nombreUsuaio = reader["usuario_nombre"].ToString();
                        Global.userLogin = nombreUsuaio;
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
