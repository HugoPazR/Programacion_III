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
            this.Gbox_GV.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbGestionV
            // 
            this.LbGestionV.AutoSize = true;
            this.LbGestionV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LbGestionV.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGestionV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbGestionV.Location = new System.Drawing.Point(275, 20);
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
            // Gestion_De_Vinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Gbox_GV);
            this.Name = "Gestion_De_Vinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Gestion_De_Vinos_Load);
            this.Gbox_GV.ResumeLayout(false);
            this.Gbox_GV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbGestionV;
        private System.Windows.Forms.GroupBox Gbox_GV;
    }
}