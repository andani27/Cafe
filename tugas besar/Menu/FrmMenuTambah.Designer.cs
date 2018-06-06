namespace Menu
{
    partial class FrmMenuTambah
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
            this.TxtSatuan = new System.Windows.Forms.ComboBox();
            this.BtnBatal = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.PbGambar = new System.Windows.Forms.PictureBox();
            this.TxtKeterangan = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtHarga = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtKode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PbGambar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSatuan
            // 
            this.TxtSatuan.FormattingEnabled = true;
            this.TxtSatuan.Items.AddRange(new object[] {
            "Btl",
            "Pcs"});
            this.TxtSatuan.Location = new System.Drawing.Point(138, 240);
            this.TxtSatuan.Name = "TxtSatuan";
            this.TxtSatuan.Size = new System.Drawing.Size(154, 24);
            this.TxtSatuan.TabIndex = 37;
            // 
            // BtnBatal
            // 
            this.BtnBatal.Location = new System.Drawing.Point(116, 441);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Size = new System.Drawing.Size(75, 23);
            this.BtnBatal.TabIndex = 36;
            this.BtnBatal.Text = "Batal";
            this.BtnBatal.UseVisualStyleBackColor = true;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(35, 441);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 23);
            this.BtnSimpan.TabIndex = 35;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.Location = new System.Drawing.Point(420, 373);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(142, 17);
            this.Label6.TabIndex = 34;
            this.Label6.Text = "Dbl Klik ganti gambar";
            // 
            // PbGambar
            // 
            this.PbGambar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PbGambar.Location = new System.Drawing.Point(401, 184);
            this.PbGambar.Name = "PbGambar";
            this.PbGambar.Size = new System.Drawing.Size(178, 186);
            this.PbGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbGambar.TabIndex = 33;
            this.PbGambar.TabStop = false;
            this.PbGambar.Click += new System.EventHandler(this.PbGambar_Click);
            // 
            // TxtKeterangan
            // 
            this.TxtKeterangan.Location = new System.Drawing.Point(138, 296);
            this.TxtKeterangan.Multiline = true;
            this.TxtKeterangan.Name = "TxtKeterangan";
            this.TxtKeterangan.Size = new System.Drawing.Size(199, 94);
            this.TxtKeterangan.TabIndex = 32;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(20, 296);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(90, 17);
            this.Label5.TabIndex = 31;
            this.Label5.Text = "Keterangan :";
            // 
            // TxtHarga
            // 
            this.TxtHarga.Location = new System.Drawing.Point(138, 268);
            this.TxtHarga.Name = "TxtHarga";
            this.TxtHarga.Size = new System.Drawing.Size(100, 22);
            this.TxtHarga.TabIndex = 30;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(55, 268);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 17);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Harga :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(49, 240);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 17);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Satuan :";
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(138, 212);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(199, 22);
            this.TxtNama.TabIndex = 27;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(57, 212);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 17);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Nama :";
            // 
            // TxtKode
            // 
            this.TxtKode.Location = new System.Drawing.Point(138, 184);
            this.TxtKode.Name = "TxtKode";
            this.TxtKode.Size = new System.Drawing.Size(100, 22);
            this.TxtKode.TabIndex = 25;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(61, 184);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 17);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Kode :";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Menu.Properties.Resources.bg;
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(567, 153);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 23;
            this.PictureBox1.TabStop = false;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // FrmMenuTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 482);
            this.Controls.Add(this.TxtSatuan);
            this.Controls.Add(this.BtnBatal);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.PbGambar);
            this.Controls.Add(this.TxtKeterangan);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TxtHarga);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtKode);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Name = "FrmMenuTambah";
            this.Text = "Input Menu";
            this.Load += new System.EventHandler(this.FrmMenuTambah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbGambar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox TxtSatuan;
        internal System.Windows.Forms.Button BtnBatal;
        internal System.Windows.Forms.Button BtnSimpan;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.PictureBox PbGambar;
        internal System.Windows.Forms.TextBox TxtKeterangan;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtHarga;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtNama;
        internal System.Windows.Forms.Label Label2;
        public System.Windows.Forms.TextBox TxtKode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;

    }
}

