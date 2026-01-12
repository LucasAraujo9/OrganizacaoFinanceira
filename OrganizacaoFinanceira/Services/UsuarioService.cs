using AutoMapper;
using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;
using OrganizacaoFinanceira.Domain.Interfaces.Services;
using OrganizacaoFinanceira.ViewModels;

namespace OrganizacaoFinanceira.Services;
public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
    {
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
    }

    public async Task AdicionaUsuario(UsuarioViewModel usuario)
    {
        if (this.ValidarUsuario(usuario))
            await _usuarioRepository.AdicionarAsync(_mapper.Map<Usuario>(usuario));
    }

    public async Task AtualizaUsuario(UsuarioViewModel viewModel)
    {
        if (!ValidarUsuario(viewModel))
            return;

        var usuario = await _usuarioRepository.ObterUsuarioPorNomeAsync(viewModel.Nome);

        if (usuario is null)
            return;

        _mapper.Map(viewModel, usuario);
        await _usuarioRepository.AtualizaAsync(usuario);
    }

    private bool ValidarUsuario(UsuarioViewModel usuario)
    {
        if (usuario == null ||
            string.IsNullOrWhiteSpace(usuario.Nome) ||
            string.IsNullOrWhiteSpace(usuario.Email) ||
            string.IsNullOrWhiteSpace(usuario.Senha))
            return false;

        return true;
    }
}
