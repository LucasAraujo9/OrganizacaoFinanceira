using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizacaoFinanceira.Domain.Entities;

namespace OrganizacaoFinanceira.Data.Configurations;

public class RecebivelConfiguration : IEntityTypeConfiguration<Recebivel>
{
    public void Configure(EntityTypeBuilder<Recebivel> builder)
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

        builder.Property(e => e.DataRecebivel)
               .HasColumnName("DataRecebivel")
               .HasColumnType("datetime")
               .IsRequired();

        builder.Property(e => e.CategoriaRecebivel)
               .HasColumnName("CategoriaRecebivel")
               .HasColumnType("byte")
               .IsRequired();

        builder.Property(x => x.Descricao)
               .HasColumnName("Descricao")
               .HasColumnType("varchar");
    }
}
