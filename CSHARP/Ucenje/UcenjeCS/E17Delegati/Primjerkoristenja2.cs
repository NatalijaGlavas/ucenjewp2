using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Delegati
{
    internal class Primjerkoristenja2
    {
        public Primjerkoristenja2()
        {
            var os = new ObradaSmjera();
            os.IspisSmjer(NijeBitno);
        }

        private void NijeBitno(Smjer s)
        {
            Console.WriteLine("2 " + s.Naziv);
        }
    }
}
