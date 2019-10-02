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
    public class cMusteriTests
    {
        [TestMethod()]
        public void MusteriKontrolTest()
        {
            cMusteri musteriUnitTest = new cMusteri();

            //İlgili müşterinin veritabanında olduğu bilinmektedir.
            //Buna göre fonksiyon true değerini döndürmektedir.
            //İlgili ad ve soyad değiştirilerek sonuçlar değiştirilebilir..
            bool sonucTestDegeri = musteriUnitTest.MusteriKontrol("Vedat", "Kaya");

            Assert.IsTrue(sonucTestDegeri);
        }
    }
}