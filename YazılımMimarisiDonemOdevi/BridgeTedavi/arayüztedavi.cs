using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiDonemOdevi.BridgeTedavi;

namespace YazılımMimarisiDonemOdevi.Bridge
{
    public abstract class arayüztedavi
    {
        //implementortedavi classından bir değişken oluşturur.
        public Implementortedavi builder;
        //Diyet türünü oluşturacak ve listogünler türünde döndürecek olan fonksiyon
        public abstract List<Ogunler> builderfonk();
    }
}
