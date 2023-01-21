using MediatR;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate
{
    public sealed class CompanyCreateHandler : IRequestHandler<CompanyCreateRequest, CompanyCreateResponse>
    {
        private readonly ICompanyService _companyService;

        public CompanyCreateHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CompanyCreateResponse> Handle(CompanyCreateRequest request, CancellationToken cancellationToken)
        {
            Company company = await _companyService.GetCompanyByName(request.Name);
            if (company != null)
            {
                throw new Exception("Bu şirket adı daha önce kullanılmıştır. Lütfen değiştirip yeniden deneyiniz.");
            }
            await _companyService.CreateCompany(request);

            return new();
        }
    }
}
