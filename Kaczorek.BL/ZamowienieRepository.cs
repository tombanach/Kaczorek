using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ZamowienieRepository
    {
        /// <summary>
        /// Pobieramy jedno zamówienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            // Kod który pobiera określone zamowienie

            // tymczasowo zakodowane wartości zamowienia
            if (zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }

            return zamowienie;
        }

        /// <summary>
        /// Pobieramy wszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            // Kod który pobiera wszystkie zamowienia
            return new List<Zamowienie>();
        }

        /// <summary>
        /// Zapisuje zamówienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Zamowienie zamowienie)
        {
            // Kod który zapisuje zdefiniowany produkt
            var sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DanePrawidlowe)
            {
                if (zamowienie.JestNowy)
                {
                    // insert
                }
                else
                {
                    // update
                }
            }

            return sukces;
        }

        /// <summary>
        /// Pobieramy jedno zamowienie do wyświetlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            // Kod który pobiera zdefiniowane pola zamówienia

            // Tymczasowe dane zakodowane na stałe
            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "Jacek";
                wyswietlanieZamowienia.Nazwisko = "Kowal";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018, 5, 21, 12, 00, 00, new TimeSpan(5, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 2,
                    Ulica = "Mila",
                    Miasto = "Katowice",
                    Kraj = "Polska",
                    KodPocztowy = "44-400"
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();

                // Kod ktory pobiera elementy zamowienia

                // Tymczasowe dane zakodowane na stałe
                if (zamowienieId == 10)
                {
                    var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stol",
                        CenaZakupu = 300.50M,
                        Ilosc = 10
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                    wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Blat",
                        CenaZakupu = 50.33M,
                        Ilosc = 5
                    };
                    wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
                }
            }

            return wyswietlanieZamowienia;
        }
    }
}
