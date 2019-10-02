using Microsoft.VisualStudio.TestTools.UnitTesting;
using StokTakipProgrami;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipProgrami.Tests
{
    [TestClass()]
    public class cFilmTests
    {
        [TestMethod()]
        public void FilmKontrolTest()
        {
            cFilm kontrolDegeri = new cFilm();

            //İlgili film veri tabanında olup olmadığını döndüren kontrol fonksiyonu..
            //Girilen ilgili film ve yönetmeni isteğe göre veritabanındaki değerlerle değiştirilebilir..
            bool sonuc = kontrolDegeri.FilmKontrol("Karayip Korsanları", "Rob Marshall");

            Assert.IsTrue(sonuc);


        }
    }
}