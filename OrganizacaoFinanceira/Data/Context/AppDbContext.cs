
using Microsoft.EntityFrameworkCore;
using OrganizacaoFinanceira.Data.Configurations;
using OrganizacaoFinanceira.Domain.Entities;

namespace OrganizacaoFinanceira.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Recebivel> Recebiveis { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Ciclo> Ciclos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new CicloConfiguration());
            //modelBuilder.ApplyConfiguration(new RecebivelConfiguration());
            //modelBuilder.ApplyConfiguration(new GastoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
