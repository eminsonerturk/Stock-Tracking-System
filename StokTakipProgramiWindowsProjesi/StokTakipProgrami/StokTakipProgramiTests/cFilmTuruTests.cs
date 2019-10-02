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
    public class cFilmTuruTests
    {
        [TestMethod()]
        public void FilmTuruKontrolTest()
        {
            cFilmTuru filmTuruTestDegeri = new cFilmTuru();

            //İlgili film türünün Database de olduğu bilindiğinden dolayı true döndürmesi gerekmektedir..
            //Film türü değiştirilerek sonuçlar değiştirilebilir..
            bool testDegeri = filmTuruTestDegeri.FilmTuruKontrol("Savaş");

            Assert.IsTrue(testDegeri);
        }
    }
}