using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazılımMimarisiDonemOdevi.DAL;
using YazılımMimarisiDonemOdevi.BridgeHasta;
using YazılımMimarisiDonemOdevi.Bridge;
namespace YazılımMimarisiDonemOdevi
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        //girilen bilgileri veri tabanına kaydeder.
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            CustomerManager veritabani = new CustomerManager(new AccessCustomerManager());
            if (textBoxAd.Text == "" || textBoxSad.Text == "" || maskedTextBoxTc.Text == "" || maskedTextBoxtelno.Text == "" || textBoxboy.Text == "" || textBoxkilo.Text == "" || textBoxyas.Text == "" || comboBoxCinsiyet.Text == "Lutfen Cinsiyet Seciniz" || comboBoxDiyetTuru.Text == "Lutfen Diyet Seciniz" || comboBoxHastalik.Text == "Lutfen Hastalik Seciniz")
            {
                MessageBox.Show("Lütfen Tün alanları doldurunuz");
            }
            else if (veritabani.tekselect(maskedTextBoxTc.Text, "TC", "TC", "Diyetisyenler") == "Null" && (veritabani.tekselect(maskedTextBoxTc.Text, "TC", "TC", "Hastalar") == "Null"))
            {
                HastaBilgileri hasta = new HastaBilgileri();
                arayüzhasta hastalik = new arkaplanhasta();
                hasta.ad = textBoxAd.Text;
                hasta.soyad = textBoxSad.Text;
                hasta.tc = maskedTextBoxTc.Text;
                hasta.cinsiyet = comboBoxCinsiyet.Text;
                hasta.boy = textBoxboy.Text;
                hasta.kilo = textBoxkilo.Text;
                hasta.yas = textBoxyas.Text;
                hasta.telno = maskedTextBoxtelno.Text;
                if (comboBoxHastalik.Text == "Colyak")
                {
                    hastalik.builderhasta = new colyakhastasi();
                    hasta.hastalık = hastalik.hastaolustur();
                }
                else if (comboBoxHastalik.Text == "Obez")
                {
                    hastalik.builderhasta = new colyakhastasi();
                    hasta.hastalık = hastalik.hastaolustur();
                }
                else if (comboBoxHastalik.Text == "Seker")
                {
                    hastalik.builderhasta = new colyakhastasi();
                    hasta.hastalık = hastalik.hastaolustur();
                }
                else
                {
                    hasta.hastalık = "Hasta Sağlam";
                }       
                hasta.diyet = comboBoxDiyetTuru.Text;
                veritabani.Add(hasta.tc, "TC", "Hastalar");
                veritabani.Update("Hastalar", "Ad", hasta.ad, hasta.tc, "TC");
                veritabani.Update("Hastalar", "Soyad", hasta.soyad, hasta.tc, "TC");
                veritabani.Update("Hastalar", "Cinsiyet", hasta.cinsiyet, hasta.tc, "TC");
                veritabani.Update("Hastalar", "Boy", hasta.boy, hasta.tc, "TC");
                veritabani.Update("Hastalar", "Kilo", hasta.kilo, hasta.tc, "TC");
                veritabani.Update("Hastalar", "Yas", hasta.yas, hasta.tc, "TC");
                veritabani.Update("Hastalar", "TelefonNo", hasta.telno, hasta.tc, "TC");
                veritabani.Update("Hastalar", "Hastalik", hasta.hastalık, hasta.tc, "TC");
                veritabani.Update("Hastalar", "Diyet", hasta.diyet, hasta.tc, "TC");
            }
            else
            {
                MessageBox.Show("veri tabanında var");
            }
        }
        //form yüklendiğinde yapılacaklar.
        private void HastaKayit_Load(object sender, EventArgs e)
        {
            comboBoxCinsiyet.Text = "Lutfen Cinsiyet Seciniz";
            comboBoxDiyetTuru.Text = "Lutfen Diyet Seciniz";
            comboBoxHastalik.Text = "Lutfen Hastalık Seciniz";
            textBoxyas.MaxLength = 3;
        }
        //önceki forma geri döner.
        private void buttonGeriDön_Click(object sender, EventArgs e)
        {
            AraPanel araPanel = new AraPanel();
            araPanel.Show();
            this.Hide();
        }
    }
}
