namespace Farmacia.Presentacion.Reportes
{
    partial class FrmRpt_Imprimir_Tiket_Venta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Farmacia = new Farmacia.Presentacion.Reportes.DataSet_Farmacia();
            this.imprimirVentaGeneradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imprimir_Venta_GeneradaTableAdapter = new Farmacia.Presentacion.Reportes.DataSet_FarmaciaTableAdapters.Imprimir_Venta_GeneradaTableAdapter();
            this.Txtp1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Farmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprimirVentaGeneradaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.imprimirVentaGeneradaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia.Presentacion.Reportes.Rpt_Imprimir_Ticket_Venta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(364, 501);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Farmacia
            // 
            this.dataSet_Farmacia.DataSetName = "DataSet_Farmacia";
            this.dataSet_Farmacia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imprimirVentaGeneradaBindingSource
            // 
            this.imprimirVentaGeneradaBindingSource.DataMember = "Imprimir_Venta_Generada";
            this.imprimirVentaGeneradaBindingSource.DataSource = this.dataSet_Farmacia;
            // 
            // imprimir_Venta_GeneradaTableAdapter
            // 
            this.imprimir_Venta_GeneradaTableAdapter.ClearBeforeFill = true;
            // 
            // Txtp1
            // 
            this.Txtp1.Location = new System.Drawing.Point(28, 63);
            this.Txtp1.Name = "Txtp1";
            this.Txtp1.Size = new System.Drawing.Size(174, 20);
            this.Txtp1.TabIndex = 3;
            this.Txtp1.Visible = false;
            // 
            // FrmRpt_Imprimir_Tiket_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 501);
            this.Controls.Add(this.Txtp1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRpt_Imprimir_Tiket_Venta";
            this.Text = "FrmRpt_Imprimir_Tiket_Venta";
            this.Load += new System.EventHandler(this.FrmRpt_Imprimir_Tiket_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Farmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprimirVentaGeneradaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource imprimirVentaGeneradaBindingSource;
        private DataSet_Farmacia dataSet_Farmacia;
        private DataSet_FarmaciaTableAdapters.Imprimir_Venta_GeneradaTableAdapter imprimir_Venta_GeneradaTableAdapter;
        public System.Windows.Forms.TextBox Txtp1;
    }
}