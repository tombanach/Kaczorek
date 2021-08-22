using Common;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CommonTest
{
    [TestClass]
    public class UslugaLogowanieTest
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            // Arrange
            var zmienioneElementy = new List<ILogowanie>();
            var klient = new Klient(1)
            {
                Email = "admin@dev-hobby.pl",
                Imie = "Mariusz",
                Nazwisko = "Nowak",
                ListaAdresow = null
            };

            zmienioneElementy.Add(klient as ILogowanie);


            var produkt = new Produkt(5)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki do zabawy",
                AktualnaCena = 100M
            };

            zmienioneElementy.Add(produkt as ILogowanie);


            var zamowienie = new Zamowienie(20)
            {
                DataZamowienia = new DateTime(2018, 9, 12, 11, 00, 00)
            };

            zmienioneElementy.Add(zamowienie as ILogowanie);

            // Act
            UslugaLogowanie.PiszDoPliku(zmienioneElementy);

            // Assert
        }
    }
}
