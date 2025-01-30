namespace tb_valutavalto_20250128
{
    partial class FoForm
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
            this.msnav = new System.Windows.Forms.MenuStrip();
            this.adatokRögzítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msdevrog = new System.Windows.Forms.ToolStripMenuItem();
            this.msarfolyam = new System.Windows.Forms.ToolStripMenuItem();
            this.msvaluta = new System.Windows.Forms.ToolStripMenuItem();
            this.msstat = new System.Windows.Forms.ToolStripMenuItem();
            this.msexit = new System.Windows.Forms.ToolStripMenuItem();
            this.msnav.SuspendLayout();
            this.SuspendLayout();
            // 
            // msnav
            // 
            this.msnav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatokRögzítéseToolStripMenuItem,
            this.msvaluta,
            this.msstat,
            this.msexit});
            this.msnav.Location = new System.Drawing.Point(0, 0);
            this.msnav.Name = "msnav";
            this.msnav.Size = new System.Drawing.Size(576, 24);
            this.msnav.TabIndex = 0;
            this.msnav.Text = "menuStrip1";
            // 
            // adatokRögzítéseToolStripMenuItem
            // 
            this.adatokRögzítéseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msdevrog,
            this.msarfolyam});
            this.adatokRögzítéseToolStripMenuItem.Name = "adatokRögzítéseToolStripMenuItem";
            this.adatokRögzítéseToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.adatokRögzítéseToolStripMenuItem.Text = "Adatok rögzítése";
            // 
            // msdevrog
            // 
            this.msdevrog.Name = "msdevrog";
            this.msdevrog.Size = new System.Drawing.Size(194, 22);
            this.msdevrog.Text = "Devizanemek rögzítése";
            this.msdevrog.Click += new System.EventHandler(this.msdevrog_Click);
            // 
            // msarfolyam
            // 
            this.msarfolyam.Name = "msarfolyam";
            this.msarfolyam.Size = new System.Drawing.Size(194, 22);
            this.msarfolyam.Text = "Árfolyam rögzítése";
            this.msarfolyam.Click += new System.EventHandler(this.msarfolyam_Click);
            // 
            // msvaluta
            // 
            this.msvaluta.Name = "msvaluta";
            this.msvaluta.Size = new System.Drawing.Size(81, 20);
            this.msvaluta.Text = "Valutaváltás";
            this.msvaluta.Click += new System.EventHandler(this.msvaluta_Click);
            // 
            // msstat
            // 
            this.msstat.Name = "msstat";
            this.msstat.Size = new System.Drawing.Size(71, 20);
            this.msstat.Text = "Statisztika";
            // 
            // msexit
            // 
            this.msexit.Name = "msexit";
            this.msexit.Size = new System.Drawing.Size(56, 20);
            this.msexit.Text = "Kilépés";
            this.msexit.Click += new System.EventHandler(this.msexit_Click);
            // 
            // FoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 367);
            this.Controls.Add(this.msnav);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.msnav;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.msnav.ResumeLayout(false);
            this.msnav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msnav;
        private System.Windows.Forms.ToolStripMenuItem adatokRögzítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msdevrog;
        private System.Windows.Forms.ToolStripMenuItem msarfolyam;
        private System.Windows.Forms.ToolStripMenuItem msvaluta;
        private System.Windows.Forms.ToolStripMenuItem msstat;
        private System.Windows.Forms.ToolStripMenuItem msexit;
    }
}

