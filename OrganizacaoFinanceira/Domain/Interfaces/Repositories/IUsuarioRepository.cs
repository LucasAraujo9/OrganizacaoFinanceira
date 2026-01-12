using OrganizacaoFinanceira.Domain.Entities;

namespace OrganizacaoFinanceira.Domain.Interfaces.Repositories;
public interface IUsuarioRepository
{
    Task<IEnumerable<Usuario>> BuscarTodosAsync();
    Task<Usuario> ObterPorIdAsync(Guid id);
    Task<Usuario> ObterUsuarioPorNomeAsync(string nome);
    Task AdicionarAsync(Usuario usuario);
    Task AtualizaAsync(Usuario usuario);
    Task DeletaAsync(Usuario usuario);
}
