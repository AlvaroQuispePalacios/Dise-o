namespace Northwind2
{
    partial class FormLogin
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
            this.panelContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lbPwd = new System.Windows.Forms.Label();
            this.btnValidarUsuario = new System.Windows.Forms.Button();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panelBase.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.panelContenedor);
            this.panelBase.Size = new System.Drawing.Size(361, 420);
            // 
            // panelContenedor
            // 
            this.panelContenedor.ColumnCount = 1;
            this.panelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContenedor.Controls.Add(this.label1, 0, 0);
            this.panelContenedor.Controls.Add(this.panelContainer, 0, 1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.RowCount = 2;
            this.panelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.panelContenedor.Size = new System.Drawing.Size(361, 420);
            this.panelContenedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.lbPwd);
            this.panelContainer.Controls.Add(this.btnValidarUsuario);
            this.panelContainer.Controls.Add(this.tbPwd);
            this.panelContainer.Controls.Add(this.tbUsuario);
            this.panelContainer.Controls.Add(this.lbUsuario);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(3, 73);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(355, 344);
            this.panelContainer.TabIndex = 1;
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPwd.Location = new System.Drawing.Point(50, 105);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(92, 20);
            this.lbPwd.TabIndex = 5;
            this.lbPwd.Text = "Contraseña";
            // 
            // btnValidarUsuario
            // 
            this.btnValidarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarUsuario.Location = new System.Drawing.Point(54, 176);
            this.btnValidarUsuario.Name = "btnValidarUsuario";
            this.btnValidarUsuario.Size = new System.Drawing.Size(252, 31);
            this.btnValidarUsuario.TabIndex = 4;
            this.btnValidarUsuario.Text = "Ingresar";
            this.btnValidarUsuario.UseVisualStyleBackColor = true;
            this.btnValidarUsuario.Click += new System.EventHandler(this.btnValidarUsuario_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPwd.Location = new System.Drawing.Point(54, 128);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(252, 24);
            this.tbPwd.TabIndex = 3;
            // 
            // tbUsuario
            // 
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(54, 70);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(252, 24);
            this.tbUsuario.TabIndex = 2;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(50, 47);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(64, 20);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 420);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panelBase.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.Button btnValidarUsuario;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbUsuario;
    }
}