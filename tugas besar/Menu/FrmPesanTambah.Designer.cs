﻿namespace Menu
{
    partial class FrmPesanTambah
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
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKode = new System.Windows.Forms.TextBox();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtJumlah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPPN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtGrantotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBayar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtKembali = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Dgv.Location = new System.Drawing.Point(12, 70);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 24;
            this.Dgv.Size = new System.Drawing.Size(720, 157);
            this.Dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jumlah";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(576, 236);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 23);
            this.BtnSimpan.TabIndex = 1;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode";
            // 
            // TxtKode
            // 
            this.TxtKode.Location = new System.Drawing.Point(12, 42);
            this.TxtKode.Name = "TxtKode";
            this.TxtKode.Size = new System.Drawing.Size(100, 22);
            this.TxtKode.TabIndex = 3;
            this.TxtKode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKode_KeyPress);
            // 
            // TxtNama
            // 
            this.TxtNama.Enabled = false;
            this.TxtNama.Location = new System.Drawing.Point(118, 42);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(176, 22);
            this.TxtNama.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // TxtHarga
            // 
            this.TxtHarga.Enabled = false;
            this.TxtHarga.Location = new System.Drawing.Point(300, 42);
            this.TxtHarga.Name = "TxtHarga";
            this.TxtHarga.Size = new System.Drawing.Size(100, 22);
            this.TxtHarga.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Harga";
            // 
            // TxtJumlah
            // 
            this.TxtJumlah.Location = new System.Drawing.Point(406, 42);
            this.TxtJumlah.Name = "TxtJumlah";
            this.TxtJumlah.Size = new System.Drawing.Size(100, 22);
            this.TxtJumlah.TabIndex = 9;
            this.TxtJumlah.TextChanged += new System.EventHandler(this.TxtJumlah_TextChanged);
            this.TxtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJumlah_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jumlah";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Location = new System.Drawing.Point(512, 42);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.TxtSubtotal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subtotal";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(118, 236);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total";
            // 
            // TxtPPN
            // 
            this.TxtPPN.Enabled = false;
            this.TxtPPN.Location = new System.Drawing.Point(118, 264);
            this.TxtPPN.Name = "TxtPPN";
            this.TxtPPN.Size = new System.Drawing.Size(100, 22);
            this.TxtPPN.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "PPN 10%";
            // 
            // TxtGrantotal
            // 
            this.TxtGrantotal.Enabled = false;
            this.TxtGrantotal.Location = new System.Drawing.Point(118, 292);
            this.TxtGrantotal.Name = "TxtGrantotal";
            this.TxtGrantotal.Size = new System.Drawing.Size(100, 22);
            this.TxtGrantotal.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grantotal";
            // 
            // TxtBayar
            // 
            this.TxtBayar.Location = new System.Drawing.Point(118, 320);
            this.TxtBayar.Name = "TxtBayar";
            this.TxtBayar.Size = new System.Drawing.Size(100, 22);
            this.TxtBayar.TabIndex = 19;
            this.TxtBayar.TextChanged += new System.EventHandler(this.TxtBayar_TextChanged);
            this.TxtBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBayar_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bayar";
            // 
            // TxtKembali
            // 
            this.TxtKembali.Enabled = false;
            this.TxtKembali.Location = new System.Drawing.Point(118, 348);
            this.TxtKembali.Name = "TxtKembali";
            this.TxtKembali.Size = new System.Drawing.Size(100, 22);
            this.TxtKembali.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kembali";
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Location = new System.Drawing.Point(657, 236);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(75, 23);
            this.BtnKeluar.TabIndex = 22;
            this.BtnKeluar.Text = "Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // FrmPesanTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 386);
            this.Controls.Add(this.BtnKeluar);
            this.Controls.Add(this.TxtKembali);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtBayar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtGrantotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPPN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtJumlah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.Dgv);
            this.Name = "FrmPesanTambah";
            this.Text = "FrmPesanTambah";
            this.Load += new System.EventHandler(this.FrmPesanTambah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKode;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtJumlah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtGrantotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBayar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtKembali;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnKeluar;
    }
}