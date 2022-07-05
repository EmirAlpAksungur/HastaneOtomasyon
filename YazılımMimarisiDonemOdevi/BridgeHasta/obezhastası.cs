using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiDonemOdevi.Bridge
{
     class obezhastasi : Implementorhasta
     {
        //implementorhastayı miras alıp obez hastasının özelliklerini barındırır
        public override string hastaolustur()
        {
            string s =  "Hasta obez";
            return s;
        }
     }
}
