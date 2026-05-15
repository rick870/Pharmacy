namespace Farmacia.Presentacion
{
    partial class FrmDistritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistritos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btnreporte = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btneditar = new System.Windows.Forms.Button();
            this.Btnnuevo = new System.Windows.Forms.Button();
            this.Tbprincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.Dgprincipal = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Pnl_Listado_po = new System.Windows.Forms.Panel();
            this.Btnretornar1 = new System.Windows.Forms.Button();
            this.Btnbuscar1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtbuscar1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dgprovincias = new System.Windows.Forms.DataGridView();
            this.Txtdescripcion_po = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btnlupa_1 = new System.Windows.Forms.Button();
            this.Btnretornar = new System.Windows.Forms.Button();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.Txtdescripcion_di = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_form_almacen = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.Tbprincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pnl_Listado_po.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprovincias)).BeginInit();
            this.Pnl_form_almacen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.Color.AliceBlue;
            this.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnsalir.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btnsalir.ImageKey = "salir.png";
            this.Btnsalir.ImageList = this.imageList1;
            this.Btnsalir.Location = new System.Drawing.Point(436, 515);
            this.Btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(80, 61);
            this.Btnsalir.TabIndex = 23;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "actualizar.png");
            this.imageList1.Images.SetKeyName(1, "eliminar.png");
            this.imageList1.Images.SetKeyName(2, "lupa.png");
            this.imageList1.Images.SetKeyName(3, "nuevo.png");
            this.imageList1.Images.SetKeyName(4, "reporte.png");
            this.imageList1.Images.SetKeyName(5, "retornar.png");
            this.imageList1.Images.SetKeyName(6, "salir.png");
            // 
            // Btnreporte
            // 
            this.Btnreporte.BackColor = System.Drawing.Color.AliceBlue;
            this.Btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnreporte.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnreporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btnreporte.ImageKey = "reporte.png";
            this.Btnreporte.ImageList = this.imageList1;
            this.Btnreporte.Location = new System.Drawing.Point(336, 515);
            this.Btnreporte.Margin = new System.Windows.Forms.Padding(2);
            this.Btnreporte.Name = "Btnreporte";
            this.Btnreporte.Size = new System.Drawing.Size(80, 61);
            this.Btnreporte.TabIndex = 22;
            this.Btnreporte.Text = "Reporte";
            this.Btnreporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btnreporte.UseVisualStyleBackColor = false;
            this.Btnreporte.Click += new System.EventHandler(this.Btnreporte_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.Btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btneliminar.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btneliminar.ImageKey = "eliminar.png";
            this.Btneliminar.ImageList = this.imageList1;
            this.Btneliminar.Location = new System.Drawing.Point(235, 515);
            this.Btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(80, 61);
            this.Btneliminar.TabIndex = 21;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btneliminar.UseVisualStyleBackColor = false;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btneditar
            // 
            this.Btneditar.BackColor = System.Drawing.Color.AliceBlue;
            this.Btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btneditar.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btneditar.ImageKey = "actualizar.png";
            this.Btneditar.ImageList = this.imageList1;
            this.Btneditar.Location = new System.Drawing.Point(136, 515);
            this.Btneditar.Margin = new System.Windows.Forms.Padding(2);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(80, 61);
            this.Btneditar.TabIndex = 20;
            this.Btneditar.Text = "Editar";
            this.Btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btneditar.UseVisualStyleBackColor = false;
            this.Btneditar.Click += new System.EventHandler(this.Btneditar_Click);
            // 
            // Btnnuevo
            // 
            this.Btnnuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.Btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnnuevo.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btnnuevo.ImageKey = "nuevo.png";
            this.Btnnuevo.ImageList = this.imageList1;
            this.Btnnuevo.Location = new System.Drawing.Point(39, 515);
            this.Btnnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.Btnnuevo.Name = "Btnnuevo";
            this.Btnnuevo.Size = new System.Drawing.Size(80, 61);
            this.Btnnuevo.TabIndex = 19;
            this.Btnnuevo.Text = "Nuevo";
            this.Btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btnnuevo.UseVisualStyleBackColor = false;
            this.Btnnuevo.Click += new System.EventHandler(this.Btnnuevo_Click);
            // 
            // Tbprincipal
            // 
            this.Tbprincipal.Controls.Add(this.tabPage1);
            this.Tbprincipal.Controls.Add(this.tabPage2);
            this.Tbprincipal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbprincipal.Location = new System.Drawing.Point(21, 73);
            this.Tbprincipal.Margin = new System.Windows.Forms.Padding(2);
            this.Tbprincipal.Name = "Tbprincipal";
            this.Tbprincipal.SelectedIndex = 0;
            this.Tbprincipal.Size = new System.Drawing.Size(1097, 426);
            this.Tbprincipal.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.Btnbuscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Txtbuscar);
            this.tabPage1.Controls.Add(this.Dgprincipal);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1089, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnbuscar.ForeColor = System.Drawing.Color.White;
            this.Btnbuscar.Location = new System.Drawing.Point(483, 23);
            this.Btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(87, 28);
            this.Btnbuscar.TabIndex = 3;
            this.Btnbuscar.Text = "Buscar";
            this.Btnbuscar.UseVisualStyleBackColor = false;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbuscar.Location = new System.Drawing.Point(135, 26);
            this.Txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(286, 26);
            this.Txtbuscar.TabIndex = 1;
            // 
            // Dgprincipal
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgprincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgprincipal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgprincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgprincipal.ColumnHeadersHeight = 38;
            this.Dgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgprincipal.EnableHeadersVisualStyles = false;
            this.Dgprincipal.Location = new System.Drawing.Point(19, 57);
            this.Dgprincipal.Margin = new System.Windows.Forms.Padding(2);
            this.Dgprincipal.Name = "Dgprincipal";
            this.Dgprincipal.RowHeadersWidth = 51;
            this.Dgprincipal.RowTemplate.Height = 24;
            this.Dgprincipal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgprincipal.Size = new System.Drawing.Size(1055, 303);
            this.Dgprincipal.TabIndex = 0;
            this.Dgprincipal.DoubleClick += new System.EventHandler(this.Dgprincipal_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.Pnl_Listado_po);
            this.tabPage2.Controls.Add(this.Txtdescripcion_po);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Btnlupa_1);
            this.tabPage2.Controls.Add(this.Btnretornar);
            this.tabPage2.Controls.Add(this.Btnguardar);
            this.tabPage2.Controls.Add(this.Btncancelar);
            this.tabPage2.Controls.Add(this.Txtdescripcion_di);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1089, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // Pnl_Listado_po
            // 
            this.Pnl_Listado_po.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(154)))));
            this.Pnl_Listado_po.Controls.Add(this.Btnretornar1);
            this.Pnl_Listado_po.Controls.Add(this.Btnbuscar1);
            this.Pnl_Listado_po.Controls.Add(this.label9);
            this.Pnl_Listado_po.Controls.Add(this.Txtbuscar1);
            this.Pnl_Listado_po.Controls.Add(this.label8);
            this.Pnl_Listado_po.Controls.Add(this.Dgprovincias);
            this.Pnl_Listado_po.Location = new System.Drawing.Point(356, 21);
            this.Pnl_Listado_po.Name = "Pnl_Listado_po";
            this.Pnl_Listado_po.Size = new System.Drawing.Size(646, 244);
            this.Pnl_Listado_po.TabIndex = 33;
            this.Pnl_Listado_po.Visible = false;
            // 
            // Btnretornar1
            // 
            this.Btnretornar1.ImageKey = "retornar.png";
            this.Btnretornar1.ImageList = this.imageList1;
            this.Btnretornar1.Location = new System.Drawing.Point(235, 37);
            this.Btnretornar1.Name = "Btnretornar1";
            this.Btnretornar1.Size = new System.Drawing.Size(46, 30);
            this.Btnretornar1.TabIndex = 25;
            this.Btnretornar1.UseVisualStyleBackColor = true;
            this.Btnretornar1.Click += new System.EventHandler(this.Btnretornar1_Click);
            // 
            // Btnbuscar1
            // 
            this.Btnbuscar1.ImageKey = "lupa.png";
            this.Btnbuscar1.ImageList = this.imageList1;
            this.Btnbuscar1.Location = new System.Drawing.Point(198, 37);
            this.Btnbuscar1.Name = "Btnbuscar1";
            this.Btnbuscar1.Size = new System.Drawing.Size(34, 30);
            this.Btnbuscar1.TabIndex = 24;
            this.Btnbuscar1.UseVisualStyleBackColor = true;
            this.Btnbuscar1.Click += new System.EventHandler(this.Btnbuscar1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Buscar:";
            // 
            // Txtbuscar1
            // 
            this.Txtbuscar1.Location = new System.Drawing.Point(77, 41);
            this.Txtbuscar1.Name = "Txtbuscar1";
            this.Txtbuscar1.Size = new System.Drawing.Size(115, 26);
            this.Txtbuscar1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "LISTADO DE DEPARTAMENTOS Y PROVINCIAS";
            // 
            // Dgprovincias
            // 
            this.Dgprovincias.AllowUserToAddRows = false;
            this.Dgprovincias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Menu;
            this.Dgprovincias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgprovincias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgprovincias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgprovincias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgprovincias.ColumnHeadersHeight = 35;
            this.Dgprovincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgprovincias.EnableHeadersVisualStyles = false;
            this.Dgprovincias.Location = new System.Drawing.Point(16, 80);
            this.Dgprovincias.Name = "Dgprovincias";
            this.Dgprovincias.ReadOnly = true;
            this.Dgprovincias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgprovincias.Size = new System.Drawing.Size(615, 150);
            this.Dgprovincias.TabIndex = 20;
            this.Dgprovincias.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgprovincias_CellContentDoubleClick);
            // 
            // Txtdescripcion_po
            // 
            this.Txtdescripcion_po.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Txtdescripcion_po.Location = new System.Drawing.Point(155, 47);
            this.Txtdescripcion_po.Margin = new System.Windows.Forms.Padding(2);
            this.Txtdescripcion_po.Name = "Txtdescripcion_po";
            this.Txtdescripcion_po.ReadOnly = true;
            this.Txtdescripcion_po.Size = new System.Drawing.Size(256, 26);
            this.Txtdescripcion_po.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(29, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Provincias: (*)";
            // 
            // Btnlupa_1
            // 
            this.Btnlupa_1.ImageKey = "lupa.png";
            this.Btnlupa_1.ImageList = this.imageList1;
            this.Btnlupa_1.Location = new System.Drawing.Point(430, 42);
            this.Btnlupa_1.Name = "Btnlupa_1";
            this.Btnlupa_1.Size = new System.Drawing.Size(40, 31);
            this.Btnlupa_1.TabIndex = 14;
            this.Btnlupa_1.UseVisualStyleBackColor = true;
            this.Btnlupa_1.Click += new System.EventHandler(this.Btnlupa_1_Click);
            // 
            // Btnretornar
            // 
            this.Btnretornar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Btnretornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnretornar.ForeColor = System.Drawing.Color.White;
            this.Btnretornar.Location = new System.Drawing.Point(356, 192);
            this.Btnretornar.Margin = new System.Windows.Forms.Padding(2);
            this.Btnretornar.Name = "Btnretornar";
            this.Btnretornar.Size = new System.Drawing.Size(87, 28);
            this.Btnretornar.TabIndex = 7;
            this.Btnretornar.Text = "Retornar";
            this.Btnretornar.UseVisualStyleBackColor = false;
            this.Btnretornar.Click += new System.EventHandler(this.Btnretornar_Click);
            // 
            // Btnguardar
            // 
            this.Btnguardar.BackColor = System.Drawing.Color.LightSlateGray;
            this.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnguardar.ForeColor = System.Drawing.Color.White;
            this.Btnguardar.Location = new System.Drawing.Point(247, 192);
            this.Btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(87, 28);
            this.Btnguardar.TabIndex = 6;
            this.Btnguardar.Text = "Guardar";
            this.Btnguardar.UseVisualStyleBackColor = false;
            this.Btnguardar.Visible = false;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // Btncancelar
            // 
            this.Btncancelar.BackColor = System.Drawing.Color.Sienna;
            this.Btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncancelar.ForeColor = System.Drawing.Color.White;
            this.Btncancelar.Location = new System.Drawing.Point(142, 192);
            this.Btncancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(87, 28);
            this.Btncancelar.TabIndex = 5;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.UseVisualStyleBackColor = false;
            this.Btncancelar.Visible = false;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // Txtdescripcion_di
            // 
            this.Txtdescripcion_di.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Txtdescripcion_di.Location = new System.Drawing.Point(155, 101);
            this.Txtdescripcion_di.Margin = new System.Windows.Forms.Padding(2);
            this.Txtdescripcion_di.MaxLength = 100;
            this.Txtdescripcion_di.Name = "Txtdescripcion_di";
            this.Txtdescripcion_di.ReadOnly = true;
            this.Txtdescripcion_di.Size = new System.Drawing.Size(256, 26);
            this.Txtdescripcion_di.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Distritos: (*)";
            // 
            // Pnl_form_almacen
            // 
            this.Pnl_form_almacen.BackColor = System.Drawing.Color.Teal;
            this.Pnl_form_almacen.Controls.Add(this.label22);
            this.Pnl_form_almacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_form_almacen.Location = new System.Drawing.Point(0, 0);
            this.Pnl_form_almacen.Name = "Pnl_form_almacen";
            this.Pnl_form_almacen.Size = new System.Drawing.Size(1129, 56);
            this.Pnl_form_almacen.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(16, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(184, 32);
            this.label22.TabIndex = 0;
            this.label22.Text = "DISTRITOS";
            // 
            // FrmDistritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 599);
            this.Controls.Add(this.Pnl_form_almacen);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnreporte);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btneditar);
            this.Controls.Add(this.Btnnuevo);
            this.Controls.Add(this.Tbprincipal);
            this.Name = "FrmDistritos";
            this.Text = "DISTRITOS";
            this.Load += new System.EventHandler(this.FrmDistritos_Load);
            this.Tbprincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprincipal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pnl_Listado_po.ResumeLayout(false);
            this.Pnl_Listado_po.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgprovincias)).EndInit();
            this.Pnl_form_almacen.ResumeLayout(false);
            this.Pnl_form_almacen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Button Btnreporte;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btneditar;
        private System.Windows.Forms.Button Btnnuevo;
        private System.Windows.Forms.TabControl Tbprincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtbuscar;
        private System.Windows.Forms.DataGridView Dgprincipal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btnretornar;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.TextBox Txtdescripcion_di;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox Txtdescripcion_po;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btnlupa_1;
        private System.Windows.Forms.Panel Pnl_Listado_po;
        private System.Windows.Forms.Button Btnretornar1;
        private System.Windows.Forms.Button Btnbuscar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txtbuscar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dgprovincias;
        private System.Windows.Forms.Panel Pnl_form_almacen;
        private System.Windows.Forms.Label label22;
    }
}