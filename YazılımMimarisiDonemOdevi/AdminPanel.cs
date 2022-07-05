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

namespace YazılımMimarisiDonemOdevi
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        //diyetisyen kaydeden buton
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //kullanıcağımız veri tabanının tanımlaması yapılır.
            CustomerManager veritabani = new CustomerManager(new AccessCustomerManager());
            if (textBoxAd.Text == "" || textBoxSad.Text == "" || maskedTextBoxTC.Text == "" || maskedTextBoxTelno.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Lütfen Tüm alanları doldurunuz");
            }
            //girilen tc tek mi diye kontol edilir.
            else if(veritabani.tekselect(maskedTextBoxTC.Text,"TC","TC", "Diyetisyenler")=="Null")
            {
                //girilen tcyi girilen tablonun girilen sütununa ekler 
                veritabani.Add(maskedTextBoxTC.Text, "TC", "Diyetisyenler");
                //veri tabanına eklenen tcyi kullanarak diğer bilgileri doldurur.
                veritabani.Update("Diyetisyenler", "Ad", textBoxAd.Text, maskedTextBoxTC.Text, "TC");
                veritabani.Update("Diyetisyenler", "Soyad", textBoxSad.Text, maskedTextBoxTC.Text, "TC");
                veritabani.Update("Diyetisyenler", "TelefonNo", maskedTextBoxTelno.Text, maskedTextBoxTC.Text, "TC");
                veritabani.Update("Diyetisyenler", "Sifre", textBoxSifre.Text, maskedTextBoxTC.Text, "TC");
                veritabani.Update("Diyetisyenler", "KullanıcıTürü","Diyetisyen", maskedTextBoxTC.Text, "TC");
            }
            else
            {
                MessageBox.Show("veri tabanında var");
            } 
        }
        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            girisEkranı giris = new girisEkranı();
            giris.Show();
            this.Hide();
        }
    }
}
