
namespace YazılımMimarisiDonemOdevi
{
    partial class AdminPanel
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
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSad = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelno = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(151, 184);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(100, 23);
            this.buttonKaydet.TabIndex = 0;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(151, 44);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxAd.TabIndex = 1;
            // 
            // textBoxSad
            // 
            this.textBoxSad.Location = new System.Drawing.Point(151, 72);
            this.textBoxSad.Name = "textBoxSad";
            this.textBoxSad.Size = new System.Drawing.Size(100, 22);
            this.textBoxSad.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(151, 156);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(100, 22);
            this.textBoxSifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon No";
            // 
            // maskedTextBoxTelno
            // 
            this.maskedTextBoxTelno.Location = new System.Drawing.Point(151, 128);
            this.maskedTextBoxTelno.Mask = "9990000000";
            this.maskedTextBoxTelno.Name = "maskedTextBoxTelno";
            this.maskedTextBoxTelno.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTelno.TabIndex = 10;
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(151, 100);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTC.TabIndex = 11;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(87, 161);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(37, 17);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Sifre";
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Location = new System.Drawing.Point(151, 214);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(100, 35);
            this.buttonGeriDon.TabIndex = 13;
            this.buttonGeriDon.Text = "Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(97, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Diyetisyen Ekleme";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.maskedTextBoxTelno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxSad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.buttonKaydet);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSad;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelno;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Button buttonGeriDon;
        private System.Windows.Forms.Label label5;
    }
}