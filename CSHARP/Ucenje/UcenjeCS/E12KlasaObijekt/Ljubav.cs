using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObijekt
{
    internal class Ljubav
    {
        public string PrvoIme { get; set; }
        public string DrugoIme2 { get; set; }

        // Ovo je konstruktor - 5. vrsta metode
        public Ljubav() {
        // ovdje se dolazi kada se izvodi ključna riječ new
        }

        public Ljubav(string prvoIme, string drugoIme2)
        {
            PrvoIme = prvoIme;
            DrugoIme2 = drugoIme2;
        }

        public string Rezultat()
        {
            return Izracunaj(SlovaUNiz(PrvoIme+DrugoIme2)) + " %";
        }
        private int[] SlovaUNiz(string Imena)
        {
            // fiksno
            return new int[2];
        }
        private int Izracunaj(int[] Brojevi)
        {
            // ovo je sad fiksno, tu dolazi rekurzivni algoritam
            return 67;
        }
    }
}
