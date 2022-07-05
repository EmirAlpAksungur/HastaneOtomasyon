using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMimarisiDonemOdevi
{
    //geçiş ekranıdır sadece formlar arası geçiş yapar
    public partial class AraPanel : Form
    {
        public AraPanel()
        {
            InitializeComponent();
        }
        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            girisEkranı giris = new girisEkranı();
            giris.Show();
            this.Hide();
        }
        private void buttonHasta_Click(object sender, EventArgs e)
        {
            HastaKayit hasta = new HastaKayit();
            hasta.Show();
            this.Hide();
        }
        private void buttonDiyetDegistir_Click_1(object sender, EventArgs e)
        {
            DiyetProgramDegistir diyet = new DiyetProgramDegistir();
            diyet.Show();
            this.Hide();
        }
    }
}
