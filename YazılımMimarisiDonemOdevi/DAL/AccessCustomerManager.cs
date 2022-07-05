using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace YazılımMimarisiDonemOdevi.DAL
{
    //access veri tabanı türüne göre işlem yapan class
    class AccessCustomerManager : ICustomerDAL
    {
        //hocam databese sabitleme kodunu kullanırken hata aldım program çalışmazsa sebebi buradadır :)
        private const string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/emira/source/repos/YazılımMimarisiDonemOdevi/YazılımMimarisiDonemOdevi/bin/Debug/mimaridb.mdb";
        private OleDbConnection baglanti;//veri tabanı bağlantı değişkenini oluşturur.
        private OleDbCommand komut;//veri tabanı komut değişkenini oluşturur.
        private OleDbDataReader bilgiokut;//veri tabanı bilgiokut değişkenini oluşturur.
        //class ilk çağrıldığı yerde veri tabanı bağlantı değişkenine adresi yollar.
        public AccessCustomerManager() 
            {
                   baglanti =new  OleDbConnection(ConnectionString);
            }
        //veri tabanının tabload tablosunun sutunad sütununa value değerini ekler 
        public void Add(string value, string sutunad, string tabload)
        {
            baglanti.Open();

            komut = new OleDbCommand(string.Format(@"insert into {0} ({1}) values ('" + value + "')", tabload, sutunad), baglanti);
            komut.ExecuteNonQuery();

            baglanti.Close();
        }
        //veri tabanının tabload tablosunun şartsutunad sütunu sartdeger sütununa eşitse sutunad sütununa value değerini güncele
        public void Update(string tabload, string sutunad, string value, string sartdeger, string sartsutunad)
        {
            baglanti.Open();
            komut = new OleDbCommand(string.Format(@"Update {0} set {1}='" + value + "' Where {2}='" + sartdeger + "'", tabload, sutunad, sartsutunad), baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //veri tabanının tabload tablosunun sutunad sütununa value değerini siler
        public void Delete(int value, string sutunad, string tabload)
        {
            baglanti.Open();
            komut = new OleDbCommand(string.Format(@"DELETE FROM {0} Where {1}=" + value + "", tabload, sutunad), baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //veri tabanının tabload tablosunun şart sütunun değeri value ya eşitse sutunad sütunundaki değeri alır.
        public string tekselect(string value, string sart, string sutunad, string tabload)
        {
            baglanti.Open();
            komut = new OleDbCommand(string.Format("SELECT {0} FROM {1} Where {2}='" + value + "'", sutunad, tabload, sart), baglanti); // çekme kodu
            string tut= "Null";
            bilgiokut = komut.ExecuteReader();
                while (bilgiokut.Read())
                {
                    tut = bilgiokut[sutunad].ToString();
                }
            baglanti.Close();
            return tut;
        }
        //veri tabanının tabload tablosunun şart sütunun değeri value ya eşitse sutunad sütunundaki değerleri alır.
        public List<string> select(string value, string sart, string sutunad, string tabload)
        {
            baglanti.Open();
            komut = new OleDbCommand(string.Format("SELECT {0} FROM {1} Where {2}='" + value + "'", sutunad, tabload, sart), baglanti); // çekme kodu
            List<string> tut = new List<string>();
            bilgiokut = komut.ExecuteReader();
            while (bilgiokut.Read())
            {
                tut.Add(bilgiokut[sutunad].ToString());
            }
            baglanti.Close();
            return tut;
        }
    }
}
