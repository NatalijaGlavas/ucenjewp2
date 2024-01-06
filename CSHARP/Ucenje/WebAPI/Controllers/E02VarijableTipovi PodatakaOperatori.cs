using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipovi_PodatakaOperatori :ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        
        public int zad1()
        {
            //vratite najmanji broj
            return int.MinValue;
        }
    }
}
