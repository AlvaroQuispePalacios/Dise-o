namespace Prueba
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
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMaximizarRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.tableLayoutPanelContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.panelContenedorMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanelContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMostrarFormProfesores = new System.Windows.Forms.Button();
            this.btnMostrarFormAlumnos = new System.Windows.Forms.Button();
            this.btnMostrarNotas = new System.Windows.Forms.Button();
            this.btnMostrarFormAsignaturas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblMostrarNombreUsuario = new System.Windows.Forms.Label();
            this.panelContenedorFormularioHijo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableLayoutPanelContenedor.SuspendLayout();
            this.panelContenedorMenu.SuspendLayout();
            this.flowLayoutPanelContenedor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(15)))));
            this.panelTop.Controls.Add(this.tableLayoutPanelTop);
            this.panelTop.Controls.Add(this.menuStrip1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(826, 50);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTop.Controls.Add(this.btnCerrar, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.btnMaximizarRestaurar, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.btnMinimizar, 0, 0);
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(655, 20);
            this.tableLayoutPanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(171, 30);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(114, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(57, 30);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizarRestaurar
            // 
            this.btnMaximizarRestaurar.BackColor = System.Drawing.Color.White;
            this.btnMaximizarRestaurar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximizarRestaurar.FlatAppearance.BorderSize = 0;
            this.btnMaximizarRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizarRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizarRestaurar.Location = new System.Drawing.Point(57, 0);
            this.btnMaximizarRestaurar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizarRestaurar.Name = "btnMaximizarRestaurar";
            this.btnMaximizarRestaurar.Size = new System.Drawing.Size(57, 30);
            this.btnMaximizarRestaurar.TabIndex = 1;
            this.btnMaximizarRestaurar.Text = "c";
            this.btnMaximizarRestaurar.UseVisualStyleBackColor = false;
            this.btnMaximizarRestaurar.Click += new System.EventHandler(this.btnMaximizarRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Location = new System.Drawing.Point(0, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(57, 30);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.Text = "__";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // tableLayoutPanelContenedor
            // 
            this.tableLayoutPanelContenedor.ColumnCount = 2;
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedor.Controls.Add(this.panelContenedorMenu, 0, 0);
            this.tableLayoutPanelContenedor.Controls.Add(this.panelContenedorFormularioHijo, 1, 0);
            this.tableLayoutPanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContenedor.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanelContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelContenedor.Name = "tableLayoutPanelContenedor";
            this.tableLayoutPanelContenedor.RowCount = 1;
            this.tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedor.Size = new System.Drawing.Size(826, 495);
            this.tableLayoutPanelContenedor.TabIndex = 1;
            // 
            // panelContenedorMenu
            // 
            this.panelContenedorMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.panelContenedorMenu.Controls.Add(this.flowLayoutPanelContenedor);
            this.panelContenedorMenu.Controls.Add(this.lblMostrarNombreUsuario);
            this.panelContenedorMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorMenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelContenedorMenu.Name = "panelContenedorMenu";
            this.panelContenedorMenu.Padding = new System.Windows.Forms.Padding(5);
            this.panelContenedorMenu.Size = new System.Drawing.Size(250, 495);
            this.panelContenedorMenu.TabIndex = 0;
            // 
            // flowLayoutPanelContenedor
            // 
            this.flowLayoutPanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelContenedor.Controls.Add(this.btnMostrarFormProfesores);
            this.flowLayoutPanelContenedor.Controls.Add(this.btnMostrarFormAlumnos);
            this.flowLayoutPanelContenedor.Controls.Add(this.btnMostrarNotas);
            this.flowLayoutPanelContenedor.Controls.Add(this.btnMostrarFormAsignaturas);
            this.flowLayoutPanelContenedor.Controls.Add(this.btnCerrarSesion);
            this.flowLayoutPanelContenedor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContenedor.Location = new System.Drawing.Point(8, 216);
            this.flowLayoutPanelContenedor.Name = "flowLayoutPanelContenedor";
            this.flowLayoutPanelContenedor.Size = new System.Drawing.Size(234, 266);
            this.flowLayoutPanelContenedor.TabIndex = 1;
            // 
            // btnMostrarFormProfesores
            // 
            this.btnMostrarFormProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarFormProfesores.Location = new System.Drawing.Point(3, 3);
            this.btnMostrarFormProfesores.Name = "btnMostrarFormProfesores";
            this.btnMostrarFormProfesores.Size = new System.Drawing.Size(231, 38);
            this.btnMostrarFormProfesores.TabIndex = 0;
            this.btnMostrarFormProfesores.Text = "Profesores";
            this.btnMostrarFormProfesores.UseVisualStyleBackColor = true;
            this.btnMostrarFormProfesores.Click += new System.EventHandler(this.btnMostrarFormProfesores_Click);
            // 
            // btnMostrarFormAlumnos
            // 
            this.btnMostrarFormAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarFormAlumnos.Location = new System.Drawing.Point(3, 47);
            this.btnMostrarFormAlumnos.Name = "btnMostrarFormAlumnos";
            this.btnMostrarFormAlumnos.Size = new System.Drawing.Size(231, 38);
            this.btnMostrarFormAlumnos.TabIndex = 1;
            this.btnMostrarFormAlumnos.Text = "Alumnos";
            this.btnMostrarFormAlumnos.UseVisualStyleBackColor = true;
            this.btnMostrarFormAlumnos.Click += new System.EventHandler(this.btnMostrarFormAlumnos_Click);
            // 
            // btnMostrarNotas
            // 
            this.btnMostrarNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarNotas.Location = new System.Drawing.Point(3, 91);
            this.btnMostrarNotas.Name = "btnMostrarNotas";
            this.btnMostrarNotas.Size = new System.Drawing.Size(231, 38);
            this.btnMostrarNotas.TabIndex = 2;
            this.btnMostrarNotas.Text = "Notas";
            this.btnMostrarNotas.UseVisualStyleBackColor = true;
            this.btnMostrarNotas.Click += new System.EventHandler(this.btnMostrarNotas_Click);
            // 
            // btnMostrarFormAsignaturas
            // 
            this.btnMostrarFormAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarFormAsignaturas.Location = new System.Drawing.Point(3, 135);
            this.btnMostrarFormAsignaturas.Name = "btnMostrarFormAsignaturas";
            this.btnMostrarFormAsignaturas.Size = new System.Drawing.Size(231, 38);
            this.btnMostrarFormAsignaturas.TabIndex = 3;
            this.btnMostrarFormAsignaturas.Text = "Asignaturas";
            this.btnMostrarFormAsignaturas.UseVisualStyleBackColor = true;
            this.btnMostrarFormAsignaturas.Click += new System.EventHandler(this.btnMostrarFormAsignaturas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 179);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(231, 38);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // lblMostrarNombreUsuario
            // 
            this.lblMostrarNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMostrarNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblMostrarNombreUsuario.Location = new System.Drawing.Point(8, 180);
            this.lblMostrarNombreUsuario.Name = "lblMostrarNombreUsuario";
            this.lblMostrarNombreUsuario.Size = new System.Drawing.Size(234, 24);
            this.lblMostrarNombreUsuario.TabIndex = 0;
            this.lblMostrarNombreUsuario.Text = "Invitado";
            this.lblMostrarNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenedorFormularioHijo
            // 
            this.panelContenedorFormularioHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.panelContenedorFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorFormularioHijo.Location = new System.Drawing.Point(250, 0);
            this.panelContenedorFormularioHijo.Margin = new System.Windows.Forms.Padding(0);
            this.panelContenedorFormularioHijo.Name = "panelContenedorFormularioHijo";
            this.panelContenedorFormularioHijo.Size = new System.Drawing.Size(576, 495);
            this.panelContenedorFormularioHijo.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.asignaturasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem.Click += new System.EventHandler(this.asignaturasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 545);
            this.Controls.Add(this.tableLayoutPanelContenedor);
            this.Controls.Add(this.panelTop);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelContenedor.ResumeLayout(false);
            this.panelContenedorMenu.ResumeLayout(false);
            this.flowLayoutPanelContenedor.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedor;
        private System.Windows.Forms.Panel panelContenedorMenu;
        private System.Windows.Forms.Panel panelContenedorFormularioHijo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizarRestaurar;
        private System.Windows.Forms.Label lblMostrarNombreUsuario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContenedor;
        private System.Windows.Forms.Button btnMostrarFormProfesores;
        private System.Windows.Forms.Button btnMostrarFormAlumnos;
        private System.Windows.Forms.Button btnMostrarNotas;
        private System.Windows.Forms.Button btnMostrarFormAsignaturas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
    }
}

