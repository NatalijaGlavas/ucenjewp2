﻿namespace UcenjeCS
{
    internal class E04Nizovi
    {
        public static void Izvedi()
        {
            // kreirao sam niz s 12 elemenata
            int[] Temperature = new int[12];
            //prvi element niza je na indeksu 0
            //sječanj
            Temperature[0] = 2;
            //veljača
            Temperature[1] = 1;
            //... idu ostali mjeseci
            //prosinac
            Temperature[11] = 7;

            Console.WriteLine(Temperature);
            Console.WriteLine(string. Join(",",Temperature));

            //višedimenzionalni nizovi

            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            //ispisati broj 5
            Console.WriteLine(tablica[1,1]);
            //ispisati broj 9
            Console.WriteLine(tablica[2,2]);

            // trodimenzionalni niz - kocka
            int[,,] Kocka;

            //zvjezdane staze

            int[,,,,,] ZvjezdaneStaze;
        }
    }
}
