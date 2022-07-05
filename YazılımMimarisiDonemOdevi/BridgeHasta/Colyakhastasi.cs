using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiDonemOdevi.Bridge;

namespace YazılımMimarisiDonemOdevi.BridgeHasta
{
    class colyakhastasi : Implementorhasta
    {
        //implementorhastayı miras alıp colyak hastasının özelliklerini barındırır
        public override string hastaolustur()
        {
            string s = "Hasta colyak hastası";
            return s;
        }
    }
}
