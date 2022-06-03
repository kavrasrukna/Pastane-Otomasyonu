using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pastane
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        private void btnmusteriler_Click(object sender, EventArgs e)
        {
            musteriler git = new musteriler();
            git.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnurunler_Click(object sender, EventArgs e)
        {
            urunler git = new urunler();
            git.Show();
            this.Hide();
        }

        private void btnsiparisler_Click(object sender, EventArgs e)
        {
            siparisler git = new siparisler();
            git.Show();
            this.Hide();
        }

        private void btnsaticilar_Click(object sender, EventArgs e)
        {
            saticilar git = new saticilar();
            git.Show();
            this.Hide();
        }

        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
            git.Show();
            this.Hide();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa git = new anasayfa();
            git.Show();
            this.Hide();
        }
    }
}
