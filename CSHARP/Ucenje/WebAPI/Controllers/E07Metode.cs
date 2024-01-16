using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E07")]
    public class E07Metode : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int PrviBroj, int DrugiBroj)
        {

            // Napiši metodu koja za dva primljena cijela
            // broj vraća njihov zbroj
            // Neka ova metoda Zad1 vrati rezultat napisane metode zadatka
            return Zbroji(PrviBroj, DrugiBroj);

        }

        private int Zbroji(int prviBroj, int drugiBroj)
        {
            return prviBroj + drugiBroj;
        }
        [HttpGet]
        [Route("zad2")]
        // Kreirati rutu zad koja prima 4 cijela broja
        // i vraća razliku prvi+drugi i treći+četvrti
        // koristite kreiranu metodu za zbroj dvaju brojeva

        [HttpGet]
        [Route("zad2")]

        private int Zad2(int PrviBroj, int DrugiBroj, int TreciBroj, int CetvrtiBroj)
        {
            
            return Zbroji(PrviBroj,DrugiBroj)-Zbroji(TreciBroj,CetvrtiBroj);
        }
        // Kreirati rutu zad3 koja prima ime grada i slovo.
        // Ruta vraća broj pojavljivanja slova u primljenom imenu grada
        // koristi metode

        private int Brojac (string Grad, string Slovo)
        {
            int Ukupno = 0;
            foreach (char c in Grad)
            {
                
                if(c == Slovo[0])
                {
                  Ukupno ++;
                }
                return 2;
            }
        }

        [HttpGet]
        [Route("zad3")]

        public int Zad3(string Grad, string Slovo)
        {
            return Brojac(Grad, Slovo);
        }


    }
        





    }

