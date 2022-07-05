using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazılımMimarisiDonemOdevi.BridgeTedavi;

namespace YazılımMimarisiDonemOdevi.Bridge
{
     class denizUrunleri : Implementortedavi
     {
        //implementortedaviyi miras alıp list öğünler türünde denizUrunleri diyetinin özelliklerini barındırır.
        public override List<Ogunler> diyeticerikolustur()
        {
            //haftalık diyet bilgisi doldurulur.
            Pazartesi.kahvalti = "1 çay kaşığı ekleyebileceğiniz bir bardak ılık az yağlı süt ile kurutulmuş kruton. bal.";
            Pazartesi.oglen = "haşlanmış fasulye; birkaç damla bitkisel yağ ile domates, dolmalık biber, yeşil soğan ve maydanoz salatası; Portakal or elma.";
            Pazartesi.aksam = " Beyaz lahana taze sıkılmış serpilir limon Meyve suyu; bir elma.";
            Pazartesi.araogun1 = "YOK";
            Pazartesi.araogun2 = "YOK";
            hafta.Add(Pazartesi);
            Salı.kahvalti = "büyük bir portakal veya birkaç elma; bal ve limon suyu ile bir bardak ılık su.";
            Salı.oglen = "bir parça haşlanmış balık filetosu; meyve salatası ve az yağlı süzme peynir.";
            Salı.aksam = " kabak bitkisel yağ ile suda haşlanmış; bir bardak taze sıkılmış domates Meyve suyu.";
            Salı.araogun1 = "YOK";
            Salı.araogun2 = "YOK";
            hafta.Add(Salı);
            Carsamba.kahvalti =" birkaç kuru ekmek ve bir bardak yoğurt.";
            Carsamba.oglen = "Yunan salatası ve haşlanmış yeşil fasulye.";
            Carsamba.aksam = "pancar salatası ve domates dilimleri; Bir bardak domates suyu; 2 küçük elma.";
            Carsamba.araogun1 = "YOK";
            Carsamba.araogun2 = "YOK";
            hafta.Add(Carsamba);
            Persembe.kahvalti = "bir tam tahıllı çörek ve bir bardak süt.";
            Persembe.oglen = "pişmiş veya haşlanmış balık; Yunan salatası; 200 ml elma suyu.";
            Persembe.aksam = "haşlanmış yeşil fasulye salatası, sarımsak, zeytin veya diğer bitkisel yağlarla terbiye edilebilen çiğ havuç.";
            Persembe.araogun1 = "YOK";
            Persembe.araogun2 = "YOK";
            hafta.Add(Persembe);
            Cuma.kahvalti = " kruton ve bir bardak ballı ısıtılmış süt.";
            Cuma.oglen = "elma salatası ve doğranmış beyaz lahana; bir bardak boş yoğurt ";
            Cuma.aksam = " haşlanmış patlican ve havuç";
            Cuma.araogun1 = "YOK";
            Cuma.araogun2 = "YOK";
            hafta.Add(Cuma);
            Cumartesi.kahvalti = "büyük bir portakal veya 3-4 mandalina; Elma suyu.";
            Cumartesi.oglen = "bir porsiyon Yunan salatası; 2 yemek kaşığı. l. az miktarda bitkisel yağ ile terbiye edilmiş haşlanmış veya çiğ biçimde rendelenmiş havuçlar.";
            Cumartesi.aksam = "bir dilim minimum yağlı peynir; bir avuç çilek; 30 gr fındık; bir bardak doğal yoğurt.";
            Cumartesi.araogun1 = "YOK";
            Cumartesi.araogun2 = "YOK";
            hafta.Add(Cumartesi);
            Pazar.kahvalti = " 1-2 kızarmış ekmek; bir bardak az yağlı yoğurt veya kefir.";
            Pazar.oglen = "haşlanmış balık filetosu; beyaz lahana ve yeşillik salatası.";
            Pazar.aksam = "bitkisel yağ ile hafifçe tatlandırılmış haşlanmış fasulye; bir dilim peynir ve bir armut ve elma salatası.";
            Pazar.araogun1 = "YOK";
            Pazar.araogun2 = "YOK";
            hafta.Add(Pazar);
            return hafta;
        }
     }
}
