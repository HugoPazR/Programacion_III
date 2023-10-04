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
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.Lb_Presentacion = new System.Windows.Forms.Label();
            this.Lb_Elaboracion = new System.Windows.Forms.Label();
            this.Lb_ContA = new System.Windows.Forms.Label();
            this.Lb_Tipo = new System.Windows.Forms.Label();
            this.Lb_Origen = new System.Windows.Forms.Label();
            this.Lb_Color = new System.Windows.Forms.Label();
            this.Cb_Presentacion = new System.Windows.Forms.ComboBox();
            this.Cb_Tipo = new System.Windows.Forms.ComboBox();
            this.Cb_Color = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Txt_Elavoracion = new System.Windows.Forms.TextBox();
            this.Txt_ContA = new System.Windows.Forms.TextBox();
            this.Txt_Origen = new System.Windows.Forms.TextBox();
            this.Bt_Agregar = new System.Windows.Forms.Button();
            this.Bt_Modificar = new System.Windows.Forms.Button();
            this.Bt_Eliminar = new System.Windows.Forms.Button();
            this.Gbox_GV.SuspendLayout();
            this.GB_InfoVino.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbGestionV
            // 
            this.LbGestionV.AutoSize = true;
            this.LbGestionV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LbGestionV.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGestionV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbGestionV.Location = new System.Drawing.Point(296, 19);
            this.LbGestionV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbGestionV.Name = "LbGestionV";
            this.LbGestionV.Size = new System.Drawing.Size(438, 60);
            this.LbGestionV.TabIndex = 0;
            this.LbGestionV.Text = "Gestión De Vinos";
            this.LbGestionV.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gbox_GV
            // 
            this.Gbox_GV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gbox_GV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Gbox_GV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gbox_GV.Controls.Add(this.LbGestionV);
            this.Gbox_GV.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gbox_GV.Location = new System.Drawing.Point(-1, -1);
            this.Gbox_GV.Margin = new System.Windows.Forms.Padding(4);
            this.Gbox_GV.Name = "Gbox_GV";
            this.Gbox_GV.Padding = new System.Windows.Forms.Padding(4);
            this.Gbox_GV.Size = new System.Drawing.Size(1071, 100);
            this.Gbox_GV.TabIndex = 2;
            this.Gbox_GV.TabStop = false;
            // 
            // GB_InfoVino
            // 
            this.GB_InfoVino.Controls.Add(this.Txt_Origen);
            this.GB_InfoVino.Controls.Add(this.Txt_ContA);
            this.GB_InfoVino.Controls.Add(this.Txt_Elavoracion);
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
            this.GB_InfoVino.Location = new System.Drawing.Point(74, 152);
            this.GB_InfoVino.Name = "GB_InfoVino";
            this.GB_InfoVino.Size = new System.Drawing.Size(370, 315);
            this.GB_InfoVino.TabIndex = 3;
            this.GB_InfoVino.TabStop = false;
            this.GB_InfoVino.Text = "Informacion del Vino";
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nombre.Location = new System.Drawing.Point(15, 34);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(69, 20);
            this.Lb_Nombre.TabIndex = 0;
            this.Lb_Nombre.Text = "Nombre:";
            this.Lb_Nombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Lb_Presentacion
            // 
            this.Lb_Presentacion.AutoSize = true;
            this.Lb_Presentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Presentacion.Location = new System.Drawing.Point(15, 70);
            this.Lb_Presentacion.Name = "Lb_Presentacion";
            this.Lb_Presentacion.Size = new System.Drawing.Size(106, 20);
            this.Lb_Presentacion.TabIndex = 1;
            this.Lb_Presentacion.Text = "Presentacion:";
            this.Lb_Presentacion.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lb_Elaboracion
            // 
            this.Lb_Elaboracion.AutoSize = true;
            this.Lb_Elaboracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Elaboracion.Location = new System.Drawing.Point(15, 110);
            this.Lb_Elaboracion.Name = "Lb_Elaboracion";
            this.Lb_Elaboracion.Size = new System.Drawing.Size(150, 20);
            this.Lb_Elaboracion.TabIndex = 2;
            this.Lb_Elaboracion.Text = "Año de Elavoracion:";
            // 
            // Lb_ContA
            // 
            this.Lb_ContA.AutoSize = true;
            this.Lb_ContA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ContA.Location = new System.Drawing.Point(15, 148);
            this.Lb_ContA.Name = "Lb_ContA";
            this.Lb_ContA.Size = new System.Drawing.Size(192, 20);
            this.Lb_ContA.TabIndex = 3;
            this.Lb_ContA.Text = "Contenido de Azucar (g/l):";
            // 
            // Lb_Tipo
            // 
            this.Lb_Tipo.AutoSize = true;
            this.Lb_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Tipo.Location = new System.Drawing.Point(15, 185);
            this.Lb_Tipo.Name = "Lb_Tipo";
            this.Lb_Tipo.Size = new System.Drawing.Size(43, 20);
            this.Lb_Tipo.TabIndex = 4;
            this.Lb_Tipo.Text = "Tipo:";
            // 
            // Lb_Origen
            // 
            this.Lb_Origen.AutoSize = true;
            this.Lb_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Origen.Location = new System.Drawing.Point(15, 220);
            this.Lb_Origen.Name = "Lb_Origen";
            this.Lb_Origen.Size = new System.Drawing.Size(127, 20);
            this.Lb_Origen.TabIndex = 5;
            this.Lb_Origen.Text = "Lugar de Origen:";
            // 
            // Lb_Color
            // 
            this.Lb_Color.AutoSize = true;
            this.Lb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Color.Location = new System.Drawing.Point(15, 257);
            this.Lb_Color.Name = "Lb_Color";
            this.Lb_Color.Size = new System.Drawing.Size(50, 20);
            this.Lb_Color.TabIndex = 6;
            this.Lb_Color.Text = "Color:";
            // 
            // Cb_Presentacion
            // 
            this.Cb_Presentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Presentacion.FormattingEnabled = true;
            this.Cb_Presentacion.Location = new System.Drawing.Point(233, 69);
            this.Cb_Presentacion.Name = "Cb_Presentacion";
            this.Cb_Presentacion.Size = new System.Drawing.Size(113, 23);
            this.Cb_Presentacion.TabIndex = 7;
            // 
            // Cb_Tipo
            // 
            this.Cb_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Tipo.FormattingEnabled = true;
            this.Cb_Tipo.Location = new System.Drawing.Point(233, 187);
            this.Cb_Tipo.Name = "Cb_Tipo";
            this.Cb_Tipo.Size = new System.Drawing.Size(113, 23);
            this.Cb_Tipo.TabIndex = 8;
            // 
            // Cb_Color
            // 
            this.Cb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Color.FormattingEnabled = true;
            this.Cb_Color.Location = new System.Drawing.Point(233, 256);
            this.Cb_Color.Name = "Cb_Color";
            this.Cb_Color.Size = new System.Drawing.Size(113, 23);
            this.Cb_Color.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(233, 33);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(113, 21);
            this.TxtNombre.TabIndex = 9;
            // 
            // Txt_Elavoracion
            // 
            this.Txt_Elavoracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Elavoracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Elavoracion.Location = new System.Drawing.Point(233, 109);
            this.Txt_Elavoracion.Name = "Txt_Elavoracion";
            this.Txt_Elavoracion.Size = new System.Drawing.Size(113, 21);
            this.Txt_Elavoracion.TabIndex = 10;
            // 
            // Txt_ContA
            // 
            this.Txt_ContA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ContA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ContA.Location = new System.Drawing.Point(233, 147);
            this.Txt_ContA.Name = "Txt_ContA";
            this.Txt_ContA.Size = new System.Drawing.Size(113, 21);
            this.Txt_ContA.TabIndex = 11;
            // 
            // Txt_Origen
            // 
            this.Txt_Origen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Origen.Location = new System.Drawing.Point(233, 222);
            this.Txt_Origen.Name = "Txt_Origen";
            this.Txt_Origen.Size = new System.Drawing.Size(113, 21);
            this.Txt_Origen.TabIndex = 10;
            // 
            // Bt_Agregar
            // 
            this.Bt_Agregar.Location = new System.Drawing.Point(74, 483);
            this.Bt_Agregar.Name = "Bt_Agregar";
            this.Bt_Agregar.Size = new System.Drawing.Size(98, 31);
            this.Bt_Agregar.TabIndex = 4;
            this.Bt_Agregar.Text = "Agregar";
            this.Bt_Agregar.UseVisualStyleBackColor = true;
            // 
            // Bt_Modificar
            // 
            this.Bt_Modificar.Location = new System.Drawing.Point(211, 483);
            this.Bt_Modificar.Name = "Bt_Modificar";
            this.Bt_Modificar.Size = new System.Drawing.Size(98, 31);
            this.Bt_Modificar.TabIndex = 5;
            this.Bt_Modificar.Text = "Modificar";
            this.Bt_Modificar.UseVisualStyleBackColor = true;
            // 
            // Bt_Eliminar
            // 
            this.Bt_Eliminar.Location = new System.Drawing.Point(346, 483);
            this.Bt_Eliminar.Name = "Bt_Eliminar";
            this.Bt_Eliminar.Size = new System.Drawing.Size(98, 31);
            this.Bt_Eliminar.TabIndex = 6;
            this.Bt_Eliminar.Text = "Eliminar";
            this.Bt_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Gestion_De_Vinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Bt_Eliminar);
            this.Controls.Add(this.Bt_Modificar);
            this.Controls.Add(this.Bt_Agregar);
            this.Controls.Add(this.GB_InfoVino);
            this.Controls.Add(this.Gbox_GV);
            this.Name = "Gestion_De_Vinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VinoScribe";
            this.Load += new System.EventHandler(this.Gestion_De_Vinos_Load);
            this.Gbox_GV.ResumeLayout(false);
            this.Gbox_GV.PerformLayout();
            this.GB_InfoVino.ResumeLayout(false);
            this.GB_InfoVino.PerformLayout();
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
        private System.Windows.Forms.TextBox Txt_Elavoracion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox Cb_Color;
        private System.Windows.Forms.ComboBox Cb_Tipo;
        private System.Windows.Forms.ComboBox Cb_Presentacion;
        private System.Windows.Forms.Button Bt_Agregar;
        private System.Windows.Forms.Button Bt_Modificar;
        private System.Windows.Forms.Button Bt_Eliminar;
    }
}