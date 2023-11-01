namespace Vinos_Scribe_Hugo
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.Tira_Herramientas = new System.Windows.Forms.ToolStrip();
            this.Tools_BTN_GestionU = new System.Windows.Forms.ToolStripButton();
            this.Tools_BTN_GestionV = new System.Windows.Forms.ToolStripButton();
            this.Tools_BTN_Bodega = new System.Windows.Forms.ToolStripButton();
            this.Tools_BTN_Desgustacion = new System.Windows.Forms.ToolStripButton();
            this.Tools_BTN_Calificacion = new System.Windows.Forms.ToolStripButton();
            this.Mas_Vendidos = new System.Windows.Forms.Label();
            this.Cuerpo_Principal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Tira_Herramientas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tira_Herramientas
            // 
            this.Tira_Herramientas.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Tira_Herramientas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tira_Herramientas.AutoSize = false;
            this.Tira_Herramientas.Dock = System.Windows.Forms.DockStyle.None;
            this.Tira_Herramientas.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tira_Herramientas.GripMargin = new System.Windows.Forms.Padding(3);
            this.Tira_Herramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tira_Herramientas.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.Tira_Herramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools_BTN_GestionU,
            this.Tools_BTN_GestionV,
            this.Tools_BTN_Bodega,
            this.Tools_BTN_Desgustacion,
            this.Tools_BTN_Calificacion,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton1});
            this.Tira_Herramientas.Location = new System.Drawing.Point(0, 0);
            this.Tira_Herramientas.Name = "Tira_Herramientas";
            this.Tira_Herramientas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Tira_Herramientas.Size = new System.Drawing.Size(791, 25);
            this.Tira_Herramientas.Stretch = true;
            this.Tira_Herramientas.TabIndex = 0;
            this.Tira_Herramientas.Text = "toolStrip1";
            this.Tira_Herramientas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Tira_Herramientas_ItemClicked);
            // 
            // Tools_BTN_GestionU
            // 
            this.Tools_BTN_GestionU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_GestionU.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.Tools_BTN_GestionU.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_GestionU.Image")));
            this.Tools_BTN_GestionU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_GestionU.Name = "Tools_BTN_GestionU";
            this.Tools_BTN_GestionU.Size = new System.Drawing.Size(138, 22);
            this.Tools_BTN_GestionU.Text = "Gestion de Usuarios";
            this.Tools_BTN_GestionU.Click += new System.EventHandler(this.Tools_BTN_GestionU_Click);
            // 
            // Tools_BTN_GestionV
            // 
            this.Tools_BTN_GestionV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_GestionV.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.Tools_BTN_GestionV.ForeColor = System.Drawing.Color.DarkRed;
            this.Tools_BTN_GestionV.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_GestionV.Image")));
            this.Tools_BTN_GestionV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_GestionV.Name = "Tools_BTN_GestionV";
            this.Tools_BTN_GestionV.Size = new System.Drawing.Size(120, 22);
            this.Tools_BTN_GestionV.Text = "Gestion de Vinos";
            this.Tools_BTN_GestionV.Click += new System.EventHandler(this.ools_BTN_GestionU_Click);
            // 
            // Tools_BTN_Bodega
            // 
            this.Tools_BTN_Bodega.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_Bodega.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.Tools_BTN_Bodega.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_Bodega.Image")));
            this.Tools_BTN_Bodega.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_Bodega.Name = "Tools_BTN_Bodega";
            this.Tools_BTN_Bodega.Size = new System.Drawing.Size(131, 22);
            this.Tools_BTN_Bodega.Text = "Gestion de Bodega";
            this.Tools_BTN_Bodega.Click += new System.EventHandler(this.Tools_BTN_Bodega_Click);
            // 
            // Tools_BTN_Desgustacion
            // 
            this.Tools_BTN_Desgustacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_Desgustacion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.Tools_BTN_Desgustacion.ForeColor = System.Drawing.Color.DarkRed;
            this.Tools_BTN_Desgustacion.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_Desgustacion.Image")));
            this.Tools_BTN_Desgustacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_Desgustacion.Name = "Tools_BTN_Desgustacion";
            this.Tools_BTN_Desgustacion.Size = new System.Drawing.Size(109, 22);
            this.Tools_BTN_Desgustacion.Text = "Desgustaciones";
            this.Tools_BTN_Desgustacion.Click += new System.EventHandler(this.Tools_BTN_Desgustacion_Click);
            // 
            // Tools_BTN_Calificacion
            // 
            this.Tools_BTN_Calificacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_Calificacion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_BTN_Calificacion.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_Calificacion.Image")));
            this.Tools_BTN_Calificacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_Calificacion.Name = "Tools_BTN_Calificacion";
            this.Tools_BTN_Calificacion.Size = new System.Drawing.Size(103, 22);
            this.Tools_BTN_Calificacion.Text = "Calificaciones";
            this.Tools_BTN_Calificacion.Click += new System.EventHandler(this.Tools_BTN_Calificacion_Click);
            // 
            // Mas_Vendidos
            // 
            this.Mas_Vendidos.AutoSize = true;
            this.Mas_Vendidos.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mas_Vendidos.Location = new System.Drawing.Point(251, 16);
            this.Mas_Vendidos.Name = "Mas_Vendidos";
            this.Mas_Vendidos.Size = new System.Drawing.Size(283, 24);
            this.Mas_Vendidos.TabIndex = 1;
            this.Mas_Vendidos.Text = "Vinos Scribe: Descubre el Arte del Vino";
            this.Mas_Vendidos.UseMnemonic = false;
            // 
            // Cuerpo_Principal
            // 
            this.Cuerpo_Principal.AutoSize = true;
            this.Cuerpo_Principal.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuerpo_Principal.Location = new System.Drawing.Point(6, 65);
            this.Cuerpo_Principal.Name = "Cuerpo_Principal";
            this.Cuerpo_Principal.Size = new System.Drawing.Size(785, 322);
            this.Cuerpo_Principal.TabIndex = 2;
            this.Cuerpo_Principal.Text = resources.GetString("Cuerpo_Principal.Text");
            this.Cuerpo_Principal.Click += new System.EventHandler(this.Cuerpo_Principal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cuerpo_Principal);
            this.groupBox1.Controls.Add(this.Mas_Vendidos);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 422);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(99, 22);
            this.toolStripButton1.Text = "Iniciar Sesión";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "      ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel2.Text = "    ";
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tira_Herramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VinoScribe";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.Tira_Herramientas.ResumeLayout(false);
            this.Tira_Herramientas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tira_Herramientas;
        private System.Windows.Forms.ToolStripButton Tools_BTN_GestionU;
        private System.Windows.Forms.ToolStripButton Tools_BTN_GestionV;
        private System.Windows.Forms.ToolStripButton Tools_BTN_Calificacion;
        private System.Windows.Forms.ToolStripButton Tools_BTN_Desgustacion;
        private System.Windows.Forms.ToolStripButton Tools_BTN_Bodega;
        private System.Windows.Forms.Label Mas_Vendidos;
        private System.Windows.Forms.Label Cuerpo_Principal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

