using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.Companyfeatures.Queries.GetAllCompany
{
    public record GetAllCompanyResponse(
    List<Company> Companies);

}
