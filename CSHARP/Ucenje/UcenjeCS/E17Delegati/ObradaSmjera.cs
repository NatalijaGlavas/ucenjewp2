using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Delegati
{
    internal class ObradaSmjera
    {
        public delegate void IspisPozivSmjer(Smjer s);
        private readonly List<Smjer> Smjerovi;
        public ObradaSmjera()
        {
            Smjerovi = new List<Smjer>() {
            new Smjer() {Naziv="Prvi"},
            new Smjer() {Naziv="Drugi"}
            };
        }


        public void IspisSmjer(IspisPozivSmjer poziv)
        {
            Smjerovi.ForEach(s => poziv(s));
        }

        // za ovo gore netreba delegat
        public void IspisSmjeraAction(Action<Smjer> poziv)
        {
            Smjerovi.ForEach(s => poziv(s));
        }

    }
}
