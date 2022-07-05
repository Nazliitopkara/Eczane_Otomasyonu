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

namespace eczane_otomasyonu1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        public string tc;

        sqlBaglan bgl = new sqlBaglan();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiGuncelle fr = new BilgiGuncelle();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris fr = new Giris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İlacBilgisi fr = new İlacBilgisi();
            fr.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            label8.Text = tc;

            SqlCommand komut1 = new SqlCommand("Select eczaciAd,eczaciSoyad from Tablo_Eczaci where eczaciTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", label8.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                label4.Text=dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tablo_Recete Where ReceteNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader rct  = komut.ExecuteReader();
            if (rct.Read())
            {
                HastaBilgi fr = new HastaBilgi();
                fr.rct = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Reçete Numarası Girdiniz");
            }
            bgl.baglanti().Close();

        }
    }
}
