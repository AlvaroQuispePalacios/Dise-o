﻿namespace sistema_de_notas
{
    partial class FormAsignaturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignaturas));
            this.notasDataSet = new sistema_de_notas.notasDataSet();
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturasTableAdapter = new sistema_de_notas.notasDataSetTableAdapters.AsignaturasTableAdapter();
            this.tableAdapterManager = new sistema_de_notas.notasDataSetTableAdapters.TableAdapterManager();
            this.asignaturasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.asignaturasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.asignaturasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingNavigator)).BeginInit();
            this.asignaturasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // notasDataSet
            // 
            this.notasDataSet.DataSetName = "notasDataSet";
            this.notasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturasBindingSource
            // 
            this.asignaturasBindingSource.DataMember = "Asignaturas";
            this.asignaturasBindingSource.DataSource = this.notasDataSet;
            // 
            // asignaturasTableAdapter
            // 
            this.asignaturasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.AsignaturasTableAdapter = this.asignaturasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistema_de_notas.notasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // asignaturasBindingNavigator
            // 
            this.asignaturasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.asignaturasBindingNavigator.BindingSource = this.asignaturasBindingSource;
            this.asignaturasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.asignaturasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.asignaturasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.asignaturasBindingNavigatorSaveItem});
            this.asignaturasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.asignaturasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.asignaturasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.asignaturasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.asignaturasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.asignaturasBindingNavigator.Name = "asignaturasBindingNavigator";
            this.asignaturasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.asignaturasBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.asignaturasBindingNavigator.TabIndex = 0;
            this.asignaturasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // asignaturasBindingNavigatorSaveItem
            // 
            this.asignaturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.asignaturasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("asignaturasBindingNavigatorSaveItem.Image")));
            this.asignaturasBindingNavigatorSaveItem.Name = "asignaturasBindingNavigatorSaveItem";
            this.asignaturasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.asignaturasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.asignaturasBindingNavigatorSaveItem.Click += new System.EventHandler(this.asignaturasBindingNavigatorSaveItem_Click);
            // 
            // asignaturasDataGridView
            // 
            this.asignaturasDataGridView.AutoGenerateColumns = false;
            this.asignaturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asignaturasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.asignaturasDataGridView.DataSource = this.asignaturasBindingSource;
            this.asignaturasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asignaturasDataGridView.Location = new System.Drawing.Point(0, 25);
            this.asignaturasDataGridView.Name = "asignaturasDataGridView";
            this.asignaturasDataGridView.Size = new System.Drawing.Size(800, 425);
            this.asignaturasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_asignatura";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_asignatura";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "profesor";
            this.dataGridViewTextBoxColumn3.HeaderText = "profesor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.asignaturasDataGridView);
            this.Controls.Add(this.asignaturasBindingNavigator);
            this.Name = "FormAsignaturas";
            this.Text = "FormAsignaturas";
            this.Load += new System.EventHandler(this.FormAsignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingNavigator)).EndInit();
            this.asignaturasBindingNavigator.ResumeLayout(false);
            this.asignaturasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private notasDataSet notasDataSet;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private notasDataSetTableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
        private notasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator asignaturasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton asignaturasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView asignaturasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}