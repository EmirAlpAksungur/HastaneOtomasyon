
namespace YazılımMimarisiDonemOdevi
{
    partial class DiyetProgramDegistir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetProgramDegistir));
            this.textBoxAraHastaTc = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewHasta = new System.Windows.Forms.ListView();
            this.listViewDiyet = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHasta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDiyetList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewHastaDiyet = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonRaporOlustur = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxRapor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonUygula = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDiyetGuncelleTc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAraHastaTc
            // 
            this.textBoxAraHastaTc.Location = new System.Drawing.Point(172, 121);
            this.textBoxAraHastaTc.MaxLength = 11;
            this.textBoxAraHastaTc.Multiline = true;
            this.textBoxAraHastaTc.Name = "textBoxAraHastaTc";
            this.textBoxAraHastaTc.Size = new System.Drawing.Size(100, 20);
            this.textBoxAraHastaTc.TabIndex = 0;
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.Color.Transparent;
            this.buttonAra.Location = new System.Drawing.Point(172, 147);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(100, 36);
            this.buttonAra.TabIndex = 1;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aranacak Hastanın TC";
            // 
            // listViewHasta
            // 
            this.listViewHasta.HideSelection = false;
            this.listViewHasta.Location = new System.Drawing.Point(342, 59);
            this.listViewHasta.Name = "listViewHasta";
            this.listViewHasta.Size = new System.Drawing.Size(923, 156);
            this.listViewHasta.TabIndex = 3;
            this.listViewHasta.UseCompatibleStateImageBehavior = false;
            this.listViewHasta.SelectedIndexChanged += new System.EventHandler(this.listViewHasta_SelectedIndexChanged);
            // 
            // listViewDiyet
            // 
            this.listViewDiyet.HideSelection = false;
            this.listViewDiyet.Location = new System.Drawing.Point(342, 478);
            this.listViewDiyet.Name = "listViewDiyet";
            this.listViewDiyet.Size = new System.Drawing.Size(923, 151);
            this.listViewDiyet.TabIndex = 4;
            this.listViewDiyet.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(590, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label3.Location = new System.Drawing.Point(589, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seçilen Diyet Bilgileri";
            // 
            // comboBoxHasta
            // 
            this.comboBoxHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHasta.FormattingEnabled = true;
            this.comboBoxHasta.Items.AddRange(new object[] {
            "Lütfen Hastalık Türünü Seçiniz",
            "Çölyak",
            "Obez",
            "Şeker"});
            this.comboBoxHasta.Location = new System.Drawing.Point(171, 48);
            this.comboBoxHasta.Name = "comboBoxHasta";
            this.comboBoxHasta.Size = new System.Drawing.Size(105, 24);
            this.comboBoxHasta.TabIndex = 7;
            this.comboBoxHasta.SelectedIndexChanged += new System.EventHandler(this.comboBoxHasta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Listelenecek Hasta Türü";
            // 
            // comboBoxDiyetList
            // 
            this.comboBoxDiyetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiyetList.FormattingEnabled = true;
            this.comboBoxDiyetList.Items.AddRange(new object[] {
            "Lütfen Diyet Türü Seçiniz",
            "Akdeniz",
            "Deniz Ürünleri",
            "Gluten free",
            "Yeşillikler Dünyası"});
            this.comboBoxDiyetList.Location = new System.Drawing.Point(171, 393);
            this.comboBoxDiyetList.Name = "comboBoxDiyetList";
            this.comboBoxDiyetList.Size = new System.Drawing.Size(100, 24);
            this.comboBoxDiyetList.TabIndex = 9;
            this.comboBoxDiyetList.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiyetList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(590, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hasta Diyet Bilgileri";
            // 
            // listViewHastaDiyet
            // 
            this.listViewHastaDiyet.HideSelection = false;
            this.listViewHastaDiyet.Location = new System.Drawing.Point(342, 267);
            this.listViewHastaDiyet.Name = "listViewHastaDiyet";
            this.listViewHastaDiyet.Size = new System.Drawing.Size(923, 151);
            this.listViewHastaDiyet.TabIndex = 11;
            this.listViewHastaDiyet.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.buttonGeriDon);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.buttonRaporOlustur);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.comboBoxRapor);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.buttonUygula);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxDiyetGuncelleTc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxDiyetList);
            this.panel1.Controls.Add(this.textBoxAraHastaTc);
            this.panel1.Controls.Add(this.buttonAra);
            this.panel1.Controls.Add(this.comboBoxHasta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 617);
            this.panel1.TabIndex = 12;
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.buttonGeriDon.Location = new System.Drawing.Point(3, 564);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(316, 36);
            this.buttonGeriDon.TabIndex = 24;
            this.buttonGeriDon.Text = "Değiştir";
            this.buttonGeriDon.UseVisualStyleBackColor = false;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 272);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 21);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "SIRA D-H";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonRaporOlustur
            // 
            this.buttonRaporOlustur.BackColor = System.Drawing.Color.Transparent;
            this.buttonRaporOlustur.Location = new System.Drawing.Point(172, 299);
            this.buttonRaporOlustur.Name = "buttonRaporOlustur";
            this.buttonRaporOlustur.Size = new System.Drawing.Size(100, 42);
            this.buttonRaporOlustur.TabIndex = 22;
            this.buttonRaporOlustur.Text = "Rapor Oluştur";
            this.buttonRaporOlustur.UseVisualStyleBackColor = false;
            this.buttonRaporOlustur.Click += new System.EventHandler(this.buttonRaporOlustur_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(78, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Rapor Türü";
            // 
            // comboBoxRapor
            // 
            this.comboBoxRapor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRapor.FormattingEnabled = true;
            this.comboBoxRapor.Items.AddRange(new object[] {
            "Lütfen Rapor Türünü Seçiniz",
            "JSON",
            "HTML"});
            this.comboBoxRapor.Location = new System.Drawing.Point(172, 242);
            this.comboBoxRapor.Name = "comboBoxRapor";
            this.comboBoxRapor.Size = new System.Drawing.Size(100, 24);
            this.comboBoxRapor.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(3, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "Seçilen Hastanın Raporunu oluşturma";
            // 
            // buttonUygula
            // 
            this.buttonUygula.BackColor = System.Drawing.Color.Transparent;
            this.buttonUygula.Location = new System.Drawing.Point(172, 499);
            this.buttonUygula.Name = "buttonUygula";
            this.buttonUygula.Size = new System.Drawing.Size(100, 36);
            this.buttonUygula.TabIndex = 18;
            this.buttonUygula.Text = "Değiştir";
            this.buttonUygula.UseVisualStyleBackColor = false;
            this.buttonUygula.Click += new System.EventHandler(this.buttonUygula_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(23, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Hastanın Diyetini Değiştir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(85, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Hasta TC";
            // 
            // textBoxDiyetGuncelleTc
            // 
            this.textBoxDiyetGuncelleTc.Location = new System.Drawing.Point(172, 473);
            this.textBoxDiyetGuncelleTc.MaxLength = 11;
            this.textBoxDiyetGuncelleTc.Multiline = true;
            this.textBoxDiyetGuncelleTc.Name = "textBoxDiyetGuncelleTc";
            this.textBoxDiyetGuncelleTc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiyetGuncelleTc.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(3, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Seçilen Diyet\'in Bilgilerini Listele";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(77, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Diyet Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(33, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hasta TC\'e Göre Listele";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(52, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hastalığa Göre Listele";
            // 
            // DiyetProgramDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewHastaDiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewDiyet);
            this.Controls.Add(this.listViewHasta);
            this.Name = "DiyetProgramDegistir";
            this.Text = "DiyetProgramDegistir";
            this.Load += new System.EventHandler(this.DiyetProgramDegistir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAraHastaTc;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewHasta;
        private System.Windows.Forms.ListView listViewDiyet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDiyetList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewHastaDiyet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUygula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDiyetGuncelleTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRaporOlustur;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxRapor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonGeriDon;
    }
}