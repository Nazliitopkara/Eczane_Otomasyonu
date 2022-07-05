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
    public partial class İlacBilgisi : Form
    {
        public İlacBilgisi()
        {
            InitializeComponent();
        }

        sqlBaglan bgl = new sqlBaglan();
        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris fr = new Giris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tablo_ilacKayit(ilacAd,ilacFirma,ilacSayi,ilacFiyat,ilacStok)values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.Parameters.AddWithValue("@p5", textBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İlaç Kaydınız Gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tablo_ilacBilgi(ilacAdi,kullanimAmaci,kullanimSekli,kullanici,yanEtkileri)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox7.Text);
            komut.Parameters.AddWithValue("@p2", textBox9.Text);
            komut.Parameters.AddWithValue("@p3", textBox10.Text);
            komut.Parameters.AddWithValue("@p4", textBox12.Text);
            komut.Parameters.AddWithValue("@p5", textBox8.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İlaç Kaydınız Gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
