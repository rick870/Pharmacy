namespace Farmacia.Presentacion.Reportes_Consolidados
{
    partial class Frm_Reporte_Ingreso_ComprasxProductos
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
            this.Dp_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.Btn_vista_previa = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dp_fecha_ini
            // 
            this.Dp_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_fecha_ini.Location = new System.Drawing.Point(217, 48);
            this.Dp_fecha_ini.Name = "Dp_fecha_ini";
            this.Dp_fecha_ini.Size = new System.Drawing.Size(104, 20);
            this.Dp_fecha_ini.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA INICIO : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA FIN : ";
            // 
            // Dp_fecha_fin
            // 
            this.Dp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_fecha_fin.Location = new System.Drawing.Point(217, 106);
            this.Dp_fecha_fin.Name = "Dp_fecha_fin";
            this.Dp_fecha_fin.Size = new System.Drawing.Size(104, 20);
            this.Dp_fecha_fin.TabIndex = 2;
            // 
            // Btn_vista_previa
            // 
            this.Btn_vista_previa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_vista_previa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_vista_previa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_vista_previa.Location = new System.Drawing.Point(405, 45);
            this.Btn_vista_previa.Name = "Btn_vista_previa";
            this.Btn_vista_previa.Size = new System.Drawing.Size(115, 35);
            this.Btn_vista_previa.TabIndex = 4;
            this.Btn_vista_previa.Text = "Vista Previa";
            this.Btn_vista_previa.UseVisualStyleBackColor = false;
            this.Btn_vista_previa.Click += new System.EventHandler(this.Btn_vista_previa_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_salir.Location = new System.Drawing.Point(405, 101);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(115, 34);
            this.Btn_salir.TabIndex = 5;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Frm_Reporte_Ingreso_ComprasxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 251);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_vista_previa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dp_fecha_fin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dp_fecha_ini);
            this.Name = "Frm_Reporte_Ingreso_ComprasxProductos";
            this.Text = "REPORTE INGRESOS COMPRAS POR PRODUCTOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dp_fecha_ini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dp_fecha_fin;
        private System.Windows.Forms.Button Btn_vista_previa;
        private System.Windows.Forms.Button Btn_salir;
    }
}