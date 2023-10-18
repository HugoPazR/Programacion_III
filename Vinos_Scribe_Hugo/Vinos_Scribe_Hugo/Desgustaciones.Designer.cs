namespace Vinos_Scribe_Hugo
{
    partial class Desgustaciones
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
            this.LbDyC = new System.Windows.Forms.Label();
            this.Gbox_GDyC = new System.Windows.Forms.GroupBox();
            this.Gbox_GDyC.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbDyC
            // 
            this.LbDyC.AutoSize = true;
            this.LbDyC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LbDyC.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDyC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbDyC.Location = new System.Drawing.Point(105, 16);
            this.LbDyC.Name = "LbDyC";
            this.LbDyC.Size = new System.Drawing.Size(601, 53);
            this.LbDyC.TabIndex = 0;
            this.LbDyC.Text = "Desgustaciones y Compras";
            this.LbDyC.Click += new System.EventHandler(this.LbGestionV_Click);
            // 
            // Gbox_GDyC
            // 
            this.Gbox_GDyC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gbox_GDyC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Gbox_GDyC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gbox_GDyC.Controls.Add(this.LbDyC);
            this.Gbox_GDyC.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gbox_GDyC.Location = new System.Drawing.Point(-2, 0);
            this.Gbox_GDyC.Name = "Gbox_GDyC";
            this.Gbox_GDyC.Size = new System.Drawing.Size(803, 81);
            this.Gbox_GDyC.TabIndex = 3;
            this.Gbox_GDyC.TabStop = false;
            this.Gbox_GDyC.Enter += new System.EventHandler(this.Gbox_GDyC_Enter);
            // 
            // Desgustaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbox_GDyC);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Desgustaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VinoScribe";
            this.Load += new System.EventHandler(this.Desgustaciones_Load);
            this.Gbox_GDyC.ResumeLayout(false);
            this.Gbox_GDyC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbDyC;
        private System.Windows.Forms.GroupBox Gbox_GDyC;
    }
}