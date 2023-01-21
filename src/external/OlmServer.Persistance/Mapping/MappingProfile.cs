using AutoMapper;
using OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
             CreateMap<CompanyCreateRequest, Company>().ReverseMap();
        }
    }

}
