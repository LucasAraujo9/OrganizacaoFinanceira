using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizacaoFinanceira.Domain.Entities;

namespace OrganizacaoFinanceira.Data.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure (EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
               .HasColumnType("uniqueidentifier")
               .HasColumnName("Id")
               .IsRequired();

        builder.Property(x => x.Nome)
               .HasColumnType("varchar")
               .HasColumnName("Name")
               .IsRequired();

        builder.Property(x => x.Email)
               .HasColumnType("varchar")
               .HasColumnName("Email")
               .IsRequired();

        builder.Property(x => x.Senha)
               .HasColumnType("varchar")
               .HasColumnName("Senha")
               .IsRequired();

        builder.Property(e => e.DataNascimento)
               .HasColumnName("DataNascimento")
               .HasColumnType("datetime")
               .IsRequired();

        builder.Property(e => e.DataCadastro)
               .HasColumnName("DataCadastro")
               .HasColumnType("datetime")
               .IsRequired();
    }
}
