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
    public partial class saticilar : Form
    {
        public saticilar()
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
            Goruntule("Select*from satici");
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into satici(saticiadsoyad,saticiadres,saticiil,saticiilce) values (@saticiadsoyad,@saticiadres,@saticiil,@saticiilce)", baglanti);
            cmd.Parameters.AddWithValue("@saticiadsoyad", txtsaticiadsoyad.Text);//@parametre txtten alıp parametreye gönderiyor oradan sqle gönderiyor.
            cmd.Parameters.AddWithValue("@saticiadres", txtsaticiadres.Text);
            cmd.Parameters.AddWithValue("@saticiil", txtsaticiil.Text);
            cmd.Parameters.AddWithValue("@saticiilce", txtsaticiilce.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            Goruntule("select*from satici");
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update satici set saticiadsoyad='" + txtsaticiadsoyad.Text.ToString()
                + "', saticiadres = '" + txtsaticiadres.Text.ToString()
                + "', saticiil = '" + txtsaticiil.Text.ToString()
                + "', saticiilce = '" + txtsaticiilce.Text.ToString()
                + "'where saticino='" + txtsaticiadsoyad.Tag.ToString() + "'", baglanti);
            //tırnakları alanları birbirinden ayırmak için kullanırız.(+) verileri birleştirmek için
            komut.ExecuteNonQuery();
            Goruntule("select*from satici");
            baglanti.Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            //arama işlemi
            //arama işlemi like kullanırız ama like yerine where de kullanabiliriz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from satici where saticiadsoyad like '%" + txtsaticiadsoyad.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            baglanti.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from satici where saticino=@saticino", baglanti);
            komut.Parameters.AddWithValue("@saticino", txtsaticiadsoyad.Tag);//saticinoyu txtsaticiadsoyad kolonuna gizledim
            komut.ExecuteNonQuery();
            baglanti.Close();
            Goruntule("select*from satici");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsaticiadsoyad.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
            txtsaticiadsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsaticiadres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsaticiil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsaticiilce.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
