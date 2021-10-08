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
    public partial class SeansListele : Form
    {
        public SeansListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-6ERATV1U\\SQLEXPRESS;Initial Catalog=SinemaSistem;Integrated Security=True");
        DataTable table = new DataTable();
        public void Listele(string sql)
        {
            table.Clear();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql,baglanti);
            da.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }
        private void SeansListele_Load(object sender, EventArgs e)
        {
            table.Clear();
            Listele("select * from tbl_SeansBilgileri");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele("select * from tbl_SeansBilgileri where Seans='" + txtSaat.Text + "'");
        }

        private void SeansListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
