namespace Farmacia.Presentacion.Reportes
{
    partial class FrmRpt_Provincias
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
            this.provincialistarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincia_listarTableAdapter = new Farmacia.Presentacion.Reportes.DataSet_FarmaciaTableAdapters.provincia_listarTableAdapter();
            this.Txtp1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Farmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincialistarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.provincialistarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia.Presentacion.Reportes.Rpt_Provincias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Farmacia
            // 
            this.dataSet_Farmacia.DataSetName = "DataSet_Farmacia";
            this.dataSet_Farmacia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provincialistarBindingSource
            // 
            this.provincialistarBindingSource.DataMember = "provincia_listar";
            this.provincialistarBindingSource.DataSource = this.dataSet_Farmacia;
            // 
            // provincia_listarTableAdapter
            // 
            this.provincia_listarTableAdapter.ClearBeforeFill = true;
            // 
            // Txtp1
            // 
            this.Txtp1.Location = new System.Drawing.Point(52, 88);
            this.Txtp1.Name = "Txtp1";
            this.Txtp1.Size = new System.Drawing.Size(174, 20);
            this.Txtp1.TabIndex = 5;
            this.Txtp1.Visible = false;
            // 
            // FrmRpt_Provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txtp1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRpt_Provincias";
            this.Text = "FrmRpt_Provincias";
            this.Load += new System.EventHandler(this.FrmRpt_Provincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Farmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincialistarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource provincialistarBindingSource;
        private DataSet_Farmacia dataSet_Farmacia;
        private DataSet_FarmaciaTableAdapters.provincia_listarTableAdapter provincia_listarTableAdapter;
        public System.Windows.Forms.TextBox Txtp1;
    }
}