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
    public partial class HastaBilgi : Form
    {
        public HastaBilgi()
        {
            InitializeComponent();
        }

        public string rct;

        sqlBaglan bgl = new sqlBaglan();
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void HastaBilgi_Load(object sender, EventArgs e)
        {
            label19.Text = rct;

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad,HastaTC,HastaCinsiyet,HastaYas,HastaSikayet,ilacAdi,ilacFiyat From Tablo_Recete where ReceteNo=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label19.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label8.Text = dr[0] + " ";
                label9.Text = dr[1] + " ";
                label10.Text = dr[2] + " ";
                label11.Text = dr[3] + " ";
                label12.Text = dr[4] + " ";
                label13.Text = dr[5] + " ";
                label14.Text = dr[6] + " ";
                label16.Text = dr[7] + " ";

                  
            }
            bgl.baglanti().Close();

            SqlCommand komut1 = new SqlCommand("Select bir,iki,uc,dort,bes,alti,yedi,sekiz,dokuz From Tablo_KullanilanIlaclar where receteNO=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", label19.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label20.Text = dr1[0] + " ";
                label31.Text = dr1[1] + " ";
                label32.Text = dr1[2] + " ";
                label33.Text = dr1[3] + " ";
                label34.Text = dr1[4] + " ";
                label35.Text = dr1[5] + " ";
                label36.Text = dr1[6] + " ";
                label37.Text = dr1[7] + " ";
                label38.Text = dr1[8] + " ";
            }
            bgl.baglanti().Close();

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
