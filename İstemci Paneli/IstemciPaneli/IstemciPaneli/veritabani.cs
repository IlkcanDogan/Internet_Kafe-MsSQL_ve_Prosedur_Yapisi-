using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace IstemciPaneli
{
    
    class veritabani
    {
        private SqlConnection baglan;
        DataTable table = new DataTable();
        
        public veritabani()
        {
            baglan = new SqlConnection(@"Data Source=DESKTOP-89O9T3T; Initial Catalog=cafeDB;Integrated Security=SSPI");
        }

        public bool BaglantiKur(string PC_Adi, string IP_Adresi)
        {
            bool Durum = false;

            SqlCommand sorgu = new SqlCommand();
            baglan.Open();
            sorgu.Connection = baglan;
            table.Clear();

            sorgu.CommandText = "sp_BilgisayarBaglan"; 
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.Parameters.Add(new SqlParameter("@PC_Adi", PC_Adi));
            sorgu.Parameters.Add(new SqlParameter("@IP_Adresi", IP_Adresi));
            table.Load(sorgu.ExecuteReader());
            foreach (DataRow satir in table.Rows)
            {
                Durum = Convert.ToBoolean(satir["Durum"]);
            }

            baglan.Close();
            return Durum;
        }

        public string SaatSorgula(string PC_Adi)
        {
           
            string Saat = null;
            
            SqlCommand sorgu = new SqlCommand();
            baglan.Open();
            sorgu.Connection = baglan;
           

            sorgu.CommandText = "sp_KapanmaSaati";
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.Parameters.Add(new SqlParameter("@PC_Adi", PC_Adi));

            Saat = sorgu.ExecuteScalar().ToString();
            baglan.Close();
            return Saat;
        }
    }
}
