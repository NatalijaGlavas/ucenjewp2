using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E01")]
    public class E01UlazIzlaz : ControllerBase
    {
       

        [HttpGet]
        [Route("Hello")]
        public String Helloworld(string Ime, int Godine, bool aktivan)
        {
            return " Upisali ste" + Ime + " koji ima " + Godine + " godina " + aktivan;
        }

        [HttpGet]
        [Route("zad2")]

        public float Zad2(int i, int j )
        {
            //Ruta vra?a kvocijent dvaju primljenih brojeva 
            return 0; // Ovo ne valja, DZ

        }
        [HttpGet]
        [Route("zad3")]

        public float Zad3(int i, int j)
        {
            //Ruta vra?a zbroj umnožaka i kvocijenta primljenih brojeva

            var umnozak = i * j; // var je klju?na rije? koja preuzima tip podataka s desne strane znaka =
            var kvocijent = (float)i / j;
            return umnozak + kvocijent;
            

        }
        [HttpGet]
        [Route("zad4")]

        public string Zad4(string s , string s1)
        {
            //Ruta vra?a spojene primljene znakove
            return s + s1;
        }

        [HttpGet]
        [Route("zad5")]
        public bool IstiSu(int a, int b)
        {
            Console.WriteLine("a ={0}", a); //pogledati u konzoli
            //Ruta vra?a True ako je a jednako b, ina?e vra?a False
            return a == b;
        }

    }
}