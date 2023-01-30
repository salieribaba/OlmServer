using Microsoft.EntityFrameworkCore;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleAndRoleRLSRep;
using OlmServer.Domain.UnitOfWorks;

namespace OlmServer.Persistance.Services.AppServices
{
    public class MainRoleAndRoleRelationshipService : IMainRoleAndRoleRelationshipService
    {
        private readonly IMainRoleAndRoleRelationshipCommandRepository _commandRepository;
        private readonly IMainRoleAndRoleRelationshipQueryRepository _queryRepository;
        private readonly IAppUnitOfWork _unitOfWork;
        public MainRoleAndRoleRelationshipService(IMainRoleAndRoleRelationshipCommandRepository commandRepository, IMainRoleAndRoleRelationshipQueryRepository queryRepository = null, IAppUnitOfWork unitOfWork = null)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _unitOfWork = unitOfWork;
        }


        public async Task CreateAsync(MainRoleAndRoleRelationShip mainRoleAndRoleRelationship, CancellationToken cancellationToken)
        {
            await _commandRepository.AddAsync(mainRoleAndRoleRelationship, cancellationToken);
            _ = await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<MainRoleAndRoleRelationShip> GetAll()
        {
            return _queryRepository.GetAll();

        }

        public async Task<MainRoleAndRoleRelationShip> GetByIdAsync(string id)
        {
            return await _queryRepository.GetByIdAsync(id);
        }

        public async Task<MainRoleAndRoleRelationShip> GetByRoleIdAndMainRoleId(string roleId, string mainRoleId, CancellationToken cancellationToken = default)
        {
            return await _queryRepository.GetByExpressionAsync(p => p.RoleId == roleId && p.MainRoleId == mainRoleId, cancellationToken);
        }

        public async Task<IList<MainRoleAndRoleRelationShip>> GetListByMainRoleIdForGetRolesAsync(string id)
        {
            return await _queryRepository.GetAllWhere(p => p.MainRoleId == id).Include("AppRole").ToListAsync();
        }

        public async Task RemoveByIdAsync(string id)
        {
            await _commandRepository.DeleteByIdAsync(id);
            _ = await _unitOfWork.SaveChangesAsync();

        }

        public async Task UpdateAsync(MainRoleAndRoleRelationShip mainRoleAndRoleRelationship)
        {
            _commandRepository.Update(mainRoleAndRoleRelationship);
            _ = await _unitOfWork.SaveChangesAsync();
        }
    }

}