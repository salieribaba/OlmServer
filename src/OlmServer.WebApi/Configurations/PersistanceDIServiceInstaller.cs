using OlmServer.Application.Services.AppServices;
using OlmServer.Application.Services.CompanyServices;
using OlmServer.Domain;
using OlmServer.Domain.UcafRepositories;
using OlmServer.Persistance;
using OlmServer.Persistance.Repositories;
using OlmServer.Persistance.Services.AppServices;
using OlmServer.Persistance.Services.CompanyServices;

namespace OlmServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            _ = services.AddScoped<ICompanyService, CompanyService>();
            _ = services.AddScoped<IUnitOfWork, UnitOfWork>();
            _ = services.AddScoped<IUcafCommandRepository, UcafRepositoryCommand>();
            _ = services.AddScoped<IUcafQueryRepository, UcafRepositoryQuery>();
            _ = services.AddScoped<IContextService, ContextService>();
            _ = services.AddScoped<IUcafService, UcafService>();
            services.AddScoped<IRoleService, RoleService>();

        }
    }
}
