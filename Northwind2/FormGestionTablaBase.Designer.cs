namespace Northwind2
{
    partial class FormGestionTablaBase
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
            System.Windows.Forms.TableLayoutPanel panelControles;
            System.Windows.Forms.TableLayoutPanel panelCambios;
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnIrAlUltimo = new System.Windows.Forms.Button();
            this.btnIrAlSiguiente = new System.Windows.Forms.Button();
            this.btnIrAlAnterior = new System.Windows.Forms.Button();
            this.btnIrAlPrimero = new System.Windows.Forms.Button();
            this.btnAceptarCambios = new System.Windows.Forms.Button();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            panelControles = new System.Windows.Forms.TableLayoutPanel();
            panelCambios = new System.Windows.Forms.TableLayoutPanel();
            this.panelBase.SuspendLayout();
            this.panelTop.SuspendLayout();
            panelControles.SuspendLayout();
            panelCambios.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.panelRight);
            this.panelBase.Controls.Add(this.panelLeft);
            this.panelBase.Controls.Add(this.panelBot);
            this.panelBase.Controls.Add(this.panelTop);
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(panelControles);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 45);
            this.panelTop.TabIndex = 0;
            // 
            // panelControles
            // 
            panelControles.ColumnCount = 7;
            panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            panelControles.Controls.Add(this.btnModificarRegistro, 6, 0);
            panelControles.Controls.Add(this.btnEliminarRegistro, 5, 0);
            panelControles.Controls.Add(this.btnAgregarRegistro, 4, 0);
            panelControles.Controls.Add(this.btnIrAlUltimo, 3, 0);
            panelControles.Controls.Add(this.btnIrAlSiguiente, 2, 0);
            panelControles.Controls.Add(this.btnIrAlAnterior, 1, 0);
            panelControles.Controls.Add(this.btnIrAlPrimero, 0, 0);
            panelControles.Location = new System.Drawing.Point(3, 3);
            panelControles.Name = "panelControles";
            panelControles.RowCount = 1;
            panelControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panelControles.Size = new System.Drawing.Size(547, 39);
            panelControles.TabIndex = 0;
            // 
            // btnModificarRegistro
            // 
            this.btnModificarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarRegistro.Location = new System.Drawing.Point(471, 3);
            this.btnModificarRegistro.Name = "btnModificarRegistro";
            this.btnModificarRegistro.Size = new System.Drawing.Size(73, 33);
            this.btnModificarRegistro.TabIndex = 6;
            this.btnModificarRegistro.Text = "Modificar";
            this.btnModificarRegistro.UseVisualStyleBackColor = true;
            this.btnModificarRegistro.Click += new System.EventHandler(this.btnModificarRegistro_Click);
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(393, 3);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(72, 33);
            this.btnEliminarRegistro.TabIndex = 5;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarRegistro.Location = new System.Drawing.Point(315, 3);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(72, 33);
            this.btnAgregarRegistro.TabIndex = 4;
            this.btnAgregarRegistro.Text = "Agregar";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // btnIrAlUltimo
            // 
            this.btnIrAlUltimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlUltimo.Location = new System.Drawing.Point(237, 3);
            this.btnIrAlUltimo.Name = "btnIrAlUltimo";
            this.btnIrAlUltimo.Size = new System.Drawing.Size(72, 33);
            this.btnIrAlUltimo.TabIndex = 3;
            this.btnIrAlUltimo.Text = ">>";
            this.btnIrAlUltimo.UseVisualStyleBackColor = true;
            this.btnIrAlUltimo.Click += new System.EventHandler(this.btnIrAlUltimo_Click);
            // 
            // btnIrAlSiguiente
            // 
            this.btnIrAlSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlSiguiente.Location = new System.Drawing.Point(159, 3);
            this.btnIrAlSiguiente.Name = "btnIrAlSiguiente";
            this.btnIrAlSiguiente.Size = new System.Drawing.Size(72, 33);
            this.btnIrAlSiguiente.TabIndex = 2;
            this.btnIrAlSiguiente.Text = ">";
            this.btnIrAlSiguiente.UseVisualStyleBackColor = true;
            this.btnIrAlSiguiente.Click += new System.EventHandler(this.btnIrAlSiguiente_Click);
            // 
            // btnIrAlAnterior
            // 
            this.btnIrAlAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlAnterior.Location = new System.Drawing.Point(81, 3);
            this.btnIrAlAnterior.Name = "btnIrAlAnterior";
            this.btnIrAlAnterior.Size = new System.Drawing.Size(72, 33);
            this.btnIrAlAnterior.TabIndex = 1;
            this.btnIrAlAnterior.Text = "<";
            this.btnIrAlAnterior.UseVisualStyleBackColor = true;
            this.btnIrAlAnterior.Click += new System.EventHandler(this.btnIrAlAnterior_Click);
            // 
            // btnIrAlPrimero
            // 
            this.btnIrAlPrimero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIrAlPrimero.Location = new System.Drawing.Point(3, 3);
            this.btnIrAlPrimero.Name = "btnIrAlPrimero";
            this.btnIrAlPrimero.Size = new System.Drawing.Size(72, 33);
            this.btnIrAlPrimero.TabIndex = 0;
            this.btnIrAlPrimero.Text = "<<";
            this.btnIrAlPrimero.UseVisualStyleBackColor = true;
            this.btnIrAlPrimero.Click += new System.EventHandler(this.btnIrAlPrimero_Click);
            // 
            // panelCambios
            // 
            panelCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            panelCambios.ColumnCount = 2;
            panelCambios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelCambios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelCambios.Controls.Add(this.btnAceptarCambios, 1, 0);
            panelCambios.Controls.Add(this.btnCancelarCambios, 0, 0);
            panelCambios.Location = new System.Drawing.Point(625, 3);
            panelCambios.Name = "panelCambios";
            panelCambios.RowCount = 1;
            panelCambios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            panelCambios.Size = new System.Drawing.Size(172, 39);
            panelCambios.TabIndex = 0;
            // 
            // btnAceptarCambios
            // 
            this.btnAceptarCambios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptarCambios.Location = new System.Drawing.Point(89, 3);
            this.btnAceptarCambios.Name = "btnAceptarCambios";
            this.btnAceptarCambios.Size = new System.Drawing.Size(80, 33);
            this.btnAceptarCambios.TabIndex = 1;
            this.btnAceptarCambios.Text = "Aceptar";
            this.btnAceptarCambios.UseVisualStyleBackColor = true;
            this.btnAceptarCambios.Click += new System.EventHandler(this.btnAceptarCambios_Click);
            // 
            // btnCancelarCambios
            // 
            this.btnCancelarCambios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarCambios.Location = new System.Drawing.Point(3, 3);
            this.btnCancelarCambios.Name = "btnCancelarCambios";
            this.btnCancelarCambios.Size = new System.Drawing.Size(80, 33);
            this.btnCancelarCambios.TabIndex = 0;
            this.btnCancelarCambios.Text = "Cancelar";
            this.btnCancelarCambios.UseVisualStyleBackColor = true;
            this.btnCancelarCambios.Click += new System.EventHandler(this.btnCancelarCambios_Click);
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(panelCambios);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 408);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(800, 42);
            this.panelBot.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 45);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(527, 363);
            this.panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(527, 45);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(273, 363);
            this.panelRight.TabIndex = 3;
            // 
            // FormGestionTablaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormGestionTablaBase";
            this.Text = "FormGestionTablaBase";
            this.Load += new System.EventHandler(this.FormGestionTablaBase_Load);
            this.panelBase.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            panelControles.ResumeLayout(false);
            panelCambios.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelBot;
        public System.Windows.Forms.Panel panelRight;
        public System.Windows.Forms.Panel panelLeft;
        public System.Windows.Forms.Button btnModificarRegistro;
        public System.Windows.Forms.Button btnEliminarRegistro;
        public System.Windows.Forms.Button btnAgregarRegistro;
        public System.Windows.Forms.Button btnIrAlUltimo;
        public System.Windows.Forms.Button btnIrAlSiguiente;
        public System.Windows.Forms.Button btnIrAlAnterior;
        public System.Windows.Forms.Button btnIrAlPrimero;
        public System.Windows.Forms.Button btnAceptarCambios;
        public System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Panel panelTop;
    }
}