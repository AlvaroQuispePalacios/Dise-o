namespace Northwind2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorAñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteOrdenes1996ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteOrden1997ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioHeredadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosGestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteClientesToolStripMenuItem,
            this.reporteOrdenesToolStripMenuItem,
            this.reportesPorAñoToolStripMenuItem,
            this.formularioHeredadoToolStripMenuItem,
            this.formulariosGestiónToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.reporteClientesToolStripMenuItem.Text = "Reporte Clientes";
            this.reporteClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteClientesToolStripMenuItem_Click);
            // 
            // reporteOrdenesToolStripMenuItem
            // 
            this.reporteOrdenesToolStripMenuItem.Name = "reporteOrdenesToolStripMenuItem";
            this.reporteOrdenesToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.reporteOrdenesToolStripMenuItem.Text = "Reporte Ordenes Clientes";
            this.reporteOrdenesToolStripMenuItem.Click += new System.EventHandler(this.reporteOrdenesToolStripMenuItem_Click);
            // 
            // reportesPorAñoToolStripMenuItem
            // 
            this.reportesPorAñoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteOrdenes1996ToolStripMenuItem,
            this.reporteOrden1997ToolStripMenuItem});
            this.reportesPorAñoToolStripMenuItem.Name = "reportesPorAñoToolStripMenuItem";
            this.reportesPorAñoToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.reportesPorAñoToolStripMenuItem.Text = "Reporte ordenes por año";
            this.reportesPorAñoToolStripMenuItem.Click += new System.EventHandler(this.reportesPorAñoToolStripMenuItem_Click);
            // 
            // reporteOrdenes1996ToolStripMenuItem
            // 
            this.reporteOrdenes1996ToolStripMenuItem.Name = "reporteOrdenes1996ToolStripMenuItem";
            this.reporteOrdenes1996ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.reporteOrdenes1996ToolStripMenuItem.Text = "Reporte orden 1996";
            // 
            // reporteOrden1997ToolStripMenuItem
            // 
            this.reporteOrden1997ToolStripMenuItem.Name = "reporteOrden1997ToolStripMenuItem";
            this.reporteOrden1997ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.reporteOrden1997ToolStripMenuItem.Text = "Reporte orden 1997";
            // 
            // formularioHeredadoToolStripMenuItem
            // 
            this.formularioHeredadoToolStripMenuItem.Name = "formularioHeredadoToolStripMenuItem";
            this.formularioHeredadoToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.formularioHeredadoToolStripMenuItem.Text = "Formulario Heredado";
            this.formularioHeredadoToolStripMenuItem.Click += new System.EventHandler(this.formularioHeredadoToolStripMenuItem_Click);
            // 
            // formulariosGestiónToolStripMenuItem
            // 
            this.formulariosGestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.gestiónEmployeesToolStripMenuItem});
            this.formulariosGestiónToolStripMenuItem.Name = "formulariosGestiónToolStripMenuItem";
            this.formulariosGestiónToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.formulariosGestiónToolStripMenuItem.Text = "Formularios Gestión";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestiónToolStripMenuItem.Text = "Gestión Customers";
            this.gestiónToolStripMenuItem.Click += new System.EventHandler(this.gestiónToolStripMenuItem_Click);
            // 
            // gestiónEmployeesToolStripMenuItem
            // 
            this.gestiónEmployeesToolStripMenuItem.Name = "gestiónEmployeesToolStripMenuItem";
            this.gestiónEmployeesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestiónEmployeesToolStripMenuItem.Text = "Gestión Employees";
            this.gestiónEmployeesToolStripMenuItem.Click += new System.EventHandler(this.gestiónEmployeesToolStripMenuItem_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 24);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 426);
            this.panelContainer.TabIndex = 1;
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteOrdenesToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripMenuItem reportesPorAñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteOrdenes1996ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteOrden1997ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioHeredadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulariosGestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

