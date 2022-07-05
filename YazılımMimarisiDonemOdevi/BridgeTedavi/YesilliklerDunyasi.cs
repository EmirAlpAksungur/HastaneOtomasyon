using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiDonemOdevi.Bridge;

namespace YazılımMimarisiDonemOdevi.BridgeTedavi
{
    class YesilliklerDunyasi : Implementortedavi
    {
        //implementortedaviyi miras alıp list öğünler türünde denizUrunleri diyetinin özelliklerini barındırır.
        public override List<Ogunler> diyeticerikolustur()
        {
            //haftalık diyet bilgisi doldurulur.
            Pazartesi.kahvalti = "Haşlanmış yumurta (1 adet), Kızarmış kepek ekmeği (2 dilim), Maydanoz (8 adet), Yağsız beyaz peynir (2 dilim), Domates (1 adet), Salatalık (1 adet).";
            Pazartesi.oglen = "Yağsız yoğurt (1 kase), Ceviz (3 adet), Yeşil elma (1 adet), Zencefilli ve tarçınlı, şekersiz az yağlı süt (1 bardak).";
            Pazartesi.araogun1 = "Yok";
            Pazartesi.aksam = "Izgara balık (1 porsiyon), Zeytinyağlı taze fasulye (1 tabak), Söğüş yeşillik (1 kase).";
            Pazartesi.araogun2 = "Yok";
            hafta.Add(Pazartesi);
            Salı.kahvalti = " Sade müsli (5 kaşık), Tarçınlı az yağlı yoğurt ( 1 kase), Fındık (6 adet).";
            Salı.oglen = "Sebze çorbası (1 kase), Tavuk göğsü ızgara (Yarım porsiyon).";
            Salı.araogun1 = " Yeşil elma (1 adet).";
            Salı.aksam = "Az acılı bulgur pilavı (Yarım tabak), Kimyonlu ve bol kırmızı biberli nohut (Yarım tabak), Sivri biber (2 adet), Söğüş yeşillik (1 kase).";
            Salı.araogun2 = "Kivi (2 adet), Yağsız az tuzlu peynir (2 dilim).";
            hafta.Add(Salı);
            Carsamba.kahvalti = "Çavdar ekmeği ile hazırlanmış kaşarlı yağsız tost.";
            Carsamba.oglen = "Mercimek çorbası (1 kase), Izgara köfte (4 adet), Sivri biber (2 adet), Yulaf ezmesi, tarçın ve zencefil ile birlikte yağsız yoğurt (1 kase), Ceviz (2 adet).";
            Carsamba.araogun1 = "Salatalık (2 adet).";
            Carsamba.aksam = "Esmer makarna (Yarım tabak), Soğanlı ve sarımsaklı ıspanak kavurma (Yarım tabak).";
            Carsamba.araogun2 = "Kabak çekirdeği (1 avuç).";
            hafta.Add(Carsamba);
            Persembe.kahvalti = "Sade müsli (3 kaşık), Yulaf ezmesi (2 kaşık), Yağsız süt (1 bardak), Tarçın (Yarım tatlı kaşığı), Zencefil (Yarım tatlı kaşığı), Ceviz (3 adet).";
            Persembe.oglen = "Sebze çorbası (1 kase), Yumurta beyazı (3 adet), Maydanoz ve sivri biberli yağsız omlet (1 yumurta sarısı ile), Söğüş roka (1 kase).";
            Persembe.araogun1 = "Ananas (3 dilim)";
            Persembe.aksam = "Kırmızı biberli yeşil mercimek yemeği (1 tabak), Kızarmış çavdar ekmeği (1 dilim).";
            Persembe.araogun2 = "Elma kurusu (1 avuç), Tuzsuz sarı leblebi (1 avuç).";
            hafta.Add(Persembe);
            Cuma.kahvalti = "Muz (1 adet), Greyfurt (1 adet), Ceviz (3 adet).";
            Cuma.oglen = "Tavuk şiş (1 porsiyon), Izgara sebze (1 porsiyon).";
            Cuma.araogun1 = "Yağsız ayran (1 bardak), Mürdüm eriği (6 adet).";
            Cuma.aksam = "Bulgur pilavı (Yarım tabak), Brokoli (1 tabak).";
            Cuma.araogun2 = "Tuzsuz sarı leblebi (1 avuç), Yeşil elma (1 adet).";
            hafta.Add(Cuma);
            Cumartesi.kahvalti = "Çavdar ekmeği ile hazırlanmış kaşarlı yağsız tost.";
            Cumartesi.oglen = "Mercimek çorbası (1 kase), Izgara köfte (4 adet), Sivri biber (2 adet).";
            Cumartesi.araogun1 = "Badem (6 adet).";
            Cumartesi.aksam = "Az acılı bulgur pilavı (Yarım tabak), Kimyonlu ve bol kırmızı biberli nohut (Yarım tabak), Sivri biber (2 adet), Söğüş yeşillik (1 kase).";
            Cumartesi.araogun2 = "Yeşil elma (1 adet).";
            hafta.Add(Cumartesi);
            Pazar.kahvalti = "Tam buğday ekmeği (2 dilim), Haşlanmış yumurta (1 adet), Maydanoz (8 adet), Yağsız beyaz peynir (2 dilim), Salatalık (1 adet), Zeytin (8 adet).";
            Pazar.oglen = "Yok";
            Pazar.araogun1 = "Salatalık (1 adet), Yeşil elma (1 adet).";
            Pazar.aksam = "Ispanak çorbası (1 kase), Izgara köfte (4 adet), Közlenmiş patlıcan ve sivri biber Söğüş yeşillik (1 kase).";
            Pazar.araogun2 = "Siyah üzüm (1 avuç).";
            hafta.Add(Pazar);
            return hafta;
        }
    }
}
