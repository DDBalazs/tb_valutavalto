﻿namespace tb_valutavalto_20250128
{
    partial class frmdeviza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeviza));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txdevkod = new System.Windows.Forms.TextBox();
            this.txdevnev = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviza rövid kódja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deviza neve:";
            // 
            // txdevkod
            // 
            this.txdevkod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txdevkod.Location = new System.Drawing.Point(149, 25);
            this.txdevkod.MaxLength = 3;
            this.txdevkod.Name = "txdevkod";
            this.txdevkod.Size = new System.Drawing.Size(76, 20);
            this.txdevkod.TabIndex = 2;
            this.txdevkod.TextChanged += new System.EventHandler(this.txdevkod_TextChanged);
            // 
            // txdevnev
            // 
            this.txdevnev.Location = new System.Drawing.Point(114, 82);
            this.txdevnev.Name = "txdevnev";
            this.txdevnev.Size = new System.Drawing.Size(191, 20);
            this.txdevnev.TabIndex = 3;
            // 
            // btsave
            // 
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsave.Location = new System.Drawing.Point(29, 130);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(135, 53);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "Mentés";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btexit
            // 
            this.btexit.Image = ((System.Drawing.Image)(resources.GetObject("btexit.Image")));
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btexit.Location = new System.Drawing.Point(170, 130);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(135, 53);
            this.btexit.TabIndex = 5;
            this.btexit.Text = "Elvet";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // frmdeviza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 214);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txdevnev);
            this.Controls.Add(this.txdevkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmdeviza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deviza rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txdevkod;
        private System.Windows.Forms.TextBox txdevnev;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btexit;
    }
}