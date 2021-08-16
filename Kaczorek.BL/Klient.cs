﻿namespace Kaczorek.BL
{
    public class Klient
    {
        private string _nazwisko;

        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }
        public string Email { get; set; }
        public int KlientId { get; private set; }
        public string ImieNazwisko
        {
            get
            {
                return Imie + "," + Nazwisko;
            }
        }

    }
}
