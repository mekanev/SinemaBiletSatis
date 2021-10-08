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
    public partial class SalonEkle : Form
    {
        public SalonEkle()
        {
            InitializeComponent();
        }

        private void SalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        DataSet1TableAdapters.tbl_SalonBilgiTableAdapter salon = new DataSet1TableAdapters.tbl_SalonBilgiTableAdapter();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(textBox1.Text);
                MessageBox.Show("Salon Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı Salon Mevcut");
            }
            textBox1.Text = "";
        }
    }
}
