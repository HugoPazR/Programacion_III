namespace Vinos_Scribe_Hugo
{
    partial class Gestion_De_Usuarios
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
            this.Lb_GestionU = new System.Windows.Forms.Label();
            this.Gbox_GU = new System.Windows.Forms.GroupBox();
            this.Bt_EliminarU = new System.Windows.Forms.Button();
            this.Bt_ModificarU = new System.Windows.Forms.Button();
            this.Bt_AgregarInfoU = new System.Windows.Forms.Button();
            this.GB_InfUsuario = new System.Windows.Forms.GroupBox();
            this.Txt_FechaU = new System.Windows.Forms.TextBox();
            this.Txt_CelularU = new System.Windows.Forms.TextBox();
            this.Txt_CorreoU = new System.Windows.Forms.TextBox();
            this.TxtNombreU = new System.Windows.Forms.TextBox();
            this.Cb_TipodeU = new System.Windows.Forms.ComboBox();
            this.Lb_TipoU = new System.Windows.Forms.Label();
            this.Lb_Fech_RegisU = new System.Windows.Forms.Label();
            this.Lb_CelularU = new System.Windows.Forms.Label();
            this.Lb_CorreoU = new System.Windows.Forms.Label();
            this.Lb_ApellidoU = new System.Windows.Forms.Label();
            this.Lb_NombreU = new System.Windows.Forms.Label();
            this.Lb_Contra = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Contra = new System.Windows.Forms.TextBox();
            this.Lb_Usuario = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.TxtApellidoU = new System.Windows.Forms.TextBox();
            this.Txt_InfoUsuario = new System.Windows.Forms.TextBox();
            this.Lb_InfU = new System.Windows.Forms.Label();
            this.Txt_InfoContra = new System.Windows.Forms.TextBox();
            this.Lb_ContraU = new System.Windows.Forms.Label();
            this.Gbox_GU.SuspendLayout();
            this.GB_InfUsuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_GestionU
            // 
            this.Lb_GestionU.AutoSize = true;
            this.Lb_GestionU.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Lb_GestionU.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GestionU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb_GestionU.Location = new System.Drawing.Point(275, 20);
            this.Lb_GestionU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_GestionU.Name = "Lb_GestionU";
            this.Lb_GestionU.Size = new System.Drawing.Size(513, 60);
            this.Lb_GestionU.TabIndex = 0;
            this.Lb_GestionU.Text = "Gestión De Usuarios";
            this.Lb_GestionU.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gbox_GU
            // 
            this.Gbox_GU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gbox_GU.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Gbox_GU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gbox_GU.Controls.Add(this.Lb_GestionU);
            this.Gbox_GU.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gbox_GU.Location = new System.Drawing.Point(-4, -1);
            this.Gbox_GU.Margin = new System.Windows.Forms.Padding(4);
            this.Gbox_GU.Name = "Gbox_GU";
            this.Gbox_GU.Padding = new System.Windows.Forms.Padding(4);
            this.Gbox_GU.Size = new System.Drawing.Size(1071, 100);
            this.Gbox_GU.TabIndex = 1;
            this.Gbox_GU.TabStop = false;
            this.Gbox_GU.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // Bt_EliminarU
            // 
            this.Bt_EliminarU.Location = new System.Drawing.Point(811, 474);
            this.Bt_EliminarU.Name = "Bt_EliminarU";
            this.Bt_EliminarU.Size = new System.Drawing.Size(98, 31);
            this.Bt_EliminarU.TabIndex = 13;
            this.Bt_EliminarU.Text = "Eliminar";
            this.Bt_EliminarU.UseVisualStyleBackColor = true;
            // 
            // Bt_ModificarU
            // 
            this.Bt_ModificarU.Location = new System.Drawing.Point(676, 474);
            this.Bt_ModificarU.Name = "Bt_ModificarU";
            this.Bt_ModificarU.Size = new System.Drawing.Size(98, 31);
            this.Bt_ModificarU.TabIndex = 12;
            this.Bt_ModificarU.Text = "Modificar";
            this.Bt_ModificarU.UseVisualStyleBackColor = true;
            // 
            // Bt_AgregarInfoU
            // 
            this.Bt_AgregarInfoU.Location = new System.Drawing.Point(539, 474);
            this.Bt_AgregarInfoU.Name = "Bt_AgregarInfoU";
            this.Bt_AgregarInfoU.Size = new System.Drawing.Size(98, 31);
            this.Bt_AgregarInfoU.TabIndex = 11;
            this.Bt_AgregarInfoU.Text = "Registrar";
            this.Bt_AgregarInfoU.UseVisualStyleBackColor = true;
            // 
            // GB_InfUsuario
            // 
            this.GB_InfUsuario.Controls.Add(this.Txt_InfoContra);
            this.GB_InfUsuario.Controls.Add(this.Lb_ContraU);
            this.GB_InfUsuario.Controls.Add(this.Txt_InfoUsuario);
            this.GB_InfUsuario.Controls.Add(this.Lb_InfU);
            this.GB_InfUsuario.Controls.Add(this.TxtApellidoU);
            this.GB_InfUsuario.Controls.Add(this.Txt_FechaU);
            this.GB_InfUsuario.Controls.Add(this.Txt_CelularU);
            this.GB_InfUsuario.Controls.Add(this.Txt_CorreoU);
            this.GB_InfUsuario.Controls.Add(this.TxtNombreU);
            this.GB_InfUsuario.Controls.Add(this.Cb_TipodeU);
            this.GB_InfUsuario.Controls.Add(this.Lb_TipoU);
            this.GB_InfUsuario.Controls.Add(this.Lb_Fech_RegisU);
            this.GB_InfUsuario.Controls.Add(this.Lb_CelularU);
            this.GB_InfUsuario.Controls.Add(this.Lb_CorreoU);
            this.GB_InfUsuario.Controls.Add(this.Lb_ApellidoU);
            this.GB_InfUsuario.Controls.Add(this.Lb_NombreU);
            this.GB_InfUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_InfUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB_InfUsuario.Location = new System.Drawing.Point(539, 133);
            this.GB_InfUsuario.Name = "GB_InfUsuario";
            this.GB_InfUsuario.Size = new System.Drawing.Size(370, 338);
            this.GB_InfUsuario.TabIndex = 10;
            this.GB_InfUsuario.TabStop = false;
            this.GB_InfUsuario.Text = "Informacion de Usuario";
            // 
            // Txt_FechaU
            // 
            this.Txt_FechaU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_FechaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaU.Location = new System.Drawing.Point(233, 186);
            this.Txt_FechaU.Name = "Txt_FechaU";
            this.Txt_FechaU.Size = new System.Drawing.Size(113, 21);
            this.Txt_FechaU.TabIndex = 10;
            // 
            // Txt_CelularU
            // 
            this.Txt_CelularU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CelularU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CelularU.Location = new System.Drawing.Point(233, 147);
            this.Txt_CelularU.Name = "Txt_CelularU";
            this.Txt_CelularU.Size = new System.Drawing.Size(113, 21);
            this.Txt_CelularU.TabIndex = 11;
            // 
            // Txt_CorreoU
            // 
            this.Txt_CorreoU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CorreoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CorreoU.Location = new System.Drawing.Point(233, 109);
            this.Txt_CorreoU.Name = "Txt_CorreoU";
            this.Txt_CorreoU.Size = new System.Drawing.Size(113, 21);
            this.Txt_CorreoU.TabIndex = 10;
            // 
            // TxtNombreU
            // 
            this.TxtNombreU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombreU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreU.Location = new System.Drawing.Point(233, 33);
            this.TxtNombreU.Name = "TxtNombreU";
            this.TxtNombreU.Size = new System.Drawing.Size(113, 21);
            this.TxtNombreU.TabIndex = 9;
            // 
            // Cb_TipodeU
            // 
            this.Cb_TipodeU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_TipodeU.FormattingEnabled = true;
            this.Cb_TipodeU.Location = new System.Drawing.Point(233, 220);
            this.Cb_TipodeU.Name = "Cb_TipodeU";
            this.Cb_TipodeU.Size = new System.Drawing.Size(113, 23);
            this.Cb_TipodeU.TabIndex = 8;
            // 
            // Lb_TipoU
            // 
            this.Lb_TipoU.AutoSize = true;
            this.Lb_TipoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TipoU.Location = new System.Drawing.Point(15, 220);
            this.Lb_TipoU.Name = "Lb_TipoU";
            this.Lb_TipoU.Size = new System.Drawing.Size(124, 20);
            this.Lb_TipoU.TabIndex = 5;
            this.Lb_TipoU.Text = "Tipo de Usuario:";
            // 
            // Lb_Fech_RegisU
            // 
            this.Lb_Fech_RegisU.AutoSize = true;
            this.Lb_Fech_RegisU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Fech_RegisU.Location = new System.Drawing.Point(15, 185);
            this.Lb_Fech_RegisU.Name = "Lb_Fech_RegisU";
            this.Lb_Fech_RegisU.Size = new System.Drawing.Size(148, 20);
            this.Lb_Fech_RegisU.TabIndex = 4;
            this.Lb_Fech_RegisU.Text = "Fecha de Registro :";
            this.Lb_Fech_RegisU.Click += new System.EventHandler(this.Lb_Tipo_Click);
            // 
            // Lb_CelularU
            // 
            this.Lb_CelularU.AutoSize = true;
            this.Lb_CelularU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CelularU.Location = new System.Drawing.Point(15, 148);
            this.Lb_CelularU.Name = "Lb_CelularU";
            this.Lb_CelularU.Size = new System.Drawing.Size(62, 20);
            this.Lb_CelularU.TabIndex = 3;
            this.Lb_CelularU.Text = "Celular:";
            // 
            // Lb_CorreoU
            // 
            this.Lb_CorreoU.AutoSize = true;
            this.Lb_CorreoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CorreoU.Location = new System.Drawing.Point(15, 110);
            this.Lb_CorreoU.Name = "Lb_CorreoU";
            this.Lb_CorreoU.Size = new System.Drawing.Size(61, 20);
            this.Lb_CorreoU.TabIndex = 2;
            this.Lb_CorreoU.Text = "Correo:";
            // 
            // Lb_ApellidoU
            // 
            this.Lb_ApellidoU.AutoSize = true;
            this.Lb_ApellidoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ApellidoU.Location = new System.Drawing.Point(15, 70);
            this.Lb_ApellidoU.Name = "Lb_ApellidoU";
            this.Lb_ApellidoU.Size = new System.Drawing.Size(69, 20);
            this.Lb_ApellidoU.TabIndex = 1;
            this.Lb_ApellidoU.Text = "Apellido:";
            // 
            // Lb_NombreU
            // 
            this.Lb_NombreU.AutoSize = true;
            this.Lb_NombreU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NombreU.Location = new System.Drawing.Point(15, 34);
            this.Lb_NombreU.Name = "Lb_NombreU";
            this.Lb_NombreU.Size = new System.Drawing.Size(69, 20);
            this.Lb_NombreU.TabIndex = 0;
            this.Lb_NombreU.Text = "Nombre:";
            // 
            // Lb_Contra
            // 
            this.Lb_Contra.AutoSize = true;
            this.Lb_Contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Contra.Location = new System.Drawing.Point(90, 148);
            this.Lb_Contra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Contra.Name = "Lb_Contra";
            this.Lb_Contra.Size = new System.Drawing.Size(116, 24);
            this.Lb_Contra.TabIndex = 4;
            this.Lb_Contra.Text = "Contraseña";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(57, 84);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(183, 22);
            this.Txt_Usuario.TabIndex = 3;
            // 
            // Txt_Contra
            // 
            this.Txt_Contra.Location = new System.Drawing.Point(57, 176);
            this.Txt_Contra.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Contra.Name = "Txt_Contra";
            this.Txt_Contra.PasswordChar = '¤';
            this.Txt_Contra.Size = new System.Drawing.Size(183, 22);
            this.Txt_Contra.TabIndex = 5;
            // 
            // Lb_Usuario
            // 
            this.Lb_Usuario.AutoSize = true;
            this.Lb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Usuario.Location = new System.Drawing.Point(110, 56);
            this.Lb_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Usuario.Name = "Lb_Usuario";
            this.Lb_Usuario.Size = new System.Drawing.Size(81, 24);
            this.Lb_Usuario.TabIndex = 2;
            this.Lb_Usuario.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lb_Usuario);
            this.groupBox2.Controls.Add(this.Txt_Contra);
            this.groupBox2.Controls.Add(this.Txt_Usuario);
            this.groupBox2.Controls.Add(this.Lb_Contra);
            this.groupBox2.Location = new System.Drawing.Point(126, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(309, 262);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Bt_Ingresar.Location = new System.Drawing.Point(126, 429);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(308, 33);
            this.Bt_Ingresar.TabIndex = 7;
            this.Bt_Ingresar.Text = "Ingresar";
            this.Bt_Ingresar.UseVisualStyleBackColor = true;
            // 
            // TxtApellidoU
            // 
            this.TxtApellidoU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtApellidoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoU.Location = new System.Drawing.Point(233, 71);
            this.TxtApellidoU.Name = "TxtApellidoU";
            this.TxtApellidoU.Size = new System.Drawing.Size(113, 21);
            this.TxtApellidoU.TabIndex = 12;
            // 
            // Txt_InfoUsuario
            // 
            this.Txt_InfoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_InfoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_InfoUsuario.Location = new System.Drawing.Point(233, 258);
            this.Txt_InfoUsuario.Name = "Txt_InfoUsuario";
            this.Txt_InfoUsuario.Size = new System.Drawing.Size(113, 21);
            this.Txt_InfoUsuario.TabIndex = 14;
            // 
            // Lb_InfU
            // 
            this.Lb_InfU.AutoSize = true;
            this.Lb_InfU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_InfU.Location = new System.Drawing.Point(15, 259);
            this.Lb_InfU.Name = "Lb_InfU";
            this.Lb_InfU.Size = new System.Drawing.Size(68, 20);
            this.Lb_InfU.TabIndex = 13;
            this.Lb_InfU.Text = "Usuario:";
            // 
            // Txt_InfoContra
            // 
            this.Txt_InfoContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_InfoContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_InfoContra.Location = new System.Drawing.Point(233, 298);
            this.Txt_InfoContra.Name = "Txt_InfoContra";
            this.Txt_InfoContra.Size = new System.Drawing.Size(113, 21);
            this.Txt_InfoContra.TabIndex = 16;
            // 
            // Lb_ContraU
            // 
            this.Lb_ContraU.AutoSize = true;
            this.Lb_ContraU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ContraU.Location = new System.Drawing.Point(15, 299);
            this.Lb_ContraU.Name = "Lb_ContraU";
            this.Lb_ContraU.Size = new System.Drawing.Size(96, 20);
            this.Lb_ContraU.TabIndex = 15;
            this.Lb_ContraU.Text = "Contraseña:";
            // 
            // Gestion_De_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Bt_EliminarU);
            this.Controls.Add(this.Bt_ModificarU);
            this.Controls.Add(this.Bt_AgregarInfoU);
            this.Controls.Add(this.GB_InfUsuario);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Gbox_GU);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestion_De_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VinoScribe";
            this.Load += new System.EventHandler(this.Gestion_De_Usuarios_Load);
            this.Gbox_GU.ResumeLayout(false);
            this.Gbox_GU.PerformLayout();
            this.GB_InfUsuario.ResumeLayout(false);
            this.GB_InfUsuario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_GestionU;
        private System.Windows.Forms.GroupBox Gbox_GU;
        private System.Windows.Forms.Button Bt_EliminarU;
        private System.Windows.Forms.Button Bt_ModificarU;
        private System.Windows.Forms.Button Bt_AgregarInfoU;
        private System.Windows.Forms.GroupBox GB_InfUsuario;
        private System.Windows.Forms.TextBox Txt_FechaU;
        private System.Windows.Forms.TextBox Txt_CelularU;
        private System.Windows.Forms.TextBox Txt_CorreoU;
        private System.Windows.Forms.TextBox TxtNombreU;
        private System.Windows.Forms.ComboBox Cb_TipodeU;
        private System.Windows.Forms.Label Lb_TipoU;
        private System.Windows.Forms.Label Lb_Fech_RegisU;
        private System.Windows.Forms.Label Lb_CelularU;
        private System.Windows.Forms.Label Lb_CorreoU;
        private System.Windows.Forms.Label Lb_ApellidoU;
        private System.Windows.Forms.Label Lb_NombreU;
        private System.Windows.Forms.Label Lb_Contra;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Contra;
        private System.Windows.Forms.Label Lb_Usuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.TextBox Txt_InfoContra;
        private System.Windows.Forms.Label Lb_ContraU;
        private System.Windows.Forms.TextBox Txt_InfoUsuario;
        private System.Windows.Forms.Label Lb_InfU;
        private System.Windows.Forms.TextBox TxtApellidoU;
    }
}