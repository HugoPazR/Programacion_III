namespace Vinos_Scribe_Hugo
{
    partial class Gestio_De_Bodega
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
            this.Lb_GestionByP = new System.Windows.Forms.Label();
            this.Gbox_GesstionByP = new System.Windows.Forms.GroupBox();
            this.Gbox_GesstionByP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_GestionByP
            // 
            this.Lb_GestionByP.AutoSize = true;
            this.Lb_GestionByP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Lb_GestionByP.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GestionByP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb_GestionByP.Location = new System.Drawing.Point(107, 19);
            this.Lb_GestionByP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_GestionByP.Name = "Lb_GestionByP";
            this.Lb_GestionByP.Size = new System.Drawing.Size(838, 60);
            this.Lb_GestionByP.TabIndex = 0;
            this.Lb_GestionByP.Text = "Gestión De Bodega y Proveedores";
            this.Lb_GestionByP.Click += new System.EventHandler(this.Lb_GestionU_Click);
            // 
            // Gbox_GesstionByP
            // 
            this.Gbox_GesstionByP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gbox_GesstionByP.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Gbox_GesstionByP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gbox_GesstionByP.Controls.Add(this.Lb_GestionByP);
            this.Gbox_GesstionByP.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gbox_GesstionByP.Location = new System.Drawing.Point(-2, 0);
            this.Gbox_GesstionByP.Margin = new System.Windows.Forms.Padding(4);
            this.Gbox_GesstionByP.Name = "Gbox_GesstionByP";
            this.Gbox_GesstionByP.Padding = new System.Windows.Forms.Padding(4);
            this.Gbox_GesstionByP.Size = new System.Drawing.Size(1071, 100);
            this.Gbox_GesstionByP.TabIndex = 2;
            this.Gbox_GesstionByP.TabStop = false;
            // 
            // Gestio_De_Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Gbox_GesstionByP);
            this.Name = "Gestio_De_Bodega";
            this.Text = "Gestio_De_Bodega";
            this.Load += new System.EventHandler(this.Gestio_De_Bodega_Load);
            this.Gbox_GesstionByP.ResumeLayout(false);
            this.Gbox_GesstionByP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_GestionByP;
        private System.Windows.Forms.GroupBox Gbox_GesstionByP;
    }
}