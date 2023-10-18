namespace Vinos_Scribe_Hugo
{
    partial class Calificaciones
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
            this.LbCa = new System.Windows.Forms.Label();
            this.Gbox_GCa = new System.Windows.Forms.GroupBox();
            this.Gbox_GCa.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbCa
            // 
            this.LbCa.AutoSize = true;
            this.LbCa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LbCa.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbCa.Location = new System.Drawing.Point(97, 16);
            this.LbCa.Name = "LbCa";
            this.LbCa.Size = new System.Drawing.Size(607, 53);
            this.LbCa.TabIndex = 0;
            this.LbCa.Text = "Calificaciones y Valoracion";
            // 
            // Gbox_GCa
            // 
            this.Gbox_GCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gbox_GCa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Gbox_GCa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gbox_GCa.Controls.Add(this.LbCa);
            this.Gbox_GCa.Cursor = System.Windows.Forms.Cursors.Default;
            this.Gbox_GCa.Location = new System.Drawing.Point(-2, 1);
            this.Gbox_GCa.Name = "Gbox_GCa";
            this.Gbox_GCa.Size = new System.Drawing.Size(803, 81);
            this.Gbox_GCa.TabIndex = 4;
            this.Gbox_GCa.TabStop = false;
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbox_GCa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Calificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VinoScribe";
            this.Load += new System.EventHandler(this.Calificaciones_Load);
            this.Gbox_GCa.ResumeLayout(false);
            this.Gbox_GCa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbCa;
        private System.Windows.Forms.GroupBox Gbox_GCa;
    }
}