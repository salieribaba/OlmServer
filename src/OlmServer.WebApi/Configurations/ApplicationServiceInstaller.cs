using MediatR;
using OlmServer.Application;

namespace OlmServer.WebApi.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            //mediatr kütüphanesini ekle
            services.AddMediatR(typeof(AssemblyReference).Assembly);
           


        }
    }
}
