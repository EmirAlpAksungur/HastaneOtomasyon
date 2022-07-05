using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiDonemOdevi.Builder
{
    //raporun oluştuğu class 
    public class ReportManager
    {
        private AnaRaporOlustur builder;
        //constructer çağrılırken ana rapor oluştur türünde veri istemesini sağlar
        public ReportManager(AnaRaporOlustur builder)
        {
            this.builder = builder;
        }
        //raporu oluşturur
        public string build()
        {
            string product = builder.BuildOut();
            return product;
        }
        //raporu tersten oluşturur
        public string BuildUpsideDown()
        {
            string product = builder.BuildDiyet();
            product += builder.BuildHasta();
            return product;
        }
    }
}
