using Microsoft.EntityFrameworkCore;
using TechVagasAPI.Models.Entities;

namespace TechVagasAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<CargoModel>? Cargos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CargoModel>().HasKey(c => c.CargoId);
            modelBuilder.Entity<CargoModel>().Property(c => c.Descricao).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<CargoModel>().Property(c => c.Tipo).HasMaxLength(50).IsRequired();
        }

	}
}
