﻿using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleRepositories;
using OlmServer.Domain.UnitOfWorks;

namespace OlmServer.Persistance.Services.AppServices
{
    public class MainRoleService : IMainRoleService
    {

        private readonly IMainRoleCommandRepository _mainRoleCommandRepository;
        private readonly IMainRoleQueryRepository _mainRoleQueryRepository;
        private readonly IAppUnitOfWork _unitOfWork;

        public MainRoleService(IMainRoleCommandRepository mainRoleCommandRepository, IMainRoleQueryRepository mainRoleQueryRepository = null, IAppUnitOfWork unitOfWork = null)
        {
            _mainRoleCommandRepository = mainRoleCommandRepository;
            _mainRoleQueryRepository = mainRoleQueryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
        {
            await _mainRoleCommandRepository.AddAsync(mainRole, cancellationToken);
            _ = await _unitOfWork.SaveChangesAsync();
        }

        public async Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken cancellationToken)
        {
            await _mainRoleCommandRepository.AddRangeAsync(newMainRoles, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

        }

        public IQueryable<MainRole> GetAll(CancellationToken cancellationToken)
        {
            return _mainRoleQueryRepository.GetAll();
        }

        public async Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken)
        {
            //if (companyId == null) return await _mainRoleQueryRepository.GetByExpressionAsync(p => p.Title == title, cancellationToken, false);
            return await _mainRoleQueryRepository.GetByExpressionAsync(p => p.Title == title && p.CompanyId == companyId, cancellationToken, false);
        }


    }
}