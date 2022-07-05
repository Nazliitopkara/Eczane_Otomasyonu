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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        sqlBaglan bgl = new sqlBaglan();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tablo_Eczaci Where eczaciTC=@p1 and eczaciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Anasayfa fr = new Anasayfa();
                fr.tc = maskedTextBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Hatalı Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
