using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KonzolnaAplikacija.Model;

namespace UcenjeCS.E12KlasaObijekt.Edunova
{
    //POCO klasa
    internal class Smjer
    {
        public int Sifra { get; set; }
        public string Naziv {  get; set; }
        public int BrojSati { get; set; }
        public float Cijena { get; set; }
        public float Upisnina { get; set; }
        public bool Vereficiran { get; set; }




    }
}
