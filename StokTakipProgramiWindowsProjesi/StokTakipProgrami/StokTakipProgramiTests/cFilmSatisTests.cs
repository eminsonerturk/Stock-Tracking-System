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
    public class cFilmSatisTests
    {
        [TestMethod()]
        public void SatislariGetirByTarihlerArasiTest()
        {

            DateTime ilkTarih = new DateTime(2017, 12, 01);
            DateTime ikinciTarih = new DateTime(2017, 12, 20);

            cFilmSatis filmSatisUnitKontrol = new cFilmSatis();

            // İlgili tarihler arasında gelen sonuçların olduğu biliniyor ve bu sonuçların gelmesi true olmaktadır.
            // İsteğe göre tarih değiştirilerek sonuç gözlenebilir..
            bool testDegeri = filmSatisUnitKontrol.SatislariGetirByTarihlerArasiTestFunction(ilkTarih, ikinciTarih);

            Assert.IsTrue(testDegeri);


        }
    }
}