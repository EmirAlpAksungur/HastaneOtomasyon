using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using YazılımMimarisiDonemOdevi.Bridge;
using YazılımMimarisiDonemOdevi.BridgeTedavi;
using YazılımMimarisiDonemOdevi.DAL;
using Newtonsoft.Json;
using YazılımMimarisiDonemOdevi.Builder;
using System.IO;

namespace YazılımMimarisiDonemOdevi
{
    public partial class DiyetProgramDegistir : Form
    {
        public DiyetProgramDegistir()
        {
            InitializeComponent();
        }
        //Hastanın aktif kullandığı diyetin yazılacağı listviewin sütunlarını oluşturur.
        void listhastadiyet()
        {
            listViewHastaDiyet.Columns.Clear();
            listViewHastaDiyet.Items.Clear();
            listViewHastaDiyet.View = View.Details;

            listViewHastaDiyet.Columns.Add("Öğün", 70, HorizontalAlignment.Left);
            listViewHastaDiyet.Columns.Add("Pazartesi", 300, HorizontalAlignment.Left);
            listViewHastaDiyet.Columns.Add("Salı", 300, HorizontalAlignment.Left);
            listViewHastaDiyet.Columns.Add("Carsamba", 300, HorizontalAlignment.Left);
            listViewHastaDiyet.Columns.Add("Persembe", 300, HorizontalAlignment.Left);
            listViewHastaDiyet.Columns.Add("Cuma", 300, HorizontalAlignment.Left);
            listViewHastaDiyet.Columns.Add("Cumartesi", 300, HorizontalAlignment.Left);
            listViewHastaDiyet.Columns.Add("Pazar", 300, HorizontalAlignment.Left);

            listViewHastaDiyet.Items.Add("Kahvaltı");
            listViewHastaDiyet.Items.Add("Ara Öğün");
            listViewHastaDiyet.Items.Add("Öglen");
            listViewHastaDiyet.Items.Add("Ara Öğün");
            listViewHastaDiyet.Items.Add("Aksam");
        }
        //Seçilen diyetin yazılacağı listviewin sütunlarını oluşturur.
        void listdiyet()
        {
            listViewDiyet.Columns.Clear();
            listViewDiyet.Items.Clear();
            listViewDiyet.View = View.Details;

            listViewDiyet.Columns.Add("Öğün", 70, HorizontalAlignment.Left);
            listViewDiyet.Columns.Add("Pazartesi", 300, HorizontalAlignment.Left);
            listViewDiyet.Columns.Add("Salı", 300, HorizontalAlignment.Left);
            listViewDiyet.Columns.Add("Carsamba", 300, HorizontalAlignment.Left);
            listViewDiyet.Columns.Add("Persembe", 300, HorizontalAlignment.Left);
            listViewDiyet.Columns.Add("Cuma", 300, HorizontalAlignment.Left);
            listViewDiyet.Columns.Add("Cumartesi", 300, HorizontalAlignment.Left);
            listViewDiyet.Columns.Add("Pazar", 300, HorizontalAlignment.Left);

            listViewDiyet.Items.Add("Kahvaltı");
            listViewDiyet.Items.Add("Ara Öğün");
            listViewDiyet.Items.Add("Öglen");
            listViewDiyet.Items.Add("Ara Öğün");
            listViewDiyet.Items.Add("Aksam");
        }
        //Hasta bilgilerinin yazılacağı listviewin sütunlarını oluşturur.
        void listhasta()
        {
            listViewHasta.Columns.Clear();
            listViewHasta.Items.Clear();
            listViewHasta.View = View.Details;
            listViewHasta.Columns.Add("TC", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Ad", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Soyad", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Telefon No", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Cinsiyet", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Boy", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Kilo", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Yas", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Hastalik", 70, HorizontalAlignment.Left);
            listViewHasta.Columns.Add("Diyet", 70, HorizontalAlignment.Left);
        }
        //form yüklendiğinde yapılacak işlemler
        private void DiyetProgramDegistir_Load(object sender, EventArgs e)
        {
            comboBoxHasta.Text = "Lütfen Hastalık Türünü Seçiniz";
            comboBoxDiyetList.Text = "Lütfen Diyet Türü Seçiniz";
        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
            listhasta();
            listViewHasta.Items.Clear();
            CustomerManager veritabanı = new CustomerManager(new AccessCustomerManager());
            string TC;//kullanıcının girdiği tc kimlik numarasını veri tabanında arar
            TC = veritabanı.tekselect(textBoxAraHastaTc.Text, "TC", "TC", "Hastalar");
            if(TC=="Null")//eğer yoksa 
            {
                MessageBox.Show("Aradığınız Tc bulanamadı");
            }
            else//varsa listeler
            {
                listViewHasta.Items.Add(TC);
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "Ad", "Hastalar"));
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "Soyad", "Hastalar"));
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "TelefonNo", "Hastalar"));
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "Cinsiyet", "Hastalar"));
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "Boy", "Hastalar"));
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "Kilo", "Hastalar"));
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "Yas", "Hastalar"));
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "Hastalik", "Hastalar"));
                listViewHasta.Items[0].SubItems.Add(veritabanı.tekselect(TC, "TC", "Diyet", "Hastalar"));
            }
        }
        //kullanıcnın seçtiği diyet türüne göre bridgetedaviden diyet oluşturur.
        List<Ogunler> DiyetTurAktarma(string text)
        {
            List<Ogunler> haftalikdiyetlistesi = new List<Ogunler>();
            arayüztedavi tedavi = new Arkaplantedavi();
            haftalikdiyetlistesi.Clear();
            if (text == "Gluten free")
            {
                tedavi.builder = new glutenFree();
                haftalikdiyetlistesi = tedavi.builderfonk();
            }
            else if (text == "Akdeniz")
            {
                tedavi.builder = new akdeniz();
                haftalikdiyetlistesi = tedavi.builderfonk();
            }
            else if (text == "Yeşillikler Dünyası")
            {
                tedavi.builder = new YesilliklerDunyasi();
                haftalikdiyetlistesi = tedavi.builderfonk();
            }
            else if (text == "Deniz Ürünleri")
            {
                tedavi.builder = new denizUrunleri();
                haftalikdiyetlistesi = tedavi.builderfonk();
            }
            return haftalikdiyetlistesi;
        }
        //diyet içeriğini listeler.
        public void DiyetİcerigiListele(List<Ogunler>haftalikdiyetlistesi)
        {
            for (int j = 0; j < haftalikdiyetlistesi.Count; j++)
            {
                listViewDiyet.Items[0].SubItems.Add(haftalikdiyetlistesi[j].kahvalti);
                listViewDiyet.Items[1].SubItems.Add(haftalikdiyetlistesi[j].araogun1);
                listViewDiyet.Items[2].SubItems.Add(haftalikdiyetlistesi[j].oglen);
                listViewDiyet.Items[3].SubItems.Add(haftalikdiyetlistesi[j].araogun2);
                listViewDiyet.Items[4].SubItems.Add(haftalikdiyetlistesi[j].aksam);
            }
        }
        //DiyetİcerigiListele overloading yapar .
        public void DiyetİcerigiListele(List<Ogunler> haftalikdiyetlistesi, ListViewItem item)
        {
            listViewHastaDiyet.Items.Clear();
            listhastadiyet();
            for (int j = 0; j < haftalikdiyetlistesi.Count; j++)
            {
                listViewHastaDiyet.Items[0].SubItems.Add(haftalikdiyetlistesi[j].kahvalti);
                listViewHastaDiyet.Items[1].SubItems.Add(haftalikdiyetlistesi[j].araogun1);
                listViewHastaDiyet.Items[2].SubItems.Add(haftalikdiyetlistesi[j].oglen);
                listViewHastaDiyet.Items[3].SubItems.Add(haftalikdiyetlistesi[j].araogun2);
                listViewHastaDiyet.Items[4].SubItems.Add(haftalikdiyetlistesi[j].aksam);
            }
        }
        //hasta listesinden seçilen hastanın aktif diyetini içeriğini listeler.
        private void listViewHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHasta.SelectedItems.Count > 0)
            {
                List<Ogunler> ListOgunler = new List<Ogunler>();
                ListViewItem item = listViewHasta.SelectedItems[0];
                string select=item.SubItems[9].Text;
                ListOgunler = DiyetTurAktarma(select);
                DiyetİcerigiListele(ListOgunler,item);
            }
        }
        //Seçilen diyetin içeriğini listeler.
        private void comboBoxDiyetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ogunler> ListOgunler = new List<Ogunler>();
            listViewDiyet.Items.Clear();
            listdiyet();
            ListOgunler= DiyetTurAktarma(comboBoxDiyetList.Text);
            DiyetİcerigiListele(ListOgunler);
        }
        //girilen tcnin kullandığı diyet türünü seçilen diyet türü ile değiştirir.
        private void buttonUygula_Click(object sender, EventArgs e)
        {
             if (comboBoxDiyetList.Text== "Lütfen Diyet Türü Seçiniz")
             {
                MessageBox.Show("Lütfen Diyet Türünü Seçiniz...");
             }
             else
             {
                CustomerManager veritabani = new CustomerManager(new AccessCustomerManager());
                veritabani.Update("Hastalar", "Diyet", comboBoxDiyetList.Text, textBoxDiyetGuncelleTc.Text, "TC");
                Thread.Sleep(1500);
                MessageBox.Show("Diyet Başarıyla Güncellendi");
                comboBoxHasta.Text = "Lütfen Hastalık Türünü Seçiniz";
                listViewHasta.Items.Clear();
             } 
        }
        //hasta bilgilerinin raporlama için oluştuğu fonksiyon.
        ReportInfo hastabilgiolusturbuilder()
        {
            ReportInfo info = new ReportInfo();
            info.Diyet = new List<Ogunler>();
            info.Hasta = new List<string>();
            ListViewItem item = listViewHasta.SelectedItems[0];
            info.Hasta.Add("TC: "+item.SubItems[0].Text);
            info.Hasta.Add("AD: " + item.SubItems[1].Text);
            info.Hasta.Add("SOYAD: " + item.SubItems[2].Text);
            info.Hasta.Add("TELEFON NO: " + item.SubItems[3].Text);
            info.Hasta.Add("Cinsiyet: " + item.SubItems[4].Text);
            info.Hasta.Add("Boy: " + item.SubItems[5].Text);
            info.Hasta.Add("Kilo: " + item.SubItems[6].Text);
            info.Hasta.Add("Yaş: " + item.SubItems[7].Text);
            info.Hasta.Add("Hastalık: " + item.SubItems[8].Text);
            info.Hasta.Add("Diyet: " + item.SubItems[9].Text);
            info.Diyet= DiyetTurAktarma(item.SubItems[9].Text);
            return info;
        }
        //gönderilen hastalık türüne sahip hastaları listeler.
        void hastalistele(string hastalıkturu)
        {
            listhasta();
            CustomerManager veritabanı = new CustomerManager(new AccessCustomerManager());
            List<string> tc = new List<string>();
            if (hastalıkturu == "Çölyak")
            {
                listViewHasta.Items.Clear();
                int i = 0;
                tc = veritabanı.select("Colyak", "Hastalik", "TC", "Hastalar");
                foreach (string TC in tc)
                {
                    listViewHasta.Items.Add(TC);
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Ad", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Soyad", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "TelefonNo", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Cinsiyet", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Boy", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Kilo", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Yas", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Hastalik", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Diyet", "Hastalar"));
                    i++;
                }
            }
            else if (hastalıkturu == "Obez")
            {
                listViewHasta.Items.Clear();
                int i = 0;
                tc = veritabanı.select("Obez", "Hastalik", "TC", "Hastalar");
                foreach (string TC in tc)
                {
                    listViewHasta.Items.Add(TC);
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Ad", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Soyad", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "TelefonNo", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Cinsiyet", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Boy", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Kilo", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Yas", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Hastalik", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Diyet", "Hastalar"));
                    i++;
                }
            }
            else if (hastalıkturu == "Şeker")
            {
                int i = 0;
                listViewHasta.Items.Clear();
                tc = veritabanı.select("Seker", "Hastalik", "TC", "Hastalar");
                foreach (string TC in tc)
                {
                    listViewHasta.Items.Add(TC);
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Ad", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Soyad", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "TelefonNo", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Cinsiyet", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Boy", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Kilo", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Yas", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Hastalik", "Hastalar"));
                    listViewHasta.Items[i].SubItems.Add(veritabanı.tekselect(TC, "TC", "Diyet", "Hastalar"));
                    i++;
                }

            }
        }
        //seçilen hastalık türünü hasta listele fonksiyonuna gönderir.
        private void comboBoxHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            hastalistele(comboBoxHasta.Text);
        }
        //seçilen hastanın seçilen türdeki rapornu oluşturur (JSON,HTML)
        private void buttonRaporOlustur_Click(object sender, EventArgs e)
        {
            AnaRaporOlustur build = new Json(hastabilgiolusturbuilder());
            if (listViewHasta.SelectedItems.Count > 0)
            {
                if (comboBoxRapor.Text == "JSON")
                {
                    ReportManager manager = new ReportManager(build);
                    string fileName = "HastaRapor.json";
                    if (checkBox1.Checked == false)
                    {
                        File.WriteAllText(fileName, manager.build());
                    }
                    else
                    {
                        File.WriteAllText(fileName, manager.BuildUpsideDown());
                    }
                }
                else if (comboBoxRapor.Text == "HTML")
                {
                    ReportManager manager = new ReportManager(build);
                    string fileName = "HastaRapor.html";
                    if (checkBox1.Checked == false)
                    {
                        File.WriteAllText(fileName, manager.build());
                    }
                    else
                    {
                        File.WriteAllText(fileName, manager.BuildUpsideDown());
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Raporlama Türünü Seçiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Hasta Seçiniz");
            }
        }
        //bir önceki forma geri döner
        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            AraPanel araPanel = new AraPanel();
            araPanel.Show();
            this.Hide();
        }
    }
}