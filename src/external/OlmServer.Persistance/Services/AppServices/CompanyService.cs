using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.CompanyRepositories;
using OlmServer.Domain.UnitOfWorks;
using OlmServer.Persistance.Contexts;
using OlmServer.Persistance.UnitOfWorks;

namespace OlmServer.Persistance.Services.AppServices
{
    public sealed class CompanyService : ICompanyService
    {

        private readonly ICompanyCommandRepository _companyCommandRepository;
        private readonly ICompanyQueryRepository _companyQueryRepository;
        private readonly IAppUnitOfWork _context;
        private readonly IMapper _mapper;
        public CompanyService(IMapper mapper, ICompanyCommandRepository companyCommandRepository = null, ICompanyQueryRepository companyQueryRepository = null, IAppUnitOfWork context = null)
        {
            _mapper = mapper;
            _companyCommandRepository = companyCommandRepository;
            _companyQueryRepository = companyQueryRepository;
            _context = context;
        }

        public async Task CreateCompany(CompanyCommandCreate request, CancellationToken cancellationToken)
        {
            Company company = _mapper.Map<Company>(request);
            company.Id = Guid.NewGuid().ToString();
            await _companyCommandRepository.AddAsync(company, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<Company> GetAllCompanies()
        {
            return _companyQueryRepository.GetAll();
        }

        public async Task<Company?> GetCompanyByName(string name, CancellationToken cancellationToken = default)
        {
            return await _companyQueryRepository.GetAllWhere(x => x.Name == name).FirstOrDefaultAsync();
        }

        public async Task MigrateCompanyDatabase()
        {
            var companies = await _companyQueryRepository.GetAll().ToListAsync();
            foreach (var company in companies)
            {
                var db = new CompanyDbContext(company);
                db.Database.Migrate();
            }
        }

    }
}
