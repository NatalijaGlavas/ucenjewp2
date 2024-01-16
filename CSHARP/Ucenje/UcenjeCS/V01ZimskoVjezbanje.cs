using System.Security.Cryptography.X509Certificates;

namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()
        {
            //zad1
            //Napisati program koji ispisuje sve brojeve od 1 do 100

            Console.WriteLine("------------- od 1 do 100 ------------");
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + ": " + (i + 1));
            }

            // 2.Napisati program koji ispisuje sve brojeve od 100 do 1

            Console.WriteLine("-------------- od 100 do 1");
            for(int i=100; i >  0; i--)
            {
                Console.WriteLine(i + " ");
            }


        }
           //3. Napisati program koji ispisuje sve brojeve od 1 do 100 koji su cijelobrojno djelivi s 7
        public static void Ispisi1Do100DjeljiviSa7()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }

                // 4.Napisati program koji unosi brojeve sve dok ne unese broj veći
                // od 100 a zatim ispisuje upisuje kojiko je bilo pokušaja  unosa

                int Broj;
                for (int Brojac = 1; ;)
                {
                    Console.WriteLine("Unesi broj veci od 100: ");
                    Broj = int.Parse(Console.ReadLine());
                    if(Broj < 101)
                    {
                        Brojac++;
                        Console.WriteLine("Krivi unos");
                        continue;
                    }
                    else
                    {
                      Console.WriteLine($"Unjeli ste:{Broj} iz {Brojac}. pokušaja");
                        Brojac = 1;
                    }
                    continue;
                }

              

                 
            }
        }
    }
}
