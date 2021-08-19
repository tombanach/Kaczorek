using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Zamowienie : KlasaBazowa
    {
        #region Konstruktor

        public Zamowienie()
        {

        }

        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        #endregion
        #region Właściwości

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> pozycjaZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }

        #endregion
        #region Metody

        // Metody
        /// <summary>
        /// Sprawdza dane zamówienia
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (DataZamowienia == null)
                poprawne = false;

            return poprawne;
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

        /// <summary>
        /// Pobieramy jedno zamówienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // Kod który pobiera określone zamowienie
            return new Zamowienie();
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

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }

        #endregion
    }
}
