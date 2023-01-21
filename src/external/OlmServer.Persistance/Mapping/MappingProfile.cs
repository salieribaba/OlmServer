using AutoMapper;
using OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.CompanyEntities;

namespace OlmServer.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
             CreateMap<CompanyCreateRequest, Company>().ReverseMap();
             CreateMap<UcafCreateRequest, UniformChartOfAccount>().ReverseMap();
            
        }
    }

}
