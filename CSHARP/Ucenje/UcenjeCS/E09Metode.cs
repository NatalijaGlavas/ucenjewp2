namespace UcenjeCS
{
    internal class E09Metode
    {
        public static void Izvedi()
        {
            // do OOP-a sve metode će biti static u ovom projektu UcenjeCS
            // POZIV METODE
            Tip1();
            Tip2(3, 23);
            // Ključna riječ var uzima tip podataka s desne strane
            var Ime = ImeRačunala(); // tip 3
            Console.WriteLine(Ime);
            //bolje
            Console.WriteLine(ImeRačunala());

            Console.WriteLine(IsPrimBroj(1200000) ? "PRIM" : "NIJE");

            //Zadatak: ispiši sve prim brojeve i između dva broja
            SviPrimBrojevi(27, 99);

        }
        private static void SviPrimBrojevi(int Od, int Do)
        {
            for(int i = Od; i < Do; i++)
            {
                if (IsPrimBroj(i))
                {

                }
                Console.WriteLine(i);
            }
        }

        // 1. vrsta tipa void, ne prima vrijednost, prima praznu listu parametara
        static void Tip1()
        {
            Console.WriteLine("Hello iz tip1");
        }

        // 2. vrsta tipa void, prima parametre

        static void Tip2(int Od, int Do)
        {
            // ispišite se brojeve između dva parametra
            for(int i = Od; i <= Do; i++)
            {
                if(i%2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }

        // 3. vrsta je određenog tipa koi vraća pozivatelju i neprima parametre
        static string ImeRačunala()
        {
            return System.Net.Dns.GetHostName();
        }

        // 4.vrsta -najkorisnija- određenog tipa koji vraca pozivatelju i prima parametre
        
        static bool IsPrimBroj(int Broj)
        {
            for(int i =2; i < Broj; i++)
            {
                if(Broj % i == 0)
                {
                    return false;// shotcuircuting
                }
            }




            return true;
        }
    }
}
