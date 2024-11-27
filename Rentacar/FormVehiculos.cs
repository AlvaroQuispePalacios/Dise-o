using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rentacar
{
    public partial class FormVehiculos : Form
    {
        public FormVehiculos()
        {
            InitializeComponent();
        }

        private void vehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbRentacarDataSet);

        }

        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbRentacarDataSet.modelo' Puede moverla o quitarla según sea necesario.
            this.modeloTableAdapter.Fill(this.dbRentacarDataSet.modelo);
            // TODO: esta línea de código carga datos en la tabla 'dbRentacarDataSet.tipologias' Puede moverla o quitarla según sea necesario.
            this.tipologiasTableAdapter.Fill(this.dbRentacarDataSet.tipologias);
            // TODO: esta línea de código carga datos en la tabla 'dbRentacarDataSet.marcas_coches' Puede moverla o quitarla según sea necesario.
            this.marcas_cochesTableAdapter.Fill(this.dbRentacarDataSet.marcas_coches);
            //// TODO: esta línea de código carga datos en la tabla 'dbRentacarDataSet.vehiculo' Puede moverla o quitarla según sea necesario.
            this.vehiculoTableAdapter.Fill(this.dbRentacarDataSet.vehiculo);
            OcultarPanelBot();

        }

        private void btnIrAlPrimerRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveFirst();
        }

        private void btnAnteriorRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MovePrevious();
        }

        private void btnSiguienteRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveNext();

        }

        private void btnIrAlUltimoRegistro_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.MoveLast();

        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            LogicaBtnConfirmar("Eliminar Registro");
            MostrarPanelBot();
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            LogicaBtnConfirmar("Agregar Registro");
            MostrarPanelBot();
            this.vehiculoBindingSource.AddNew();
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            LogicaBtnConfirmar("Modificar Registro");
            MostrarPanelBot();
        }


        private void LogicaBtnConfirmar(string mensaje)
        {
            btnConfirmar.Text = mensaje;
        }

        private void MostrarPanelBot()
        {
            tableLayoutPanelContenedorBotBotones.Visible = true;
        }

        private void OcultarPanelBot()
        {
            tableLayoutPanelContenedorBotBotones.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.vehiculoBindingSource.CancelEdit();
            OcultarPanelBot();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.btnConfirmar.Text.Equals("Agregar Registro"))
            {
                if (this.Validate())
                {
                    this.vehiculoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dbRentacarDataSet);
                }
            }
            else if(this.btnConfirmar.Text.Equals("Eliminar Registro"))
            {
                this.vehiculoBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dbRentacarDataSet);

            }else if (this.btnConfirmar.Text.Equals("Modificar Registro"))
            {
                if (this.Validate())
                {
                    this.vehiculoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dbRentacarDataSet);
                }
            }
            OcultarPanelBot();
        }

        private void cbTipologia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.modelsBindingSource.Filter = "tipologia = '" + comboBox1.Text + "'";
            //this.marcasBindingSource.Filter = "tipologia = '" + comboBox1.Text + "'";
            Console.WriteLine($"Filtro aplicado: {modeloBindingSource.Filter}");

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modeloBindingSource.Filter = $"modelo_tipologia='{cbTipologia.Text}'";
            //Console.WriteLine($"Filtro aplicado: {modeloBindingSource.Filter}");

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modeloBindingSource.Filter = $"modelo_tipologia = '{cbTipologia.Text}' AND modelo_marca = '{cbMarca.Text}'";
            Console.WriteLine($"Filtro aplicado: {modeloBindingSource.Filter}");
        }
    }
}
