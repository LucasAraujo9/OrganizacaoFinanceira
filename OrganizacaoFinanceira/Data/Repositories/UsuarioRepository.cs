using Microsoft.EntityFrameworkCore;
using OrganizacaoFinanceira.Data.Context;
using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;

namespace OrganizacaoFinanceira.Data.Repositories;
public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _dbContext;

    public UsuarioRepository(AppDbContext appDbContext)
    {
        _dbContext = appDbContext;
    }

    public async Task<IEnumerable<Usuario>> BuscarTodosAsync() 
        => await _dbContext.Usuarios.ToListAsync();

    public async Task<Usuario> ObterPorIdAsync(Guid id) 
        => await _dbContext.Usuarios.FindAsync(id);

    public async Task<Usuario> ObterUsuarioPorNomeAsync(string nome)
        => await _dbContext.Usuarios.FirstAsync(x => x.Nome == nome);

    public async Task AdicionarAsync(Usuario usuario)
    {
        _dbContext.Usuarios.Add(usuario);
        await _dbContext.SaveChangesAsync();
    }

    public async Task AtualizaAsync(Usuario usuario)
    {
        _dbContext.Usuarios.Update(usuario);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeletaAsync(Usuario usuario)
    {
        _dbContext.Usuarios.Remove(usuario);
        await _dbContext.SaveChangesAsync();
    }
}
