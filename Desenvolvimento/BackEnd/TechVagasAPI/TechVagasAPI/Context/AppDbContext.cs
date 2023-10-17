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
            //Cargo
            modelBuilder.Entity<CargoModel>().HasKey(c => c.CargoId);
            modelBuilder.Entity<CargoModel>().Property(c => c.Descricao).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<CargoModel>().Property(c => c.Tipo).HasMaxLength(50).IsRequired();

            //Pessoa
            modelBuilder.Entity<PessoaModel>().HasKey(p => p.PessoaId);
            modelBuilder.Entity<PessoaModel>().Property(p => p.Nome).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<PessoaModel>().Property(p => p.Idade);
            modelBuilder.Entity<PessoaModel>().Property(p => p.Rg).HasMaxLength(8).IsRequired();
            modelBuilder.Entity<PessoaModel>().Property(p => p.Cpf).HasMaxLength(12).IsRequired();
			modelBuilder.Entity<PessoaModel>().Property(p => p.Cidade).HasMaxLength(25).IsRequired();
			modelBuilder.Entity<PessoaModel>().Property(p => p.Cep).HasMaxLength(9).IsRequired();
			modelBuilder.Entity<PessoaModel>().Property(p => p.Genero).HasMaxLength(20);
            modelBuilder.Entity<PessoaModel>().Property(p => p.Bairro).HasMaxLength(25);
			modelBuilder.Entity<PessoaModel>().Property(p => p.Email).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<PessoaModel>().Property(p => p.Telefone).HasMaxLength(15);
            modelBuilder.Entity<PessoaModel>().Property(p => p.DataNascimento);
			modelBuilder.Entity<PessoaModel>().Property(p => p.NivelEscolaridade).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<PessoaModel>().Property(p => p.Endereco).HasMaxLength(35);

            //Concedente
            modelBuilder.Entity<ConcedenteModel>().HasKey(c => c.ConcedenteId);
            modelBuilder.Entity<ConcedenteModel>().Property(c => c.ResponsavelEmpresa).HasMaxLength(100).IsRequired();
		}

	}
}
