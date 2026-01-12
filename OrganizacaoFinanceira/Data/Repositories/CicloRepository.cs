using Microsoft.EntityFrameworkCore;
using OrganizacaoFinanceira.Data.Context;
using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;

namespace OrganizacaoFinanceira.Data.Repositories;
public class CicloRepository : ICicloRepository
{
    private readonly AppDbContext _dbContext;

    public CicloRepository(AppDbContext appDbContext)
    {
        _dbContext = appDbContext;
    }

    public async Task<IEnumerable<Ciclo>> BuscarTodosAsync()
        => await _dbContext.Ciclos.ToListAsync();

    public async Task AdicionarAsync(Ciclo ciclo)
    {
        _dbContext.Ciclos.Add(ciclo);
        await _dbContext.SaveChangesAsync();
    }

    public async Task AtualizaAsync(Ciclo ciclo)
    {
        _dbContext.Ciclos.Update(ciclo);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeletaAsync(Ciclo ciclo)
    {
        _dbContext.Ciclos.Remove(ciclo);
        await _dbContext.SaveChangesAsync();
    }
}
