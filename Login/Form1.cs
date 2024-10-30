using Microsoft.Data.SqlClient;
namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbContrasenya_Click(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContrasenya_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contrasenya = tbContrasenya.Text;

            //
            try { 
                SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=rentacar;User id=usuarioRentacar;Password=rentacar;Trusted_Connection=True;TrustServerCertificate=True");
                conn.Open();
                //MessageBox.Show("se ha hecho conexion");
                string sql = $"SELECT validarUsuario2({usuario}, {contrasenya}) as sel";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show(reader[]);
            }
            catch (SqlException){
                MessageBox.Show("La conexion ha fallado");
            }

        }
    }
}
