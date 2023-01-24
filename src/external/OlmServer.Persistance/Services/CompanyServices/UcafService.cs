using AutoMapper;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;
using OlmServer.Application.Services.CompanyServices;
using OlmServer.Domain;
using OlmServer.Domain.CompanyEntities;
using OlmServer.Domain.UcafRepositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Services.CompanyServices
{
    public class UcafService : IUcafService
    {
        private readonly IUcafCommandRepository _commandRepository;
        private readonly IContextService _contextService;
        private readonly IUcafQueryRepository _queryRepository;
        private CompanyDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public UcafService(IUcafCommandRepository commandRepository, IContextService contextService = null, IUnitOfWork unitOfWork = null, IMapper mapper = null, IUcafQueryRepository queryRepository = null)
        {
            _commandRepository = commandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _queryRepository = queryRepository;
        }

        public async Task CreateUcafAsync(UcafCreateCommand request, CancellationToken cancellationToken)
        {

            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            UniformChartOfAccount uniformChartOfAccount =
            _mapper.Map<UniformChartOfAccount>(request);

            uniformChartOfAccount.Id = Guid.NewGuid().ToString();
            await _commandRepository.AddAsync(uniformChartOfAccount, cancellationToken);
            _ = await _unitOfWork.SaveChangesAsync(cancellationToken);







        }

        public async Task<UniformChartOfAccount> GetByCode(string code)
        {
            return await _queryRepository.GetByExpressionAsync(x => x.Code == code);
        }
    }
}
