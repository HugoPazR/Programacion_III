namespace Vinos_Scribe_Hugo
{
    partial class Gestion_De_Vinos
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
            this.LbGestionV = new System.Windows.Forms.Label();
            this.Gbox_GV = new System.Windows.Forms.GroupBox();
            this.GB_InfoVino = new System.Windows.Forms.GroupBox();
            this.Txt_Origen = new System.Windows.Forms.TextBox();
            this.Txt_ContA = new System.Windows.Forms.TextBox();
            this.Txt_Elaboracion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Cb_Color = new System.Windows.Forms.ComboBox();
            this.Cb_Tipo = new System.Windows.Forms.ComboBox();
            this.Cb_Presentacion = new System.Windows.Forms.ComboBox();
            this.Lb_Color = new System.Windows.Forms.Label();
            this.Lb_Origen = new System.Windows.Forms.Label();
            this.Lb_Tipo = new System.Windows.Forms.Label();
            this.Lb_ContA = new System.Windows.Forms.Label();
            this.Lb_Elaboracion = new System.Windows.Forms.Label();
            this.Lb_Presentacion = new System.Windows.Forms.Label();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Examinar = new System.Windows.Forms.Button();
            this.Picture_Vino = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tabla_Vinos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año_Elaboracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contenido_Azucar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar_de_Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color_Dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gbox_GV.SuspendLayout();
            this.GB_InfoVino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Vino)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Vinos)).BeginInit();
            this.SuspendLayout();
            // 
            // LbGestionV
            // 
            this.LbGestionV.AutoSize = true;
            this.LbGestionV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LbGestionV.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGestionV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbGestionV.Location = new System.Drawing.Point(226, 16);
            this.LbGestionV.Name = "LbGestionV";
            this.LbGestionV.Size = new System.Drawing.Size(388, 53);
            this.LbGestionV.TabIndex = 0;
            this.LbGestionV.Text = "Gestión De Vinos";
            this.LbGestionV.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gbox_GV
            // 
            this.Gbox_GV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gbox_GV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Gbox_GV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gbox_GV.Controls.Add(this.LbGestionV);
            this.Gbox_GV.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gbox_GV.Enabled = false;
            this.Gbox_GV.Location = new System.Drawing.Point(0, -3);
            this.Gbox_GV.Name = "Gbox_GV";
            this.Gbox_GV.Size = new System.Drawing.Size(803, 81);
            this.Gbox_GV.TabIndex = 2;
            this.Gbox_GV.TabStop = false;
            this.Gbox_GV.Enter += new System.EventHandler(this.Gbox_GV_Enter);
            // 
            // GB_InfoVino
            // 
            this.GB_InfoVino.Controls.Add(this.Txt_Origen);
            this.GB_InfoVino.Controls.Add(this.Txt_ContA);
            this.GB_InfoVino.Controls.Add(this.Txt_Elaboracion);
            this.GB_InfoVino.Controls.Add(this.TxtNombre);
            this.GB_InfoVino.Controls.Add(this.Cb_Color);
            this.GB_InfoVino.Controls.Add(this.Cb_Tipo);
            this.GB_InfoVino.Controls.Add(this.Cb_Presentacion);
            this.GB_InfoVino.Controls.Add(this.Lb_Color);
            this.GB_InfoVino.Controls.Add(this.Lb_Origen);
            this.GB_InfoVino.Controls.Add(this.Lb_Tipo);
            this.GB_InfoVino.Controls.Add(this.Lb_ContA);
            this.GB_InfoVino.Controls.Add(this.Lb_Elaboracion);
            this.GB_InfoVino.Controls.Add(this.Lb_Presentacion);
            this.GB_InfoVino.Controls.Add(this.Lb_Nombre);
            this.GB_InfoVino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_InfoVino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB_InfoVino.Location = new System.Drawing.Point(58, 107);
            this.GB_InfoVino.Margin = new System.Windows.Forms.Padding(2);
            this.GB_InfoVino.Name = "GB_InfoVino";
            this.GB_InfoVino.Padding = new System.Windows.Forms.Padding(2);
            this.GB_InfoVino.Size = new System.Drawing.Size(278, 256);
            this.GB_InfoVino.TabIndex = 3;
            this.GB_InfoVino.TabStop = false;
            this.GB_InfoVino.Text = "Informacion del Vino";
            // 
            // Txt_Origen
            // 
            this.Txt_Origen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Origen.Enabled = false;
            this.Txt_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Origen.Location = new System.Drawing.Point(175, 180);
            this.Txt_Origen.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Origen.Name = "Txt_Origen";
            this.Txt_Origen.Size = new System.Drawing.Size(85, 19);
            this.Txt_Origen.TabIndex = 10;
            // 
            // Txt_ContA
            // 
            this.Txt_ContA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ContA.Enabled = false;
            this.Txt_ContA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ContA.Location = new System.Drawing.Point(175, 119);
            this.Txt_ContA.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_ContA.Name = "Txt_ContA";
            this.Txt_ContA.Size = new System.Drawing.Size(85, 19);
            this.Txt_ContA.TabIndex = 11;
            // 
            // Txt_Elaboracion
            // 
            this.Txt_Elaboracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Elaboracion.Enabled = false;
            this.Txt_Elaboracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Elaboracion.Location = new System.Drawing.Point(175, 89);
            this.Txt_Elaboracion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Elaboracion.Name = "Txt_Elaboracion";
            this.Txt_Elaboracion.Size = new System.Drawing.Size(85, 19);
            this.Txt_Elaboracion.TabIndex = 10;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(175, 27);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(85, 19);
            this.TxtNombre.TabIndex = 9;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.MouseEnter += new System.EventHandler(this.TxtNombre_MouseEnter);
            this.TxtNombre.MouseLeave += new System.EventHandler(this.TxtNombre_MouseLeave);
            // 
            // Cb_Color
            // 
            this.Cb_Color.Enabled = false;
            this.Cb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Color.FormattingEnabled = true;
            this.Cb_Color.Items.AddRange(new object[] {
            "Elija una Opcion:",
            "BLANCO",
            "TINTO",
            "ROSADO"});
            this.Cb_Color.Location = new System.Drawing.Point(175, 208);
            this.Cb_Color.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_Color.Name = "Cb_Color";
            this.Cb_Color.Size = new System.Drawing.Size(86, 21);
            this.Cb_Color.TabIndex = 8;
            // 
            // Cb_Tipo
            // 
            this.Cb_Tipo.Enabled = false;
            this.Cb_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Tipo.FormattingEnabled = true;
            this.Cb_Tipo.Items.AddRange(new object[] {
            "Elija una opcion:",
            "SECO",
            "ABOCADO",
            "SEMI-SECO",
            "SEMI-DULCE",
            "DULCE"});
            this.Cb_Tipo.Location = new System.Drawing.Point(175, 152);
            this.Cb_Tipo.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_Tipo.Name = "Cb_Tipo";
            this.Cb_Tipo.Size = new System.Drawing.Size(86, 21);
            this.Cb_Tipo.TabIndex = 8;
            this.Cb_Tipo.SelectedIndexChanged += new System.EventHandler(this.Cb_Tipo_SelectedIndexChanged);
            // 
            // Cb_Presentacion
            // 
            this.Cb_Presentacion.CausesValidation = false;
            this.Cb_Presentacion.Enabled = false;
            this.Cb_Presentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Presentacion.FormattingEnabled = true;
            this.Cb_Presentacion.Items.AddRange(new object[] {
            "Elija una Opcion:",
            "BARRIL",
            "BOTELLA"});
            this.Cb_Presentacion.Location = new System.Drawing.Point(175, 56);
            this.Cb_Presentacion.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_Presentacion.Name = "Cb_Presentacion";
            this.Cb_Presentacion.Size = new System.Drawing.Size(86, 21);
            this.Cb_Presentacion.TabIndex = 7;
            // 
            // Lb_Color
            // 
            this.Lb_Color.AutoSize = true;
            this.Lb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Color.Location = new System.Drawing.Point(11, 209);
            this.Lb_Color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Color.Name = "Lb_Color";
            this.Lb_Color.Size = new System.Drawing.Size(49, 18);
            this.Lb_Color.TabIndex = 6;
            this.Lb_Color.Text = "Color:";
            // 
            // Lb_Origen
            // 
            this.Lb_Origen.AutoSize = true;
            this.Lb_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Origen.Location = new System.Drawing.Point(11, 179);
            this.Lb_Origen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Origen.Name = "Lb_Origen";
            this.Lb_Origen.Size = new System.Drawing.Size(117, 18);
            this.Lb_Origen.TabIndex = 5;
            this.Lb_Origen.Text = "Lugar de Origen:";
            // 
            // Lb_Tipo
            // 
            this.Lb_Tipo.AutoSize = true;
            this.Lb_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Tipo.Location = new System.Drawing.Point(11, 150);
            this.Lb_Tipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Tipo.Name = "Lb_Tipo";
            this.Lb_Tipo.Size = new System.Drawing.Size(41, 18);
            this.Lb_Tipo.TabIndex = 4;
            this.Lb_Tipo.Text = "Tipo:";
            // 
            // Lb_ContA
            // 
            this.Lb_ContA.AutoSize = true;
            this.Lb_ContA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ContA.Location = new System.Drawing.Point(11, 120);
            this.Lb_ContA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_ContA.Name = "Lb_ContA";
            this.Lb_ContA.Size = new System.Drawing.Size(179, 18);
            this.Lb_ContA.TabIndex = 3;
            this.Lb_ContA.Text = "Contenido de Azucar (g/l):";
            // 
            // Lb_Elaboracion
            // 
            this.Lb_Elaboracion.AutoSize = true;
            this.Lb_Elaboracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Elaboracion.Location = new System.Drawing.Point(11, 89);
            this.Lb_Elaboracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Elaboracion.Name = "Lb_Elaboracion";
            this.Lb_Elaboracion.Size = new System.Drawing.Size(141, 18);
            this.Lb_Elaboracion.TabIndex = 2;
            this.Lb_Elaboracion.Text = "Año de Elaboración:";
            // 
            // Lb_Presentacion
            // 
            this.Lb_Presentacion.AutoSize = true;
            this.Lb_Presentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Presentacion.Location = new System.Drawing.Point(11, 57);
            this.Lb_Presentacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Presentacion.Name = "Lb_Presentacion";
            this.Lb_Presentacion.Size = new System.Drawing.Size(99, 18);
            this.Lb_Presentacion.TabIndex = 1;
            this.Lb_Presentacion.Text = "Presentación:";
            this.Lb_Presentacion.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre.Location = new System.Drawing.Point(11, 28);
            this.Lb_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(66, 18);
            this.Lb_Nombre.TabIndex = 0;
            this.Lb_Nombre.Text = "Nombre:";
            this.Lb_Nombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(58, 375);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(88, 25);
            this.Btn_Agregar.TabIndex = 4;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Bt_Agregar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Enabled = false;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(150, 375);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(97, 25);
            this.Btn_Modificar.TabIndex = 5;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(251, 375);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(85, 25);
            this.Btn_Eliminar.TabIndex = 6;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Examinar
            // 
            this.Btn_Examinar.Enabled = false;
            this.Btn_Examinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Examinar.Location = new System.Drawing.Point(356, 374);
            this.Btn_Examinar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Examinar.Name = "Btn_Examinar";
            this.Btn_Examinar.Size = new System.Drawing.Size(210, 25);
            this.Btn_Examinar.TabIndex = 8;
            this.Btn_Examinar.Text = "Examinar";
            this.Btn_Examinar.UseVisualStyleBackColor = true;
            this.Btn_Examinar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Picture_Vino
            // 
            this.Picture_Vino.Location = new System.Drawing.Point(2, 13);
            this.Picture_Vino.Name = "Picture_Vino";
            this.Picture_Vino.Size = new System.Drawing.Size(209, 243);
            this.Picture_Vino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_Vino.TabIndex = 9;
            this.Picture_Vino.TabStop = false;
            this.Picture_Vino.Click += new System.EventHandler(this.Picture_Vino_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Picture_Vino);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(354, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 260);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen Del Vino";
            // 
            // Tabla_Vinos
            // 
            this.Tabla_Vinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Vinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Presentacion,
            this.Año_Elaboracion,
            this.Contenido_Azucar,
            this.Tipo,
            this.Lugar_de_Origen,
            this.Color_Dgv});
            this.Tabla_Vinos.Location = new System.Drawing.Point(25, 405);
            this.Tabla_Vinos.Name = "Tabla_Vinos";
            this.Tabla_Vinos.ReadOnly = true;
            this.Tabla_Vinos.RowHeadersWidth = 47;
            this.Tabla_Vinos.Size = new System.Drawing.Size(741, 169);
            this.Tabla_Vinos.TabIndex = 11;
            this.Tabla_Vinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_Vinos_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 115;
            // 
            // Presentacion
            // 
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.MinimumWidth = 6;
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            this.Presentacion.Width = 115;
            // 
            // Año_Elaboracion
            // 
            this.Año_Elaboracion.HeaderText = "Año";
            this.Año_Elaboracion.MinimumWidth = 6;
            this.Año_Elaboracion.Name = "Año_Elaboracion";
            this.Año_Elaboracion.ReadOnly = true;
            this.Año_Elaboracion.Width = 115;
            // 
            // Contenido_Azucar
            // 
            this.Contenido_Azucar.HeaderText = "Contenido De Azucar";
            this.Contenido_Azucar.MinimumWidth = 6;
            this.Contenido_Azucar.Name = "Contenido_Azucar";
            this.Contenido_Azucar.ReadOnly = true;
            this.Contenido_Azucar.Width = 115;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo De Vino";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 115;
            // 
            // Lugar_de_Origen
            // 
            this.Lugar_de_Origen.HeaderText = "Origen";
            this.Lugar_de_Origen.MinimumWidth = 6;
            this.Lugar_de_Origen.Name = "Lugar_de_Origen";
            this.Lugar_de_Origen.ReadOnly = true;
            this.Lugar_de_Origen.Width = 115;
            // 
            // Color_Dgv
            // 
            this.Color_Dgv.HeaderText = "Color";
            this.Color_Dgv.MinimumWidth = 6;
            this.Color_Dgv.Name = "Color_Dgv";
            this.Color_Dgv.ReadOnly = true;
            this.Color_Dgv.Width = 115;
            // 
            // Gestion_De_Vinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.Tabla_Vinos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Examinar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.GB_InfoVino);
            this.Controls.Add(this.Gbox_GV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_De_Vinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VinoScribe";
            this.Load += new System.EventHandler(this.Gestion_De_Vinos_Load);
            this.Gbox_GV.ResumeLayout(false);
            this.Gbox_GV.PerformLayout();
            this.GB_InfoVino.ResumeLayout(false);
            this.GB_InfoVino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Vino)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Vinos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbGestionV;
        private System.Windows.Forms.GroupBox Gbox_GV;
        private System.Windows.Forms.GroupBox GB_InfoVino;
        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Label Lb_Presentacion;
        private System.Windows.Forms.Label Lb_Color;
        private System.Windows.Forms.Label Lb_Origen;
        private System.Windows.Forms.Label Lb_Tipo;
        private System.Windows.Forms.Label Lb_ContA;
        private System.Windows.Forms.Label Lb_Elaboracion;
        private System.Windows.Forms.TextBox Txt_Origen;
        private System.Windows.Forms.TextBox Txt_ContA;
        private System.Windows.Forms.TextBox Txt_Elaboracion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox Cb_Color;
        private System.Windows.Forms.ComboBox Cb_Tipo;
        private System.Windows.Forms.ComboBox Cb_Presentacion;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Examinar;
        private System.Windows.Forms.PictureBox Picture_Vino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Tabla_Vinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año_Elaboracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contenido_Azucar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar_de_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color_Dgv;
    }
}