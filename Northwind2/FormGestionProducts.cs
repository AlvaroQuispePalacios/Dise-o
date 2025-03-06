using Northwind2.NorthwindDataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace Northwind2
{
    public partial class FormGestionProducts : FormGestionTablaBase
    {
        public FormGestionProducts()
         : base(new BindingSource(), new TableAdapterManager()) // Se pasa también TableAdapterManager
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FormGestionProducts_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Suppliers' Puede moverla o quitarla según sea necesario.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.northwindDataSet.Categories);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

            this.conectarBinding = productsBindingSource;
            //this.conectarTableAdapter = this.productsTableAdapter.Fill(this.northwindDataSet.Products);
        }
    }
}
