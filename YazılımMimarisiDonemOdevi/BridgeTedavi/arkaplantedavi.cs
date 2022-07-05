using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiDonemOdevi.BridgeTedavi;

namespace YazılımMimarisiDonemOdevi.Bridge
{
    public class Arkaplantedavi : arayüztedavi
    {
        //arayüztedavinin metodunu ezip işlem yapan fonksiyon.
        public override List<Ogunler> builderfonk()
        {
            List<Ogunler> hafta = new List<Ogunler>();
            hafta=builder.diyeticerikolustur();
            return hafta;
        }
    }
}
