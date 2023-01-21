using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Identity;
using OlmServer.Persistance.Contexts;
using OlmServer.Persistance;


namespace OlmServer.WebApi.Configurations
{
    public class PersistanceServicesInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });


            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

            //automapper ekle
            services.AddAutoMapper(typeof(AssemblyReference).Assembly);

        }
    }
}
