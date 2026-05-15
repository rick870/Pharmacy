namespace Farmacia.Presentacion.Reportes_Consolidados
{
    partial class Frm_Rpt_Salida_AcumuladoxProductos
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
            this.dataSet_Reportes_Consolidados = new Farmacia.Presentacion.Reportes_Consolidados.DataSet_Reportes_Consolidados();
            this.reporteSalidaAcumuladoxProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_Salida_AcumuladoxProductoTableAdapter = new Farmacia.Presentacion.Reportes_Consolidados.DataSet_Reportes_ConsolidadosTableAdapters.Reporte_Salida_AcumuladoxProductoTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Consolidados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSalidaAcumuladoxProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.reporteSalidaAcumuladoxProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia.Presentacion.Reportes_Consolidados.Rpt_Salida_AcumuladoProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1295, 622);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Reportes_Consolidados
            // 
            this.dataSet_Reportes_Consolidados.DataSetName = "DataSet_Reportes_Consolidados";
            this.dataSet_Reportes_Consolidados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteSalidaAcumuladoxProductoBindingSource
            // 
            this.reporteSalidaAcumuladoxProductoBindingSource.DataMember = "Reporte_Salida_AcumuladoxProducto";
            this.reporteSalidaAcumuladoxProductoBindingSource.DataSource = this.dataSet_Reportes_Consolidados;
            // 
            // reporte_Salida_AcumuladoxProductoTableAdapter
            // 
            this.reporte_Salida_AcumuladoxProductoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(63, 145);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(174, 20);
            this.txt_p2.TabIndex = 7;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(63, 80);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(174, 20);
            this.txt_p1.TabIndex = 6;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Salida_AcumuladoxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 622);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Salida_AcumuladoxProductos";
            this.Text = "Frm_Rpt_Salida_AcumuladoxProductos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Salida_AcumuladoxProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Consolidados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSalidaAcumuladoxProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteSalidaAcumuladoxProductoBindingSource;
        private DataSet_Reportes_Consolidados dataSet_Reportes_Consolidados;
        private DataSet_Reportes_ConsolidadosTableAdapters.Reporte_Salida_AcumuladoxProductoTableAdapter reporte_Salida_AcumuladoxProductoTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}