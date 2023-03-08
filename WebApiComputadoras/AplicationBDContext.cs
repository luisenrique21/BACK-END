using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebApicomputadoras.BD;

namespace WebApicomputadoras
{
    public class AplicationBDContext: DbContext
    {
        public AplicationBDContext(DbContextOptions options): base(options) { 
        
        }

        public DbSet<Computadoras> Computadoras { get; set; }
        public DbSet<Tiendas> Tiendas { get; set; }

    }
}
