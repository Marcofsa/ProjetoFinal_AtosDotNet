using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal_AtosDotNet.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<Biblioteca> biblioteca { get; set; }
        

    }
}
