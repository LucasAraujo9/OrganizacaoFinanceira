namespace OrganizacaoFinanceira.Domain.Entities;
public class Ciclo
{
    public Guid Id { get; set; }
    public Guid UsuarioId { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public decimal SaldoInicial { get; set; }
    public decimal SaldoFinal { get; set; }
}