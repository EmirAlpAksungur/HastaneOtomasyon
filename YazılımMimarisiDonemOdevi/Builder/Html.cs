using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YazılımMimarisiDonemOdevi.BridgeTedavi;
namespace YazılımMimarisiDonemOdevi.Builder
{
    public class Html : AnaRaporOlustur
    {
        //constructer classı çağırırken report info türünde veri almaya yarar
        public Html(ReportInfo reporInfo) : base(reporInfo){}
        //anaraporoluştur classındaki metodu ezip hasta bilgilerinin rapor türüne göre içeriğini oluşturur.
        public override string BuildHasta()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var bol in base.info.Hasta)
            {
                sb.Append(string.Format("<div class='contentItem'>{0} <br </div>",bol));
            }
            return sb.ToString();
        }
        //anaraporoluştur classındaki metodu ezip diyet bilgilerinin rapor türüne göre içeriğini oluşturur.
        public override string BuildDiyet()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (var bol in base.info.Diyet)
            {
                sb.Append(string.Format("<div class='contentItem'>{0} <br </div>", "<br> GÜN: " + base.info.Diyet[i].gun + " <br> Kahvaltı:  " + base.info.Diyet[i].kahvalti + " <br> Ara Öğün:  " + base.info.Diyet[i].araogun1 + " <br> Öğlen:  " + base.info.Diyet[i].oglen + " <br> Ara Öğün:  " + base.info.Diyet[i].araogun2 + " <br> Akşam:  " + base.info.Diyet[i].aksam));
                i++;
            }
            return sb.ToString();
        }
    }
}
