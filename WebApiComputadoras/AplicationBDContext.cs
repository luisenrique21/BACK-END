using WebApiComputadora.BD;

namespace WebApiComputadora
{
    public class AplicationBDContext : DbContext
    {
        public AplicationBDContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Computadoras> Computadoras { get; set; }
    }
}
