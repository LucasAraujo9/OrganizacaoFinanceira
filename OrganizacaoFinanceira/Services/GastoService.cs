using AutoMapper;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;
using OrganizacaoFinanceira.Domain.Interfaces.Services;

namespace OrganizacaoFinanceira.Services;
public class GastoService : IGastoService
{
    private readonly IGastoRepository _gastoRepository;
    private readonly IMapper _mapper;

    public GastoService(IGastoRepository gastoRepository, IMapper mapper)
    {
        _gastoRepository = gastoRepository;
        _mapper = mapper;
    }
}
