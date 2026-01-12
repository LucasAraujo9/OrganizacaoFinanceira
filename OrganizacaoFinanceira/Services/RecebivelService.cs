using AutoMapper;
using OrganizacaoFinanceira.Domain.Interfaces.Repositories;
using OrganizacaoFinanceira.Domain.Interfaces.Services;

namespace OrganizacaoFinanceira.Services;
public class RecebivelService : IRecebivelService
{
    private readonly IRecebivelRepository _recebivelRepository;
    private readonly IMapper _mapper;

    public RecebivelService(IRecebivelRepository recebivelRepository, IMapper mapper)
    {
        _recebivelRepository = recebivelRepository;
        _mapper = mapper;
    }
}