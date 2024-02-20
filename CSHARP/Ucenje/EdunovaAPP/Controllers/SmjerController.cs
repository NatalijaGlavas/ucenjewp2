using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace EdunovaAPP.Controllers
{
    /// <summary>
    /// Namjenjeno za CRUD operacije nad Entitetom smjr u bazi
    /// </summary>
    [ApiController]
    [Route("api/v1[controller]")]
    public class SmjerController:ControllerBase
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
                if(smjerovi==null || smjerovi.Count == 0)
                {
                    return new EmptyResult();
                }
                return new JsonResult(smjerovi);
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, 
                    ex.Message);
            }

           
        }
       
    }
}
