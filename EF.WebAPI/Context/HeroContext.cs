using EF.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EF.WebAPI.Context
{
    public class HeroContext : DbContext
    {
       public DbSet<Hero> Heroes { get; set; }
       public DbSet<Gun> Gunes { get; set; }
       public DbSet<Batle> Batles { get; set; }
       public DbSet<HeroBatle> HeroBatles { get; set; }
       public DbSet<SecretIdentity> SecretIdentities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = ; Integrated Security = SSPI; Initial Catalog = Hero");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroBatle>(entity =>
            {
                entity.HasKey(e => new { e.BatleId, e.HeroId });
            });
        }
    }
 
}
