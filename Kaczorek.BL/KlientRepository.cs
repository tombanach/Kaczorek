using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class KlientRepository
    {      
        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            // Tworzymy instancję klasy klienta
            Klient klient = new Klient(klientId);

            // Kod który pobiera określonego klienta

            // Tymczasowo zakodowane wartości, aby zwrócić klienta
            if (klientId == 1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Kowal";
            }

            return klient;
        }

        /// <summary>
        /// Pobieramy wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            // Kod który pobiera wszystkich klientów
            return new List<Klient>();
        }

        /// <summary>
        /// Zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowanego klienta
            return true;
        }
    }
}
