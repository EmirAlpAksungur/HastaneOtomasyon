using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiDonemOdevi.Bridge
{
    public class sekerhastasi : Implementorhasta
    {
        //implementorhastayı miras alıp şeker hastasının özelliklerini barındırır
        public override string hastaolustur()
        {
            string s = "Hasta sekerhastasi";
            return s;
        }
    }
}
