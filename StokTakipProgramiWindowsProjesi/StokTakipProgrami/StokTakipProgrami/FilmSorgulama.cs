using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgrami
{
    public partial class FilmSorgulama : Form
    {
        public FilmSorgulama()
        {
            InitializeComponent();
        }

        private void FilmleriGetir()
        {
            cFilm f = new cFilm();
            string TureGore = "";
            if (cbFilmTurleri.SelectedItem.ToString() != "Tüm Türler")
                TureGore = cbFilmTurleri.SelectedItem.ToString();
            f.FilmleriGetirBySorgulama(txtAdaGore.Text, TureGore, txtYonetmeneGore.Text, txtOyuncularaGore.Text, lvFilmler);
        }

        private void FilmSorgulama_Load(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmleriGetir(lvFilmler);

            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(cbFilmTurleri);
            //cbFilmTurleri.Items.Add("Tüm Türler"); //En son eleman olarak ekler.
            cbFilmTurleri.Items.Insert(0, "Tüm Türler"); //İlk eleman olarak ekler.
            cbFilmTurleri.SelectedIndex = 0;
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtYonetmeneGore_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtOyuncularaGore_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void lvFilmler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cGenel.filmNo = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[0].Text);
            cGenel.film = lvFilmler.SelectedItems[0].SubItems[1].Text;
            cGenel.stokMiktar = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[7].Text);
            this.Close();
        }
    }
}
