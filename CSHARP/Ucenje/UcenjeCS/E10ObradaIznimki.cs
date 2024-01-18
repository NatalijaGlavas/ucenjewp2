namespace UcenjeCS
{
    internal class E10ObradaIznimki
    {
        public static void Izvedi()
        {
            int pb = UcitajBroj("Unesi prvi broj: ");
            int db = UcitajBroj("Daj mi i drugi ");


            IspisiBrojeve(pb, db);

        }


        private static void IspisiBrojeve(int pb, int db)
        {
            var Manji = pb <= db ? pb : db;
            int Veci = pb >= db ? pb : db;

            for (int i = Manji; i <= Veci; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static int UcitajBroj(string v)
        {
            for (; ; )
            {
                Console.WriteLine(v);

                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {

                    Console.WriteLine("Nisi unio broj");

                }
                catch(OverflowException )
                {

                    Console.WriteLine("nešto gadno navalja");
                }

                // mogao bi još uhvatiti ArgumentNullExceptio
                catch(Exception ) // Ovdje hvatam bilo koju iznimku
                {
                    Console.WriteLine("Oooops");
                }
                finally
                {
                    Console.WriteLine("Mjesto na koje se dolazi pukao ti ili ne");
                }

            }






                //return 0;

            }
        }
    }
