using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StokTakipProgrami
{
    public partial class kullaniciEkrani : Form
    {
        public kullaniciEkrani()
        {

            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();

        void ChildForm(Form _childForm, int width, int height)
        {
            this.Width = _childForm.Width + width;
            this.Height = _childForm.Height + height; 

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }


        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Xml dosyasının içinde kullanıcı girişini hatırlamasını istiyorsak onları tutabiliriz.. 
            //Tuttuğumuz değerleri silmek içinse burayı kullanabiliriz..

            DialogResult dr = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {

                DegerDegistir(0);
                LoginEkrani loginEkrani = new LoginEkrani();
                loginEkrani.Show();
                this.Hide();
                
            }

        }

        //Xml'e girilen kullanıcılar etiketindeki loginMi attribute'unun değerini girilen değer yapan fonksiyon..
        public void DegerDegistir(int deger)
        {
            xmlDoc.Load("kullanicilar.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//Kullanicilar/kullanici");
            foreach (XmlNode userNode in userNodes)
            {
                userNode.Attributes["loginMi"].Value = deger.ToString();
            }

            xmlDoc.Save("kullanicilar.xml");

        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new IletisimBilgileriEkrani(), 20, 67);
        }

        private void FilmTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FilmTanimlama(), 20, 67);
        }

        private void FilmTurleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm(new FilmTurleri(), 20, 67);
        }

        private void MusteriTanimlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new MusteriTanimla(), 21,67);
        }

        private void FilmSatisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FilmSatis(),20,67);
        }

        private void satisSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new satisSorgulama(),20,67);
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            ChildForm(new GirisEkrani(), 22, 67);
        }



        // X butonuna basıldığı zaman programı sonlandırır..
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }
    }
}
