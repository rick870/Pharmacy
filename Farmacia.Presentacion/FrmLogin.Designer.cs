namespace Farmacia.Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.Pnl_form_almacen = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Btniniciar = new System.Windows.Forms.Button();
            this.Txt_login_us = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_password_us = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_form_almacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_form_almacen
            // 
            this.Pnl_form_almacen.BackColor = System.Drawing.Color.Teal;
            this.Pnl_form_almacen.Controls.Add(this.label22);
            this.Pnl_form_almacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_form_almacen.Location = new System.Drawing.Point(0, 0);
            this.Pnl_form_almacen.Name = "Pnl_form_almacen";
            this.Pnl_form_almacen.Size = new System.Drawing.Size(634, 56);
            this.Pnl_form_almacen.TabIndex = 35;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(16, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(256, 32);
            this.label22.TabIndex = 0;
            this.label22.Text = "Inicio de Sesion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(19, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 46);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sistema de Farmacia \r\nver.1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.Color.Gainsboro;
            this.Btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalir.Location = new System.Drawing.Point(419, 161);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(121, 41);
            this.Btnsalir.TabIndex = 43;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Btniniciar
            // 
            this.Btniniciar.BackColor = System.Drawing.Color.LightBlue;
            this.Btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btniniciar.Location = new System.Drawing.Point(292, 161);
            this.Btniniciar.Name = "Btniniciar";
            this.Btniniciar.Size = new System.Drawing.Size(121, 41);
            this.Btniniciar.TabIndex = 42;
            this.Btniniciar.Text = "Iniciar";
            this.Btniniciar.UseVisualStyleBackColor = false;
            this.Btniniciar.Click += new System.EventHandler(this.Btniniciar_Click);
            // 
            // Txt_login_us
            // 
            this.Txt_login_us.Location = new System.Drawing.Point(332, 88);
            this.Txt_login_us.MaxLength = 20;
            this.Txt_login_us.Name = "Txt_login_us";
            this.Txt_login_us.Size = new System.Drawing.Size(147, 20);
            this.Txt_login_us.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Login(*)";
            // 
            // Txt_password_us
            // 
            this.Txt_password_us.Location = new System.Drawing.Point(332, 114);
            this.Txt_password_us.MaxLength = 20;
            this.Txt_password_us.Name = "Txt_password_us";
            this.Txt_password_us.PasswordChar = '*';
            this.Txt_password_us.Size = new System.Drawing.Size(147, 20);
            this.Txt_password_us.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Password(*)";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 241);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btniniciar);
            this.Controls.Add(this.Txt_login_us);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_password_us);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pnl_form_almacen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Pnl_form_almacen.ResumeLayout(false);
            this.Pnl_form_almacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_form_almacen;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button Btniniciar;
        private System.Windows.Forms.TextBox Txt_login_us;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_password_us;
        private System.Windows.Forms.Label label2;
    }
}