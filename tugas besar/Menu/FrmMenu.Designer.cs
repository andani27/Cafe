namespace Menu
{
    partial class FrmMenu
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
            this.BtnCari = new System.Windows.Forms.Button();
            this.TxtCari = new System.Windows.Forms.TextBox();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnUbah = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Menu.Properties.Resources.bg;
            this.PictureBox1.Location = new System.Drawing.Point(12, 15);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(759, 190);
            this.PictureBox1.TabIndex = 13;
            this.PictureBox1.TabStop = false;
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(696, 211);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(75, 23);
            this.BtnCari.TabIndex = 12;
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // TxtCari
            // 
            this.TxtCari.Location = new System.Drawing.Point(590, 212);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Size = new System.Drawing.Size(100, 22);
            this.TxtCari.TabIndex = 11;
            this.TxtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCari_KeyPress);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(174, 211);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(75, 23);
            this.BtnHapus.TabIndex = 10;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnUbah
            // 
            this.BtnUbah.Location = new System.Drawing.Point(93, 211);
            this.BtnUbah.Name = "BtnUbah";
            this.BtnUbah.Size = new System.Drawing.Size(75, 23);
            this.BtnUbah.TabIndex = 9;
            this.BtnUbah.Text = "Ubah";
            this.BtnUbah.UseVisualStyleBackColor = true;
            this.BtnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Location = new System.Drawing.Point(12, 211);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(75, 23);
            this.BtnTambah.TabIndex = 8;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 240);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(759, 217);
            this.Dgv.TabIndex = 7;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 473);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.TxtCari);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnUbah);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.Dgv);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button BtnCari;
        internal System.Windows.Forms.TextBox TxtCari;
        internal System.Windows.Forms.Button BtnHapus;
        internal System.Windows.Forms.Button BtnUbah;
        internal System.Windows.Forms.Button BtnTambah;
        internal System.Windows.Forms.DataGridView Dgv;
    }
}