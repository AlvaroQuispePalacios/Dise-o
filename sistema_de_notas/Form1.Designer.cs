namespace sistema_de_notas
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
            this.tableLayoutPanelContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenedorMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenuOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMostrarAlumnos = new System.Windows.Forms.Button();
            this.btnMostrarNotas = new System.Windows.Forms.Button();
            this.btnAsignaturas = new System.Windows.Forms.Button();
            this.panelContenedorFormHijo = new System.Windows.Forms.Panel();
            this.btnViewNAA = new System.Windows.Forms.Button();
            this.tableLayoutPanelContenedor.SuspendLayout();
            this.panelContenedorMenu.SuspendLayout();
            this.flowLayoutPanelMenuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 38);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanelContenedor
            // 
            this.tableLayoutPanelContenedor.ColumnCount = 2;
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedor.Controls.Add(this.panelContenedorMenu, 0, 0);
            this.tableLayoutPanelContenedor.Controls.Add(this.panelContenedorFormHijo, 1, 0);
            this.tableLayoutPanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContenedor.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanelContenedor.Name = "tableLayoutPanelContenedor";
            this.tableLayoutPanelContenedor.RowCount = 1;
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedor.Size = new System.Drawing.Size(800, 412);
            this.tableLayoutPanelContenedor.TabIndex = 1;
            // 
            // panelContenedorMenu
            // 
            this.panelContenedorMenu.Controls.Add(this.flowLayoutPanelMenuOpciones);
            this.panelContenedorMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMenu.Location = new System.Drawing.Point(3, 3);
            this.panelContenedorMenu.Name = "panelContenedorMenu";
            this.panelContenedorMenu.Padding = new System.Windows.Forms.Padding(10);
            this.panelContenedorMenu.Size = new System.Drawing.Size(244, 406);
            this.panelContenedorMenu.TabIndex = 0;
            // 
            // flowLayoutPanelMenuOpciones
            // 
            this.flowLayoutPanelMenuOpciones.Controls.Add(this.btnMostrarAlumnos);
            this.flowLayoutPanelMenuOpciones.Controls.Add(this.btnMostrarNotas);
            this.flowLayoutPanelMenuOpciones.Controls.Add(this.btnAsignaturas);
            this.flowLayoutPanelMenuOpciones.Controls.Add(this.btnViewNAA);
            this.flowLayoutPanelMenuOpciones.Location = new System.Drawing.Point(13, 199);
            this.flowLayoutPanelMenuOpciones.Name = "flowLayoutPanelMenuOpciones";
            this.flowLayoutPanelMenuOpciones.Size = new System.Drawing.Size(218, 198);
            this.flowLayoutPanelMenuOpciones.TabIndex = 0;
            // 
            // btnMostrarAlumnos
            // 
            this.btnMostrarAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAlumnos.Location = new System.Drawing.Point(3, 3);
            this.btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            this.btnMostrarAlumnos.Size = new System.Drawing.Size(215, 39);
            this.btnMostrarAlumnos.TabIndex = 0;
            this.btnMostrarAlumnos.Text = "Alumnos";
            this.btnMostrarAlumnos.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnos.Click += new System.EventHandler(this.btnMostrarAlumnos_Click);
            // 
            // btnMostrarNotas
            // 
            this.btnMostrarNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarNotas.Location = new System.Drawing.Point(3, 48);
            this.btnMostrarNotas.Name = "btnMostrarNotas";
            this.btnMostrarNotas.Size = new System.Drawing.Size(215, 39);
            this.btnMostrarNotas.TabIndex = 1;
            this.btnMostrarNotas.Text = "Notas";
            this.btnMostrarNotas.UseVisualStyleBackColor = true;
            this.btnMostrarNotas.Click += new System.EventHandler(this.btnMostrarNotas_Click);
            // 
            // btnAsignaturas
            // 
            this.btnAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaturas.Location = new System.Drawing.Point(3, 93);
            this.btnAsignaturas.Name = "btnAsignaturas";
            this.btnAsignaturas.Size = new System.Drawing.Size(215, 39);
            this.btnAsignaturas.TabIndex = 2;
            this.btnAsignaturas.Text = "Asignaturas";
            this.btnAsignaturas.UseVisualStyleBackColor = true;
            this.btnAsignaturas.Click += new System.EventHandler(this.btnAsignaturas_Click);
            // 
            // panelContenedorFormHijo
            // 
            this.panelContenedorFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorFormHijo.Location = new System.Drawing.Point(253, 3);
            this.panelContenedorFormHijo.Name = "panelContenedorFormHijo";
            this.panelContenedorFormHijo.Size = new System.Drawing.Size(544, 406);
            this.panelContenedorFormHijo.TabIndex = 1;
            // 
            // btnViewNAA
            // 
            this.btnViewNAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNAA.Location = new System.Drawing.Point(3, 138);
            this.btnViewNAA.Name = "btnViewNAA";
            this.btnViewNAA.Size = new System.Drawing.Size(215, 39);
            this.btnViewNAA.TabIndex = 3;
            this.btnViewNAA.Text = "View";
            this.btnViewNAA.UseVisualStyleBackColor = true;
            this.btnViewNAA.Click += new System.EventHandler(this.btnViewNAA_Click);
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
            this.tableLayoutPanelContenedor.ResumeLayout(false);
            this.panelContenedorMenu.ResumeLayout(false);
            this.flowLayoutPanelMenuOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedor;
        private System.Windows.Forms.Panel panelContenedorMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuOpciones;
        private System.Windows.Forms.Button btnMostrarAlumnos;
        private System.Windows.Forms.Button btnMostrarNotas;
        private System.Windows.Forms.Panel panelContenedorFormHijo;
        private System.Windows.Forms.Button btnAsignaturas;
        private System.Windows.Forms.Button btnViewNAA;
    }
}

