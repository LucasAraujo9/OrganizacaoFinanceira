using OrganizacaoFinanceira.Domain.Enums;

namespace OrganizacaoFinanceira.Domain.Entities;

public class Gasto
{
    public Guid Id { get; set; }
    public Guid UsuarioId { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataGasto { get; set; }
    public Categoria.Gasto CategoriaGasto { get; set; }
    public string? Descricao { get; set; }
}