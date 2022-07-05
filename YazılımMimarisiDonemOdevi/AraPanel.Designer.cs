
namespace YazılımMimarisiDonemOdevi
{
    partial class AraPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AraPanel));
            this.buttonDiyetDegistir = new System.Windows.Forms.Button();
            this.buttonHasta = new System.Windows.Forms.Button();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDiyetDegistir
            // 
            this.buttonDiyetDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiyetDegistir.Location = new System.Drawing.Point(12, 91);
            this.buttonDiyetDegistir.Name = "buttonDiyetDegistir";
            this.buttonDiyetDegistir.Size = new System.Drawing.Size(149, 58);
            this.buttonDiyetDegistir.TabIndex = 1;
            this.buttonDiyetDegistir.Text = "Diyet Değiştirme Paneli";
            this.buttonDiyetDegistir.UseVisualStyleBackColor = true;
            this.buttonDiyetDegistir.Click += new System.EventHandler(this.buttonDiyetDegistir_Click_1);
            // 
            // buttonHasta
            // 
            this.buttonHasta.Location = new System.Drawing.Point(12, 27);
            this.buttonHasta.Name = "buttonHasta";
            this.buttonHasta.Size = new System.Drawing.Size(149, 58);
            this.buttonHasta.TabIndex = 2;
            this.buttonHasta.Text = "Hasta Ekleme Paneli";
            this.buttonHasta.UseVisualStyleBackColor = true;
            this.buttonHasta.Click += new System.EventHandler(this.buttonHasta_Click);
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Location = new System.Drawing.Point(12, 155);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(149, 58);
            this.buttonGeriDon.TabIndex = 3;
            this.buttonGeriDon.Text = "Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // AraPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(176, 214);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.buttonHasta);
            this.Controls.Add(this.buttonDiyetDegistir);
            this.Name = "AraPanel";
            this.Text = "AraPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDiyetDegistir;
        private System.Windows.Forms.Button buttonHasta;
        private System.Windows.Forms.Button buttonGeriDon;
    }
}