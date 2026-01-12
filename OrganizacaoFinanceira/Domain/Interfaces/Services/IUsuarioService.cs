using OrganizacaoFinanceira.ViewModels;

namespace OrganizacaoFinanceira.Domain.Interfaces.Services;
public interface IUsuarioService
{
    Task AdicionaUsuario(UsuarioViewModel usuario);
}
