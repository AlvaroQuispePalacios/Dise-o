namespace ExamenHerencialAlvaroQuispe
{
    partial class FormGestionBase
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIrAlFinal = new System.Windows.Forms.Button();
            this.btnIrAlSiquiente = new System.Windows.Forms.Button();
            this.btnIrAlAnterior = new System.Windows.Forms.Button();
            this.btnIrAlPrimero = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panelBot);
            this.panel1.Controls.Add(this.panelTop);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnModificar);
            this.panelTop.Controls.Add(this.btnAgregar);
            this.panelTop.Controls.Add(this.btnEliminar);
            this.panelTop.Controls.Add(this.btnIrAlFinal);
            this.panelTop.Controls.Add(this.btnIrAlSiquiente);
            this.panelTop.Controls.Add(this.btnIrAlAnterior);
            this.panelTop.Controls.Add(this.btnIrAlPrimero);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 46);
            this.panelTop.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(498, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(417, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(336, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnIrAlFinal
            // 
            this.btnIrAlFinal.Location = new System.Drawing.Point(255, 12);
            this.btnIrAlFinal.Name = "btnIrAlFinal";
            this.btnIrAlFinal.Size = new System.Drawing.Size(75, 23);
            this.btnIrAlFinal.TabIndex = 3;
            this.btnIrAlFinal.Text = ">>";
            this.btnIrAlFinal.UseVisualStyleBackColor = true;
            this.btnIrAlFinal.Click += new System.EventHandler(this.btnIrAlFinal_Click);
            // 
            // btnIrAlSiquiente
            // 
            this.btnIrAlSiquiente.Location = new System.Drawing.Point(174, 12);
            this.btnIrAlSiquiente.Name = "btnIrAlSiquiente";
            this.btnIrAlSiquiente.Size = new System.Drawing.Size(75, 23);
            this.btnIrAlSiquiente.TabIndex = 2;
            this.btnIrAlSiquiente.Text = ">";
            this.btnIrAlSiquiente.UseVisualStyleBackColor = true;
            this.btnIrAlSiquiente.Click += new System.EventHandler(this.btnIrAlSiquiente_Click);
            // 
            // btnIrAlAnterior
            // 
            this.btnIrAlAnterior.Location = new System.Drawing.Point(93, 12);
            this.btnIrAlAnterior.Name = "btnIrAlAnterior";
            this.btnIrAlAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnIrAlAnterior.TabIndex = 1;
            this.btnIrAlAnterior.Text = "<";
            this.btnIrAlAnterior.UseVisualStyleBackColor = true;
            this.btnIrAlAnterior.Click += new System.EventHandler(this.btnIrAlAnterior_Click);
            // 
            // btnIrAlPrimero
            // 
            this.btnIrAlPrimero.Location = new System.Drawing.Point(12, 12);
            this.btnIrAlPrimero.Name = "btnIrAlPrimero";
            this.btnIrAlPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnIrAlPrimero.TabIndex = 0;
            this.btnIrAlPrimero.Text = "<<";
            this.btnIrAlPrimero.UseVisualStyleBackColor = true;
            this.btnIrAlPrimero.Click += new System.EventHandler(this.btnIrAlPrimero_Click);
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.btnCancelar);
            this.panelBot.Controls.Add(this.btnAceptar);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 416);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(800, 34);
            this.panelBot.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(641, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(722, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 46);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 370);
            this.panelContainer.TabIndex = 2;
            // 
            // FormGestionBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormGestionBase";
            this.Text = "FormGestionBase";
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Panel panelContainer;
        public System.Windows.Forms.Panel panelBot;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnIrAlFinal;
        public System.Windows.Forms.Button btnIrAlSiquiente;
        public System.Windows.Forms.Button btnIrAlAnterior;
        public System.Windows.Forms.Button btnIrAlPrimero;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAceptar;
    }
}