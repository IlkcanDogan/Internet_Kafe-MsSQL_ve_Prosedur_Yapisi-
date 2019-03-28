using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CafeYonetimPaneli
{
    class VeriTabani
    {
        private SqlConnection baglan;
        DataTable table = new DataTable();
        public VeriTabani()
        {
            baglan = new SqlConnection(@"Data Source=DESKTOP-89O9T3T; Initial Catalog=cafeDB;Integrated Security=SSPI");
        }
        public DataTable OnlinePCler()
        {
            SqlCommand sorgu = new SqlCommand();
            baglan.Open();
            sorgu.Connection = baglan;
            
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.CommandText = "sp_OnlinePCler";


            table.Clear();
            table.Load(sorgu.ExecuteReader());
      
            baglan.Close();

            return table;
            
        }
        

        public bool OturumAc(string PC_Adi,string SureDK)
        {
            bool Durum= false;
            table.Clear();
            SqlCommand sorgu = new SqlCommand();
            baglan.Open();
            sorgu.Connection = baglan;


            sorgu.CommandText = "sp_OturumAc";
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.Parameters.Add(new SqlParameter("@PC_Adi",PC_Adi));
            sorgu.Parameters.Add(new SqlParameter("@SureDK", SureDK));
            table.Load(sorgu.ExecuteReader());
            foreach (DataRow satir in table.Rows)
            {
                Durum = Convert.ToBoolean(satir["Durum"]);
            }
          
            baglan.Close();
            return Durum;
        }

        public DataTable PCBilgiGetir(string PC_Adi)
        {
            table.Clear();

            SqlCommand sorgu = new SqlCommand();
            baglan.Open();
            sorgu.Connection = baglan;
            sorgu.CommandText = "sp_OturumBilgileri";
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.Parameters.Add(new SqlParameter("@PC_Adi", PC_Adi));
            table.Load(sorgu.ExecuteReader());
            baglan.Close();
            return table;
        }

        public bool MasaAktar(string PC_Adi, string MasaAdi)
        {
            bool Durum = false;
            table.Clear();
            SqlCommand sorgu = new SqlCommand();
            baglan.Open();
            sorgu.Connection = baglan;


            sorgu.CommandText = "sp_MasaDegistir";
            sorgu.CommandType = CommandType.StoredProcedure;

            sorgu.Parameters.Add(new SqlParameter("@PC_Adi", PC_Adi));
            sorgu.Parameters.Add(new SqlParameter("@AktarilacakMasaAdi", MasaAdi));
            table.Load(sorgu.ExecuteReader());
            foreach (DataRow satir in table.Rows)
            {
                Durum = Convert.ToBoolean(satir["Durum"]);
            }

            baglan.Close();
            return Durum;
        }

    }
}
