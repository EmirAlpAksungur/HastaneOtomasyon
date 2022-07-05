using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiDonemOdevi.Builder
{
    //raporları soyutlamak için kullanılan class
    public abstract class AnaRaporOlustur
    {
        //reportinfo türünde bir değişken oluşturur.
        protected ReportInfo info;
        //constructerında reportinfo türünde bir değişken alarak kendi oluşturduğuinfo değişkenine eşitler.
        public AnaRaporOlustur(ReportInfo reporInfo)
        {
            info = reporInfo;
        }
        //hastalık ve diyetin oluşacağı raporu tek parça haline getirir.
        public string BuildOut()
        {
            string output = BuildHasta();
            output += BuildDiyet();
            return output;
        }
        //miras alan klasın ezeceği fonksiyonlar
        public abstract string BuildHasta();
        public abstract string BuildDiyet();
    }
}
