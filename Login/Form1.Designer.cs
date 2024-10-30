namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo = new Label();
            tbUsuario = new TextBox();
            tbContrasenya = new TextBox();
            lbContrasenya = new Label();
            lbUsuario = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(263, 25);
            titulo.Margin = new Padding(6, 0, 6, 0);
            titulo.Name = "titulo";
            titulo.Size = new Size(84, 37);
            titulo.TabIndex = 0;
            titulo.Text = "Login";
            titulo.Click += label1_Click;
            // 
            // tbUsuario
            // 
            tbUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsuario.Location = new Point(198, 142);
            tbUsuario.Margin = new Padding(6, 7, 6, 7);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(210, 33);
            tbUsuario.TabIndex = 1;
            tbUsuario.TextChanged += tbUsuario_TextChanged;
            // 
            // tbContrasenya
            // 
            tbContrasenya.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContrasenya.Location = new Point(198, 251);
            tbContrasenya.Margin = new Padding(6, 7, 6, 7);
            tbContrasenya.Name = "tbContrasenya";
            tbContrasenya.Size = new Size(210, 33);
            tbContrasenya.TabIndex = 2;
            tbContrasenya.TextChanged += tbContrasenya_TextChanged;
            // 
            // lbContrasenya
            // 
            lbContrasenya.AutoSize = true;
            lbContrasenya.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContrasenya.Location = new Point(253, 219);
            lbContrasenya.Margin = new Padding(6, 0, 6, 0);
            lbContrasenya.Name = "lbContrasenya";
            lbContrasenya.Size = new Size(108, 25);
            lbContrasenya.TabIndex = 3;
            lbContrasenya.Text = "Contraseña";
            lbContrasenya.Click += lbContrasenya_Click;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(270, 101);
            lbUsuario.Margin = new Padding(6, 0, 6, 0);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(77, 25);
            lbUsuario.TabIndex = 4;
            lbUsuario.Text = "Usuario";
            lbUsuario.Click += label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(198, 334);
            btnLogin.Margin = new Padding(6, 7, 6, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(210, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 448);
            Controls.Add(btnLogin);
            Controls.Add(lbUsuario);
            Controls.Add(lbContrasenya);
            Controls.Add(tbContrasenya);
            Controls.Add(tbUsuario);
            Controls.Add(titulo);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private TextBox tbUsuario;
        private TextBox tbContrasenya;
        private Label lbContrasenya;
        private Label lbUsuario;
        private Button btnLogin;
    }
}
