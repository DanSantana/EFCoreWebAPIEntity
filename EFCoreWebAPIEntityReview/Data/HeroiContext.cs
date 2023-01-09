using EFCoreWebAPIEntityReview.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWebAPIEntityReview.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=addpasswordhere;Persist Security Info=True;TrustServerCertificate=Yes; User ID=dan;Initial Catalog=dbHeroi;Data Source=addsourcehehre");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => { 
            entity.HasKey(e=> new { e.BatalhaId, e.HeroiId});            
            });
        }
    }
}
