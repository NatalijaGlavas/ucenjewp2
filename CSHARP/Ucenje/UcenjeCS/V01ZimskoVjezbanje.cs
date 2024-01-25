using System.Security.Cryptography.X509Certificates;

namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()
        {
          // Ispisivanje brojeva od 1 do 100
          for (int broj =1; broj <=100; broj++)
            {
                Console.WriteLine(broj);
            }

           // Ispisivanje brojeva od 100 do 1
           for (int broj =100; broj >=1; broj --)
            {
                Console.WriteLine(broj);
            }

           // Ispisivanje brojeva od 1 do 100 koji su djelivi s 7
           for (int broj =1; broj < 100; broj++)
            {
                if (broj % 7 == 0)
                {
                    Console.WriteLine(broj);
                }

                // Unesi brojeve sve dok ne uneseš veći od 100, a zatim ispiši koliko
                // je bilo pokušaja unosa
                int brojPokusaja = 0;
                int uneseniBroj;

                do
                {
                    Console.WriteLine("Unesite broj");
                    uneseniBroj = int.Parse(Console.ReadLine());
                }
                while (uneseniBroj <= 100);

                Console.WriteLine("Broj pokušaj unosa:" + brojPokusaja);
            }
        }
    }
}
