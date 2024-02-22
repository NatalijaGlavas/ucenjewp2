using EdunovaAPP.Data;
using EdunovaAPP.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace EdunovaAPP.Controllers
{
    /// <summary>
    /// Namjenjeno za CRUD operacije nad Entitetom smjr u bazi
    /// </summary>
    [ApiController]
    [Route("api/v1[controller]")]
    public class SmjerController : ControllerBase
    {
        /// <summary>
        /// Kontest za rad bazom koji će biti postavljen s pomoću Dependecy Injection-om
        /// </summary>
        private readonly EdunovaContext _context;
        /// <summary>
        /// Konstruktor klase koji prima Edunova kontext
        /// pomoću ID principa
        /// </summary>
        /// <param name="context"></param>
        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Dohvaća sve smjerove iz base
        /// </summary>
        /// <remarks>
        /// Primjer upita
        /// 
        /// GRT api/v1/Smjer
        /// 
        /// </remarks>
        /// <returns>Smjerovi u basi</returns>
        /// <response cod="200">Sve OK, ako nema podataka content-length: 0 </response>
        /// <response cod="400">Zahtjev nije valjan</response>
        /// <response cod="503">Baza na koju se spajam nije dostupna</response>
        [HttpGet]
        public IActionResult Get()
        {
            // kontrola ukoliko upit nije valjan
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var smjerovi = _context.Smjerovi.ToList();
                if (smjerovi == null || smjerovi.Count == 0)
                {
                    return new EmptyResult();
                }
                return new JsonResult(smjerovi);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }


        }
        /// <summary>
        /// Dodaje novi smjer u bazu
        /// </summary>
        /// <remarks>
        ///    POST api/vi/Smjer
        ///    {naziv: "Primjer naziva"}
        ///    </remarks>
        ///    <param name="smjer">Smjer za unjeti u JSON formatu</param>
        ///    <response code"201">Kreirano</response>
        ///    <response code"400">Zahtjev nije valjan(BadRequest)</response>
        ///    <response code"503">Baza nedostupna iz razno raznih razloga</response>
        /// <returns>Smjer s šifrom koju je dala basa</returns>
        [HttpPost]

        public IActionResult Post(Smjer smjer)
        {
            if (!ModelState.IsValid || smjer == null)
            {
                return BadRequest();
            }
            try
            {
                _context.Smjerovi.Add(smjer);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created);
              

            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }
        }
        /// <summary>
        /// Mjenja podatke postojećeg smjera u bazi
        /// </summary>
        /// <remarks>
        /// Primjer upita:
        /// 
        /// Put api/v1/smjer/1
        /// 
        /// {
        ///  "sifra":0,
        ///  "naziv":"Novi naziv",
        ///  "trajannje" : 120,
        ///  "cijena": 890.22,
        ///  "upisnina": 0,
        ///  "verificiran": true
        ///  }
        ///  </remarks>
        /// <param name="sifra">Šifra smjera koji se mjenja</param>
        /// <param name="smjer">Smjer za unjeti u JSON formatu</param>
        /// <returns>Svi poslani podaci od smjera koji su spremljeni u bazi</returns>
        /// <response code= "200">Sve je u redu</response>
        /// <response code= "204">Nema u bazi smjera kojeg želimo promjeniti</response>
        /// <response code= "415">Nismo poslali JSON</response>
        /// <response code= "503">Baza nedostupna</response>
        [HttpPut]
        [Route("{sifra:int}")]
        public IActionResult Put(int sifra, Smjer smjer)
        {
            if (sifra <= 0 || !ModelState.IsValid || smjer == null)
            {
                return BadRequest();
            }
            try
            {
                var smjerIzBase = _context.Smjerovi.Find(sifra);

                if (smjerIzBase == null)
                {
                    return StatusCode(StatusCodes.Status204NoContent, sifra);
                }


                // inače ovo rade maperi
                // zasad ručno
                smjerIzBase.Naziv = smjer.Naziv;
                smjerIzBase.Trajanje = smjer.Trajanje;
                smjerIzBase.Cijena = smjer.Cijena;
                smjerIzBase.Upisnina = smjer.Upisnina;
                smjerIzBase.Vereficiran = smjer.Vereficiran;

                _context.Smjerovi.Update(smjerIzBase);
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, smjerIzBase);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }
        }
        /// <summary>
        /// Briše smjer iz baze
        /// </summary>
        /// <remarks>
        /// Primjer upita:
        /// 
        ///  DELETE api/v1/smjer/1
        ///  
        /// </remarks>
        /// <param name="sifra">Šifra smjera koji se briše</param>
        /// <returns>Odgovor dali je brisano ili ne</returns>
        /// <response code="200">Sve je u redu, obrisano je u basi</response>
        /// <response code="204">nema u bazi smjera kojeg zelimo obrisati</response>
        /// <response code="503">Problem s basom</response>
        [HttpDelete]
        [Route("{sifra:int}")]
        [Produces("applicacion/jonson")]
        public IActionResult Delete(int sifra)
        {
            if (!ModelState.IsValid || sifra <= 0)
            {
                return BadRequest();
            }
            try
            {
                var smjerIzbase = _context.Smjerovi.Find(sifra);

                if (smjerIzbase == null)
                {
                    return StatusCode(StatusCodes.Status204NoContent, sifra);
                }
                _context.Smjerovi.Remove(smjerIzbase);
                _context.SaveChanges();

                return new JsonResult("{\"poruka\":\"Obrisano\"}");//ovo nije baš najbolja praksa ali da znate kako i to može
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }
        }

    }
}
