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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelControles = new System.Windows.Forms.TableLayoutPanel();
            this.btnModificarRegistro = new System.Windows.Forms.Button();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnIrAlUltimo = new System.Windows.Forms.Button();
            this.btnIrAlSiguiente = new System.Windows.Forms.Button();
            this.btnIrAlAnterior = new System.Windows.Forms.Button();
            this.btnIrAlPrimero = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelCambios = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptarCambios = new System.Windows.Forms.Button();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewForm = new System.Windows.Forms.DataGridView();
            this.panelBase.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.panelCambios.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm)).BeginInit();
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
            this.panelTop.Controls.Add(this.panelControles);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 45);
            this.panelTop.TabIndex = 0;
            // 
            // panelControles
            // 
            this.panelControles.ColumnCount = 7;
            this.panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panelControles.Controls.Add(this.btnModificarRegistro, 6, 0);
            this.panelControles.Controls.Add(this.btnEliminarRegistro, 5, 0);
            this.panelControles.Controls.Add(this.btnAgregarRegistro, 4, 0);
            this.panelControles.Controls.Add(this.btnIrAlUltimo, 3, 0);
            this.panelControles.Controls.Add(this.btnIrAlSiguiente, 2, 0);
            this.panelControles.Controls.Add(this.btnIrAlAnterior, 1, 0);
            this.panelControles.Controls.Add(this.btnIrAlPrimero, 0, 0);
            this.panelControles.Location = new System.Drawing.Point(3, 3);
            this.panelControles.Name = "panelControles";
            this.panelControles.RowCount = 1;
            this.panelControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelControles.Size = new System.Drawing.Size(547, 39);
            this.panelControles.TabIndex = 0;
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
            // panelBot
            // 
            this.panelBot.Controls.Add(this.panelCambios);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 408);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(800, 42);
            this.panelBot.TabIndex = 1;
            // 
            // panelCambios
            // 
            this.panelCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCambios.ColumnCount = 2;
            this.panelCambios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCambios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCambios.Controls.Add(this.btnAceptarCambios, 1, 0);
            this.panelCambios.Controls.Add(this.btnCancelarCambios, 0, 0);
            this.panelCambios.Location = new System.Drawing.Point(625, 3);
            this.panelCambios.Name = "panelCambios";
            this.panelCambios.RowCount = 1;
            this.panelCambios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCambios.Size = new System.Drawing.Size(172, 39);
            this.panelCambios.TabIndex = 0;
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
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 45);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(420, 363);
            this.panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.dataGridViewForm);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(420, 45);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(380, 363);
            this.panelRight.TabIndex = 3;
            // 
            // dataGridViewForm
            // 
            this.dataGridViewForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewForm.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewForm.Name = "dataGridViewForm";
            this.dataGridViewForm.Size = new System.Drawing.Size(378, 361);
            this.dataGridViewForm.TabIndex = 0;
            // 
            // FormGestionTablaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormGestionTablaBase";
            this.Text = "FormGestionTablaBase";
            this.panelBase.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelControles.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.panelCambios.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel panelControles;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnIrAlUltimo;
        private System.Windows.Forms.Button btnIrAlSiguiente;
        private System.Windows.Forms.Button btnIrAlAnterior;
        private System.Windows.Forms.Button btnIrAlPrimero;
        private System.Windows.Forms.TableLayoutPanel panelCambios;
        private System.Windows.Forms.Button btnAceptarCambios;
        private System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Button btnModificarRegistro;
        public System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Panel panelBot;
        public System.Windows.Forms.Panel panelRight;
        public System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView dataGridViewForm;
    }
}