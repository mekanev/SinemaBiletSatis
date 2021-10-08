using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satis
{
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tbl_FilmBilgiTableAdapter film = new DataSet1TableAdapters.tbl_FilmBilgiTableAdapter();
        private void btnFilmKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                film.FilmEkleme(txtFilm.Text);
                MessageBox.Show("Film Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu Film Daha Önce Eklendi");
            }
        }

        private void FilmEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        
    }
}
