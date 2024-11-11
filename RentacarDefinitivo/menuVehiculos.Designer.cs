namespace RentacarDefinitivo
{
    partial class menuVehiculos
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
            this.rentacarDataSet = new RentacarDefinitivo.rentacarDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehicleTableAdapter();
            this.tableAdapterManager = new RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager();
            this.panelTopFormVehiculos = new System.Windows.Forms.Panel();
            this.panelMidFormVehiculos = new System.Windows.Forms.Panel();
            this.panelBotFormVehiculos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.panelTopFormVehiculos.SuspendLayout();
            this.panelBotFormVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentacarDataSet
            // 
            this.rentacarDataSet.DataSetName = "rentacarDataSet";
            this.rentacarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "vehicle";
            this.vehicleBindingSource.DataSource = this.rentacarDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carrecsTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contracteTableAdapter = null;
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.vehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // panelTopFormVehiculos
            // 
            this.panelTopFormVehiculos.Controls.Add(this.button6);
            this.panelTopFormVehiculos.Controls.Add(this.button5);
            this.panelTopFormVehiculos.Controls.Add(this.button4);
            this.panelTopFormVehiculos.Controls.Add(this.button3);
            this.panelTopFormVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopFormVehiculos.Location = new System.Drawing.Point(0, 0);
            this.panelTopFormVehiculos.Name = "panelTopFormVehiculos";
            this.panelTopFormVehiculos.Size = new System.Drawing.Size(800, 37);
            this.panelTopFormVehiculos.TabIndex = 2;
            // 
            // panelMidFormVehiculos
            // 
            this.panelMidFormVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMidFormVehiculos.Location = new System.Drawing.Point(0, 37);
            this.panelMidFormVehiculos.Name = "panelMidFormVehiculos";
            this.panelMidFormVehiculos.Size = new System.Drawing.Size(800, 413);
            this.panelMidFormVehiculos.TabIndex = 3;
            // 
            // panelBotFormVehiculos
            // 
            this.panelBotFormVehiculos.Controls.Add(this.button2);
            this.panelBotFormVehiculos.Controls.Add(this.button1);
            this.panelBotFormVehiculos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotFormVehiculos.Location = new System.Drawing.Point(0, 413);
            this.panelBotFormVehiculos.Name = "panelBotFormVehiculos";
            this.panelBotFormVehiculos.Size = new System.Drawing.Size(800, 37);
            this.panelBotFormVehiculos.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(691, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 31);
            this.button4.TabIndex = 1;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 31);
            this.button5.TabIndex = 2;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 31);
            this.button6.TabIndex = 3;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // menuVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBotFormVehiculos);
            this.Controls.Add(this.panelMidFormVehiculos);
            this.Controls.Add(this.panelTopFormVehiculos);
            this.Name = "menuVehiculos";
            this.Text = "menuVehiculos";
            this.Load += new System.EventHandler(this.menuVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.panelTopFormVehiculos.ResumeLayout(false);
            this.panelBotFormVehiculos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private rentacarDataSet rentacarDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private rentacarDataSetTableAdapters.vehicleTableAdapter vehicleTableAdapter;
        private rentacarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelTopFormVehiculos;
        private System.Windows.Forms.Panel panelMidFormVehiculos;
        private System.Windows.Forms.Panel panelBotFormVehiculos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}