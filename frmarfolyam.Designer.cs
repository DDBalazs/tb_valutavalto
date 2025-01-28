namespace tb_valutavalto_20250128
{
    partial class frmarfolyam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmarfolyam));
            this.label1 = new System.Windows.Forms.Label();
            this.cbdevnem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txdevegy = new System.Windows.Forms.TextBox();
            this.txdevhuf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devizanem:";
            // 
            // cbdevnem
            // 
            this.cbdevnem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdevnem.FormattingEnabled = true;
            this.cbdevnem.Location = new System.Drawing.Point(93, 56);
            this.cbdevnem.Name = "cbdevnem";
            this.cbdevnem.Size = new System.Drawing.Size(121, 21);
            this.cbdevnem.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txdevhuf);
            this.groupBox1.Controls.Add(this.txdevegy);
            this.groupBox1.Location = new System.Drawing.Point(258, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egység";
            // 
            // txdevegy
            // 
            this.txdevegy.Location = new System.Drawing.Point(6, 19);
            this.txdevegy.Name = "txdevegy";
            this.txdevegy.Size = new System.Drawing.Size(100, 20);
            this.txdevegy.TabIndex = 0;
            // 
            // txdevhuf
            // 
            this.txdevhuf.Location = new System.Drawing.Point(6, 60);
            this.txdevhuf.Name = "txdevhuf";
            this.txdevhuf.Size = new System.Drawing.Size(100, 20);
            this.txdevhuf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HUF";
            // 
            // btsave
            // 
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsave.Location = new System.Drawing.Point(16, 157);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(154, 48);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "Mentés";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Image = ((System.Drawing.Image)(resources.GetObject("btexit.Image")));
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btexit.Location = new System.Drawing.Point(304, 157);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(154, 48);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "Elvet";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // frmarfolyam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 238);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbdevnem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmarfolyam";
            this.Text = "Áfrolyam rögzítése";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbdevnem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txdevhuf;
        private System.Windows.Forms.TextBox txdevegy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btexit;
    }
}