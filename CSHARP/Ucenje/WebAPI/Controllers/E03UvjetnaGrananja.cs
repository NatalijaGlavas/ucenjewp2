﻿using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnaGrananja:ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public string Zad1(int broj)
        {
            // Za primljeni cijeli broj
            // Ruta vraća PARAN ili NEPARAN
            // ovisno kakav je primljeni broj

            //riješenje 1
            //if(broj % 2== 0)
            //{
            //    return "PARAN";
            //}

            //else
            //{
            //    return "NEPARAN";
            //}



            //riješenje 2
            //if(broj % 2==0)
            //{
            //    return "PARAN";
            //}
            //return "NPARAN";

            //riješenje 3
            //return broj%2 ==0 ? "PARAN" : "NEPARAN";

            // riješenje 4
            return (broj % 2 != 0 ? "NE" : "") + "PARAN";
            
        }
        [HttpGet]
        [Route("zad2")]

        public string ocijenaTekstom(int ocijena)
        {
            //Za primljenu brojčanu vrijednost ocijene
            // vratiti tekstualni reprezenten
            switch (ocijena)
            {
                case 1:
                    return "Nedovoljan";
                case 2:
                    return "Dovoljan";
                case 3:
                    return "Dobar";
                case 4:
                    return "Vrlo dobar";
                case 5:
                    return "Odličan";

            }
            return $"{ocijena} nije ocijena";
        }

        
    }
}
