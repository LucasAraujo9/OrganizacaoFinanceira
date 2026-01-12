using AutoMapper;
using OrganizacaoFinanceira.Domain.Entities;
using OrganizacaoFinanceira.ViewModels;

namespace OrganizacaoFinanceira.Data.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Ciclo, CicloViewModel>().ReverseMap();
        CreateMap<Gasto, GastoViewModel>().ReverseMap();
        CreateMap<Recebivel, RecebivelViewModel>().ReverseMap();
        CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
    }
}


