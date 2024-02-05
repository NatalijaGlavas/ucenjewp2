﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KonzolnaAplikacija
{
    internal class Pomocno
    {
        public static int UcitajInt(string poruka)
        {
            for (; ; )
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
                
                
            }
            
        }
        public static string ucitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine();
                if(s.Trim().Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }
        }
    }
}
