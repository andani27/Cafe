namespace Menu
{
    partial class FrmUtama
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnPesan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Menu.Properties.Resources.bg;
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(649, 238);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 14;
            this.PictureBox1.TabStop = false;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(12, 256);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(319, 85);
            this.BtnMenu.TabIndex = 15;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnPesan
            // 
            this.BtnPesan.Location = new System.Drawing.Point(337, 256);
            this.BtnPesan.Name = "BtnPesan";
            this.BtnPesan.Size = new System.Drawing.Size(324, 85);
            this.BtnPesan.TabIndex = 16;
            this.BtnPesan.Text = "Pesan";
            this.BtnPesan.UseVisualStyleBackColor = true;
            this.BtnPesan.Click += new System.EventHandler(this.BtnPesan_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 357);
            this.Controls.Add(this.BtnPesan);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.PictureBox1);
            this.Name = "FrmUtama";
            this.Text = "FrmUtama";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnPesan;
    }
}