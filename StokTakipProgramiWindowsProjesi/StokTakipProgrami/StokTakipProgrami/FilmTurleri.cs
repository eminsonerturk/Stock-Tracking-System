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

   
    public partial class FilmTurleri : Form
    {

        int turNo = 0;
        public FilmTurleri()
        {
            InitializeComponent();
        }

        private void FilmTurleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(lvFilmTurleri);
        }

        private void Temizle()
        {
            txtFilmTuru.Clear();
            txtAciklama.Clear();
            txtFilmTuru.Focus();
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
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruKontrol(txtFilmTuru.Text);
                if (Sonuc)
                {
                    MessageBox.Show("Bu Film Türü önceden kayıtlı!");
                    txtFilmTuru.Focus();
                }
                else
                {
                    //Sonuc = ft.FilmTuruEkle(txtFilmTuru.Text, txtAciklama.Text);
                    ft.TurAd = txtFilmTuru.Text;
                    ft.Aciklama = txtAciklama.Text;
                    Sonuc = ft.FilmTuruEkle(ft);
                    if (Sonuc)
                    {
                        MessageBox.Show("Film Türü bilgileri kayıt edildi.");
                        Temizle();
                        ft.FilmTurleriGetir(lvFilmTurleri);
                    }
                }
            }
            else { MessageBox.Show("Film Türü girmelisiniz!", "Eksik Bilgi!"); }
        }

        private void lvFilmTurleri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            turNo = Convert.ToInt32(lvFilmTurleri.SelectedItems[0].SubItems[0].Text);
            txtFilmTuru.Text = lvFilmTurleri.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvFilmTurleri.SelectedItems[0].SubItems[2].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtFilmTuru.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                ft.FilmTurNo = turNo;
                ft.TurAd = txtFilmTuru.Text;
                ft.Aciklama = txtAciklama.Text;
                bool Sonuc = ft.FilmTuruGuncelle(ft);
                if (Sonuc)
                {
                    MessageBox.Show("Film Türü bilgileri değiştirildi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    ft.FilmTurleriGetir(lvFilmTurleri);
                }
            }
            else { MessageBox.Show("Film Türü girmelisiniz!", "Eksik Bilgi!"); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Film türü bilgilerini silmek istiyor musunuz?", "SİLME İŞLEMİ HAKKINDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruSil(turNo);
                if (Sonuc)
                {
                    MessageBox.Show("Film Türü bilgileri silindi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    ft.FilmTurleriGetir(lvFilmTurleri);
                }
            }
        }



    }
}
