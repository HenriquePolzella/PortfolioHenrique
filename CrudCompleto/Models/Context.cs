using Microsoft.EntityFrameworkCore;

namespace CrudWeb.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options) :base (options) 
        { 

        }

        public DbSet<Contato> Contato { get; set; }

        public DbSet<Assunto> Assunto { get; set; }
      
    }
}
