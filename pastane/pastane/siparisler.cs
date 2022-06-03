using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pastane
{
    public partial class siparisler : Form
    {
        public siparisler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=Pastane;Integrated Security=true;");

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        public void Goruntule(string sorgu)//adonet prosedürsüz işlem
        {
            SqlDataAdapter goruntule = new SqlDataAdapter(sorgu, baglanti);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa git = new anasayfa();
            git.Show();
            this.Hide();
        }
        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
            git.Show();
            this.Hide();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            Goruntule("Select*from siparis");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into siparis(siparisadi,siparisadres,siparisadet,siparisfiyat,urunno,tutar) values (@siparisadi,@siparisadres,@siparisadet,@siparisfiyat,@urunno,@tutar)", baglanti);
            cmd.Parameters.AddWithValue("@siparisadi", txtsiparisadi.Text);//@parametre txtten alıp parametreye gönderiyor oradan sqle gönderiyor.
            cmd.Parameters.AddWithValue("@siparisadres", txtsiparisadres.Text);
            cmd.Parameters.AddWithValue("@siparisadet", txtsiparisadet.Text);
            cmd.Parameters.AddWithValue("@siparisfiyat", txtsiparisfiyat.Text);
            cmd.Parameters.AddWithValue("@urunno", txturunno.Text);
            cmd.Parameters.AddWithValue("@tutar", txttutar.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            Goruntule("select*from siparis");
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update siparis set siparisadi='" + txtsiparisadi.Text.ToString()
                + "', siparisadres = '" + txtsiparisadres.Text.ToString()
                + "', siparisadet = '" + txtsiparisadet.Text.ToString()
                + "', siparisfiyat = '" + txtsiparisfiyat.Text.ToString()
                 + "', urunno = '" + txturunno.Text.ToString()
                + "', tutar = '" + txttutar.Text.ToString()
                + "'where siparisno='" + txtsiparisadi.Tag.ToString() + "'", baglanti);

            //tırnakları alanları birbirinden ayırmak için kullanırız.(+) verileri birleştirmek için
            komut.ExecuteNonQuery();
            Goruntule("select*from siparis");
            baglanti.Close();

        }
        private void btnara_Click(object sender, EventArgs e)
        {
            //arama işlemi
            //arama işlemi like kullanırız ama like yerine where de kullanabiliriz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from siparis where siparisadi like '%" + txtsiparisadi.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            baglanti.Close();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from siparis where siparisno=@siparisno", baglanti);
            komut.Parameters.AddWithValue("@siparisno", txtsiparisadi.Tag);//siparisnoyu txtsiparisadi kolonuna gizledim
            komut.ExecuteNonQuery();
            baglanti.Close();
            Goruntule("select*from siparis");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsiparisadi.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtsiparisadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsiparisadres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsiparisadet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsiparisfiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txturunno.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txttutar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
