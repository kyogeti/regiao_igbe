using Microsoft.EntityFrameworkCore;

namespace RegiaoIbge.App
{
    public class IbgeContext : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\sqlite\\meso.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}