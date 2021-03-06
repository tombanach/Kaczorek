using Common;
using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Produkt : KlasaBazowa, ILogowanie
    {
        #region Konstruktory

        public Produkt()
        {

        }

        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        #endregion
        #region Właściwości

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }

        private string _NazwaProduktu;
        public string NazwaProduktu
        {
            get
            {
                return _NazwaProduktu.WstawSpacje();
            }
            set { _NazwaProduktu = value; }
        }

        #endregion
        #region Metody

        // Metody
        /// <summary>
        /// Sprawdza dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            if (AktualnaCena == null)
                poprawne = false;

            return poprawne;
        }

        /// <summary>
        /// Zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowany produkt
            return true;
        }

        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // Kod który pobiera określony produkt
            return new Produkt();
        }

        /// <summary>
        /// Pobieramy wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            // Kod który pobiera wszystkich klientów
            return new List<Produkt>();
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }

        public string Log()
        {
            var log = ProduktId + ": " +
                NazwaProduktu + " " +
                "Opis: " + Opis + " " +
                "Status: " + StanObiektu.ToString();

            return log;
        }

        #endregion
    }
}
