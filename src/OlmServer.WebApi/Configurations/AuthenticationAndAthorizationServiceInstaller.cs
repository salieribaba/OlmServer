using Microsoft.AspNetCore.Authentication.JwtBearer;
using OlmServer.WebApi.OptionsSetup;

namespace OlmServer.WebApi.Configurations
{
    public class AuthenticationAndAthorizationServiceInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            _ = services.ConfigureOptions(typeof(JwtOptionsSetup));

            _ = services.ConfigureOptions(typeof(JwtBearerOptionsSetup));

            _ = services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer();
            _ = services.AddAuthorization();

        }
    }
}
