using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiDonemOdevi.BridgeTedavi;

namespace YazılımMimarisiDonemOdevi.Bridge
{
    public class glutenFree : Implementortedavi
    {
        //implementortedaviyi miras alıp list öğünler türünde denizUrunleri diyetinin özelliklerini barındırır.
        public override List<Ogunler> diyeticerikolustur()
        {
            //haftalık diyet bilgisi doldurulur.
            Pazartesi.gun = "Pazartesi";
            Pazartesi.kahvalti = "Glutensiz ekmek, çiğ sebze (buharda yapılabilir), beyaz peynir, 2 tane kuru erik.";
            Pazartesi.oglen= " Izgara balık, rokalı salata, mısır ekmeği.";
            Pazartesi.araogun1 = "YOK";
            Pazartesi.araogun2 = "YOK";
            Pazartesi.aksam = "Tavuk sote, pirinçli yayla çorbası, mevsim salatası.";
            hafta.Add(Pazartesi);
            Salı.gun = "Salı";
            Salı.kahvalti = "Glutensiz kahvaltılık gevrek, 2 ceviz, 10 adet yaban mersini, yarım yağlı süt.";
            Salı.oglen = " Unsuz mantarlı omlet, glutensiz ekmek, domates, salatalık.";
            Salı.aksam = "Zeytinyağlı pırasa, mısır ekmeği, yoğurt.";
            Salı.araogun1 = "YOK";
            Salı.araogun2 = "YOK";
            hafta.Add(Salı);
            Carsamba.gun = "Carsamba";
            Carsamba.kahvalti = "Glutensiz ekmek, 2 ceviz, yarım yağlı peynir, çiğ sebze.";
            Carsamba.oglen = "Çoban salatası, zeytinyağlı kuru fasulye, glutensiz ekmek";
            Carsamba.aksam = "Fırında balık, pirinçli ezogelin çorba, yeşil salata.";
            Carsamba.araogun1 = "YOK";
            Carsamba.araogun2 = "YOK";
            hafta.Add(Carsamba);
            Persembe.gun = "Persembe";
            Persembe.kahvalti = "Maydanozlu lor peyniri, zeytin, çiğ sebze, glutensiz ekmek.";
            Persembe.oglen = "Yeşillik salatası, köfte (malzemesi ekmeksiz), pirinç pilavı.";
            Persembe.aksam = "Haşlama sebze, kıymalı mercimek yemeği, glutensiz ekmek.";
            Persembe.araogun1 = "YOK";
            Persembe.araogun2 = "YOK";
            hafta.Add(Persembe);
            Cuma.gun = "Cuma";
            Cuma.kahvalti = "Taze sebze, mısır ekmeği, yarım yağlı kaşar, 1 kaşık reçel.";
            Cuma.oglen = "Sebzeli fırında hindi, unsuz mercimek çorbası, mevsim salatası.";
            Cuma.aksam = "Ispanak yemeği, dereotlu cacık, glutensiz ekmek.";
            Cuma.araogun1 = "YOK";
            Cuma.araogun2 = "YOK";
            hafta.Add(Cuma);
            Cumartesi.gun = "Cumartesi";
            Cumartesi.kahvalti = "1 elma, mısır ekmeği, taze sebze, 1 yumurta.";
            Cumartesi.oglen = " Zeytinyağlı kabak, domates çorbası, yoğurt, domates, salatalık.";
            Cumartesi.aksam = "Tavuklu sebze sote, ayran.";
            Cumartesi.araogun1 = "YOK";
            Cumartesi.araogun2 = "YOK";
            hafta.Add(Cumartesi);
            Pazar.gun = "Pazar";
            Pazar.kahvalti = " Peynirli omlet, taze sebze, 2 ceviz.";
            Pazar.oglen = "Bonfile ızgara, közlenmiş kırmızıbiber, mısır ekmeği";
            Pazar.aksam = "Ton balıklı salata, domates çorbası, 2 ceviz.";
            Pazar.araogun1 = "YOK";
            Pazar.araogun2 = "YOK";
            hafta.Add(Pazar);
            return hafta;
        }
    }
}
