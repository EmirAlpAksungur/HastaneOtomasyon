using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiDonemOdevi.Bridge
{
   public class arkaplanhasta : arayüzhasta
   {
        //arayüzdeki fonksiyonu ezip hastayı oluşturur.
        public override string hastaolustur()
        {
            string s = "";
            s=builderhasta.hastaolustur();
            return s;
        }
   }
}
