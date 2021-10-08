
namespace Satis
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnAl = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUcret = new System.Windows.Forms.ComboBox();
            this.cbSoyad = new System.Windows.Forms.ComboBox();
            this.cbAd = new System.Windows.Forms.ComboBox();
            this.cbKoltuk = new System.Windows.Forms.ComboBox();
            this.cbSeans = new System.Windows.Forms.ComboBox();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.cbFilmAd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSatis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 520);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.Location = new System.Drawing.Point(472, 12);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(142, 53);
            this.btnSalonEkle.TabIndex = 2;
            this.btnSalonEkle.Text = "Salon Ekle";
            this.btnSalonEkle.UseVisualStyleBackColor = true;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.Location = new System.Drawing.Point(759, 12);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(142, 53);
            this.btnSeansEkle.TabIndex = 3;
            this.btnSeansEkle.Text = "Seans Ekle";
            this.btnSeansEkle.UseVisualStyleBackColor = true;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(614, 12);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(142, 53);
            this.btnFilmEkle.TabIndex = 4;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(905, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(154, 53);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Seans Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnAl);
            this.groupBox1.Controls.Add(this.comboBox8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbUcret);
            this.groupBox1.Controls.Add(this.cbSoyad);
            this.groupBox1.Controls.Add(this.cbAd);
            this.groupBox1.Controls.Add(this.cbKoltuk);
            this.groupBox1.Controls.Add(this.cbSeans);
            this.groupBox1.Controls.Add(this.cbSalon);
            this.groupBox1.Controls.Add(this.cbFilmAd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(773, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 520);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet İşlemleri";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(130, 409);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(143, 53);
            this.btnIptal.TabIndex = 16;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(129, 306);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(142, 53);
            this.btnAl.TabIndex = 7;
            this.btnAl.Text = "Bilet Al";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(132, 370);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(144, 33);
            this.comboBox8.TabIndex = 15;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bilet İptal";
            // 
            // cbUcret
            // 
            this.cbUcret.FormattingEnabled = true;
            this.cbUcret.Location = new System.Drawing.Point(129, 267);
            this.cbUcret.Name = "cbUcret";
            this.cbUcret.Size = new System.Drawing.Size(144, 33);
            this.cbUcret.TabIndex = 13;
            // 
            // cbSoyad
            // 
            this.cbSoyad.FormattingEnabled = true;
            this.cbSoyad.Location = new System.Drawing.Point(129, 228);
            this.cbSoyad.Name = "cbSoyad";
            this.cbSoyad.Size = new System.Drawing.Size(144, 33);
            this.cbSoyad.TabIndex = 12;
            // 
            // cbAd
            // 
            this.cbAd.FormattingEnabled = true;
            this.cbAd.Location = new System.Drawing.Point(129, 188);
            this.cbAd.Name = "cbAd";
            this.cbAd.Size = new System.Drawing.Size(144, 33);
            this.cbAd.TabIndex = 11;
            // 
            // cbKoltuk
            // 
            this.cbKoltuk.Enabled = false;
            this.cbKoltuk.FormattingEnabled = true;
            this.cbKoltuk.Location = new System.Drawing.Point(130, 147);
            this.cbKoltuk.Name = "cbKoltuk";
            this.cbKoltuk.Size = new System.Drawing.Size(144, 33);
            this.cbKoltuk.TabIndex = 10;
            // 
            // cbSeans
            // 
            this.cbSeans.FormattingEnabled = true;
            this.cbSeans.Location = new System.Drawing.Point(129, 108);
            this.cbSeans.Name = "cbSeans";
            this.cbSeans.Size = new System.Drawing.Size(144, 33);
            this.cbSeans.TabIndex = 9;
            this.cbSeans.SelectedIndexChanged += new System.EventHandler(this.cbSeans_SelectedIndexChanged);
            // 
            // cbSalon
            // 
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Location = new System.Drawing.Point(129, 69);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(144, 33);
            this.cbSalon.TabIndex = 8;
            this.cbSalon.SelectedIndexChanged += new System.EventHandler(this.cbSalon_SelectedIndexChanged);
            // 
            // cbFilmAd
            // 
            this.cbFilmAd.FormattingEnabled = true;
            this.cbFilmAd.Location = new System.Drawing.Point(130, 30);
            this.cbFilmAd.Name = "cbFilmAd";
            this.cbFilmAd.Size = new System.Drawing.Size(144, 33);
            this.cbFilmAd.TabIndex = 7;
            this.cbFilmAd.SelectedIndexChanged += new System.EventHandler(this.cbFilmAd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ücret :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Koltuk No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seans :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salon No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(482, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 357);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "*  *  *  *  *\r\n\r\n*  *  *  *  *\r\n\r\n*  *  *  *  *\r\n\r\n*  *  *  *  *\r\n\r\n*  *  *  *  *" +
    "\r\n\r\n*  *  *  *  *\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(472, 63);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(176, 53);
            this.btnSatis.TabIndex = 8;
            this.btnSatis.Text = "Satışları Göster";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1065, 601);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnSeansEkle);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbUcret;
        private System.Windows.Forms.ComboBox cbSoyad;
        private System.Windows.Forms.ComboBox cbAd;
        private System.Windows.Forms.ComboBox cbKoltuk;
        private System.Windows.Forms.ComboBox cbSeans;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.ComboBox cbFilmAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSatis;
    }
}

