namespace UcenjeCS
{
    internal class E07DoWhilePetlja
    {
        public static void Izvedi()
        {

            // dali se u for i while mora ući? NE
            // Ako uvjet na početku nije zadovoljen ne ulazi se

            // do while osigurava minimalno jedno izvođenje
            // uvjet je na kraju petlja

            do
            {
                Console.WriteLine("Edunova");
            } while (false);

            // continue, break i ugnježđivanje isto kao kod for i while petlje


            // Prekidanje vanjske petlje

            for (; ; )
            {
                while (true)
                {
                    do
                    {
                        //break;// 1
                        // Kako prekinuti vanjski for
                        goto nakonfora;
                    } while (true);
                    // ovdje se nastavlja 1
                    //break; //2
                }
                // ovdje se nastavlja 2
            }
            nakonfora:// ovo je labela
            Console.WriteLine("odradio");

        }

    }
}
