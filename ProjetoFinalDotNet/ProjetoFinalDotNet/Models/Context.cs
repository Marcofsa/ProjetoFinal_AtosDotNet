using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalDotNet.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }
        public DbSet<Biblioteca> Biblioteca { get; set; }
    }
}
