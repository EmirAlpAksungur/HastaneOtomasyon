using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YazılımMimarisiDonemOdevi.Bridge;
using YazılımMimarisiDonemOdevi.BridgeHasta;
using YazılımMimarisiDonemOdevi.BridgeTedavi;
using YazılımMimarisiDonemOdevi.Builder;

using Newtonsoft.Json;
using System.Web;
using System.IO;
using YazılımMimarisiDonemOdevi.DAL;

namespace YazılımMimarisiDonemOdevi
{
    public partial class girisEkranı : Form
    {
        public girisEkranı()
        {
            InitializeComponent();
        }
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            CustomerManager veritabanı = new CustomerManager(new AccessCustomerManager());
            //tc ve şifre kontol edilir.
            if (veritabanı.tekselect(textBoxTC.Text,"TC","Sifre","Diyetisyenler")==textBoxSifre.Text)
            {
                //rol kontrolü yapılır
                if(veritabanı.tekselect(textBoxTC.Text, "TC", "KullanıcıTürü", "Diyetisyenler")=="Admin")
                {
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    AraPanel araPanel = new AraPanel();
                    araPanel.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Bulunamadı");
            }
        }
    }
}
