using Microsoft.AspNetCore.Mvc;
using WebApiComputadora.BD;

namespace WebApiComputadora.Controllers
{
    [ApiController]
    [Route("api/computadoras")]
    public class ComputadorasController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Computadoras>> Get() 
        {
            return new List<Computadoras>()
            {
                new Computadoras { Id=1, Nombre= "PC GAMER MASTER RACE"},
                new Computadoras {Id=2, Nombre= "PC ASUS VIVOBOOK S15"}
            };
        }
    }
}
