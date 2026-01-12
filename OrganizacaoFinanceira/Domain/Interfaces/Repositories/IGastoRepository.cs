using Microsoft.EntityFrameworkCore;
using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.Domain.Enums;

namespace OrganizacaoFinanceira.Domain.Interfaces.Repositories;
public interface IGastoRepository
{
    Task<IEnumerable<Gasto>> BuscarTodosAsync();
    Task<IEnumerable<Gasto>> ObterPorCategoriaGastoAsync(Categoria.Gasto categoriaGasto);
    Task<IEnumerable<Gasto>> ObterPorDataGastoAsync(DateTime dataGasto);
    Task AdicionarAsync(Gasto gasto);
    Task AtualizaAsync(Gasto gasto);
    Task DeletaAsync(Gasto gasto);
}