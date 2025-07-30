using DevDemoEntities;
using Microsoft.EntityFrameworkCore;

namespace DevDemoData
{
    public class ContextoBaseDatos : DbContext
    {
        public ContextoBaseDatos(DbContextOptions<ContextoBaseDatos> options) : base(options)
        {
        }

        public DbSet<Tipo> Tipos { get; set; }
    }
}
