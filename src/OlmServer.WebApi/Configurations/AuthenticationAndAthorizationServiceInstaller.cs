using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using OlmServer.WebApi.OptionsSetup;
using System.Text;

namespace OlmServer.WebApi.Configurations
{
    public class AuthenticationAndAthorizationServiceInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions(typeof(JwtOptionsSetup));

            services.ConfigureOptions(typeof(JwtBearerOptionsSetup));
            
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer();

        }
    }
}
