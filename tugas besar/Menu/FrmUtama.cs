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
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu f = new FrmMenu();
            f.ShowDialog();
        }

        private void BtnPesan_Click(object sender, EventArgs e)
        {
            FrmPesanTambah f = new FrmPesanTambah();
            f.ShowDialog();
        }
    }
}
