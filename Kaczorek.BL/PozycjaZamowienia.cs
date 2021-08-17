namespace Kaczorek.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        // Metody
        /// <summary>
        /// Sprawdza dane pozycji zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (Ilosc <= 0)
                poprawne = false;
            if (ProduktId <= 0)
                poprawne = false;
            if (CenaZakupu == 0)
                poprawne = false;

            return poprawne;
        }

        /// <summary>
        /// Zapisuje element zamówienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowane zamówienie
            return true;
        }

        /// <summary>
        /// Pobieramy jeden element zamówienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            // Kod który pobiera określone zamowienie
            return new PozycjaZamowienia();
        }
    }
}
