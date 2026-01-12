using OrganizacaoFinanceira.Domain.Entities;

namespace OrganizacaoFinanceira.Domain.Interfaces.Repositories;
public interface ICicloRepository
{
    Task<IEnumerable<Ciclo>> BuscarTodosAsync();
    Task AdicionarAsync(Ciclo ciclo);
    Task AtualizaAsync(Ciclo ciclo);
    Task DeletaAsync(Ciclo ciclo);
}
