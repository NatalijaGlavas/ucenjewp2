using System.Runtime.CompilerServices;

namespace UcenjeCS
{
    internal class E03UvjetnaGrananja
    {
        public static void Izvedi()
        {
            int i = 7; // Namjrno ne radim čitanje iz Conzole kako bi dobili na vremenu

            // Binarno geananje

            bool uvjet = i == 7;


            // uvjet ima vrijednost true
            if (uvjet)
            {
                Console.WriteLine( $" broj je {i},ušli smo u true dio if naredbe");
            }

            // ovo gore i sljedeće je minimalni dio if naredbe
            // inače se u pravilu ovakko piše
            if ( i == 7 )
            {
                Console.WriteLine(" isti uvjet kao i prethodno");
            }

            // drugi dio if nardbe ( neobavezni ) je else 

            if ( i < 5)
            {
                Console.WriteLine(" i je manje od 5 ");
            } 
            else
            {
                Console.WriteLine(" i nije manje od 5 ");
            }


            // puni izgled if naredbe

            if ( i == 2 )
            {
                Console.WriteLine(" i je 2");
            } else if ( i == 3 )
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.WriteLine(" i nije 2 niti je 3 ");
            }

            int j = 2;
            if ( j == 7)
            {
                if ( i == 2)
                {
                    Console.WriteLine(" Oba uvjeta su zadovoljena ugnježđeno ");
                } 
            }

            // korištenje logičkih operatora
            // logičko & i uvjetovano &&
            i = 4;
            if ( i== 7 & j == 2)
            {
                Console.WriteLine(" Oba uvjeta su zadovoljena ");
            }
            // provjeravaju se oba uvjeta bez obzira ako se na prvom padne (false)

            if( i == 7 && j == 2)
            {
                Console.WriteLine(" Oba uvjeta su zadovoljena ");
            }

            // && ukoliko padne (flase) na prvom uvjetu ne provjeravas se drugi


            // logičko | i uvjetovano ||

            if ( i ==5 | j== 1)
            {
                Console.WriteLine("Dovoljno je da jedan od uvjeta bude zadovoljen");
            }
            // | provjerava oba uvjeta bez obzira ako je prvi prošao (true)

            if(i == 5 || j== 1)
            {
                Console.WriteLine("Prvi uvjet zadovoljen drugi se ne provjerava");
            }
            // || Ukoliko prvi uvjet prođe (true) drugi se ne provjerava

            // Logičko Ne (!)
            if ( (i==5 || j==1) && !(i>5 || j < 8))
            {
                Console.WriteLine("Kompicirani izraz");
            }

            // skraćeni način pisanja: inline if

            //Program upisuje cijeli broj
            //Ako je broj veći ispisuje Osijek
            //Inače ispisuje Zagreb
            Console.Write("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj > 10)
            {
                Console.WriteLine("Osijek");
            }
            else
            {
                Console.WriteLine("Zagreb");
            }
            // u slučaju istog ponašanja s različitim vrijednostima u if i else dijelu
            //možemo pisati kraće

            //inline if
            Console.WriteLine(i > 10 ? "Osijek" : "Zagreb");

            //višestruko grananje
            int ocijena = 4;

            switch(ocijena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                    case 2:
                    case 3:
                    Console.WriteLine("Dovoljno ili dobro");
                    break;
                    case 4: case 5:
                    Console.WriteLine("to je ocijena");
                    break;
                default:
                    Console.WriteLine("Nije ocijena");
                    break;
            }

            string Ime = "Pero";
            switch (Ime)
            {
                case "Marko":
                    Console.WriteLine("OK");
                    break;
                case "Pero":
                    Console.WriteLine("Super");
                    break;

            }
        }
    }
}
