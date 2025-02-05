namespace Northwind2
{
    partial class FormReportBase
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
            this.cbReports = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.panelViewReport = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cbReports);
            this.panelTop.Controls.Add(this.btnFiltro);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 91);
            this.panelTop.TabIndex = 0;
            // 
            // cbReports
            // 
            this.cbReports.FormattingEnabled = true;
            this.cbReports.Location = new System.Drawing.Point(57, 14);
            this.cbReports.Name = "cbReports";
            this.cbReports.Size = new System.Drawing.Size(200, 21);
            this.cbReports.TabIndex = 1;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltro.Location = new System.Drawing.Point(722, 12);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 0;
            this.btnFiltro.Text = "Ver";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // panelViewReport
            // 
            this.panelViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewReport.Location = new System.Drawing.Point(0, 91);
            this.panelViewReport.Name = "panelViewReport";
            this.panelViewReport.Size = new System.Drawing.Size(800, 359);
            this.panelViewReport.TabIndex = 1;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelViewReport);
            this.Controls.Add(this.panelTop);
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Panel panelViewReport;
        public System.Windows.Forms.Button btnFiltro;
        public System.Windows.Forms.ComboBox cbReports;
    }
}