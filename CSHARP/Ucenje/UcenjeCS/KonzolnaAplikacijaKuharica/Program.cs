using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.KonzolnaAplikacijaKuharica.Model;

namespace UcenjeCS.KonzolnaAplikacijaKuharica
{
    internal class Program
    {
        
        public Program()
        {
           
            PozdravnaPoruka();
            Izbornik();

        }

        private void Izbornik()
        {
            Console.WriteLine("Izbornik");
            Console.WriteLine("1.Rad sa autorima");
            Console.WriteLine("2.Rad sa receptima ");
            Console.WriteLine("3.Izlaz iz programa");
            OdabirStavkePocetnogIzbornika();
        }
        private void OdabirStavkePocetnogIzbornika()
        {
            //var izbor = Pomocno.UcitajInt("Unesi izbor:");
            switch (Pomocno.UcitajInt("Unesi izbor:"))
            {
                case 1:
                    Console.WriteLine("Rad s autorima");
                    IzbornikRadSAutorima();
                    break;  
                case 2:
                    Console.WriteLine("Rad s receptima");
                    break;
                case 3:
                    Console.WriteLine("Izlaz iz programa");
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    Izbornik();
                    break;
            }
        }

        private void IzbornikRadSAutorima()
        {
            Console.WriteLine("1. Prikaži sve autore");
            Console.WriteLine("2. Dodaj autora");
            Console.WriteLine("3. Uredi autora");
            Console.WriteLine("4. Izbriši autora");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.UcitajInt("Odaberi stavku izbornika"))
            {
                case 1:
                    Console.WriteLine("Prikaži sve autore");
                    break;
                case 2:
                    Console.WriteLine("Dodaj autora");
                    break;
                case 3:
                    Console.WriteLine("Uredi autora");
                    break;
                case 4:
                    Console.WriteLine("Izbriši autora");
                    break;
                case 5:
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Krivi odabir");
                    IzbornikRadSAutorima();
                    break;
            }
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("KUHARICA KONZOLNA APLIKACIJA V1");
            Console.WriteLine("*******************************");
        }
    }
}
