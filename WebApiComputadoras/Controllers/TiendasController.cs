using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApicomputadoras.BD;
using WebApicomputadoras.Migrations;

namespace WebApicomputadoras.Controllers
{
    [ApiController]
    [Route("api/tiendas")]
    public class TiendasController: ControllerBase
    {
        private readonly AplicationBDContext DbContext;
        public TiendasController (AplicationBDContext context)
        {
            this.DbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tiendas>>> GetAll()
        {
            return await DbContext.Tiendas.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Tiendas>> GetById(int id)
        {
            return await DbContext.Tiendas.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Tiendas tienda)
        {
            var existeTienda = await DbContext.Tiendas.AnyAsync(x => x.Id == tienda.Id);
            if(!existeTienda) 
            {
                return BadRequest($"No existe la tienda con el id:{tienda.Id}");
            }

            DbContext.Add(tienda);
            await DbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Tiendas tienda, int id)
        {
            var existeTienda = await DbContext.Tiendas.AnyAsync(x =>x.Id == id);
            if (!existeTienda)
            {
                return NotFound("La tienda esepecificada no existe.  ");
            }

            if(tienda.Id != id)
            {
                return BadRequest("El id de la tienda no coincide con el establecido en la url");
            }
            DbContext.Update(tienda);
            await DbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existeTienda = await DbContext.Tiendas.AnyAsync(x => x.Id == id);
            if(!existeTienda) 
            {
                return NotFound("El recurso no fue encontrado");
            }

            DbContext.Remove(new Tiendas { Id = id});
            await DbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
