using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiDonemOdevi.Bridge;

namespace YazılımMimarisiDonemOdevi.BridgeTedavi
{
    class akdeniz : Implementortedavi
    {
        //implementortedaviyi miras alıp list öğünler türünde akdeniz diyetinin özelliklerini barındırır.
        public override List<Ogunler> diyeticerikolustur()
        {
            //haftalık diyet bilgisi doldurulur.
            Pazartesi.kahvalti = "1 adet yumurta , 1 dilim az yağlı beyaz peynir , kepekli ekmek , domates, salatalık,";
            Pazartesi.oglen = "Ton balıklı bol yeşillikli salata , 1 dilim kepekli ekmek,";
            Pazartesi.araogun1 = "Yarım yağlı süt , Badem,";
            Pazartesi.aksam = "Zeytinyağlı sebze yemeği , yarım yağlı yoğurt , salata,";
            Pazartesi.araogun2 = "Meyve,";
            hafta.Add(Pazartesi);
            Salı.kahvalti = " 2 dilim beyaz peynir , Zeytin , Kepek ekmeği , Domates, salatalık, yeşillik,";
            Salı.oglen = " Fırında ızgara sebze , Makarna , Ayran,";
            Salı.araogun1 = "Meyve , fındık,";
            Salı.aksam = "Zeytinyağlı bakliyat yemeği , yarım yağlı yoğurt , salata,";
            Salı.araogun2 = "Yarım yağlı süt , meyve,";
            hafta.Add(Salı);
            Carsamba.kahvalti = "Yarım yağlı yoğurt , 3 kaşık yulaf ezmesi , meyve,";
            Carsamba.oglen = "Peynirli, avokadolu salata , kepekli ekmek , ayran,";
            Carsamba.araogun1 = "Yarım yağlı süt , ceviz,";
            Carsamba.aksam = " Izgara balık , bol yeşillikli salata,";
            Carsamba.araogun2 = "Meyve.";
            hafta.Add(Carsamba);
            Persembe.kahvalti = "Peynirli omlet , zeytin , kepek ekmeği ,  Yeşillik,";
            Persembe.oglen = "Zeytinyağlı bakliyat yemeği , Yarım yağlı yoğurt , Salata,";
            Persembe.araogun1 = "Meyve , badem,";
            Persembe.aksam = "Zeytinyağlı sebze yemeği , Bulgur pilavı , Ayran,";
            Persembe.araogun2 = " Yarım yağlı yoğurt , ceviz,";
            hafta.Add(Persembe);
            Cuma.kahvalti = "Lor peyniri , Ceviz , Kepek ekmeği , Domates, salatalık,";
            Cuma.oglen = "Haşlanmış mercimekli salata , ayran,";
            Cuma.araogun1 = "1 kase yoğurt , Meyve,";
            Cuma.aksam = "Zeytinyağlı sebze yemeği , salata , kepek ekmeği,";
            Cuma.araogun2 = "Meyve,";
            hafta.Add(Cuma);
            Cumartesi.kahvalti = "Yarım yağlı süt , Fındık , 2 yemek kaşığı yulaf ezmesi , Meyve,";
            Cumartesi.oglen = "Sebzeli makarna , ayran , salata,";
            Cumartesi.araogun1 = "Meyve , ceviz,";
            Cumartesi.aksam = "Izgara Tavuk , Yarım yağlı yoğurt , Haşlama sebze,";
            Cumartesi.araogun2 = "Yarım yağlı süt , meyve,";
            hafta.Add(Cumartesi);
            Pazar.kahvalti = "Menemen , Yarım yağlı beyaz peynir , Kepek ekmeği , yeşillik,";
            Pazar.oglen = "Tam tahıl ekmeğine yapılmış sandviç , ayran,";
            Pazar.araogun1 = "Meyve , badem,";
            Pazar.aksam = "Çorba , Zeytinyağlı bakliyat yemeği , Salata,";
            Pazar.araogun2 = "Yarım yağlı süt,";
            hafta.Add(Pazar);
            return hafta;
        }
    }
}
