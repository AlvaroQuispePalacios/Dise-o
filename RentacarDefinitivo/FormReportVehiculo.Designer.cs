namespace RentacarDefinitivo
{
    partial class FormReportVehiculo
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelParams = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.rentacarDataSet = new RentacarDefinitivo.rentacarDataSet();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculoTableAdapter = new RentacarDefinitivo.rentacarDataSetTableAdapters.vehiculoTableAdapter();
            this.tableAdapterManager = new RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParams
            // 
            this.panelParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParams.Location = new System.Drawing.Point(0, 0);
            this.panelParams.Name = "panelParams";
            this.panelParams.Size = new System.Drawing.Size(800, 78);
            this.panelParams.TabIndex = 0;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.reportViewer1);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 78);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(800, 383);
            this.panelReport.TabIndex = 1;
            // 
            // rentacarDataSet
            // 
            this.rentacarDataSet.DataSetName = "rentacarDataSet";
            this.rentacarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "vehiculo";
            this.vehiculoBindingSource.DataSource = this.rentacarDataSet;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carrecsTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contracteTableAdapter = null;
            this.tableAdapterManager.modeloTableAdapter = null;
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.restriccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentacarDefinitivo.rentacarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.vehiculoTableAdapter = this.vehiculoTableAdapter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReportVehiculos";
            reportDataSource1.Value = this.vehiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RentacarDefinitivo.ReportVehiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 383);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormReportVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelParams);
            this.Name = "FormReportVehiculo";
            this.Text = "FormReportVehiculo";
            this.Load += new System.EventHandler(this.FormReportVehiculo_Load);
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParams;
        private System.Windows.Forms.Panel panelReport;
        private rentacarDataSet rentacarDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private rentacarDataSetTableAdapters.vehiculoTableAdapter vehiculoTableAdapter;
        private rentacarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}