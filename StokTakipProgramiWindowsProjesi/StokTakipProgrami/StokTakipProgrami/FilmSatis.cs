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
    public partial class FilmSatis : Form
    {
        public FilmSatis()
        {
            InitializeComponent();
        }

        int ilkAdet = 0, filmNo = -1, MusteriNo = -1, satisNo = -1, adetDegeri = 0;
        private void FilmSatis_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            cFilmSatis fs = new cFilmSatis();
            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void Temizle()
        {
            txtAdet.Text = "1";
            txtFiyat.Text = "0";
            txtTutar.Text = "0";
            txtFilm.Clear();
 
            txtStok.Clear();
            txtFilm.Focus();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            MusteriSorgula frm = new MusteriSorgula();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            MusteriNo = cGenel.musteriNo;
            txtMusteri.Text = cGenel.musteri;
        }

        private void btnFilmBul_Click(object sender, EventArgs e)
        {
            FilmSorgulama frm = new FilmSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            filmNo = cGenel.filmNo;
            txtFilm.Text = cGenel.film;
            txtStok.Text = cGenel.stokMiktar.ToString();
            txtAdet.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            btnFilmBul.Enabled = true;
            btnMusteriBul.Enabled = true;
            Temizle();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, txtAdet.Text.Length);
            }
            if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, txtFiyat.Text.Length);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtFiyat.Text)).ToString();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Text = "1";
                txtAdet.Select(0, txtAdet.Text.Length);
            }
            if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, txtFiyat.Text.Length);
            }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtFiyat.Text)).ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (filmNo!=-1 && MusteriNo != -1)
            {
                if (Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtStok.Text))
                {
                    MessageBox.Show("Stok Miktarı yetersiz!");
                    txtAdet.Text = txtStok.Text;
                    txtAdet.Focus();
                }
                else
                {
                    cFilmSatis fs = new cFilmSatis();
                    fs.Tarih = Convert.ToDateTime(txtTarih.Text);
                    fs.FilmNo = filmNo;
                    fs.MusteriNo = MusteriNo;
                    fs.Adet = Convert.ToInt32(txtAdet.Text);
                    fs.BirimFiyat = Convert.ToDouble(txtFiyat.Text);
                    if (fs.SatisEkle(fs))
                    {
                        MessageBox.Show("Satış Bilgileri kayıt edildi.");
                        //Satılan filmin stok miktarı güncellenmeli (azaltılmalı)
                        cFilm f = new cFilm();
                        bool Sonuc = f.StokGuncelleBySatisEkle(filmNo, Convert.ToInt32(txtAdet.Text));
                        if (Sonuc)
                        {
                            MessageBox.Show("Stok Güncellendi!");
                            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                            Temizle();
                            btnKaydet.Enabled = false;
                            btnFilmBul.Enabled = false;
                            btnMusteriBul.Enabled = false;
                        }
                    }
                    else { MessageBox.Show("Satış kaydı gerçekleşmedi!"); }
                }
            }
            else
            {
                MessageBox.Show("Müşteri ve Film seçilmelidir!", "Dikkat! Eksik Bilgi!");
                txtMusteri.Focus();
            }
        }

        private void lvSatislar_DoubleClick(object sender, EventArgs e)
        {
            satisNo = Convert.ToInt32(lvSatislar.SelectedItems[0].SubItems[0].Text);
            txtTarih.Text = lvSatislar.SelectedItems[0].SubItems[1].Text;
            txtFilm.Text = lvSatislar.SelectedItems[0].SubItems[2].Text;
            txtMusteri.Text = lvSatislar.SelectedItems[0].SubItems[3].Text;
            txtFiyat.Text = lvSatislar.SelectedItems[0].SubItems[4].Text;
            txtAdet.Text = lvSatislar.SelectedItems[0].SubItems[5].Text;
            ilkAdet = Convert.ToInt32(lvSatislar.SelectedItems[0].SubItems[5].Text);
            filmNo = Convert.ToInt32(lvSatislar.SelectedItems[0].SubItems[7].Text);
            MusteriNo = Convert.ToInt32(lvSatislar.SelectedItems[0].SubItems[8].Text);
            txtStok.Text = lvSatislar.SelectedItems[0].SubItems[9].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;

            adetDegeri = Convert.ToInt32(txtAdet.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilmSatis fs = new cFilmSatis();
                if (fs.SatisIptal(satisNo))
                {
                    MessageBox.Show("Satış bilgileri iptal edildi.");
                    //Film stok miktarı güncellenmeli
                    cFilm f = new cFilm();
                    bool Sonuc = f.StokGuncelleBySatisIptal(filmNo, Convert.ToInt32(txtAdet.Text));
                    if (Sonuc)
                    {
                        MessageBox.Show("Satış iptali gerçekleştirildi.");
                        fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                        Temizle();
                    }
                    else
                        MessageBox.Show("Satış iptali gerçekleşmedi.");

                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtStok.Text))
            {
                MessageBox.Show("Stok Miktarı yetersiz!");
                txtAdet.Text = txtStok.Text;
                txtAdet.Focus();
            }
            else
            {
                cFilmSatis fs = new cFilmSatis();
                fs.SatisNo = satisNo;
                fs.Tarih = Convert.ToDateTime(txtTarih.Text);
                fs.FilmNo = filmNo;
                fs.MusteriNo = MusteriNo;
                fs.Adet = Convert.ToInt32(txtAdet.Text);
                fs.BirimFiyat = Convert.ToDouble(txtFiyat.Text);
                if (fs.SatisGuncelle(fs))
                {
                    MessageBox.Show("Satış Bilgileri değiştirildi.");
                    //Satılan filmin stok miktarı güncellenmeli 
                    fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                    int bayrak = 0, flag= 0;


                    if (adetDegeri == Convert.ToInt32(txtAdet.Text))
                    {
                        flag = 1;
                    }


                    if ((Convert.ToInt32(txtAdet.Text) > adetDegeri) && flag == 0)
                    {
                        cFilm f = new cFilm();
                        int stokFarki = Convert.ToInt32(txtAdet.Text) - adetDegeri;

                        bool Sonuc = f.FilmStokGuncelle(filmNo, Convert.ToInt32(txtStok.Text) - stokFarki);
                        if (Sonuc)
                        {
                            MessageBox.Show("Stok Güncellendi!");
                            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                            Temizle();
                            btnKaydet.Enabled = false;
                            btnFilmBul.Enabled = false;
                            btnMusteriBul.Enabled = false;
                        }
                        bayrak = 1;
                    }
                    //txtStok sağ üstteki
                    //ilkAdet değeri listeden gelen değer
                    //adetDegeri listeden kalan eski değer.
                    //Txtadet değeri soldaki kolonun değeri.
                    else if((adetDegeri > Convert.ToInt32(txtAdet.Text)) && bayrak == 0 && flag == 0)
                    {
                        cFilm f = new cFilm();
                        int stokFarki = adetDegeri - Convert.ToInt32(txtAdet.Text);


                        bool Sonuc = f.FilmStokGuncelle(filmNo, Convert.ToInt32(txtStok.Text)+stokFarki);
                        if (Sonuc)
                        {
                            MessageBox.Show("Stok Güncellendi!");
                            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                            Temizle();
                            btnKaydet.Enabled = false;
                            btnFilmBul.Enabled = false;
                            btnMusteriBul.Enabled = false;
                        }


                    }
                    


                }
                else { MessageBox.Show("Satış kaydı gerçekleşmedi!"); }
            }
        }


    }
}
