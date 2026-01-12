using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.Domain.Enums;

namespace OrganizacaoFinanceira.Domain.Interfaces.Repositories;
public interface IRecebivelRepository
{
    Task<IEnumerable<Recebivel>> BuscarTodosAsync();
    Task<IEnumerable<Recebivel>> ObterPorCategoriaRecebivelAsync(Categoria.Recebivel categoriaRecebivel);
    Task<IEnumerable<Recebivel>> ObterPorDataRecebivelAsync(DateTime dataRecebivel);
    Task AdicionarAsync(Recebivel recebivel);
    Task AtualizaAsync(Recebivel recebivel);
    Task DeletaAsync(Recebivel recebivel);
}