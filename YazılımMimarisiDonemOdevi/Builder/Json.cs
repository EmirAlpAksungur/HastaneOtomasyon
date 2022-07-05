using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YazılımMimarisiDonemOdevi.BridgeTedavi;
namespace YazılımMimarisiDonemOdevi.Builder
{
    public class Json : AnaRaporOlustur
    {
        //constructer classı çağırırken report info türünde veri almaya yarar
        public Json(ReportInfo reporInfo) : base(reporInfo){}
        //anaraporoluştur classındaki metodu ezip hasta bilgilerinin rapor türüne göre içeriğini oluşturur.
        public override string BuildHasta()
        {
            string jsoncover = JsonConvert.SerializeObject(base.info.Hasta, Formatting.Indented)+"\n";
            return jsoncover;
        }
        //anaraporoluştur classındaki metodu ezip diyet bilgilerinin rapor türüne göre içeriğini oluşturur.
        public override string BuildDiyet()
        {
            string jsoncover = JsonConvert.SerializeObject(base.info.Diyet, Formatting.Indented);
            return jsoncover;
        }
    }
}
