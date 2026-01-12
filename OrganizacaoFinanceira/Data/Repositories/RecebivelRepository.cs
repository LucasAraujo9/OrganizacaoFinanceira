using Microsoft.EntityFrameworkCore;
using OrganizacaoFinanceira.Data.Context;
using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.Domain.Enums;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;

namespace OrganizacaoFinanceira.Data.Repositories;
public class RecebivelRepository : IRecebivelRepository
{
    private readonly AppDbContext _dbContext;

    public RecebivelRepository(AppDbContext appDbContext)
    {
        _dbContext = appDbContext;
    }

    public async Task<IEnumerable<Recebivel>> BuscarTodosAsync()
        => await _dbContext.Recebiveis.ToListAsync();

    public async Task<IEnumerable<Recebivel>> ObterPorCategoriaRecebivelAsync(Categoria.Recebivel categoriaRecebivel)
        => await _dbContext.Recebiveis.Where(x => x.CategoriaRecebivel == categoriaRecebivel).ToListAsync();

    public async Task<IEnumerable<Recebivel>> ObterPorDataRecebivelAsync(DateTime dataRecebivel)
        => await _dbContext.Recebiveis.Where(x => x.DataRecebivel == dataRecebivel).ToListAsync();

    public async Task AdicionarAsync(Recebivel recebivel)
    {
        _dbContext.Recebiveis.Add(recebivel);
        await _dbContext.SaveChangesAsync();
    }

    public async Task AtualizaAsync(Recebivel recebivel)
    {
        _dbContext.Recebiveis.Update(recebivel);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeletaAsync(Recebivel recebivel)
    {
        _dbContext.Recebiveis.Remove(recebivel);
        await _dbContext.SaveChangesAsync();
    }
}