namespace Farmacia.Presentacion.Reportes_Consolidados
{
    partial class Frm_Reporte_Salida_AcumuladoxProducto
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
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_vista_previa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Dp_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_salir.Location = new System.Drawing.Point(402, 118);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(115, 34);
            this.Btn_salir.TabIndex = 17;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_vista_previa
            // 
            this.Btn_vista_previa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_vista_previa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_vista_previa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_vista_previa.Location = new System.Drawing.Point(402, 62);
            this.Btn_vista_previa.Name = "Btn_vista_previa";
            this.Btn_vista_previa.Size = new System.Drawing.Size(115, 35);
            this.Btn_vista_previa.TabIndex = 16;
            this.Btn_vista_previa.Text = "Vista Previa";
            this.Btn_vista_previa.UseVisualStyleBackColor = false;
            this.Btn_vista_previa.Click += new System.EventHandler(this.Btn_vista_previa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "FECHA FIN : ";
            // 
            // Dp_fecha_fin
            // 
            this.Dp_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_fecha_fin.Location = new System.Drawing.Point(214, 123);
            this.Dp_fecha_fin.Name = "Dp_fecha_fin";
            this.Dp_fecha_fin.Size = new System.Drawing.Size(104, 20);
            this.Dp_fecha_fin.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "FECHA INICIO : ";
            // 
            // Dp_fecha_ini
            // 
            this.Dp_fecha_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dp_fecha_ini.Location = new System.Drawing.Point(214, 65);
            this.Dp_fecha_ini.Name = "Dp_fecha_ini";
            this.Dp_fecha_ini.Size = new System.Drawing.Size(104, 20);
            this.Dp_fecha_ini.TabIndex = 12;
            // 
            // Frm_Reporte_Salida_AcumuladoxProducto
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
            this.Name = "Frm_Reporte_Salida_AcumuladoxProducto";
            this.Text = "SALIDA ACUMULADO POR PRODUCTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_vista_previa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dp_fecha_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dp_fecha_ini;
    }
}