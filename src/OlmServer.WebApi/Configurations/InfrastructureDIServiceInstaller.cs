using OlmServer.Application.Abstractions;
using OlmServer.Infrastructure.Authentication;

namespace OlmServer.WebApi.Configurations
{
    public class InfrastructureDIServiceInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
        }
    }
}
