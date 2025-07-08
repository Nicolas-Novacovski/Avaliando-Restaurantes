using Microsoft.EntityFrameworkCore;

namespace Avaliando_Restaurantes.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Restaurantes> Restaurantes { get; set; }
    }
}
