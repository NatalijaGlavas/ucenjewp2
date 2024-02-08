using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Delegati
{
    internal class PrimjerKoristenja1
    {
        public PrimjerKoristenja1()
        {
            var os = new ObradaSmjera();
            os.IspisSmjer(MojIspisUOvojKlasi);


           // Action<Smjer> a = new(MojIspisUOvojKlasi);
           // os.IspisSmjeraAction(new(MojIspisUOvojKlasi));

            // Ova linija je ekvivalentna gornjim dvjema linijama
            os.IspisSmjeraAction(new(MojIspisUOvojKlasi));
        }

        private void MojIspisUOvojKlasi(Smjer s)
        {
            Console.WriteLine("1 " + s.Naziv);
        }
    }
}
