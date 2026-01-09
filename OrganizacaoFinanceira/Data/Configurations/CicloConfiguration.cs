using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizacaoFinanceira.Domain.Entities;

namespace OrganizacaoFinanceira.Data.Configurations;

public class CicloConfiguration : IEntityTypeConfiguration<Ciclo>
{
    public void Configure(EntityTypeBuilder<Ciclo> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
               .HasColumnType("uniqueidentifier")
               .HasColumnName("Id")
               .IsRequired();

        builder.Property(x => x.UsuarioId)
               .HasColumnType("uniqueidentifier")
               .HasColumnName("UsuarioId")
               .IsRequired();

        builder.Property(e => e.DataInicio)
               .HasColumnName("DataInicio")
               .HasColumnType("datetime")
               .IsRequired();

        builder.Property(e => e.DataFim)
               .HasColumnName("DataFim")
               .HasColumnType("datetime")
               .IsRequired();

        builder.Property(e => e.SaldoInicial)
               .HasColumnName("SaldoInicial")
               .HasColumnType("decimal")
               .IsRequired();

        builder.Property(e => e.SaldoFinal)
               .HasColumnName("SaldoFinal")
               .HasColumnType("decimal")
               .IsRequired();

        builder.HasOne<Usuario>()
               .WithMany()
               .HasForeignKey(e => e.UsuarioId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}

