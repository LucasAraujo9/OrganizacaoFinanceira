namespace OrganizacaoFinanceira.ViewModels;
public class CicloViewModel
{
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    public decimal SaldoInicial { get; set; }
    public decimal SaldoFinal { get; set; }
}