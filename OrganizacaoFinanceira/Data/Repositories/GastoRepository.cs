using Microsoft.EntityFrameworkCore;
using OrganizacaoFinanceira.Data.Context;
using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.Domain.Enums;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;

namespace OrganizacaoFinanceira.Data.Repositories;
public class GastoRepository : IGastoRepository
{
    private readonly AppDbContext _dbContext;

    public GastoRepository(AppDbContext appDbContext)
    {
        _dbContext = appDbContext;
    }

    public async Task<IEnumerable<Gasto>> BuscarTodosAsync()
        => await _dbContext.Gastos.ToListAsync();

    public async Task<IEnumerable<Gasto>> ObterPorCategoriaGastoAsync(Categoria.Gasto categoriaGasto)
        => await _dbContext.Gastos.Where(x => x.CategoriaGasto == categoriaGasto).ToListAsync();

    public async Task<IEnumerable<Gasto>> ObterPorDataGastoAsync(DateTime dataGasto)
        => await _dbContext.Gastos.Where(x => x.DataGasto == dataGasto).ToListAsync();

    public async Task AdicionarAsync(Gasto gasto)
    {
        _dbContext.Gastos.Add(gasto);
        await _dbContext.SaveChangesAsync();
    }

    public async Task AtualizaAsync(Gasto gasto)
    {
        _dbContext.Gastos.Update(gasto);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeletaAsync(Gasto gasto)
    {
        _dbContext.Gastos.Remove(gasto);
        await _dbContext.SaveChangesAsync();
    }
}
