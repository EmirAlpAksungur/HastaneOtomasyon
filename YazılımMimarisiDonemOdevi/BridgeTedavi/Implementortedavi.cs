using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiDonemOdevi.BridgeTedavi;

namespace YazılımMimarisiDonemOdevi.Bridge
{
    public  abstract class  Implementortedavi
    {
        //Tüm içeriğin barınacağı liste.
        protected List<Ogunler> hafta = new List<Ogunler>();
        //Haftanın günlerinin öğünlerini tutacak listeler.
        protected Ogunler Pazartesi = new Ogunler();
        protected Ogunler Salı = new Ogunler();
        protected Ogunler Carsamba = new Ogunler();
        protected Ogunler Persembe = new Ogunler();
        protected Ogunler Cuma = new Ogunler();
        protected Ogunler Cumartesi = new Ogunler();
        protected Ogunler Pazar = new Ogunler();
        public abstract List<Ogunler> diyeticerikolustur();
    }
}
