using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Menu
{
    public partial class FrmMenuTambah : Form
    {
        public bool Edit = false;

        public FrmMenuTambah()
        {
            InitializeComponent();
        }

        private void FrmMenuTambah_Load(object sender, EventArgs e)
        {
            TxtKode.Enabled = true;
            TxtNama.Text = "";
            TxtHarga.Text = "";
            TxtSatuan.Text = "";
            TxtKeterangan.Text = "";
            PbGambar.Image = null;

            if (Edit)
            {
                TxtKode.Enabled = false;
                DataTable Dt = H.OpenDT("SELECT * FROM tb_menu WHERE kode='" + TxtKode.Text + "'");
                if (Dt.Rows.Count > 0)
                {
                    TxtNama.Text = Dt.Rows[0]["Nama"].ToString();
                    TxtHarga.Text = Dt.Rows[0]["Harga"].ToString();
                    TxtSatuan.Text = Dt.Rows[0]["Satuan"].ToString();
                    TxtKeterangan.Text = Dt.Rows[0]["Keterangan"].ToString();

                    if (Dt.Rows[0]["Gambar"] != null)
                    {
                        byte[] lb = (byte[])Dt.Rows[0]["Gambar"];
                        MemoryStream lstr = new MemoryStream(lb);
                        PbGambar.Image = Image.FromStream(lstr);
                    }
                }
            }
        }

        private void PbGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "JPG|*.jpg|PNG|*.png";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbGambar.Image = Image.FromFile(OpenFileDialog1.FileName);
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            DataTable DtAda = H.OpenDT("SELECT * FROM tb_menu WHERE kode='" + TxtKode.Text + "'");

            if (TxtKode.Text == "" || TxtNama.Text == "" || TxtHarga.Text == "" || TxtSatuan.Text == "")
            {
                H.MsgInfo("Masukkan Kode, Nama, Harga, dan Satuan!");
            }
            else if (DtAda.Rows.Count > 0 && !Edit)
            {
                H.MsgInfo("Kode sudah ada!");
            }
            else
            {
                if (Edit)
                {
                    H.Execute("UPDATE tb_menu SET nama='" + TxtNama.Text + "', harga='" + TxtHarga.Text + "', satuan='" + TxtSatuan.Text + "', keterangan='" + TxtKeterangan.Text + "' WHERE kode='" + TxtKode.Text + "'");
                }
                else
                {
                    H.Execute("INSERT INTO tb_menu (kode, nama, harga, satuan, keterangan) VALUES ('" + TxtKode.Text + "', '" + TxtNama.Text + "', '" + TxtHarga.Text + "', '" + TxtSatuan.Text + "', '" + TxtKeterangan.Text + "' )");
                }
                SimpanGambar();
                H.MsgInfo("Data tersimpan!");
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void SimpanGambar()
        {
            if (PbGambar.Image==null) return;

            MemoryStream mstream = new MemoryStream();
            PbGambar.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            Byte[] arrImage = mstream.GetBuffer();

            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE tb_menu SET gambar=@0 WHERE kode=@1", H.GetConn());
                cmd.Parameters.AddWithValue("@0", arrImage);
                cmd.Parameters.AddWithValue("@1", TxtKode.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                H.MsgInfo("Gagal menyimpan gambar: " + ex.Message);
            }            
        }
    }
}
