using OrganizacaoFinanceira.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OrganizacaoFinanceira.Domain.Entities;

public class Recebivel
{
    public Guid Id { get; set; }
    public Guid UsuarioId { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataRecebivel { get; set; }
    public Categoria.Recebivel CategoriaRecebivel { get; set; }
    public string? Descricao { get; set; }
}
