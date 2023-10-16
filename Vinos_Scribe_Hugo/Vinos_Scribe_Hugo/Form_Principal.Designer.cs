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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tools_BTN_GestionU = new System.Windows.Forms.ToolStripButton();
            this.Tools_BTN_GestionV = new System.Windows.Forms.ToolStripButton();
            this.Tools_BTN_Bodega = new System.Windows.Forms.ToolStripButton();
            this.Tools_BTN_Desgustacion = new System.Windows.Forms.ToolStripButton();
            this.Tools_BTN_Calificacion = new System.Windows.Forms.ToolStripButton();
            this.Mas_Vendidos = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools_BTN_GestionU,
            this.Tools_BTN_GestionV,
            this.Tools_BTN_Bodega,
            this.Tools_BTN_Desgustacion,
            this.Tools_BTN_Calificacion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tools_BTN_GestionU
            // 
            this.Tools_BTN_GestionU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_GestionU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_BTN_GestionU.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_GestionU.Image")));
            this.Tools_BTN_GestionU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_GestionU.Name = "Tools_BTN_GestionU";
            this.Tools_BTN_GestionU.Size = new System.Drawing.Size(121, 22);
            this.Tools_BTN_GestionU.Text = "Gestion de Usuarios";
            this.Tools_BTN_GestionU.Click += new System.EventHandler(this.Tools_BTN_GestionU_Click);
            // 
            // Tools_BTN_GestionV
            // 
            this.Tools_BTN_GestionV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_GestionV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_BTN_GestionV.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_GestionV.Image")));
            this.Tools_BTN_GestionV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_GestionV.Name = "Tools_BTN_GestionV";
            this.Tools_BTN_GestionV.Size = new System.Drawing.Size(104, 22);
            this.Tools_BTN_GestionV.Text = "Gestion de Vinos";
            this.Tools_BTN_GestionV.Click += new System.EventHandler(this.ools_BTN_GestionU_Click);
            // 
            // Tools_BTN_Bodega
            // 
            this.Tools_BTN_Bodega.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_Bodega.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_BTN_Bodega.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_Bodega.Image")));
            this.Tools_BTN_Bodega.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_Bodega.Name = "Tools_BTN_Bodega";
            this.Tools_BTN_Bodega.Size = new System.Drawing.Size(116, 22);
            this.Tools_BTN_Bodega.Text = "Gestion de Bodega";
            this.Tools_BTN_Bodega.Click += new System.EventHandler(this.Tools_BTN_Bodega_Click);
            // 
            // Tools_BTN_Desgustacion
            // 
            this.Tools_BTN_Desgustacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_Desgustacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_BTN_Desgustacion.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_Desgustacion.Image")));
            this.Tools_BTN_Desgustacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_Desgustacion.Name = "Tools_BTN_Desgustacion";
            this.Tools_BTN_Desgustacion.Size = new System.Drawing.Size(97, 22);
            this.Tools_BTN_Desgustacion.Text = "Desgustaciones";
            this.Tools_BTN_Desgustacion.Click += new System.EventHandler(this.Tools_BTN_Desgustacion_Click);
            // 
            // Tools_BTN_Calificacion
            // 
            this.Tools_BTN_Calificacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools_BTN_Calificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_BTN_Calificacion.Image = ((System.Drawing.Image)(resources.GetObject("Tools_BTN_Calificacion.Image")));
            this.Tools_BTN_Calificacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools_BTN_Calificacion.Name = "Tools_BTN_Calificacion";
            this.Tools_BTN_Calificacion.Size = new System.Drawing.Size(85, 22);
            this.Tools_BTN_Calificacion.Text = "Calificaciones";
            this.Tools_BTN_Calificacion.Click += new System.EventHandler(this.Tools_BTN_Calificacion_Click);
            // 
            // Mas_Vendidos
            // 
            this.Mas_Vendidos.AutoSize = true;
            this.Mas_Vendidos.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mas_Vendidos.Location = new System.Drawing.Point(29, 58);
            this.Mas_Vendidos.Name = "Mas_Vendidos";
            this.Mas_Vendidos.Size = new System.Drawing.Size(164, 25);
            this.Mas_Vendidos.TabIndex = 1;
            this.Mas_Vendidos.Text = "Los Mas Vendidos";
            this.Mas_Vendidos.UseMnemonic = false;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mas_Vendidos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VinoScribe";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tools_BTN_GestionU;
        private System.Windows.Forms.ToolStripButton Tools_BTN_GestionV;
        private System.Windows.Forms.ToolStripButton Tools_BTN_Calificacion;
        private System.Windows.Forms.ToolStripButton Tools_BTN_Desgustacion;
        private System.Windows.Forms.ToolStripButton Tools_BTN_Bodega;
        private System.Windows.Forms.Label Mas_Vendidos;
    }
}

