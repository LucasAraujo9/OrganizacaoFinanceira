using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizacaoFinanceira.Domain.Entities;

namespace OrganizacaoFinanceira.Data.Configurations;

public class GastoConfiguration : IEntityTypeConfiguration<Gasto>
{
    public void Configure(EntityTypeBuilder<Gasto> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
               .HasColumnName("Id")
               .HasColumnType("uniqueidentifier")
               .IsRequired();

        builder.Property(x => x.UsuarioId)
               .HasColumnName("UsuarioId")
               .HasColumnType("uniqueidentifier")
               .IsRequired();

        builder.Property(x => x.Valor)
               .HasColumnName("valor")
               .HasColumnType("decimal")
               .IsRequired();

        builder.Property(e => e.DataGasto)
               .HasColumnName("DataGasto")
               .HasColumnType("datetime")
               .IsRequired();

        builder.Property(e => e.CategoriaGasto)
               .HasColumnName("CategoriaGasto")
               .HasColumnType("byte")
               .IsRequired();

        builder.Property(x => x.Descricao)
               .HasColumnName("Descricao")
               .HasColumnType("varchar");
    }
}
