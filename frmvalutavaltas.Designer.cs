namespace tb_valutavalto_20250128
{
    partial class frmvalutavaltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvalutavaltas));
            this.label1 = new System.Windows.Forms.Label();
            this.dbdeviza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbhuf = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txossz = new System.Windows.Forms.TextBox();
            this.dbHUFU = new System.Windows.Forms.RadioButton();
            this.dbUSDH = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviza:";
            // 
            // dbdeviza
            // 
            this.dbdeviza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbdeviza.FormattingEnabled = true;
            this.dbdeviza.Location = new System.Drawing.Point(74, 22);
            this.dbdeviza.Name = "dbdeviza";
            this.dbdeviza.Size = new System.Drawing.Size(121, 21);
            this.dbdeviza.TabIndex = 1;
            this.dbdeviza.SelectedIndexChanged += new System.EventHandler(this.dbdeviza_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deviza egység: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "HUF egység:";
            // 
            // lbhuf
            // 
            this.lbhuf.AutoSize = true;
            this.lbhuf.Location = new System.Drawing.Point(392, 79);
            this.lbhuf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhuf.Name = "lbhuf";
            this.lbhuf.Size = new System.Drawing.Size(14, 13);
            this.lbhuf.TabIndex = 4;
            this.lbhuf.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbUSDH);
            this.groupBox1.Controls.Add(this.dbHUFU);
            this.groupBox1.Location = new System.Drawing.Point(17, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Árváltás iránya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Összeg:";
            // 
            // txossz
            // 
            this.txossz.Location = new System.Drawing.Point(318, 159);
            this.txossz.Name = "txossz";
            this.txossz.Size = new System.Drawing.Size(100, 20);
            this.txossz.TabIndex = 7;
            // 
            // dbHUFU
            // 
            this.dbHUFU.AutoSize = true;
            this.dbHUFU.Location = new System.Drawing.Point(21, 24);
            this.dbHUFU.Name = "dbHUFU";
            this.dbHUFU.Size = new System.Drawing.Size(88, 17);
            this.dbHUFU.TabIndex = 0;
            this.dbHUFU.TabStop = true;
            this.dbHUFU.Text = "HUF - USD";
            this.dbHUFU.UseVisualStyleBackColor = true;
            // 
            // dbUSDH
            // 
            this.dbUSDH.AutoSize = true;
            this.dbUSDH.Location = new System.Drawing.Point(21, 57);
            this.dbUSDH.Name = "dbUSDH";
            this.dbUSDH.Size = new System.Drawing.Size(88, 17);
            this.dbUSDH.TabIndex = 1;
            this.dbUSDH.TabStop = true;
            this.dbUSDH.Text = "USD - HUF";
            this.dbUSDH.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(55, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "HUF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(55, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(231, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "- - - -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(365, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "USD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(358, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "0";
            // 
            // btsave
            // 
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsave.Location = new System.Drawing.Point(17, 370);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(151, 68);
            this.btsave.TabIndex = 13;
            this.btsave.Text = "Mentés";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(345, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 68);
            this.button1.TabIndex = 14;
            this.button1.Text = "Elvet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmvalutavaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txossz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbhuf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbdeviza);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmvalutavaltas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valutavaltasform";
            this.Load += new System.EventHandler(this.frmvalutavaltas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dbdeviza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbhuf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dbUSDH;
        private System.Windows.Forms.RadioButton dbHUFU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txossz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button button1;
    }
}