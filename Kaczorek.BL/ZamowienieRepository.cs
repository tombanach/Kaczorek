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
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowane zamówienie
            return true;
        }
    }
}
