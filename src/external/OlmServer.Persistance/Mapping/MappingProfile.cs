using AutoMapper;
using OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.AppEntities.Identity;
using OlmServer.Domain.CompanyEntities;

namespace OlmServer.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
             CreateMap<CompanyCreateRequest, Company>();
             CreateMap<UcafCreateRequest, UniformChartOfAccount>();
            CreateMap<CreateRoleRequest, AppRole>();

        }
    }

}
