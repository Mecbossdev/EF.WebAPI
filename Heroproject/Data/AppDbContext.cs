using Heroproject.Models;
using Microsoft.EntityFrameworkCore;

namespace Heroproject.Data
{
    public class DevEventsDbContext : DbContext
    {
        public DbSet<Heroi>? Herois { get; set; }
        public DbSet<Arma>? Armas { get; set; }
        public DbSet<Batalha>? Batalhas { get; set; }

        public DbSet<BatalhasHeroi>? BatalhasHerois { get; set; }

        public DbSet<Identidade>? Identidades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9CPHD7F\\SQLSERVER2022;Initial Catalog=HeroDB;Integrated Security=True");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BatalhasHeroi>(entity =>
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }


    }
}
