using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori:ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            //vratite najmanji broj
            return int.MinValue;
        }
    }
}
