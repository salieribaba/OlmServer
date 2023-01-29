using OlmServer.Application.Services.AppServices;
using OlmServer.Application.Services.CompanyServices;
using OlmServer.Domain;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.CompanyRepositories;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleAndRoleRLSRep;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleAndUserRelationshipRepositories;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleRepositories;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.UserAndCompanyRelationshipRepositories;
using OlmServer.Domain.Repositories.GenericRepositories.UcafRepositories;
using OlmServer.Domain.UnitOfWorks;
using OlmServer.Persistance;
using OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.CompanyRepositories;
using OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainRoleAndRoleRLSRep;
using OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainRoleAndUserRelationshipRepositories;
using OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainroleRepositories;
using OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.UserAndCompanyRelationshipRepositories;
using OlmServer.Persistance.Repositories.GenericRepositories.CompanyDbContexts.UcafRepositores;
using OlmServer.Persistance.Services.AppServices;
using OlmServer.Persistance.Services.CompanyServices;
using OlmServer.Persistance.UnitOfWorks;

namespace OlmServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            _ = services.AddScoped<ICompanyService, CompanyService>();
            _ = services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
            _ = services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            _ = services.AddScoped<IUcafCommandRepository, UcafRepositoryCommand>();
            _ = services.AddScoped<IUcafQueryRepository, UcafRepositoryQuery>();
            _ = services.AddScoped<IContextService, ContextService>();
            _ = services.AddScoped<IUcafService, UcafService>();
            _ = services.AddScoped<IRoleService, RoleService>();
            _ = services.AddScoped<IMainRoleService, MainRoleService>();
            _ = services.AddScoped<IMainRoleAndRoleRelationshipService, MainRoleAndRoleRelationshipService>();
            _ = services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
            _ = services.AddScoped<IUserAndCompanyRelationshipService, UserAndCompanyRelationshipService>();
            _ = services.AddScoped<IAuthService, AuthService>();

            _ = services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            _ = services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            _ = services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
            _ = services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
            _ = services.AddScoped<IMainRoleAndRoleRelationshipCommandRepository, MainRoleAndRoleRelationshipCommandRepository>();
            _ = services.AddScoped<IMainRoleAndRoleRelationshipQueryRepository, MainRoleAndRoleRelationshipQueryRepository>();
            _ = services.AddScoped<IMainRoleAndUserRelationshipCommandRepository, MainRoleAndUserRelationshipCommandRepository>();
            _ = services.AddScoped<IMainRoleAndUserRelationshipQueryRepository, MainRoleAndUserRelationshipQueryRepository>();
            _ = services.AddScoped<IUserAndCompanyRelationshipCommandRepository, UserAndCompanyRelationshipCommandRepository>();
            _ = services.AddScoped<IUserAndCompanyRelationshipQueryRepository, UserAndCompanyRelationshipQueryRepository>();



        }
    }
}
