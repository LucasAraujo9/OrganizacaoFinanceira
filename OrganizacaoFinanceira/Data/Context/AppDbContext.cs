
using Microsoft.EntityFrameworkCore;
using OrganizacaoFinanceira.Data.Configurations;
using OrganizacaoFinanceira.Domain.Entities;

namespace OrganizacaoFinanceira.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) { }

        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Recebivel> Recebiveis { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CicloConfiguration());
            modelBuilder.ApplyConfiguration(new GastoConfiguration());
            modelBuilder.ApplyConfiguration(new RecebivelConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
