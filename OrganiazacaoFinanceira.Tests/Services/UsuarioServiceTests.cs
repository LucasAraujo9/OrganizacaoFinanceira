using AutoMapper;
using Moq;
using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;
using OrganizacaoFinanceira.Domain.Interfaces.Services;
using OrganizacaoFinanceira.Services;
using OrganizacaoFinanceira.ViewModels;

namespace OrganiazacaoFinanceira.Tests.Services
{
    public class UsuarioServiceTests
    {
        [Fact(DisplayName = "Adicionar Usuario com Sucesso")]
        public async Task UsuarioService_Adicionar_DeveExecutarComSucesso()
        {
            //Arrage
            var usuarioRepo = new Mock<IUsuarioRepository>();
            var mapper = new Mock<IMapper>();
            var usuarioService = new UsuarioService(usuarioRepo.Object, mapper.Object);

            UsuarioViewModel viewModel = new UsuarioViewModel
            {
                Nome = "Lucas Araujo",
                Email = "lucas.souza@gmail.com",
                Senha = "SenhaTeste",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now
            };

            var usuario = new Usuario
            {
                Nome = viewModel.Nome,
                Email = viewModel.Email,
                Senha = viewModel.Senha,
                DataCadastro = viewModel.DataCadastro,
                DataNascimento = viewModel.DataNascimento
            };

            mapper.Setup(m => m.Map<Usuario>(viewModel)).Returns(usuario);

            // Act
            await usuarioService.AdicionaUsuario(viewModel);

            // Assert
            usuarioRepo.Verify(r => r.AdicionarAsync(usuario), Times.Once);
        }
    }
}
