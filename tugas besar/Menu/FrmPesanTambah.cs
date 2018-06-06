using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmPesanTambah : Form
    {
        public FrmPesanTambah()
        {
            InitializeComponent();
        }

        private void FrmPesanTambah_Load(object sender, EventArgs e)
        {
            Dgv.AllowUserToAddRows = false;
            Dgv.ReadOnly = true;
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void TxtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataTable Dt = H.OpenDT("SELECT * FROM tb_menu WHERE kode='" + TxtKode.Text + "'");
                if (Dt.Rows.Count > 0)
                {
                    TxtKode.Text = Dt.Rows[0]["kode"].ToString();
                    TxtNama.Text = Dt.Rows[0]["nama"].ToString();
                    TxtHarga.Text = Dt.Rows[0]["harga"].ToString();
                    TxtJumlah.Focus();
                }
                else
                {
                    H.MsgInfo("Kode tidak ditemukan!");
                    TxtNama.Text = "";
                    TxtHarga.Text = "";
                    TxtJumlah.Text = "";
                }
            } 
        }

        private void TxtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (H.ToDouble(TxtJumlah.Text) <= 0)
                {
                    H.MsgInfo("Masukkan jumlah dengan benar");
                }
                else
                {
                    Dgv.Rows.Add(new object[] { TxtKode.Text, TxtNama.Text, TxtHarga.Text, TxtJumlah.Text, TxtSubtotal.Text });
                    TxtKode.Text = "";
                    TxtNama.Text = "";
                    TxtHarga.Text = "";
                    TxtJumlah.Text = "";

                    HitungTotal();

                    TxtKode.Focus();
                }
            }
        }

        private void TxtJumlah_TextChanged(object sender, EventArgs e)
        {
            TxtSubtotal.Text = (H.ToDouble(TxtHarga.Text) * H.ToDouble(TxtJumlah.Text)).ToString();
        }

        private void HitungTotal()
        {
            double total = 0;
            double ppn;

            foreach (DataGridViewRow Row in Dgv.Rows)
            {
                total += H.ToDouble(Row.Cells[4].Value.ToString());
            }
            TxtTotal.Text = total.ToString();
            ppn = 0.1 * total;
            TxtPPN.Text = ppn.ToString();
            TxtGrantotal.Text = (total + ppn).ToString();
        }

        private void TxtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnSimpan_Click(sender, e);
            }
        }

        private void TxtBayar_TextChanged(object sender, EventArgs e)
        {
            double grantotal = H.ToDouble(TxtGrantotal.Text);
            double bayar = H.ToDouble(TxtBayar.Text);
            TxtKembali.Text = (bayar - grantotal).ToString();
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            double bayar = H.ToDouble(TxtBayar.Text);
            double grantotal = H.ToDouble(TxtGrantotal.Text);
            if (bayar < grantotal)
            {
                H.MsgInfo("Pembayaran kurang!");
            }
            else if (Dgv.Rows.Count==0)
            {
                H.MsgInfo("Belum ada menu yang dipesan!");
            }
            else
            {
                string kode_pesan = DateTime.Now.ToString("yyyyMMdd-HHmmss");
                foreach (DataGridViewRow Row in Dgv.Rows)
                {
                    H.Execute("INSERT INTO tb_pesan (kode_pesan, kode, nama, harga, jumlah, subtotal, total, ppn, grantotal, bayar, kembali) VALUES ('"
                        + kode_pesan + "', '"
                        + Row.Cells[0].Value.ToString() + "', '"
                        + Row.Cells[1].Value.ToString() + "', '"
                        + Row.Cells[2].Value.ToString() + "', '"
                        + Row.Cells[3].Value.ToString() + "', '"
                        + Row.Cells[4].Value.ToString() + "', '"
                        + TxtTotal.Text + "', '"
                        + TxtPPN.Text + "', '"
                        + TxtGrantotal.Text + "', '"
                        + TxtBayar.Text + "', '"
                        + TxtKembali.Text + "')");
                }
                H.MsgInfo("Pemesanan tersimpan");
                TxtKode.Text = "";
                TxtNama.Text = "";
                TxtHarga.Text = "";
                TxtJumlah.Text = "";
                TxtSubtotal.Text = "";
                Dgv.Rows.Clear();
                TxtTotal.Text = "";
                TxtPPN.Text = "";
                TxtGrantotal.Text = "";
                TxtBayar.Text = "";
                TxtKembali.Text = "";
            }
        }
    }
}
