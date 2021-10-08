using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satis
{
    public partial class SeansEkle : Form
    {
        public SeansEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6ERATV1U\\SQLEXPRESS;Initial Catalog=SinemaSistem;Integrated Security=True");
        DataSet1TableAdapters.tbl_SeansBilgileriTableAdapter seans = new DataSet1TableAdapters.tbl_SeansBilgileriTableAdapter();
      private void FilmveSalonGoster(ComboBox combo,string sql,string sql2)
      {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combo.Items.Add(dr[sql2].ToString());
            }baglanti.Close();
      }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                seans.SeansEkleme(cbFilm.Text, cbSalon.Text, txtSaat.Text);
                MessageBox.Show("Seans Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Seans Ekleme İşlemi Yapılamadı");
            }
            cbFilm.Text = "";
            cbSalon.Text = "";
            txtSaat.Text = "";
        }
        private void SeansEkle_Load(object sender, EventArgs e)
        {
            FilmveSalonGoster(cbFilm, "select * from tbl_FilmBilgi", "FilmAdi");
            FilmveSalonGoster(cbSalon, "select * from tbl_SalonBilgi", "SalonAdi");
        }

        private void SeansEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
