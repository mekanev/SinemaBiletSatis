using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6ERATV1U\\SQLEXPRESS;Initial Catalog=SinemaSistem;Integrated Security=True");
        private void SalonveFilmGoster(ComboBox combo,string sql,string sql2)
        {
            baglanti.Open();
            SqlCommand salon = new SqlCommand(sql,baglanti);
            SqlDataReader dr = salon.ExecuteReader();
            while (dr.Read())
            {
                combo.Items.Add(dr[sql2].ToString());
            }
            baglanti.Close();
        }
      private void SeansGoster()
        {
            baglanti.Open();
            SqlCommand seans = new SqlCommand("select * from tbl_SeansBilgileri where FilmAdi='"+cbFilmAd.SelectedItem+"'and SalonAdi='"+cbSalon.SelectedItem+"'", baglanti);
            SqlDataReader dr = seans.ExecuteReader();
            while (dr.Read())
            {
                if (DateTime.Parse(dr["Seans"].ToString())>=DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!cbSeans.Items.Contains(dr["Seans"].ToString()))
                    {
                        cbSeans.Items.Add(dr["Seans"].ToString());
                    }
                }
            }
            baglanti.Close();
        }
        private void YenidenRenk()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Green;
                }
            }
        }
        private void DoluKoltukCb()
        {
            comboBox8.Items.Clear();
            comboBox8.Text = " ";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        comboBox8.Items.Add(item.Text);
                    }
                }
            }
        }
        private void VeriTabaniDoluKoltuk()
        {
            baglanti.Open();
            SqlCommand dolu = new SqlCommand("select * from tbl_SatisBilgi where FilmAdi='"+cbFilmAd.SelectedItem+"'and SalonAdi='"+cbSalon.SelectedItem+"'and Seans='"+cbSeans.SelectedItem+"' ",baglanti);
            SqlDataReader dr = dolu.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (dr["KoltukNo"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;
                            comboBox8.Items.Add(item.Text);
                        }
                    }
                }
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BosKoltuklar();
            YenidenRenk();
            VeriTabaniDoluKoltuk();
            SalonveFilmGoster(cbFilmAd, "select * from tbl_FilmBilgi","FilmAdi");
            SalonveFilmGoster(cbSalon, "select * from tbl_SalonBilgi","SalonAdi");
        }
        
        private void BosKoltuklar()
        {
            int say = 0;
            int koltuk = 30;
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                for (int j = 0; j < textBox1.Lines[i].Count(); j++)
                {
                    string satir = textBox1.Lines[i];
                    if (satir[j] == '*')
                    {
                        Button nesne = new Button();
                        nesne.Text = (++say).ToString();
                        nesne.Name = "buton_" + nesne.Text;
                        nesne.BackColor = Color.Green;
                        nesne.Width = nesne.Height = 40;
                        nesne.Left = koltuk * j;
                        nesne.Top = koltuk * i;
                        panel1.Controls.Add(nesne);
                        nesne.Click += nesne_Click;
                    }
                }
            }
        }

        private void nesne_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor==Color.Green)
            {
                cbKoltuk.Text = btn.Text;
            }
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            SalonEkle salon = new SalonEkle();
            salon.Show();
            this.Hide();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            FilmEkle film = new FilmEkle();
            film.Show();
            this.Hide();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            SeansEkle seans = new SeansEkle();
            seans.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SeansListele listele = new SeansListele();
            listele.Show();
            this.Hide();
        }

        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeansGoster();
            YenidenRenk();
            DoluKoltukCb();
            VeriTabaniDoluKoltuk();
        }
        private void Temizle()
        {
            cbAd.Text = "";
            cbFilmAd.Text = "";
            cbKoltuk.Text = "";
            cbSalon.Text = "";
            cbSeans.Text = "";
            cbSoyad.Text = "";
            cbUcret.Text = "";
            comboBox8.Text = "";
        }
        DataSet1TableAdapters.tbl_SatisBilgiTableAdapter satis = new DataSet1TableAdapters.tbl_SatisBilgiTableAdapter();
        private void btnAl_Click(object sender, EventArgs e)
        {
            if (  cbKoltuk.Text!="")
            {
                try
                {
                    satis.SatisYapmak(cbKoltuk.Text, cbSalon.Text, cbFilmAd.Text, cbSeans.Text, cbAd.Text, cbSoyad.Text, cbUcret.Text);
                    Temizle();
                    YenidenRenk();
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata Oluştu");
                } 
            }
            else
            {
                MessageBox.Show("Koltuk Seçiniz");
            }
        }

        private void cbFilmAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenk();
            DoluKoltukCb();
            VeriTabaniDoluKoltuk();
        }

        private void cbSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeansGoster();
            YenidenRenk();
            DoluKoltukCb();
            VeriTabaniDoluKoltuk();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar();
            satislar.Show();
            this.Hide();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from tbl_SatisBilgi where KoltukNo=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", comboBox8.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            Temizle();
            YenidenRenk();
        }
    }
}