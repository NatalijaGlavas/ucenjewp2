using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CiklicnaMatrica
    {
        public static void Izvedi()
        {
            // Definiraj dimenzije matrice
            int redovi = 5;
            int stupci = 5;

            int[,] matrica = new int[redovi, stupci];
            int brojac = 1;

            //Pocetne pozicije za popunjavanje matrice
            int red = 0, stupac = 0;
            int brojPoteza = 0;

            //Stvaranje ciklicne matrice
            while(brojac <= redovi * stupci)
            {
                //Popuni dolje
                for (; red < redovi - brojPoteza; red++)
                    matrica[red, stupac] = brojac++;

                red--;
                stupac++;

                //Popuni lijevo
                for (; stupac < stupci - brojPoteza; stupac++)
                    matrica[red, stupac] = brojac++;

                stupac --;
                red--;

                //Popuni gore
                for (; red >= brojPoteza; red--)
                    matrica[red, stupac] = brojac++;

                red++;
                stupac--;

                //Popuni desno
                for (;stupac >= brojPoteza + 1; stupac --)
                    matrica[red, stupac]= brojac ++;

                brojPoteza++;
                stupac++;
                red++;
            } 
            //Ispisivanje ciklicne matrice
            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
