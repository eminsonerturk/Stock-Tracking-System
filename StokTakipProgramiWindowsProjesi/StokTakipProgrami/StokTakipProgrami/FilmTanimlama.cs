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
    public partial class FilmTanimlama : Form
    {
        public FilmTanimlama()
        {
            InitializeComponent();
        }

        int filmNo = -1, turNo = -1;

        private void FilmTanimlama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilm f = new cFilm();
            f.FilmleriGetir(lvFilmler);

            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(cbFilmTurleri);
        }

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            cFilmTuru ft = (cFilmTuru)cbFilmTurleri.SelectedItem;
            txtFilmTuru.Text = ft.TurAd;
            turNo = cbFilmTurleri.SelectedIndex + 1;

            txtYonetmen.Focus();
        }
        private void Temizle()
        {
            txtFilmAdi.Clear();
            txtYonetmen.Clear();
            txtOyuncular.Clear();
            txtOzet.Clear();
            txtMiktar.Text = "1";
            txtFilmAdi.Focus();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text.Trim() != "" && txtYonetmen.Text.Trim() != "")
            {
                cFilm f = new cFilm();
                if (f.FilmKontrol(txtFilmAdi.Text, txtYonetmen.Text))
                {
                    MessageBox.Show("Bu film önceden kayıtlı!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    f.FilmAd = txtFilmAdi.Text;
                    f.FilmTurNo = turNo;
                    f.Yonetmen = txtYonetmen.Text;
                    f.Oyuncular = txtOyuncular.Text;
                    f.Ozet = txtOzet.Text;
                    f.Miktar = Convert.ToInt32(txtMiktar.Text);
                    if (f.FilmEkle(f))
                    {
                        MessageBox.Show("Film Bilgileri kayıt edildi.");
                        f.FilmleriGetir(lvFilmler);
                        Temizle();
                        btnKaydet.Enabled = false;
                    }
                    else { MessageBox.Show("Film kayıt işlemi gerçekleşmedi!"); }
                }
            }
            else
            {
                MessageBox.Show("Film adı ve Yönetmen bilgileri boş bırakılamaz!");
            }
        }

        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            filmNo = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[0].Text);
            txtFilmAdi.Text = lvFilmler.SelectedItems[0].SubItems[1].Text;
            turNo = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[2].Text);
            txtFilmTuru.Text = lvFilmler.SelectedItems[0].SubItems[3].Text;
            txtYonetmen.Text = lvFilmler.SelectedItems[0].SubItems[4].Text;
            txtOyuncular.Text = lvFilmler.SelectedItems[0].SubItems[5].Text;
            txtOzet.Text = lvFilmler.SelectedItems[0].SubItems[6].Text;
            txtMiktar.Text = lvFilmler.SelectedItems[0].SubItems[7].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtFilmAdi.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text.Trim() != "" && txtYonetmen.Text.Trim() != "")
            {
                cFilm f = new cFilm();
                if (f.FilmKontrol(txtFilmAdi.Text, txtYonetmen.Text, filmNo))
                {
                    MessageBox.Show("Bu film önceden kayıtlı!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    f.FilmNo = filmNo;
                    f.FilmAd = txtFilmAdi.Text;
                    f.FilmTurNo = turNo;
                    f.Yonetmen = txtYonetmen.Text;
                    f.Oyuncular = txtOyuncular.Text;
                    f.Ozet = txtOzet.Text;
                    f.Miktar = Convert.ToInt32(txtMiktar.Text);
                    if (f.FilmGuncelle(f))
                    {
                        MessageBox.Show("Film Bilgileri değiştirildi.");
                        f.FilmleriGetir(lvFilmler);
                        Temizle();
                        btnKaydet.Enabled = false;
                    }
                    else { MessageBox.Show("Film güncelleme işlemi gerçekleşmedi!"); }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilm f = new cFilm();
                bool Sonuc = f.FilmSil(filmNo);
                if (Sonuc)
                {
                    MessageBox.Show("Film bilgileri silindi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    f.FilmleriGetir(lvFilmler);
                }
            }
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmleriGetirByAdaGore(txtAdaGore.Text, lvFilmler);
        }

       
    }
}
