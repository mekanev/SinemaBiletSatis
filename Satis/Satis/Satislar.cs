using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satis
{
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }
        public void Listele(string sql)
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql,baglanti);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Satislar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6ERATV1U\\SQLEXPRESS;Initial Catalog=SinemaSistem;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void Satislar_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            Listele("select * from tbl_SatisBilgi");
        }
    }
}
