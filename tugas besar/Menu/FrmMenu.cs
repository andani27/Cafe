using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            Dgv.DataSource = H.OpenDT("SELECT * FROM tb_menu WHERE nama LIKE '%" + TxtCari.Text + "%'");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Dgv.AllowUserToAddRows = false;
            Dgv.ReadOnly = true;
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            BtnCari_Click(sender, e);
        }

        private void TxtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)13)
            {
                BtnCari_Click(sender, e);
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FrmMenuTambah f = new FrmMenuTambah();
            if (f.ShowDialog()==DialogResult.Yes)
            {
                BtnCari_Click(sender, e);
            }
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (Dgv.CurrentCell != null)
            {
                FrmMenuTambah f = new FrmMenuTambah();
                f.Edit = true;
                f.TxtKode.Text = Dgv[0, Dgv.CurrentCell.RowIndex].Value.ToString();
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    BtnCari_Click(sender, e);
                }
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (Dgv.CurrentCell != null)
            {
                if (H.MsgAsk("Hapus data?") == DialogResult.Yes)
                {
                    H.Execute("DELETE FROM tb_menu WHERE kode='" + Dgv[0, Dgv.CurrentCell.RowIndex].Value.ToString() + "'");
                    H.MsgInfo("Menu terhapus!");
                    BtnCari_Click(sender, e);
                }                                
            }
        }
    }
}
