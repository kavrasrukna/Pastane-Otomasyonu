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
    public partial class urunler : Form
    {
        public urunler()
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txturunad.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txturunad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txturunfiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1kullanim.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker2uretim.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtsaticino.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            Goruntule("Select*from urunler");
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into urunler(urunadi,urunfiyat,kullanimtarihi,uretimtarihi,saticino) values (@urunadi,@urunfiyat,@kullanimtarihi,@uretimtarihi,@saticino)", baglanti);
            cmd.Parameters.AddWithValue("@urunadi", txturunad.Text);//@parametre txtten alıp parametreye gönderiyor oradan sqle gönderiyor.
            cmd.Parameters.AddWithValue("@urunfiyat", txturunfiyat.Text);
            cmd.Parameters.AddWithValue("@kullanimtarihi", dateTimePicker1kullanim.Text);
            cmd.Parameters.AddWithValue("@uretimtarihi", dateTimePicker2uretim.Text);
            cmd.Parameters.AddWithValue("@saticino", txtsaticino.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            Goruntule("select*from urunler");
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urunler set urunadi='" + txturunad.Text.ToString()
                + "', urunfiyat = '" + txturunfiyat.Text.ToString()
                + "', kullanimtarihi = '" + dateTimePicker1kullanim.Text.ToString()
                + "', uretimtarihi = '" + dateTimePicker2uretim.Text.ToString()
                 + "', saticino = '" + txtsaticino.Text.ToString()
                + "'where urunno='" + txturunad.Tag.ToString() + "'", baglanti);

            //tırnakları alanları birbirinden ayırmak için kullanırız.(+) verileri birleştirmek için
            komut.ExecuteNonQuery();
            Goruntule("select*from urunler");
            baglanti.Close();
        }
        private void btnara_Click(object sender, EventArgs e)
        {
            //arama işlemi
            //arama işlemi like kullanırız ama like yerine where de kullanabiliriz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from urunler where urunadi like '%" + txturunad.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            baglanti.Close();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urunler where urunno=@urunno", baglanti);
            komut.Parameters.AddWithValue("@urunno", txturunad.Tag);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Goruntule("select*from urunler");
        }
    }
}
