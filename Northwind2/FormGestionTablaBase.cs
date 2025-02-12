using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Northwind2.NorthwindDataSetTableAdapters;
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
    public partial class FormGestionTablaBase : FormBase
    {
        private BindingSource bindingSource = new BindingSource();
        private DataTable tabla = new DataTable();
        private DataGridView dataGridView = null;
        private SqlDataAdapter adaptador = null;

        private TableAdapterManager tableAdapterManager = null;

        public FormGestionTablaBase()
        {
            InitializeComponent();
            cargarTabla();
            this.bindingSource.DataSource = tabla;
            this.dataGridViewForm.DataSource = bindingSource;

        }

        private void btnIrAlPrimero_Click(object sender, EventArgs e)
        {
            //this.bindingSource.MoveFirst();
        }

        private void btnIrAlAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnIrAlSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnIrAlUltimo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {

        }

        private void cargarTabla()
        {

            String nombreTabla = null;

            try
            {
                // Obtenemos la tabla que esta asociada al formulario de gestión
                SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                String query = $"SELECT * FROM NCLGestionTablas WHERE nombre_formulario = '{this.Name}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read())
                    {
                        nombreTabla = Convert.ToString(reader["nombre_tabla_asociado"]);
                    }
                }

                // Cargará los datos de la tabla asociado al formulario
                if (nombreTabla != null) {
                    String queryObtenerDatosTabla = $"SELECT * FROM {nombreTabla}";
                    this.adaptador = new SqlDataAdapter(queryObtenerDatosTabla, conn);
                    // Llenar el dataTable con los datos de la tabla Customers
                    this.adaptador.Fill(this.tabla);
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
