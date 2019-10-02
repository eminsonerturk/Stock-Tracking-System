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
    public partial class MusteriTanimla : Form
    {
        public MusteriTanimla()
        {
            InitializeComponent();
        }
        int musteriNo = 0;
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtAdi.Focus();
        }

        private void MusteriTanimla_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cMusteri m = new cMusteri();
            m.MusterileriGetir(lvMusteriler);
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
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "")
            {
                cMusteri m = new cMusteri();
                bool Sonuc = m.MusteriKontrol(txtAdi.Text, txtSoyadi.Text);
                if (Sonuc)
                {
                    MessageBox.Show("Bu müşteri önceden kayıtlı!");
                    txtAdi.Focus();
                }
                else
                {
                    m.MusteriAd = txtAdi.Text;
                    m.MusteriSoyad = txtSoyadi.Text;
                    m.Telefon = txtTelefon.Text;
                    m.Adres = txtAdres.Text;
                    Sonuc = m.MusteriEkle(m);
                    if (Sonuc)
                    {
                        MessageBox.Show("Müşteri bilgileri kayıt edildi.");
                        Temizle();
                        m.MusterileriGetir(lvMusteriler);
                    }
                }
            }
            else { MessageBox.Show("Adı ve Soyadı bilgilerini girmelisiniz!", "Eksik Bilgi!"); }
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            musteriNo = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = lvMusteriler.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lvMusteriler.SelectedItems[0].SubItems[2].Text;
            txtTelefon.Text = lvMusteriler.SelectedItems[0].SubItems[3].Text;
            txtAdres.Text = lvMusteriler.SelectedItems[0].SubItems[4].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAdi.Focus();
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusterileriGetirByAdaGore(txtAdaGore.Text, lvMusteriler);
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "")
            {
                cMusteri m = new cMusteri();
                bool Sonuc = m.MusteriKontrol(txtAdi.Text, txtSoyadi.Text, musteriNo);
                if (Sonuc)
                {
                    MessageBox.Show("Bu müşteri önceden kayıtlı!");
                    txtAdi.Focus();
                }
                else
                {
                    m.MusteriNo = musteriNo;
                    m.MusteriAd = txtAdi.Text;
                    m.MusteriSoyad = txtSoyadi.Text;
                    m.Telefon = txtTelefon.Text;
                    m.Adres = txtAdres.Text;
                    Sonuc = m.MusteriGuncelle(m);
                    if (Sonuc)
                    {
                        MessageBox.Show("Müşteri bilgileri kayıt edildi.");
                        Temizle();
                        m.MusterileriGetir(lvMusteriler);
                    }
                }
            }
            else { MessageBox.Show("Adı ve Soyadı bilgilerini girmelisiniz!", "Eksik Bilgi!"); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cMusteri m = new cMusteri();
                bool Sonuc = m.MusteriSil(musteriNo);
                if (Sonuc)
                {
                    MessageBox.Show("Müşteri bilgileri silindi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    m.MusterileriGetir(lvMusteriler);
                }
            }
        }
    }
}
