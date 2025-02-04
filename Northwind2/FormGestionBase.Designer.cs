namespace Northwind2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIrPrimerRegistro = new System.Windows.Forms.Button();
            this.btnIrRegistroAnterior = new System.Windows.Forms.Button();
            this.btnIrRegistroSiguiente = new System.Windows.Forms.Button();
            this.btnIrUltimoRegistro = new System.Windows.Forms.Button();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.panelBot = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.TableLayoutPanel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.flowLayoutPanel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 47);
            this.panelTop.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnIrPrimerRegistro);
            this.flowLayoutPanel1.Controls.Add(this.btnIrRegistroAnterior);
            this.flowLayoutPanel1.Controls.Add(this.btnIrRegistroSiguiente);
            this.flowLayoutPanel1.Controls.Add(this.btnIrUltimoRegistro);
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarRegistro);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminarRegistro);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarRegistro);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnIrPrimerRegistro
            // 
            this.btnIrPrimerRegistro.Location = new System.Drawing.Point(3, 3);
            this.btnIrPrimerRegistro.Name = "btnIrPrimerRegistro";
            this.btnIrPrimerRegistro.Size = new System.Drawing.Size(61, 35);
            this.btnIrPrimerRegistro.TabIndex = 0;
            this.btnIrPrimerRegistro.Text = "<<";
            this.btnIrPrimerRegistro.UseVisualStyleBackColor = true;
            // 
            // btnIrRegistroAnterior
            // 
            this.btnIrRegistroAnterior.Location = new System.Drawing.Point(70, 3);
            this.btnIrRegistroAnterior.Name = "btnIrRegistroAnterior";
            this.btnIrRegistroAnterior.Size = new System.Drawing.Size(61, 35);
            this.btnIrRegistroAnterior.TabIndex = 1;
            this.btnIrRegistroAnterior.Text = "<";
            this.btnIrRegistroAnterior.UseVisualStyleBackColor = true;
            // 
            // btnIrRegistroSiguiente
            // 
            this.btnIrRegistroSiguiente.Location = new System.Drawing.Point(137, 3);
            this.btnIrRegistroSiguiente.Name = "btnIrRegistroSiguiente";
            this.btnIrRegistroSiguiente.Size = new System.Drawing.Size(61, 35);
            this.btnIrRegistroSiguiente.TabIndex = 2;
            this.btnIrRegistroSiguiente.Text = ">";
            this.btnIrRegistroSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnIrUltimoRegistro
            // 
            this.btnIrUltimoRegistro.Location = new System.Drawing.Point(204, 3);
            this.btnIrUltimoRegistro.Name = "btnIrUltimoRegistro";
            this.btnIrUltimoRegistro.Size = new System.Drawing.Size(61, 35);
            this.btnIrUltimoRegistro.TabIndex = 3;
            this.btnIrUltimoRegistro.Text = ">>";
            this.btnIrUltimoRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Location = new System.Drawing.Point(271, 3);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(61, 35);
            this.btnAgregarRegistro.TabIndex = 4;
            this.btnAgregarRegistro.Text = "Agregar";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.Location = new System.Drawing.Point(338, 3);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(61, 35);
            this.btnEliminarRegistro.TabIndex = 5;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.Location = new System.Drawing.Point(405, 3);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(61, 35);
            this.btnActualizarRegistro.TabIndex = 6;
            this.btnActualizarRegistro.Text = "Modificar";
            this.btnActualizarRegistro.UseVisualStyleBackColor = true;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.tableLayoutPanel1);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 409);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(800, 41);
            this.panelBot.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(600, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 32);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(103, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 32);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // panelMid
            // 
            this.panelMid.ColumnCount = 2;
            this.panelMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelMid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panelMid.Controls.Add(this.panelTable, 1, 0);
            this.panelMid.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 47);
            this.panelMid.Name = "panelMid";
            this.panelMid.RowCount = 1;
            this.panelMid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMid.Size = new System.Drawing.Size(800, 362);
            this.panelMid.TabIndex = 3;
            // 
            // panelTable
            // 
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(243, 3);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(554, 356);
            this.panelTable.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 356);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGestionBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Name = "FormGestionBase";
            this.Text = "FormGestionBase";
            this.panelTop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnIrPrimerRegistro;
        private System.Windows.Forms.Button btnIrRegistroAnterior;
        private System.Windows.Forms.Button btnIrRegistroSiguiente;
        private System.Windows.Forms.Button btnIrUltimoRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel panelMid;
        public System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
    }
}