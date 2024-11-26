namespace Rentacar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTopBotones = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanelContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenedorMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanelContenedorMenuBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMostrarFormVehiculos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelContenedorHijo = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanelTopBotones.SuspendLayout();
            this.tableLayoutPanelContenedor.SuspendLayout();
            this.panelContenedorMenu.SuspendLayout();
            this.flowLayoutPanelContenedorMenuBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanelTopBotones);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 37);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanelTopBotones
            // 
            this.tableLayoutPanelTopBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTopBotones.ColumnCount = 3;
            this.tableLayoutPanelTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTopBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTopBotones.Controls.Add(this.button8, 2, 0);
            this.tableLayoutPanelTopBotones.Controls.Add(this.button7, 1, 0);
            this.tableLayoutPanelTopBotones.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanelTopBotones.Location = new System.Drawing.Point(613, 0);
            this.tableLayoutPanelTopBotones.Name = "tableLayoutPanelTopBotones";
            this.tableLayoutPanelTopBotones.RowCount = 1;
            this.tableLayoutPanelTopBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTopBotones.Size = new System.Drawing.Size(187, 37);
            this.tableLayoutPanelTopBotones.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(127, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 31);
            this.button8.TabIndex = 2;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(65, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 31);
            this.button7.TabIndex = 1;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 31);
            this.button6.TabIndex = 0;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelContenedor
            // 
            this.tableLayoutPanelContenedor.ColumnCount = 2;
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedor.Controls.Add(this.panelContenedorMenu, 0, 0);
            this.tableLayoutPanelContenedor.Controls.Add(this.panelContenedorHijo, 1, 0);
            this.tableLayoutPanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContenedor.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanelContenedor.Name = "tableLayoutPanelContenedor";
            this.tableLayoutPanelContenedor.RowCount = 1;
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedor.Size = new System.Drawing.Size(800, 413);
            this.tableLayoutPanelContenedor.TabIndex = 1;
            // 
            // panelContenedorMenu
            // 
            this.panelContenedorMenu.Controls.Add(this.flowLayoutPanelContenedorMenuBotones);
            this.panelContenedorMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMenu.Location = new System.Drawing.Point(3, 3);
            this.panelContenedorMenu.Name = "panelContenedorMenu";
            this.panelContenedorMenu.Size = new System.Drawing.Size(194, 407);
            this.panelContenedorMenu.TabIndex = 0;
            // 
            // flowLayoutPanelContenedorMenuBotones
            // 
            this.flowLayoutPanelContenedorMenuBotones.Controls.Add(this.btnMostrarFormVehiculos);
            this.flowLayoutPanelContenedorMenuBotones.Controls.Add(this.button2);
            this.flowLayoutPanelContenedorMenuBotones.Controls.Add(this.button3);
            this.flowLayoutPanelContenedorMenuBotones.Controls.Add(this.button4);
            this.flowLayoutPanelContenedorMenuBotones.Controls.Add(this.button5);
            this.flowLayoutPanelContenedorMenuBotones.Location = new System.Drawing.Point(3, 186);
            this.flowLayoutPanelContenedorMenuBotones.Name = "flowLayoutPanelContenedorMenuBotones";
            this.flowLayoutPanelContenedorMenuBotones.Size = new System.Drawing.Size(188, 212);
            this.flowLayoutPanelContenedorMenuBotones.TabIndex = 0;
            // 
            // btnMostrarFormVehiculos
            // 
            this.btnMostrarFormVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarFormVehiculos.Location = new System.Drawing.Point(3, 3);
            this.btnMostrarFormVehiculos.Name = "btnMostrarFormVehiculos";
            this.btnMostrarFormVehiculos.Size = new System.Drawing.Size(185, 35);
            this.btnMostrarFormVehiculos.TabIndex = 0;
            this.btnMostrarFormVehiculos.Text = "Vehiculos";
            this.btnMostrarFormVehiculos.UseVisualStyleBackColor = true;
            this.btnMostrarFormVehiculos.Click += new System.EventHandler(this.btnMostrarFormVehiculos_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panelContenedorHijo
            // 
            this.panelContenedorHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorHijo.Location = new System.Drawing.Point(203, 3);
            this.panelContenedorHijo.Name = "panelContenedorHijo";
            this.panelContenedorHijo.Size = new System.Drawing.Size(594, 407);
            this.panelContenedorHijo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelContenedor);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanelTopBotones.ResumeLayout(false);
            this.tableLayoutPanelContenedor.ResumeLayout(false);
            this.panelContenedorMenu.ResumeLayout(false);
            this.flowLayoutPanelContenedorMenuBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedor;
        private System.Windows.Forms.Panel panelContenedorMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContenedorMenuBotones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTopBotones;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnMostrarFormVehiculos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelContenedorHijo;
    }
}

