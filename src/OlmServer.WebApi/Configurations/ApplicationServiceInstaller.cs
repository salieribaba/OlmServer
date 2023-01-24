using FluentValidation;
using MediatR;
using OlmServer.Application;
using OlmServer.Application.Behavior;

namespace OlmServer.WebApi.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(AssemblyReference).Assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), (typeof(ValidationBehavior<,>)));

            services.AddValidatorsFromAssembly(typeof(AssemblyReference).Assembly);
        }

    }
}
