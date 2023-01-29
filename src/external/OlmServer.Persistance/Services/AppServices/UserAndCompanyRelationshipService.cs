using Microsoft.EntityFrameworkCore;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.UserAndCompanyRelationshipRepositories;
using OlmServer.Domain.UnitOfWorks;

namespace OlmServer.Persistance.Services.AppServices
{
    public class UserAndCompanyRelationshipService : IUserAndCompanyRelationshipService
    {
        private readonly IUserAndCompanyRelationshipCommandRepository _commandRepository;
        private readonly IUserAndCompanyRelationshipQueryRepository _queryRepository;
        private readonly IAppUnitOfWork _unitOfWork;

        public UserAndCompanyRelationshipService(IAppUnitOfWork unitOfWork, IUserAndCompanyRelationshipQueryRepository queryRepository = null, IUserAndCompanyRelationshipCommandRepository commandRepository = null)
        {
            _unitOfWork = unitOfWork;
            _queryRepository = queryRepository;
            _commandRepository = commandRepository;
        }

        public async Task CreateAsync(AppUsersCompany userAndCompanyRelationship, CancellationToken cancellationToken)
        {
            await _commandRepository.AddAsync(userAndCompanyRelationship, cancellationToken);
            _ = await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<AppUsersCompany> GetByIdAsync(string id)
        {
            return await _queryRepository.GetByIdAsync(id);
        }

        public async Task<AppUsersCompany> GetByUserIdAndCompanyId(string userId, string companyId, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetByExpressionAsync(p => p.AppUserId == userId && p.CompanyId == companyId, cancellationToken);
        }

        public async Task<IList<AppUsersCompany>> GetListByUserId(string userId)
        {
            return await _queryRepository.GetAllWhere(p => p.AppUserId == userId).Include("Company").ToListAsync();
        }

        public async Task RemoveByIdAsync(string id)
        {
            await _commandRepository.DeleteByIdAsync(id);
            _ = await _unitOfWork.SaveChangesAsync();
        }
    }
}
