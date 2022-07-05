using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eczane_otomasyonu1
{
    class sqlBaglan
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-9IQ5NO3T\\SQLEXPRESS;Initial Catalog=EczaneOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
