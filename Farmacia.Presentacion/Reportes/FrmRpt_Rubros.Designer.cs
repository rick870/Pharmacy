namespace Farmacia.Presentacion.Reportes
{
    partial class FrmRpt_Rubros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Farmacia = new Farmacia.Presentacion.Reportes.DataSet_Farmacia();
            this.rubrolistarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubro_listarTableAdapter = new Farmacia.Presentacion.Reportes.DataSet_FarmaciaTableAdapters.rubro_listarTableAdapter();
            this.Txtp1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Farmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrolistarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.rubrolistarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia.Presentacion.Reportes.Rpt_Rubros.rdlc";
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
            // rubrolistarBindingSource
            // 
            this.rubrolistarBindingSource.DataMember = "rubro_listar";
            this.rubrolistarBindingSource.DataSource = this.dataSet_Farmacia;
            // 
            // rubro_listarTableAdapter
            // 
            this.rubro_listarTableAdapter.ClearBeforeFill = true;
            // 
            // Txtp1
            // 
            this.Txtp1.Location = new System.Drawing.Point(64, 83);
            this.Txtp1.Name = "Txtp1";
            this.Txtp1.Size = new System.Drawing.Size(174, 20);
            this.Txtp1.TabIndex = 3;
            this.Txtp1.Visible = false;
            // 
            // FrmRpt_Rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txtp1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRpt_Rubros";
            this.Text = "FrmRpt_Rubros";
            this.Load += new System.EventHandler(this.FrmRpt_Rubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Farmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrolistarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rubrolistarBindingSource;
        private DataSet_Farmacia dataSet_Farmacia;
        private DataSet_FarmaciaTableAdapters.rubro_listarTableAdapter rubro_listarTableAdapter;
        public System.Windows.Forms.TextBox Txtp1;
    }
}