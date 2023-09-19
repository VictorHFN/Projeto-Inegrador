using Microsoft.EntityFrameworkCore;
using TechVagasAPI.Models;

namespace TechVagasAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<CargoModel>? Cargos { get; set; }
    }
}
