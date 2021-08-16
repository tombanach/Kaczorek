using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Kaczorek.BLTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "Robert";
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Robert, Kowal";


            // Act (działaj)
            string aktualna = klient.ImieNazwisko;


            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {
            // Arrange (przygotuj test)
            Klient klient = new Klient();
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Kowal";


            // Act (działaj)
            string aktualna = klient.ImieNazwisko;


            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPusteTest()
        {
            // Arrange (przygotuj test)
            Klient klient = new Klient();
            klient.Imie = "Robert";

            string oczekiwana = "Robert";


            // Act (działaj)
            string aktualna = klient.ImieNazwisko;


            // Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange (przygotuj test)
            var kln1 = new Klient();
            kln1.Imie = "Jacek";
            Klient.Licznik += 1;

            var kln2 = new Klient();
            kln1.Imie = "Maciek";
            Klient.Licznik += 1;

            var kln3 = new Klient();
            kln1.Imie = "Irek";
            Klient.Licznik += 1;


            // Act (działaj)


            // Assert (potwierdź test)
            Assert.AreEqual(3, Klient.Licznik);
        }
    }
}
