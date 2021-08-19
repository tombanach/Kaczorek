using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ProduktRepository
    {
        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // Tworzenie instancji produktu
            Produkt produkt = new Produkt(produktId);
            Object mojObiekt = new Object();
            Console.WriteLine("Obiekt: " + mojObiekt.ToString());
            Console.WriteLine("Produkt :" + produkt.ToString());

            // Kod który pobiera określony produkt

            // Tymczasoso zakodowane wartości, aby zwrócić produkt
            if (produktId == 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci";
                produkt.AktualnaCena = 89.99M;
            }

            return produkt;
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

        /// <summary>
        /// Zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Produkt produkt)
        {
            // Kod który zapisuje zdefiniowany produkt
            var sukces = true;

            if (produkt.MaZmiany && produkt.DanePrawidlowe)
            {
                if (produkt.JestNowy)
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
    }
}
