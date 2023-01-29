using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleAndUserRelationshipRepositories;
using OlmServer.Domain.UnitOfWorks;

namespace OlmServer.Persistance.Services.AppServices
{
    public class MainRoleAndUserRelationshipService : IMainRoleAndUserRelationshipService
    {
        private readonly IMainRoleAndUserRelationshipCommandRepository _commandRepository;
        private readonly IMainRoleAndUserRelationshipQueryRepository _queryRepository;
        private readonly IAppUnitOfWork _unitOfWork;

        public MainRoleAndUserRelationshipService(IMainRoleAndUserRelationshipCommandRepository commandRepository, IMainRoleAndUserRelationshipQueryRepository queryRepository, IAppUnitOfWork unitOfWork)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(MainRoleAndUserRelationShip mainRoleAndUserRelationship, CancellationToken cancellationToken)
        {
            await _commandRepository.AddAsync(mainRoleAndUserRelationship, cancellationToken);
            _ = await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<MainRoleAndUserRelationShip> GetByIdAsync(string id, bool tracking)
        {
            MainRoleAndUserRelationShip entity = await _queryRepository.GetByIdAsync(id, tracking);
            return entity;
        }

        public async Task<MainRoleAndUserRelationShip> GetByUserIdCompanyIdAndMainRoleIdAsync(string userId, string companyId, string mainRoleId, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetByExpressionAsync(p => p.UserId == userId && p.CompanyId == companyId && p.MainRoleId == mainRoleId, cancellationToken);
        }

        public async Task<MainRoleAndUserRelationShip> GetRolesByUserIdAndCompanyId(string userId, string companyId)
        {
            return await _queryRepository.GetByExpressionAsync(p => p.UserId == userId && p.CompanyId == companyId, default);
        }

        public async Task RemoveByIdAsync(string id)
        {
            await _commandRepository.DeleteByIdAsync(id);
            _ = await _unitOfWork.SaveChangesAsync();
        }
    }

}
