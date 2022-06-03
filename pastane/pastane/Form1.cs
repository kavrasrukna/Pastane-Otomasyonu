using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //kütüphanemizi ekledik

namespace pastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=Pastane;Integrated Security=true"); //sqlle bağlantı kurma işlemi serverda . yı kabul etmezse
                                                                                                          //sql deki server name i yaz
        private void Form1_Load(object sender, EventArgs e)
        {
            kayitol.Visible = false;
        }
        private void btngiris_Click(object sender, EventArgs e)//prosedürsüz işlemler
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from kullanicigiris where kullaniciad=@kullaniciad and kullanicisifre=@kullanicisifre", baglanti);//sqldeki tablonun adı  
            komut.Parameters.AddWithValue("kullaniciad", txtgkullaniciadi.Text);
            komut.Parameters.AddWithValue("kullanicisifre", txtgsifre.Text); // tablodaki kolonlarımın adı
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anasayfa git = new anasayfa();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz hatalı", "Tekrar deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtgkullaniciadi.Clear();
                txtgsifre.Clear();
            }
            baglanti.Close();
        }
        private void checkBoxkayit_CheckedChanged(object sender, EventArgs e)
        {
            kayitol.Visible = true;
        }
        private void btnkayit_Click(object sender, EventArgs e)
        {
            if (kayitkullaniciadi.Text == "" || kayitsifre.Text == "" || txtmail.Text == "" || maskedtxttel.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }
            else
            {
                MessageBox.Show("Üyeliğiniz oluşturuldu.Giriş yapınız.");

                // veri ekleme komutu
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into kullanicigiris(kullaniciad,kullanicisifre,email,telefon) values (@kullaniciad,@kullanicisifre,@email,@telefon)", baglanti);
                cmd.Parameters.AddWithValue("@kullaniciad", kayitkullaniciadi.Text);//@parametre txtten alıp parametreye gönderiyor oradan sqle gönderiyor.
                cmd.Parameters.AddWithValue("@kullanicisifre", kayitsifre.Text);
                cmd.Parameters.AddWithValue("@email", txtmail.Text);
                cmd.Parameters.AddWithValue("@telefon", maskedtxttel.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydınız başarıyla gerçekleşti.");
                kayitkullaniciadi.Clear();
                kayitsifre.Clear();
                txtmail.Clear();
                maskedtxttel.Clear();

            }
        }
    }
}
