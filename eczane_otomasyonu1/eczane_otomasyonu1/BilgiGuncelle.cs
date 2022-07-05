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
    public partial class BilgiGuncelle : Form
    {
        public BilgiGuncelle()
        {
            InitializeComponent();
        }

        sqlBaglan bgl = new sqlBaglan();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tablo_Eczaci(eczaciAd,eczaciSoyad,eczaciTC,eczaciTelefon,eczaciSifre,eczaciCinsiyet)values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p5", textBox3.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Tamamlanmıştır Şifreniz: " + textBox3.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
    }
}
