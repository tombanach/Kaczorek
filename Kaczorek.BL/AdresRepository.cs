using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    class AdresRepository
    {
        /// <summary>
        /// Pobieramy jednen adres
        /// </summary>
        /// <param name="adresId"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            // Tworzymy instancję klasy adres i przekazujemy żądany identyfikator
            Adres adres = new Adres(adresId);

            // Kod który pobiera określony adres

            // Tymczasowo zakodowane wartości, aby zwrócić adres
            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Gościnna";
                adres.Miasto = "Katowice";
                adres.KodPocztowy = "Polska";
                adres.Kraj = "40-467";
            }

            return adres;
        }

        /// <summary>
        /// Pobieramy wszystkie zdefiniowane adresy dla klienta o przekazanym klientId
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            // Kod który pobiera zdefiniowane adresy dla klienta

            // Tymczasowo zakodowane wartości do zwrócenia, zestaw adresów
            var listaAdresow = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Adama",
                Miasto = "Opole",
                Kraj = "Polska",
                KodPocztowy = "11-100"
            };
            listaAdresow.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 3,
                Ulica = "Miła",
                Miasto = "Katowice",
                Kraj = "Polska",
                KodPocztowy = "44-400"
            };
            listaAdresow.Add(adres);

            return listaAdresow;
        }

        /// <summary>
        /// Zapisuje aktualny adres
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Kod który zapisuje zdefiniowany adres

            return true;
        }
    }
}
