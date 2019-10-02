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
    public partial class LoginEkrani : Form
    {
        public LoginEkrani()
        {
           
                InitializeComponent();
        }

        //Xml dosyasını oluşturma işlemi yapıldı..
        XmlDocument xmlDoc = new XmlDocument();
        int bayrak = 0;

        private void girisButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(kullaniciAdi.Text) ||String.IsNullOrEmpty(sifre.Text))
            {
               MessageBox.Show("Kullanıcı adı veya şifre bölümü boş bırakılamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(kullaniciAdi.Text != "admin")
            {
                MessageBox.Show("Kullanıcı adı hatalı girildi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (sifre.Text != "1234")
            {
                MessageBox.Show("Şifre hatalı girildi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(kullaniciAdi.Text == "admin" && sifre.Text == "1234")
            {
                

                //Login olduktan sonra login olduğu bilgisi xml dosyasına kaydedildi..

                if (!TablodaDegerVarMı())
                {
                    XmlNode rootNode = xmlDoc.CreateElement("Kullanicilar");
                    xmlDoc.AppendChild(rootNode);
                    createNode(kullaniciAdi.Text, rootNode);
                    xmlDoc.Save("kullanicilar.xml");
                }
                else
                {
                    DegerDegistir(1);
                }

                
                kullaniciEkrani kullaniciEkrani = new kullaniciEkrani();
                kullaniciEkrani.Show();
                bayrak = 1;
                this.Close();
                bayrak = 0;
                

            }
        }

        public void LoginEkrani_Load(object sender, EventArgs e)
        {
            //Eğer daha önce login olunmuşsa direk xml dosyasından okuduğu değerle programı açar..
            if (degerVarMi())
            {
                
                kullaniciEkrani kullaniciEkrani = new kullaniciEkrani();
                kullaniciEkrani.Show();
                bayrak = 1;
                this.Close();
                bayrak = 0;
                

            }
           
        }

        //Xml dosyasının içinde kullaniciAdi etiketi ve onun attribute'u olan loginMi değerini oluşturur..
        public void createNode(string kullaniciAdi, XmlNode rootNode)
        {
            XmlNode userNode = xmlDoc.CreateElement("kullanici");
            XmlAttribute attribute = xmlDoc.CreateAttribute("loginMi");
            attribute.Value = "1";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = kullaniciAdi;
            rootNode.AppendChild(userNode);
        }


        //Xml dosyasının içindeki loginMi değerinin 1 olup olmadığına bakan fonksiyon..
        public bool degerVarMi()
        {
            xmlDoc.Load("kullanicilar.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//Kullanicilar/kullanici");
            foreach (XmlNode userNode in userNodes)
            {
                string deneme = userNode.InnerText;
                int dogrulukDegeri = int.Parse(userNode.Attributes["loginMi"].Value);

                if (dogrulukDegeri == 1)
                    return true;
            }

            return false;
        }


        //Xml dosyasında herhangi bir değer olup olmadığını döndüren fonksiyondur..
        public bool TablodaDegerVarMı()
        {
            xmlDoc.Load("kullanicilar.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//Kullanicilar/kullanici");
            foreach (XmlNode userNode in userNodes)
            {
                string kullanici = userNode.InnerText;
                if (kullanici != "")
                    return true;
            }

            return false;
        }


        //Xml dosyasının içindeki ilgili kullanıcının loginMi attribute değerini aldığı değerler değiştiren fonksiyondur..
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


        //sağ üstteki X e basınca ve this.close(); kodunu yazınca programı sonlandıran kod..
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            if (bayrak == 0)
            {
                base.OnFormClosing(e);

                if (e.CloseReason == CloseReason.WindowsShutDown) return;

                Application.Exit();
            }
        }


    }
}
