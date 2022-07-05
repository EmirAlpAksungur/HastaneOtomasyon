using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiDonemOdevi.Bridge
{
  public abstract class arayüzhasta
    {
        //implementorhasta türünde değişken oluşturur
        public Implementorhasta builderhasta;
        public abstract string hastaolustur();
    }
}
