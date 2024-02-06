using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.KonzolnaAplikacijaKuharica.Model
{
    internal class Recepti:Entitet
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; }
        public float Autor { get; set; }
        public float Opis { get; set; }

    }
}
