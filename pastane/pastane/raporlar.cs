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
    public partial class raporlar : Form
    {
        public raporlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=Pastane;Integrated Security=true;");

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa git = new anasayfa();
            git.Show();
            this.Hide();
        }
        private void btnsatici1_Click(object sender, EventArgs e)
        {
            //satıcı ve ilçeye göre il sıralama

            SqlCommand komut = new SqlCommand("select saticiil,saticiilce,saticiadsoyad from satici order by saticiil asc", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource =ds;
        }
        private void btnsatici2_Click(object sender, EventArgs e)
        {
            //şehri istanbul olan satıcıların isimleri
            SqlCommand komut = new SqlCommand("select saticiil,saticiadsoyad from satici where saticiil='istanbul'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
        }
        private void btnsatici3_Click(object sender, EventArgs e)
        {
            //ilçe kadıköy ve maltepe olan satıcıların bilgileri
            SqlCommand komut = new SqlCommand("select * from satici where saticiilce='kadıköy' or saticiilce='maltepe'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
        }
        private void btnurun1_Click(object sender, EventArgs e)
        {
            //ismi pasta ve fiyatı 100 tlden fazla olan iller
            //join işlemi kodları(ürünler ile satıcılar saticino ile ilişki kuruldu)
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select siparisadi,siparisadres,siparisfiyat from siparis where siparisadi='pasta' and siparisfiyat>100", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void btnurun2_Click(object sender, EventArgs e)
        {
            //son ve ilk kullanma tarihi arasındaki ürünler
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urunler where kullanimtarihi between'01.01.2021' and '01.01.2022'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void btnurun3_Click(object sender, EventArgs e)
        {
            //son kullanma tarihine göre en yüksek fiyat
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select kullanimtarihi,max(urunfiyat) as 'son kullanma tarihine göre en yüksek fiyatlı ürün' from urunler where kullanimtarihi='01.01.2022' group by kullanimtarihi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void btnmusteri1_Click(object sender, EventArgs e)
        {
            //müşteri isimleri sıralama
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteriler order by musteriadsoyad asc", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void btnmusteri2_Click(object sender, EventArgs e)
        {
            //en son eklenen 5 kayıt
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select top 5 * from musteriler order by musterino desc", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();        
        }

        private void btnsiparis1_Click(object sender, EventArgs e)
        {
            //isme göre sipariş adet toplamı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select musteriadsoyad,siparisadi,sum(siparisadet) as 'sipariş toplamı' from musteriler m inner join siparis s on m.siparisno = s.siparisno group by siparisadi, musteriadsoyad", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void btnsiparis2_Click(object sender, EventArgs e)
        {
            //sipariş adına göre sipariş adet toplam
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select siparisadi,sum(siparisadet) as 'sipariş toplamı' from musteriler m inner join siparis s on m.siparisno=s.siparisno group by siparisadi ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void btnsiparis3_Click(object sender, EventArgs e)
        {
            //sipariş adına göre fiyat toplamı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select siparisadi,sum(siparisfiyat) as 'sipariş fiyat toplamı' from musteriler m inner join siparis s on m.siparisno=s.siparisno group by siparisadi ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void btnmusteri3_Click(object sender, EventArgs e)
        {
            //müşterilerin aldığı siparişler ve fiyatları
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select musteriadsoyad,siparisadi,siparisfiyat from musteriler m inner join siparis s on m.siparisno=s.siparisno", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {//siparişe göre müşteri bilgileri
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select musteriadsoyad, musteritelefon, siparisadi, siparisadres, siparisadet, siparisfiyat from musteriler inner join siparis on musteriler.siparisno = siparis.siparisno", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {//ürüne göre satıcı bilgileri
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select saticiadsoyad,saticiil,saticiilce,urunadi,urunfiyat from urunler inner join satici on satici.saticino=urunler.saticino", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
