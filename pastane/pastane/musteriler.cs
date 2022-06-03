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
    public partial class musteriler : Form
    {
        public musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=Pastane;Integrated Security=true;");
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
        public void Goruntule(string sorgu)//adonet prosedürsüz işlem
        {
            SqlDataAdapter goruntule = new SqlDataAdapter(sorgu, baglanti);
            DataTable doldur = new DataTable();
            goruntule.Fill(doldur);
            dataGridView1.DataSource = doldur;
        }


        private void btnlistele_Click(object sender, EventArgs e)
        {
            Goruntule("Select*from musteriler");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into musteriler(musteriadsoyad,musteritelefon,siparisno) values (@musteriadsoyad,@musteritelefon,@siparisno)", baglanti);
            cmd.Parameters.AddWithValue("@musteriadsoyad", txtmusteriadsoyad.Text);//@parametre txtten alıp parametreye gönderiyor oradan sqle gönderiyor.
            cmd.Parameters.AddWithValue("@musteritelefon", maskedtxttel.Text);
            cmd.Parameters.AddWithValue("@siparisno", txtmusterisiparisno.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            Goruntule("select*from musteriler");

        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteriler set musteriadsoyad='" + txtmusteriadsoyad.Text.ToString() 
                + "', musteritelefon = '"  + maskedtxttel.Text.ToString() 
                + "', siparisno = '" + txtmusterisiparisno.Text.ToString() 
                + "'where musterino='" + txtmusteriadsoyad.Tag.ToString() + "'", baglanti);

            //tırnakları alanları birbirinden ayırmak için kullanırız.(+) verileri birleştirmek için
            komut.ExecuteNonQuery();
            Goruntule("select*from musteriler");
            baglanti.Close();


        }

        private void btnara_Click(object sender, EventArgs e)
        {
        //arama işlemi
        //arama işlemi like kullanırız ama like yerine where de kullanabiliriz
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select* from musteriler where musteriadsoyad like '%" + txtmusteriadsoyad.Text + "%'" ,  baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                baglanti.Close();

            }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from musteriler where musterino=@musterino", baglanti);
            komut.Parameters.AddWithValue("@musterino",txtmusteriadsoyad.Tag);//musterinoyu txtmusteriadsoyad kolonuna gizledim
            komut.ExecuteNonQuery();
            baglanti.Close();
            Goruntule("select*from musteriler");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//properties cellclik olayına yazıyoruz 
        {
            txtmusteriadsoyad.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //[0] sütun numarası //pastanenoyu tag ile gizler o kolon gelmez.txtmusteriadsoyad textboxının içinde tagında gizler
            txtmusteriadsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedtxttel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmusterisiparisno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
