using AutoMapper;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;
using OrganizacaoFinanceira.Domain.Interfaces.Services;

namespace OrganizacaoFinanceira.Services;
public class CicloService : ICicloService
{
    private readonly ICicloRepository _cicloRepository;
    private readonly IMapper _mapper;

    public CicloService(ICicloRepository cicloRepository, IMapper mapper)
    {
        _cicloRepository = cicloRepository;
        _mapper = mapper;
    }
}
